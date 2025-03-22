$NumHelpPages = 8;

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
                 "Over the years, many Marble Blast players have made their own modification of the game. Some notable mods of the game are Platinum Quest, STOP DeluXe, Marble Blast Emerald, Gerson\'s Level Compilation, etc.";
      case 2:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>About Marble Blast: Synergy" @
                 "<font:Lucida Sans:18><just:left>\n\n" @
                 "Marble Blast Synergy (referred to as \"this mod\" from now on) is a Marble Blast modification by a13069. This mod started in 2019, and was being developed on and off until eventually being forgotten by its author. The author rediscovered it in November 2024, and decided to release it."
                 @ "\n\n" @
                 "The main new feature of this mod is the addition of a new hazard (lava) and a new powerup (water) that counters it. Play the first few beginner levels to see how they work. There are other gameplay features in this mod, such as checkpoints, bouncy floors, powerup timer, etc., but they are common in other mods as well."
                 @ "\n\n" @
                 "This mod is currently released in an unfinished state - However, with 50 levels (over 60 if you count scrapped ones) and all its planned gameplay features implemented, the author believes it is able to stand on its own, even in its current unfinished state. The author also wishes to continue working on this mod, but there isn\'t a set schedule for it.";
      case 3:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>About the Levels (1)" @
                 "<font:Lucida Sans:18><just:left>\n\n" @

"This mod's aesthetic and level designs are inspired by jmtb02's \"Ball Revamped V: Synergy\" (hence the name). Each difficulty is divided into 10-level \"realms\", which correspond to 10-level \"realms\" in Ball Revamped V. Each realm has its own skybox, textures and soundtracks."@ "\n\n" @
"The correspondence is as follows:<tab:200,400>"@ "\n" @
"This mod's realm" TAB " Ball Revamped V's realm"@ "\n" @
"Tutorial" TAB " Level 1-10 (Bengium)"@ "\n" @
"Early Beginner" TAB " Level 11-20 (Eucharis)"@ "\n" @
"Middle Beginner" TAB " Level 41-50 (Solidago)"@ "\n" @
"Late Beginner" TAB " Level 61-70 (Achillea)"@ "\n" @
"Early Intermediate" TAB " Level 21-30 (Centaurea)"@ "\n" @
"Middle Intermediate" TAB " Level 51-60 (Amaranthus)"@ "\n" @
"Late Intermediate" TAB " None"@ "\n" @
"Early Advanced" TAB " Level 31-40 (Allium)"@ "\n" @
"Middle Advanced" TAB " Level 71-80 (Arachnis)"@ "\n" @
"Late Advanced" TAB " Level 81-90 (Platycodon)"@ "\n" @
"Expert" TAB " Level 91-99 (Lilium)"@ "\n\n" @
"Realms are purely aesthetic and have no impact on gameplay. However, the levels in the same realm may share some common gameplay elements. There's also a \"Custom\" difficulty, which contains levels the author didn't like enough to put into the main game.";


      case 4:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>About the Levels (2)" @
                 "<font:Lucida Sans:18><just:left>\n\n" @
"On the level select screen, you can see a \"Level Info\" tab to the bottom left. Inside it is author\'s notes on the level, which shows the change log (if there are any) and author\'s thoughts on the level. Sometimes there are some trivia in it. If you\'ve beaten the gold time, an awesome hint will show. It shows what the author thinks that will help you beat the awesome time. Some awesome hints are provided by more experienced Marble Blast Players. Note that because of the limited marbling skill of the author, some awesome hints (by the author) might be sub-optimal." @ "\n\n" @


