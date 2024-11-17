//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Arrow base class
//-----------------------------------------------------------------------------

function Arrow::onPickup(%this,%obj,%user,%amount)
{
   return false;
}

//-----------------------------------------------------------------------------

datablock ItemData(ArrowItem)
{
   // Mission editor category
   category = "Arrows";
   className = "Arrow";

   // Basic Item properties
   shapeFile = "~/data/shapes/signs/arrow2.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;

   // Dynamic properties defined by the scripts
   maxInventory = 1;
   pickupName = "an arrow!";
   noPickupMessage = true;
};
