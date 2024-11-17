$NumHelpPages = 7;

function HelpCreditsGui::onWake(%this)
{
   $CurHelpPage = 1;
   %this.setPage($CurHelpPage);
}

function HelpCreditsGui::setPage(%this, %page)
{
   switch(%page)
   {
      case 1:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>About Marble Blast" @ 
                 "<font:Lucida Sans:18><just:left>\n\n" @
                 "Roll your marble through a rich cartoon landscape of moving platforms and dangerous hazards.  Along the way find power ups to increase your speed, jumping ability or flight power, and use them to collect the hidden gems and race to the finish for the fastest time."
@ "\n\n" @
                 "Over the years, many Marble Blast players have made their own modification of the game. Some notable mods of the game are Platinum Quest, STOP DeluXe, Marble Blast Emerald, Gerson's Level Compilation etc.";
      case 2:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>About Marble Blast: Synergy" @
                 "<font:Lucida Sans:18><just:left>\n\n" @
                 "Marble Blast Synergy (referred to as \"this mod\" from now on) is a Marble Blast modification by a13069. This mod started in 2019, and was being developed on and off until eventually being forgotten by its author. The author rediscovered it in November 2024, and decided to release it."
                 @ "\n\n" @
                 "The main new feature in this mod is the addition of a new hazard (lava) and a new powerup (water) that counters it. Play the first few beginner levels to see how they work. There are other gameplay features in this mod, such as checkpoints, bouncy floors, powerup timer, etc., but they are common in other mods as well.";
      case 3:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>The Level Themes" @
                 "<font:Lucida Sans:18><just:left>\n\n" @

"This mod's aesthetic and level designs are inspired by jmtb02's \"Ball Revamped V: Synergy\" (hence the name). Each difficulty is divided into 10-level \"themes\", which correspond to 10-level \"realms\" in Ball Revamped V. Each theme has its own skybox, textures and soundtracks."@ "\n\n" @
"The correspondence is as follows: (This mod's theme - Ball Revamped V's realm)"@ "\n" @
"Tutorial: Level 1-10"@ "\n" @
"Beginner Theme 1: Level 11-20"@ "\n" @
"Beginner Theme 2: Level 41-50"@ "\n" @
"Beginner Theme 3: Level 61-70"@ "\n" @
"Intermediate Theme 1: Level 21-30"@ "\n" @
"Intermediate Theme 2: Level 51-60"@ "\n" @
"Intermediate Theme 3: Space-themed (There aren't enough realms in BRV's roadmap)"@ "\n" @
"Advanced Theme 1: Level 31-40"@ "\n" @
"Advanced Theme 2: Level 71-80"@ "\n" @
"Advanced Theme 3: Level 81-90"@ "\n" @
"Expert: Level 91-99 "@ "\n\n" @
"Themes are purely aesthetic and have no impact on gameplay. However, the levels in the same theme may share some common gameplay elements. There's also a \"Custom\" difficulty, which contains levels the author didn't like enough to put into the main game.";


      case 4:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>Status of This Mod" @
                 "<font:Lucida Sans:18><just:left>\n\n" @
                 "This mod is currently released in an unfinished state - However, with 30+ levels (nearly 50 if you count scrapped ones) and all its planned gameplay features implemented, the author believes it is able to stand on its own, even in its current unfinished state."
                 @ "\n\n" @



"With that being said, there are still significant gaps in this mod:" @ "\n" @
"- Every Marble Blast Gold UI you see in this mod are meant to be replaced with this mod's UI. The MBG UI are there because the author haven't made the UI for them yet." @ "\n" @
"- Most levels in this mod are unnamed and without a description." @ "\n" @
"- Some levels may lack indicators (the \"where to go\" signs) and help texts." @ "\n" @
"- The intermediate levels are unstable right now. Some intermediate levels may be changed, reordered, or be delegeted to a later theme in the future." @ "\n" @
"- There aren't any advanced or expert level being made yet. The author planned to make the level in the order of difficulty, so there won't be any of them in quite some time." @ "\n\n" @

"The author wishes to continue working on this mod, but there isn't a set schedule for it.";

      case 5:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>How You Can Help" @
                 "<font:Lucida Sans:18><just:left>\n\n" @
"If you don't have anything specific in mind, just play this mod and give feedbacks/suggestions/bug reports/constructive criticisms to the author (a13069 on Discord/marbleblast.com)! They will be appreciated."
                 @ "\n" @
"Here are some ways you can help specifically:"
                 @ "\n" @
"- Come up with the exsiting levels' names and their descriptions."
                 @ "\n" @
"- Determine each level's gold time and awesome time."
                 @ "\n" @
"- Write/Review awesome hints for the levels."
                 @ "\n" @
"- Make/Donate some levels/textures/sounds for this mod! However, keep in mind that the author might modify them if he sees fit."
;
      case 6:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>Special Thanks" @
                 "<font:Lucida Sans:18><just:left>\n\n" @
                 "Although I worked on this mod on my own, this mod wouldn't be possible without other people's work. This includes HiGuy's Mod_TMTimer, whirligig's remade powerups, but I also want to thank everyone who has asked questions in the Marble Blast forum, I consulted the threads a lot when writing codes for this mod."
                 @ "\n\n" @
                 "I'd also like to thank everyone who has made their own mods, especially Jiquor (for Marble Blast STOP), NaCl586 (for Gerson's Level Compilation) and EvilTaco (for Evil's Mini Mod) for making me realize it's possible to make a full mod as a single person. Even though this mod isn't finished (yet), I wouldn't have started it at all without your precedents. Also thanks to jmtb02 for making Ball Revamped V: Synergy, which serves as the inspiration for this mod. Many assets of this mod are modified from the game as well."
                 @ "\n\n" @
                 "Lastly, I'd like to thank the original Marble Blast Gold team for making Marble Blast Gold, and the Marble Blast team for maintaining and updating the game. Marble Blast is truly a wonderful game that I have been coming back to for years and finally decided to make a mod of.";
      case 7:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>Soundtracks Used" @
                 "<font:Lucida Sans:18><just:left>\n\n" @
      
"<lmargin:0>Shell Music & Custom Levels:\n" @ "<lmargin:35> \"Rig - Celtic Warloads preview\" - Rig: https://www.newgrounds.com/audio/listen/94774"@ "\n" @
"<lmargin:0>Beginner Theme 1:\n" @ "<lmargin:35> \"Moving Pieces\" - Montron: https://www.newgrounds.com/audio/listen/1106610"@ "\n" @
"<lmargin:0>Beginner Theme 2:\n" @ "<lmargin:35> \"Purple Skies\" - Qshunt: https://www.newgrounds.com/audio/listen/941702"@ "\n" @
"<lmargin:0>Beginner Theme 3:\n" @ "<lmargin:35> \"Custom Shader\" - AliceMako: https://www.newgrounds.com/audio/listen/955260"@ "\n" @
"<lmargin:0>Intermediate Theme 1:\n" @ "<lmargin:35> \"PUZZLE GAME 3\" - Eric Matyas: https://soundimage.org/wp-content/uploads/2016/03/Puzzle-Game-3_Looping.mp3"@ "\n" @
"<lmargin:0>Intermediate Theme 2:\n" @ "<lmargin:35> \"Loading\" - CorruptedFrame: https://www.newgrounds.com/audio/listen/1137802"@ "\n" @
"<lmargin:0>Intermediate Theme 3:\n" @ "<lmargin:35> \"Resilience\" - Zoonotist: https://www.newgrounds.com/audio/listen/1004454"@ "\n" @
"<lmargin:0>Advanced Theme 1:\n" @ "<lmargin:35> \"-Temptation-\" - Sabodis: https://www.newgrounds.com/audio/listen/59043"@ "\n" @
"<lmargin:0>Advanced Theme 2:\n" @ "<lmargin:35> \"Journey to the Third Sun\" - Dem0n1x: https://www.newgrounds.com/audio/listen/1177385"@ "\n" @
"<lmargin:0>Advanced Theme 3:\n" @ "<lmargin:35> \"Map the Sky\" - Ynor9: https://www.newgrounds.com/audio/listen/967045"@ "\n" @
"<lmargin:0>Expert:\n" @ "<lmargin:35> \"Ordinary\" - Zoonotist & Eurns: https://www.newgrounds.com/audio/listen/935824"@ "\n" @
"<lmargin:0>Sound Effect for Water Powerup:\n" @ "<lmargin:35> \"MODERATE RAIN WITH PASSING CARS\" - Eric Matyas: https://soundimage.org/wp-content/uploads/2016/08/Moderate-Rain-with-Passing-Cars-.mp3"@ "\n" @
"<lmargin:0>Sound Effect for \"Ready\", \"Set\", \"Go\", \"Water\" made with https://ttsmaker.com/";

      case 8:
         %text = "<font:Expo:50><color:FFFFFF><just:center>Hazards (2/2)<font:DomCasualD:32><just:left>\n\n" @
                 "<lmargin:35>Bumper - this'll bounce you if you touch it.\n\nLand Mine - Warning!  Explodes on contact!\n\nOil Slick - you won't have much traction on these surfaces.";
      case 9:
         %text = "<font:Expo:50><color:FFFFFF><just:center>About GarageGames<font:DomCasualD:32><just:left>\n\n" @
                 "GarageGames is a unique Internet publishing label for independent games and gamemakers.  Our mission is to provide the independent developer with tools, knowledge, co-conspirators - whatever is needed to unleash the creative spirit and get great innovative independent games to market.";
      case 10:
        %text = "<font:Expo:50><color:FFFFFF><just:center>About the Torque<font:DomCasualD:32><just:left>\n\n" @
                "The Torque Game Engine (TGE) is a full featured AAA title engine with the latest in scripting, geometry, particle effects, animation and texturing, as well as award winning multi-player networking code.  For $100 per programmer, you get the source to the engine!";

      case 11:
         %text = "<font:Expo:50><color:FFFFFF><just:center>The Marble Blast Team<font:DomCasualD:32><just:left>\n\n" @
            "<lmargin%:15><rmargin%:85>" @
            "<just:left>Alex Swanson" @ 
            "<just:right>Mark Frohnmayer" @
            "\n<just:left>Jeff Tunnell" @
            "<just:right>Brian Hahn" @
            "\n<just:left>Liam Ryan" @
            "<just:right>Tim Gift" @
            "\n<just:left>Rick Overman" @
            "<just:right>Kevin Ryan" @
            "\n<just:left>Timothy Clarke" @
            "<just:right>Jay Moore" @
            "\n<just:left>Pat Wilson" @
            "<just:right>John Quigley";

      case 12:
         %text = "<font:Expo:50><color:FFFFFF><just:center>Special Thanks<font:DomCasualD:32><just:left>\n\n" @
            "We'd like to thank Nullsoft, for the SuperPiMP Install System, " @
            "and Markus F.X.J. Oberhumer, Laszlo Molnar and the rest of the UPX team for the UPX executable packer."  @
            "  Thanks also to Kurtis Seebaldt for his work on integrating Ogg/Vorbis streaming into the Torque engine, and to the Ogg/Vorbis team.";

   }
   HC_Text.setText(%text);
}

function HelpNext()
{
   $CurHelpPage++;
   if($CurHelpPage > $NumHelpPages)
      $CurHelpPage = 1;
   HelpCreditsGui.setPage($CurHelpPage);
}

function HelpPrev()
{
   $CurHelpPage--;
   if($CurHelpPage < 1)
      $CurHelpPage = $NumHelpPages;
   HelpCreditsGui.setPage($CurHelpPage);
}