"The gold times and the awesome times are as follows:" @ "\n" @
"- The gold times are meant to be as hard as the platinum times in Platinum Quest. They are set to be a little lower than the author\'s first play through, or a little lower than the time it takes with the intended route." @ "\n" @
"- The awesome times are meant to be as hard as the ultimate times in Platinum Quest. They are set to be the best time the author can achieve. However, if the author still hasn\'t had a run he likes (or the time is too close to the gold time), the awesome time is left undetermined. Some awesome times are suggested by other Marble Blast players, they\'re credited in the \"Special Thanks\" page.";
      case 5:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>About the Levels (3)" @
                "<font:Lucida Sans:18><just:left>\n\n" @
                "This page lists the contributor of each level's challange times and their hints. If a time/hint isn't listed here, it means it's set by the author, or it hasn't been set yet.\n" @
				" - Tornado Arena (B24) - Awesome time by Mazik\n" @
				" - Winding Trail (B26) - Awesome time and awesome hint by Mazik\n" @
				" - Tube Pathfinder (B28) - Gold time and awesome time by Mazik\n" @
				" - Moving Blocks (I1), Chilly Gem Hunter (I2), Knight of the Marble (I3) - Gold time, awesome time and awesome hint by Mazik\n" @
				" - Gravitational Speedtrack (I8), Tale of Three Islands (I9), Ride the Wind (I11), Water Rings (I16), Connect Gems! (I17) - Awesome time and awesome hint by Mazik\n" ;

      case 6:
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
      case 7:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>Special Thanks" @
                 "<font:Lucida Sans:18><just:left>\n\n" @
                 "Although I worked on this mod (mainly) on my own, this mod wouldn't be possible without other people's work.\n\n" @
				 "On gameplay:\n" @
				 " - The playtester (an IRL of mine) who played through the mod's 49 levels of the initial release\n" @
				 " - Mazik for suggesting the awesome times and their hints for many levels, and also making a full speerun compilation of the initial release"  
                 @ "\n\n" @
				 "On coding and mechanics:\n" @ 
				 " - HiGuy (for HiGuy's Mod_TMTimer)\n" @ 
				 " - whirligig (for whirligig's remade powerups)\n" @ 
				 " - Everyone who has asked questions in the Marble Blast forum (I consulted those threads a lot)"
                 @ "\n\n" @
                 "On Inspiration: \n" @
				 "Everyone who has made their own mods, especially:\n" @ 
				 " - Jiquor (for Marble Blast STOP)\n" @ 
				 " - NaCl586 (for Gerson's Level Compilation)\n" @ 
				 " - EvilTaco (for Evil's Mini Mod)\n" @ 
				 "for showing it's possible to make a full mod as a single person. Also, \n" @ 
				 " - jmtb02 (for Ball Revamped V: Synergy)\n" @ 
				 "The flash game is the inspiration for this mod. Many assets of this mod are modified from the game as well."
                 @ "\n\n" @
                 "Last but not least:\n" @ 
				 " - The original Marble Blast Gold team (for making Marble Blast Gold)\n" @ 
				 " - The Marble Blast team (for maintaining and updating the game)\n" @ 
				 "Marble Blast is truly a wonderful game that I have been coming back to for years and decided to make a mod of.";
      case 8:
         %text = "<font:Lucida Sans:24><color:FFFFFF><just:center>Soundtracks Used" @
                 "<font:Lucida Sans:18><just:left>\n\n" @
      
"<lmargin:0>Shell Music & Custom Levels:\n" @ "<lmargin:35> \"Rig - Celtic Warloads preview\" - Rig: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/94774"@ "\n" @
"<lmargin:0>Early Beginner:\n" @ "<lmargin:35> \"Moving Pieces\" - Montron: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/1106610"@ "\n" @
"<lmargin:0>Middle Beginner:\n" @ "<lmargin:35> \"Purple Skies\" - Qshunt: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/941702"@ "\n" @
"<lmargin:0>Late Beginner:\n" @ "<lmargin:35> \"Custom Shader\" - AliceMako: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/955260"@ "\n" @
"<lmargin:0>Early Intermediate:\n" @ "<lmargin:35> \"PUZZLE GAME 3\" - Eric Matyas: \n" @ "<lmargin:35>https://soundimage.org/wp-content/uploads/2016/03/Puzzle-Game-3_Looping.mp3"@ "\n" @
"<lmargin:0>Middle Intermediate:\n" @ "<lmargin:35> \"Loading\" - CorruptedFrame: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/1137802"@ "\n" @
"<lmargin:0>Late Intermediate:\n" @ "<lmargin:35> \"Resilience\" - Zoonotist: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/1004454"@ "\n" @
"<lmargin:0>Early Advanced:\n" @ "<lmargin:35> \"-Temptation-\" - Sabodis: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/59043"@ "\n" @
"<lmargin:0>Middle Advanced:\n" @ "<lmargin:35> \"Journey to the Third Sun\" - Dem0n1x: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/1177385"@ "\n" @
"<lmargin:0>Late Advanced:\n" @ "<lmargin:35> \"Map the Sky\" - Ynor9: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/967045"@ "\n" @
"<lmargin:0>Expert:\n" @ "<lmargin:35> \"Ordinary\" - Zoonotist & Eurns: \n" @ "<lmargin:35>https://www.newgrounds.com/audio/listen/935824"@ "\n" @
"<lmargin:0>Sound Effect for Water Powerup:\n" @ "<lmargin:35> \"MODERATE RAIN WITH PASSING CARS\" - Eric Matyas: \n" @ "<lmargin:35>https://soundimage.org/wp-content/uploads/2016/08/Moderate-Rain-with-Passing-Cars-.mp3"@ "\n" @
"<lmargin:0>Sound Effect for \"Ready\", \"Set\", \"Go\", \"Water\" made with https://ttsmaker.com/";

      case 9:
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
