//HiGuy: We need to wait to execute this!
if (!$TMTimer::Execute) {
   $TMTimer::Execute = true;
   schedule(1000, 0, exec, $Con::File);
   return;
}

//Determine mod
function getMod() {
   if (isFile("marble/server/scripts/speedmeter.cs.dso"))
      return "Advanced";
   if (isFile("marble/client/ui/Awards/AllSapphires.png"))
      return "Emerald";
   if (isFile("marble/quickFix.cs"))
      return "Future";
   if (isFile("marble/quickFix.cs.dso"))
      return "Future";
   if (isFile("marble/client/ui/fullVersion.png"))
      return "Gold Demo";
   if (isFile("marble/client/ui/STBox.gui.dso"))
      return "Opal";
   if (isFile("marble/client/ui/play_rc_d.png"))
      return "Platinum";
   if (isFile("platinum/client/ui/play_rc_d.png"))
      return "Platinum";
   if (isFile("marble/client/ui/BBLoadingGui.gui.dso"))
      return "Reloaded";
   if (isFile("marble/data/particles/debris.png"))
      return "Revived";
   if (isFile("marble/client/ui/loading/loadinggui_origin.png"))
      return "Space";
   return "Gold";
}

//HiGuy: Jeff said I had to. :(
function getGameName() {
   if ($platform $= "macos")
      return "MarbleBlast";
   return "Marble Blast";
//   return "Murble Blust";
}

echo("Initializing TimeModifier Timer scripts in" SPC getGameName() SPC getMod());

