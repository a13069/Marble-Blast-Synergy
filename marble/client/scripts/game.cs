//-----------------------------------------------------------------------------
// Torque Game Engine
// 
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//----------------------------------------------------------------------------
// Game start / end events sent from the server
//----------------------------------------------------------------------------

function clientCmdGameStart()
{
}

function getBestTimes(%mis, %deftime)
{
   for(%i = 0; %i < 5; %i++)
   {
      $hs[%i] = $pref::highScores[%mis, %i];
      if($hs[%i] $= "")
      {
         if(%deftime !$= "0")
            $hs[%i] = %deftime @ "\tNardo Polo";
         else
            $hs[%i] = "5998999\tNardo Polo";
      }
   }
}

function clientCmdGameEnd()
{
   if($playingDemo)
      return;

   getBestTimes($Server::MissionFile, MissionInfo.time);
   $highScoreIndex = "";
   for(%i = 0; %i < 5; %i++)
   {
      if($Game::ScoreTime < getField($hs[%i], 0))
      {
         for(%j = 4; %j > %i; %j--)
         {
            $hs[%j] = $hs[%j - 1];
         }
         $highScoreIndex = %i;
         $hs[%i] = $Game::ScoreTime @ "\t" @ $pref::highScoreName;
         break;
      }
   }
   reformatGameEndText();
   Canvas.pushDialog(EndGameGui);
   if($highScoreIndex !$= "")
   {
      if($highScoreIndex == 0)
         %msgIn = "";
      else if($highScoreIndex == 1)
         %msgIn = " 2nd";
      else if($highScoreIndex == 2)
         %msgIn = " 3rd";
      else if($highScoreIndex == 3)
         %msgIn = " 4th";
      else
         %msgIn = " 5th";
      EnterNameText.setText("<color:FFFFFF><just:center><font:Lucida Sans:24>Congratulations!\nYou got the" @ %msgIn @ " best time!<font:Arial:14>\n\n<font:Lucida Sans:24><just:left>Enter your name: ");
      Canvas.pushDialog(EnterNameDlg);
      EnterNameEdit.setSelectionRange(0, 100000);
   }
}

function highScoreNameAccept()
{
   Canvas.popDialog(EnterNameDlg);
   for(%i = 0; %i < 5; %i++)
      $pref::highScores[$Server::MissionFile, %i] = $hs[%i];
}

function highScoreNameChanged()
{
   $hs[$highScoreIndex] = $Game::ScoreTime @ "\t" @ $pref::highScoreName;
   reformatGameEndText();
}

function reformatGameEndText()
{
   // Final Score
   %text = 
      "<lmargin:57><font:Lucida Sans:36><color:ffffff>Final Time: " @
      formatTime($Game::ScoreTime) @ "\n<lmargin:0><font:Lucida Sans:24><color:ffffff><just:center>";

   // Qualification time
   if($Game::Qualified) {
      if(MissionInfo.AwesomeTime && $Game::ScoreTime < MissionInfo.AwesomeTime && MissionInfo.AwesomeTime < MissionInfo.goldTime) 
         %text = %text @ "You beat the <color:00ffff>Awesome Time<color:ffffff>!";
      else if(MissionInfo.goldTime && $Game::ScoreTime < MissionInfo.goldTime) 
         %text = %text @ "You beat the <color:ffff00>Gold Time<color:ffffff>!";
      else
         %text = %text @ "You\'ve qualified!"; //that "\'" is suppost to be in there
   } 
   else 
      %text = %text @ "You failed to qualify!";
   
   // Basic time info
   %text = %text @
      "\n<just:left><lmargin:57><font:Arial:14>\n<tab:270,280>";
   if (MissionInfo.time)
      %text = %text @
         "<color:ffffff>" @
         "<font:Lucida Sans:24>Qualify Time:\t" @
         ($Game::Qualified? "<color:ffffff>": "<color:ff0000>") @
         formatTime(MissionInfo.time) @ "\n";
   else
      %text = %text @ "<color:ffffff><font:Lucida Sans:24>Qualify Time:\t\t99:59.99\n";

   if(MissionInfo.goldTime)
   {
      %text = %text @ "<color:ffffff><font:Lucida Sans:24>Gold Time:\t<color:FFFF00><shadowcolor:0000007f>" @
         formatTime(MissionInfo.goldTime) @ "\n";
   }

   if(MissionInfo.AwesomeTime)
   {
      %text = %text @ "<color:ffffff><font:Lucida Sans:24>Awesome Time:\t<color:00ffff><shadowcolor:0000007f>" @
         formatTime(MissionInfo.AwesomeTime) @ "\n";
   }

   %text = %text @
      "<color:ffffff>" @
      "<font:Lucida Sans:24>Elapsed Time:\t" @ formatTime($Game::ElapsedTime)  @ "\n" @
      "<font:Lucida Sans:24>Bonus Time:\t" @ formatTime($Game::BonusTime) @ "\n";
   %text = %text @ "<font:Arial:14>\n<font:Lucida Sans:24><color:ffffff>Best Times:\n";
   for(%i = 0; %i < 5; %i++)
   {
      %time = getField($hs[%i], 0);
      %name = getField($hs[%i], 1);
      %text = %text 
         @ "<color:ffffff><font:Lucida Sans:24>" @ %i+1 @ ". " @ %name @ "\t" 
         @ (%time < MissionInfo.goldTime ? 
		       (%time < MissionInfo.AwesomeTime? "<color:00ffff>" : "<color:ffff00>")
			: "") @ formatTime(%time) @ "\n";
   }
   // Display the end-game screen
   EndGameGuiDescription.setText(%text);
}


//-----------------------------------------------------------------------------

function formatTime(%time)
{
   %isNeg = "\t";
   if (%time < 0)
   {
      %time = -%time;
      %isNeg = "-\t";
   }
   %hundredth = mFloor((%time % 1000) / 10);
   %totalSeconds = mFloor(%time / 1000);
   %seconds = %totalSeconds % 60;
   %minutes = (%totalSeconds - %seconds) / 60;

   %secondsOne   = %seconds % 10;
   %secondsTen   = (%seconds - %secondsOne) / 10;
   %minutesOne   = %minutes % 10;
   %minutesTen   = (%minutes - %minutesOne) / 10;
   %hundredthOne = %hundredth % 10; 
   %hundredthTen = (%hundredth - %hundredthOne) / 10;

   return %isNeg @ %minutesTen @ %minutesOne @ ":" @
       %secondsTen @ %secondsOne @ "." @
       %hundredthTen @ %hundredthOne;
}

function formatTimeNoTab(%time)
{
   %isNeg = "";
   if (%time < 0)
   {
      %time = -%time;
      %isNeg = "-";
   }
   %hundredth = mFloor((%time % 1000) / 10);
   %totalSeconds = mFloor(%time / 1000);
   %seconds = %totalSeconds % 60;
   %minutes = (%totalSeconds - %seconds) / 60;

   %secondsOne   = %seconds % 10;
   %secondsTen   = (%seconds - %secondsOne) / 10;
   %minutesOne   = %minutes % 10;
   %minutesTen   = (%minutes - %minutesOne) / 10;
   %hundredthOne = %hundredth % 10; 
   %hundredthTen = (%hundredth - %hundredthOne) / 10;

   return %isNeg @ %minutesTen @ %minutesOne @ ":" @
       %secondsTen @ %secondsOne @ "." @
       %hundredthTen @ %hundredthOne;
}
