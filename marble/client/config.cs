// Torque Input Map File
moveMap.delete();
new ActionMap(moveMap);
moveMap.bindCmd(keyboard, "escape", "", "escapeFromGame();");
moveMap.bindCmd(keyboard, "r", "", "ClientGroup.getObject(0).respawnPlayer();");
moveMap.bind(keyboard, "space", jump);
moveMap.bind(keyboard, "alt c", toggleCamera);
moveMap.bind(keyboard, "f8", dropCameraAtPlayer);
moveMap.bind(keyboard, "f7", dropPlayerAtCamera);
moveMap.bind(keyboard, "w", moveforward);
moveMap.bind(keyboard, "d", moveright);
moveMap.bind(keyboard, "s", movebackward);
moveMap.bind(keyboard, "a", moveleft);
moveMap.bind(keyboard, "up", panUp);
moveMap.bind(keyboard, "down", panDown);
moveMap.bind(keyboard, "right", turnRight);
moveMap.bind(keyboard, "left", turnLeft);
moveMap.bind(mouse0, "xaxis", yaw);
moveMap.bind(mouse0, "yaxis", pitch);
moveMap.bind(mouse0, "button1", freelook);
moveMap.bind(mouse0, "button0", mouseFire);
