//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Copyright (c) 2001 GarageGames.Com
// Portions Copyright (c) 2001 by Sierra Online, Inc.
// Portions by Whirligig231, Jeff, and HiGuy
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

datablock ParticleData(BounceParticle)
{
   textureName          = "~/data/particles/star";
   dragCoeffiecient     = 1.0;
   gravityCoefficient   = 0;
   windCoefficient      = 0;
   inheritedVelFactor   = 0;
   constantAcceleration = -2;
   lifetimeMS           = 500;
   lifetimeVarianceMS   = 100;
   useInvAlpha =  true;
   spinSpeed     = 90;
   spinRandomMin = -90.0;
   spinRandomMax =  90.0;

   colors[0]     = "0.9 0.0 0.0 1.0";
   colors[1]     = "0.9 0.9 0.0 1.0";
   colors[2]     = "0.9 0.9 0.0 0.0";

   sizes[0]      = 0.25;
   sizes[1]      = 0.25;
   sizes[2]      = 0.25;

   times[0]      = 0;
   times[1]      = 0.75;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(MarbleBounceEmitter)
{
   ejectionPeriodMS = 80;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 0.25;
   thetaMin         = 80.0;
   thetaMax         = 90.0;
   lifetimeMS       = 250;
   particles = "BounceParticle";
};

//-----------------------------------------------------------------------------

datablock ParticleData(TrailParticle)
{
   textureName          = "~/data/particles/smoke";
   dragCoeffiecient     = 1.0;
   gravityCoefficient   = 0;
   windCoefficient      = 0;
   inheritedVelFactor   = 1;
   constantAcceleration = 0;
   lifetimeMS           = 100;
   lifetimeVarianceMS   = 10;
   useInvAlpha =  true;
   spinSpeed     = 0;

   colors[0]     = "1 1 0 0.0";
   colors[1]     = "1 1 0 1";
   colors[2]     = "1 1 1 0.0";

   sizes[0]      = 0.7;
   sizes[1]      = 0.4;
   sizes[2]      = 0.1;

   times[0]      = 0;
   times[1]      = 0.15;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(MarbleTrailEmitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 0;
   ejectionVelocity = 0.0;
   velocityVariance = 0.25;
   thetaMin         = 80.0;
   thetaMax         = 90.0;
   lifetimeMS       = 10000;
   particles = "TrailParticle";
};

//-----------------------------------------------------------------------------

datablock ParticleData(SuperJumpParticle)
{
   textureName          = "~/data/particles/twirl";
   dragCoefficient      = 0.25;
   gravityCoefficient   = 0;
   inheritedVelFactor   = 0.1;
   constantAcceleration = 0;
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 150;
   spinSpeed     = 90;
   spinRandomMin = -90.0;
   spinRandomMax =  90.0;

   colors[0]     = "0 0.5 1 0";
   colors[1]     = "0 0.6 1 1.0";
   colors[2]     = "0 0.6 1 0.0";

   sizes[0]      = 0.25;
   sizes[1]      = 0.25;
   sizes[2]      = 0.5;

   times[0]      = 0;
   times[1]      = 0.75;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(MarbleSuperJumpEmitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 0;
   ejectionVelocity = 1.0;
   velocityVariance = 0.25;
   thetaMin         = 150.0;
   thetaMax         = 170.0;
   lifetimeMS       = 5000;
   particles = "SuperJumpParticle";
};

//-----------------------------------------------------------------------------

datablock ParticleData(SuperSpeedParticle)
{
   textureName          = "~/data/particles/spark";
   dragCoefficient      = 0.25;
   gravityCoefficient   = 0;
   inheritedVelFactor   = 0.25;
   constantAcceleration = 0;
   lifetimeMS           = 1500;
   lifetimeVarianceMS   = 150;

   colors[0]     = "0.8 0.8 0 0";
   colors[1]     = "0.8 0.8 0 1.0";
   colors[2]     = "0.8 0.8 0 0.0";

   sizes[0]      = 0.25;
   sizes[1]      = 0.25;
   sizes[2]      = 1.0;

   times[0]      = 0;
   times[1]      = 0.25;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(MarbleSuperSpeedEmitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 0;
   ejectionVelocity = 1.0;
   velocityVariance = 0.25;
   thetaMin         = 130.0;
   thetaMax         = 170.0;
   lifetimeMS       = 5000;
   particles = "SuperSpeedParticle";
};

//-----------------------------------------------------------------------------

datablock ParticleEmitterData(MarbleSuperBounceEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 0.25;
   thetaMin         = 80.0;
   thetaMax         = 90.0;
   lifetimeMS       = 250;
   particles = "MarbleStar";
};

//-----------------------------------------------------------------------------

datablock ParticleEmitterData(MarbleShockAbsorberEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 0.25;
   thetaMin         = 80.0;
   thetaMax         = 90.0;
   lifetimeMS       = 250;
   particles = "MarbleStar";
};

//-----------------------------------------------------------------------------

datablock ParticleEmitterData(MarbleHelicopterEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 0.25;
   thetaMin         = 80.0;
   thetaMax         = 90.0;
   lifetimeMS       = 5000;
   particles = "MarbleStar";
};

//-----------------------------------------------------------------------------
// ActivePowerUp
// 0 - no active powerup
// 1 - Super Jump
// 2 - Super Speed
// 3 - Super Bounce
// 4 - Indestructible

datablock AudioProfile(Bounce1Sfx)
{
   filename    = "~/data/sound/bouncehard1.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(Bounce2Sfx)
{
   filename    = "~/data/sound/bouncehard2.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(Bounce3Sfx)
{
   filename    = "~/data/sound/bouncehard3.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(Bounce4Sfx)
{
   filename    = "~/data/sound/bouncehard4.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(JumpSfx)
{
   filename    = "~/data/sound/Jump.wav";
   description = AudioDefault3d;
   preload = true;
};

datablock AudioProfile(RollingHardSfx)
{
   filename    = "~/data/sound/Rolling_Hard.wav";
   description = AudioClosestLooping3d;
   preload = true;
};

datablock AudioProfile(SlippingSfx)
{
   filename    = "~/data/sound/Sliding.wav";
   description = AudioClosestLooping3d;
   preload = true;
};

datablock MarbleData(DefaultMarble)
{
   shapeFile = "~/data/shapes/balls/ball-superball.dts";
   emap = true;
   renderFirstPerson = true;
// maxRollVelocity = 55;
// angularAcceleration = 120;

   
   maxRollVelocity = 15;
   angularAcceleration = 75;
   brakingAcceleration = 30;
   gravity = 20;
   staticFriction = 1.1;
   kineticFriction = 0.7;
   bounceKineticFriction = 0.2;
   maxDotSlide = 0.5;
   bounceRestitution = 0.5;
   jumpImpulse = 7.5;
   maxForceRadius = 50;

   bounce1 = Bounce1Sfx;
   bounce2 = Bounce2Sfx;
   bounce3 = Bounce3Sfx;
   bounce4 = Bounce4Sfx;

   rollHardSound = RollingHardSfx;
   slipSound = SlippingSfx;
   jumpSound = JumpSfx;
   
   // Emitters
   minTrailSpeed = 10;            // Trail threshold
   trailEmitter = MarbleTrailEmitter;
   
   minBounceSpeed = 3;           // Bounce threshold
   bounceEmitter = MarbleBounceEmitter;
   
   powerUpEmitter[1] = MarbleSuperJumpEmitter; 		// Super Jump
   powerUpEmitter[2] = MarbleSuperSpeedEmitter; 	// Super Speed
// powerUpEmitter[3] = MarbleSuperBounceEmitter; 	// Super Bounce
// powerUpEmitter[4] = MarbleShockAbsorberEmitter; 	// Shock Absorber
// powerUpEmitter[5] = MarbleHelicopterEmitter; 	// Helicopter
   
   // Power up timouts. Timeout on the speed and jump only affect
   // the particle trail
   powerUpTime[1] = 1000;	// Super Jump
   powerUpTime[2] = 1000; 	// Super Speed
   powerUpTime[3] = 5000; 	// Super Bounce
   powerUpTime[4] = 5000; 	// Shock Absorber
   powerUpTime[5] = 5000; 	// Helicopter

   // Allowable Inventory Items
   maxInv[SuperJumpItem] = 20;
   maxInv[SuperSpeedItem] = 20;
   maxInv[SuperBounceItem] = 20;
   maxInv[IndestructibleItem] = 20;
   maxInv[TimeTravelItem] = 20;
//   maxInv[GoodiesItem] = 10;
};


//-----------------------------------------------------------------------------

function MarbleData::onAdd(%this, %obj)
{
   echo("New Marble: " @ %obj);
}

function MarbleData::onTrigger(%this, %obj, %triggerNum, %val)
{
}


//-----------------------------------------------------------------------------

function MarbleData::onCollision(%this,%obj,%col)
{
   // Try and pickup all items
   if (%col.getClassName() $= "Item")
   {
      %data = %col.getDatablock();
      %obj.pickup(%col,1);
   }
   if (%col.getClassName() $= "StaticShape" && %col.getDataBlock().className $= "checkPoint") {
      %this.setCheckpoint(%obj, %col);
   }
}


//-----------------------------------------------------------------------------
// The following event callbacks are punted over to the connection
// for processing

function MarbleData::onEnterPad(%this,%object)
{
   %object.client.onEnterPad();
}

function MarbleData::onLeavePad(%this,%object)
{
   %object.client.onLeavePad();
}

function MarbleData::onStartPenalty(%this,%object)
{
   %object.client.onStartPenalty();
}

function MarbleData::onOutOfBounds(%this,%object)
{
   %object.client.onOutOfBounds();
}

function MarbleData::setCheckpoint(%this,%object,%check)
{
   %object.client.setCheckpoint(%check);
}


//-----------------------------------------------------------------------------
// Marble object
//-----------------------------------------------------------------------------

function Marble::setPowerUp(%this,%item,%reset)
{
   PlayGui.setPowerUp(%item.shapeFile);
   %this.powerUpData = %item;
   %this.setPowerUpId(%item.powerUpId,%reset);
   if (%item.powerUpId > 5) {
      %this.CPpowerUpId = %item.powerUpId;
      %this.setPowerUpId(0, true);
      %this.hasCustomPowerup = true;
      return;
   }
   %this.hasCustomPowerup = false;
   %this.CPpowerUpId = 0;
}

function Marble::getPowerUp(%this)
{
   return %this.powerUpData;
}

function Marble::onPowerUpUsed(%obj)
{
   PlayGui.setPowerUp("");
   %obj.playAudio(0, %obj.powerUpData.activeAudio);
   %obj.powerUpData = "";
}

// MATHS

function OrthoMultiplyAdjusted(%ortho,%vec) {
   return (getWord(%ortho,0)*getWord(%vec,0)+getWord(%ortho,1)*getWord(%vec,1)+getWord(%ortho,2)*getWord(%vec,2)) SPC -(getWord(%ortho,3)*getWord(%vec,0)+getWord(%ortho,4)*getWord(%vec,1)+getWord(%ortho,5)*getWord(%vec,2)) SPC (getWord(%ortho,6)*getWord(%vec,0)+getWord(%ortho,7)*getWord(%vec,1)+getWord(%ortho,8)*getWord(%vec,2));
}

// Custom powerup properties

$superJumpHeight = 20;
$superJumpParticleTimeout = 1000;
$superSpeedPower = 24.7;
$superSpeedParticleTimeout = 1000;
$superBounceRestitution = 0.8;
$superBounceTime = 5000;
$shockAbsorberTime = 5000;
$superBounceExpire = -1;
$shockAbsorberExpire = -1;
$superBounceOn = false;
$shockAbsorberOn = false;
$gyrocopterGravity = 5;
$gyrocopterTime = 5000;
$gyrocopterOn = false;
$gyrocopterExpire = -1;
$waterTime = 5000;
$waterOn = false;
$waterExpire = -1;

// Powerup code

function Marble::useCustomPowerUp(%this) {
   if (%this.hasCustomPowerup == true) {
      %currentTime = PlayGui.elapsedTime + PlayGui.totalBonus;
      switch (%this.CPpowerUpId) {
      case 6:
         findRealMarble().applyImpulse("0 0 0",VectorScale(getGravityDir(),-$superJumpHeight));
         serverPlay2d(doSuperJumpSfx);
         %scale = 1-($scaleFactor/10000);
         %scale = %scale SPC %scale SPC %scale;
         $scaleFactor++;
         %superJumpParticle = new ParticleEmitterNode() {
            position = %this.position;
            rotation = "1 0 0 0";
            scale = %scale;
            dataBlock = "FireWorkNode";
            emitter = "MarbleSuperJumpEmitter";
            velocity = "1";
         };
         
         schedule(100,0,"doTheParticleThing",%scale,0);
         %superJumpParticle.schedule($superJumpParticleTimeout,"delete");
      case 7:
         %impulseX = $superSpeedPower*mSin($marbleYaw);
         %impulseY = $superSpeedPower*mCos($marbleYaw);
         findRealMarble().applyImpulse("0 0 0",OrthoMultiplyAdjusted($gravityMatrix,%impulseX SPC %impulseY SPC 0));
         serverPlay2d(doSuperSpeedSfx);
         %scale = 1-($scaleFactor/10000);
         %scale = %scale SPC %scale SPC %scale;
         $scaleFactor++;
         %superSpeedParticle = new ParticleEmitterNode() {
            position = %this.position;
            rotation = "1 0 0 0";
            scale = %scale;
            dataBlock = "FireWorkNode";
            emitter = "MarbleSuperSpeedEmitter";
            velocity = "1";
         };
         schedule(100,0,"doTheParticleThing",%scale,1);
         %superSpeedParticle.schedule($superSpeedParticleTimeout,"delete");
      case 8:
         DefaultMarble.bounceRestitution = $superBounceRestitution;
         %this.mountImage(SuperBounceImage,0);
		 $shockAbsorberOn = false;
		 $shockAbsorberExpire = -1;
    	 $superBounceOn = true;
         Bounce_ShowPowerUp.setModel($Con::Root @ "/data/shapes/items/superbounce.dts", "");
         if($superBounceExpire > %currentTime){
		    $superBounceExpire += $superBounceTime;
		 }else{
		    $superBounceExpire = %currentTime + $superBounceTime;
         }
      case 9:
         DefaultMarble.bounceRestitution = 0;
         %this.mountImage(ShockAbsorberImage,0);
		 $superBounceOn = false;
		 $superBounceExpire = -1;
    	 $shockAbsorberOn = true;
         Bounce_ShowPowerUp.setModel($Con::Root @ "/data/shapes/items/shockabsorber.dts", "");
         if($shockAbsorberExpire > %currentTime){
		    $shockAbsorberExpire += $shockAbsorberTime;
		 }else{
		    $shockAbsorberExpire = %currentTime + $shockAbsorberTime;
         }
      case 10:
         DefaultMarble.gravity = $gyrocopterGravity;
         %this.mountImage(HelicopterImage,1);
		 $gyrocopterOn = true;
         if($gyrocopterExpire > %currentTime){
		    $gyrocopterExpire += $gyrocopterTime;
		 }else{
		    $gyrocopterExpire = %currentTime + $gyrocopterTime;
         }
      case 11:
	     $waterOn = true;
         %this.mountImage(WaterImage,2);
         if($waterExpire > %currentTime){
		    $waterExpire += $waterTime;
		 }else{
		    $waterExpire = %currentTime + $waterTime;
         }
      default:
         echo("\c2Bad or incomplete powerup code!");
      }
      %this.setPowerUp(0, true);
      %this.CPpowerUpId = 0;
      %this.hasCustomPowerup = false;
   }
}

function Marble::cancelCustomPowerUps(%this) {
   %this.unbounceMe();
   %this.unheliMe();
   %this.unwaterMe();
}

function Marble::unbounceMe(%this) {
   DefaultMarble.bounceRestitution = 0.5;
   %this.unmountImage(0);
   $shockAbsorberOn = false;
   $shockAbsorberExpire = -1;
   $superBounceOn = false;
   $superBounceExpire = -1;
}

function Marble::unheliMe(%this) {
   DefaultMarble.gravity = 20;
   %this.unmountImage(1);
   $gyrocopterOn = false;
   $gyrocopterExpire = -1;
}

function Marble::unwaterMe(%this) {
   %this.unmountImage(2);
   $waterOn = false;
   $waterExpire = -1;
}

//-----------------------------------------------------------------------------

function marbleVel()
{
   return $MarbleVelocity;
}

function metricsMarble()
{
   Canvas.pushDialog(FrameOverlayGui, 1000);
   TextOverlayControl.setValue("$MarbleVelocity");
}

function findRealMarble() {
   //Iterate through all objects in client-side server connection
   for (%i = 0; %i < ServerConnection.getCount(); %i ++) {
      //Get the object from the iteration
      %obj = ServerConnection.getObject(%i);
      //Check for ID. The marble ID will *always* be higher.
      //Analysis shaped by using tree();
      //tree(); is one of those hidden-but-useful functions
      if (%obj.getId() < LocalClientConnection.player.getId())
         continue;
      //If it's a marble, then we're good!
      //This is *guarenteed* to be the client-side marble, 100%
      //of the time, if you are playing single player
      if (%obj.getClassName() $= "Marble") {
         return %obj;
      }
   }
}

function searchForObjectParticle(%scale) {
   %count = ServerConnection.getCount();
   for (%i = 0; %i < %count; %i ++) {
  %obj = ServerConnection.getObject(%i);
  if (%obj.getClassName() $= "ParticleEmitterNode")
  {
     if (%obj.getScale() $= %scale)
      return %obj;
  }
 }
 return -1;
}

function attachParticleToClient(%ghost, %particle, %index) {
  cancel($Schedule::ClientParticle[%index]);
  if (!isObject(%ghost) || !isObject(%particle))
   return;
  %particle.setTransform(%ghost.getPosition() SPC "1 0 0 0");
  $Schedule::ClientParticle[%index] = schedule(40, 0, "attachParticleToClient", %ghost, %particle, %index);
}

function doTheParticleThing(%scale,%index) {
	attachParticleToClient(LocalClientConnection.player,searchForObjectParticle(%scale),%index);
}