//HiGuy: Called when we init this script
function initTMTimer() {
   //HiGuy: Clean up
   if (isObject(PG_TMTimer))
      PG_TMTimer.delete();
   if (isObject(PG_GyroTimer))
      PG_GyroTimer.delete();

   //HiGuy: Create the whole Gui (unnecessary portions left out)
   %CenterPos = mfloor((getWord(PlayGui.getExtent(), 0) - 237) / 2);
   new GuiBitmapCtrl(PG_TMTimer) {
      profile = "GuiDefaultProfile";
      horizSizing = "right";
      vertSizing = "top";
      //HiGuy: Center it!
      position = "0 441";
      extent = "163 39";
      bitmap = $Con::Root @ "/client/ui/game/shade.png";
      visible = "0";

      new GuiObjectView(HUD_ShowTT) {
         profile = "GuiButtonProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "-2 -2";
         extent = "44 44";
         minExtent = "8 8";
         visible = "1";
         helpTag = "0";
         cameraZRot = "0";
         forceFOV = "0";
         skin = "base";
         cameraRotX = "0";
         cameraZRotSpeed = "0.001";
         orbitDistance = "1.46368";
         autoSize = "1";
      };
      new GuiBitmapCtrl(TMMin_Ten) {
         profile = "GuiDefaultProfile";
         position = "35 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(TMMin_One) {
         profile = "GuiDefaultProfile";
         position = "53 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(TMMinSec_Colon) {
         profile = "GuiDefaultProfile";
         position = "64 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/colon_green.png";
      };
      new GuiBitmapCtrl(TMSec_Ten) {
         profile = "GuiDefaultProfile";
         position = "76 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(TMSec_One) {
         profile = "GuiDefaultProfile";
         position = "94 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(TMMinSec_Point) {
         profile = "GuiDefaultProfile";
         position = "105 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/point_green.png";
      };
      new GuiBitmapCtrl(TMSec_Tenth) {
         profile = "GuiDefaultProfile";
         position = "117 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(TMSec_Hundredth) {
         profile = "GuiDefaultProfile";
         position = "135 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
   };
   HUD_ShowTT.setModel($Con::Root @ "/data/shapes/items/timetravel.dts", "");
   //HiGuy: Add it to the PlayGui
   PlayGui.add(PG_TMTimer);

   %Offset = mfloor(getWord(PlayGui.getExtent(), 0) / 2);
   //The Gyrocopter timer
   //echo("GyroOffset = " @ %Offset);
   //echo("CenterPos = " @ %CenterPos);
   new GuiBitmapCtrl(PG_GyroTimer) {
      profile = "GuiDefaultProfile";
      horizSizing = "left";
      vertSizing = "top";
      position = "518 363";
      extent = "122 39";
      bitmap = $Con::Root @ "/client/ui/game/shade.png";
      visible = "1";
      new GuiObjectView(Gyro_ShowPowerUp) {
         profile = "GuiButtonProfile";
         position = "0 9";
         extent = "38 38";
         helpTag = "0";
         cameraZRot = "0";
         forceFOV = "0";
         skin = "base";
         cameraRotX = "0";
         cameraZRotSpeed = "0.001";
         orbitDistance = "1.82456";
         autoSize = "1";
      };
      new GuiBitmapCtrl(GyroSec_Ten) {
         profile = "GuiDefaultProfile";
         position = "35 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(GyroSec_One) {
         profile = "GuiDefaultProfile";
         position = "53 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(GyroMinSec_Point) {
         profile = "GuiDefaultProfile";
         position = "64 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/point_green.png";
      };
      new GuiBitmapCtrl(GyroSec_Tenth) {
         profile = "GuiDefaultProfile";
         position = "76 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(GyroSec_Hundredth) {
         profile = "GuiDefaultProfile";
         position = "94 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
   };
   Gyro_ShowPowerUp.setModel($Con::Root @ "/data/shapes/images/helicopter.dts", "");
   PlayGui.add(PG_GyroTimer);

   //The Water timer
   new GuiBitmapCtrl(PG_WaterTimer) {
      profile = "GuiDefaultProfile";
      horizSizing = "left";
      vertSizing = "top";
      position = "518 441";
      extent = "122 39";
      bitmap = $Con::Root @ "/client/ui/game/shade.png";
      visible = "1";
      new GuiObjectView(Water_ShowPowerUp) {
         profile = "GuiButtonProfile";
         position = "1 1";
         extent = "38 38";
         helpTag = "0";
         cameraZRot = "0";
         forceFOV = "0";
         skin = "base";
         cameraRotX = "0";
         cameraZRotSpeed = "0.001";
         orbitDistance = "1.82456";
         autoSize = "1";
      };
      new GuiBitmapCtrl(WaterSec_Ten) {
         profile = "GuiDefaultProfile";
         position = "35 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(WaterSec_One) {
         profile = "GuiDefaultProfile";
         position = "53 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(WaterMinSec_Point) {
         profile = "GuiDefaultProfile";
         position = "64 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/point_green.png";
      };
      new GuiBitmapCtrl(WaterSec_Tenth) {
         profile = "GuiDefaultProfile";
         position = "76 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(WaterSec_Hundredth) {
         profile = "GuiDefaultProfile";
         position = "94 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
   };
   Water_ShowPowerUp.setModel($Con::Root @ "/data/shapes/items/water.dts", "");
   PlayGui.add(PG_WaterTimer);

   //The Bounce timer
   new GuiBitmapCtrl(PG_BounceTimer) {
      profile = "GuiDefaultProfile";
      horizSizing = "left";
      vertSizing = "top";
      position = "518 402";
      extent = "122 39";
      bitmap = $Con::Root @ "/client/ui/game/shade.png";
      visible = "1";
      new GuiObjectView(Bounce_ShowPowerUp) {
         profile = "GuiButtonProfile";
         position = "1 1";
         extent = "38 38";
         helpTag = "0";
         cameraZRot = "0";
         forceFOV = "0";
         skin = "base";
         cameraRotX = "0";
         cameraZRotSpeed = "0.001";
         orbitDistance = "1.82456";
         autoSize = "1";
      };
      new GuiBitmapCtrl(BounceSec_Ten) {
         profile = "GuiDefaultProfile";
         position = "35 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(BounceSec_One) {
         profile = "GuiDefaultProfile";
         position = "53 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(BounceMinSec_Point) {
         profile = "GuiDefaultProfile";
         position = "64 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/point_green.png";
      };
      new GuiBitmapCtrl(BounceSec_Tenth) {
         profile = "GuiDefaultProfile";
         position = "76 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
      new GuiBitmapCtrl(BounceSec_Hundredth) {
         profile = "GuiDefaultProfile";
         position = "94 5";
         extent = "23 29";
         bitmap = $Con::Root @ "/client/ui/game/numbers/0_green.png";
      };
   };
   Bounce_ShowPowerUp.setModel($Con::Root @ "/data/shapes/items/water.dts", "");
   PlayGui.add(PG_BounceTimer);

   //HiGuy: Updating scripts
   activatePackage(TMTimer);
}

//HiGuy: OVERRIDE TIME
package TMTimer {
   //HiGuy: General, all-around good functions to call from

   function clientCmdGameStart() {
      Parent::clientCmdGameStart();
      PlayGui.updateControls();
      HUD_ShowTT.setModel($Con::Root @ "/data/shapes/items/timetravel.dts", "");
      Gyro_ShowPowerUp.setModel($Con::Root @ "/data/shapes/images/helicopter.dts", "");
      Water_ShowPowerUp.setModel($Con::Root @ "/data/shapes/items/water.dts", "");
      Bounce_ShowPowerUp.setModel($Con::Root @ "/data/shapes/items/superbounce.dts", "");
   }
   function setGameState(%a, %b) {
      Parent::setGameState(%a, %b);
      PlayGui.updateControls();
   }
   function GameConnection::incBonusTime(%this, %a) {
      Parent::incBonusTime(%this, %a);
      PlayGui.updateControls();
   }

   //HiGuy: Update our things!
   function PlayGui::updateControls(%this) {
      Parent::updateControls(%this);

      //HiGuy: Copied directly from PlayGui.cs, just changed to BonusTime
      %bt = %this.bonusTime;
      PG_TMTimer.setVisible(%bt);

      if (%bt) {
         %hundredth = mFloor((%bt % 1000) / 10);
         %totalSeconds = mFloor(%bt / 1000);
         %seconds = %totalSeconds % 60;
         %minutes = (%totalSeconds - %seconds) / 60;

         %secondsOne      = %seconds % 10;
         %secondsTen      = (%seconds - %secondsOne) / 10;
         %minutesOne      = %minutes % 10;
         %minutesTen      = (%minutes - %minutesOne) / 10;
         %hundredthOne    = %hundredth % 10;
         %hundredthTen    = (%hundredth - %hundredthOne) / 10;

         // Update the controls
         TMMin_Ten.setTimeNumber(%minutesTen);
         TMMin_One.setTimeNumber(%minutesOne);
         TMSec_Ten.setTimeNumber(%secondsTen);
         TMSec_One.setTimeNumber(%secondsOne);
         TMSec_Tenth.setTimeNumber(%hundredthTen);
         TMSec_Hundredth.setTimeNumber(%hundredthOne);

         TMMinSec_Colon.setTimeNumber("colon");
         TMMinSec_Point.setTimeNumber("point");
      }
	  
	  // Gyrocopter Timer
	  %currentTime = %this.elapsedTime + %this.totalBonus;
	  %gyro = $gyrocopterExpire - %currentTime;
      PG_GyroTimer.setVisible($gyrocopterOn);
      Gyro_ShowPowerUp.setVisible($gyrocopterOn);

      if ($gyrocopterOn) {
         %hundredth = mFloor((%gyro % 1000) / 10);
         %seconds = mFloor(%gyro / 1000);

         %secondsOne      = %seconds % 10;
         %secondsTen      = (%seconds - %secondsOne) / 10;
         %hundredthOne    = %hundredth % 10;
         %hundredthTen    = (%hundredth - %hundredthOne) / 10;

         GyroSec_Ten.setTimeNumber(%secondsTen);
         GyroSec_One.setTimeNumber(%secondsOne);
         GyroSec_Tenth.setTimeNumber(%hundredthTen);
         GyroSec_Hundredth.setTimeNumber(%hundredthOne);

         GyroMinSec_Point.setTimeNumber("point");
      } 

	  // Water Timer
	  %water = $waterExpire - %currentTime;
      PG_WaterTimer.setVisible($waterOn);
      Water_ShowPowerUp.setVisible($waterOn);

      if ($waterOn) {
         %hundredth = mFloor((%water % 1000) / 10);
         %seconds = mFloor(%water / 1000);

         %secondsOne      = %seconds % 10;
         %secondsTen      = (%seconds - %secondsOne) / 10;
         %hundredthOne    = %hundredth % 10;
         %hundredthTen    = (%hundredth - %hundredthOne) / 10;

         WaterSec_Ten.setTimeNumber(%secondsTen);
         WaterSec_One.setTimeNumber(%secondsOne);
         WaterSec_Tenth.setTimeNumber(%hundredthTen);
         WaterSec_Hundredth.setTimeNumber(%hundredthOne);

         WaterMinSec_Point.setTimeNumber("point");
      }

	  // Bounce Timer
      PG_BounceTimer.setVisible($superBounceOn || $shockAbsorberOn);
      Bounce_ShowPowerUp.setVisible($superBounceOn || $shockAbsorberOn);

      if ($superBounceOn) {
	     %superBounce = $superBounceExpire - %currentTime;
         %hundredth = mFloor((%superBounce % 1000) / 10);
         %seconds = mFloor(%superBounce / 1000);

         %secondsOne      = %seconds % 10;
         %secondsTen      = (%seconds - %secondsOne) / 10;
         %hundredthOne    = %hundredth % 10;
         %hundredthTen    = (%hundredth - %hundredthOne) / 10;

         BounceSec_Ten.setTimeNumber(%secondsTen);
         BounceSec_One.setTimeNumber(%secondsOne);
         BounceSec_Tenth.setTimeNumber(%hundredthTen);
         BounceSec_Hundredth.setTimeNumber(%hundredthOne);

         BounceMinSec_Point.setTimeNumber("point");
      } else {
	     %shockAbsorber = $shockAbsorberExpire - %currentTime;
         %hundredth = mFloor((%shockAbsorber % 1000) / 10);
         %seconds = mFloor(%shockAbsorber / 1000);

         %secondsOne      = %seconds % 10;
         %secondsTen      = (%seconds - %secondsOne) / 10;
         %hundredthOne    = %hundredth % 10;
         %hundredthTen    = (%hundredth - %hundredthOne) / 10;

         BounceSec_Ten.setTimeNumber(%secondsTen);
         BounceSec_One.setTimeNumber(%secondsOne);
         BounceSec_Tenth.setTimeNumber(%hundredthTen);
         BounceSec_Hundredth.setTimeNumber(%hundredthOne);

         BounceMinSec_Point.setTimeNumber("point");
      }
   }
};

//HiGuy: I know MBP has this, but I don't think MBG does
function GuiBitmapCtrl::setTimeNumber(%this, %number) {
   if (getMod() $= "Platinum")
      %this.setBitmap($Con::Root @ "/client/ui/game/numbers/" @ %number @ $PlayTimerPrefix @ ".png");
   else
      %this.setBitmap($Con::Root @ "/client/ui/game/numbers/" @ %number @ ".png");
}

//HiGuy: START HER UP
initTMTimer();
