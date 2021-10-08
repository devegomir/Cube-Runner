# Cube Sprinter
### Video Demo:  <https://www.youtube.com/watch?v=RhUGItaIwW8>
### Description:


#### Gameplay:
Hello to my final Project,

for my final project I chose to create a 3D videogame using the engine Unity. The name of the Game is Cube Sprinter. The game consist currently of five scenes, of
which are two menus and three levels.

After starting the game you are in the start menu. You can change the color of the player cube. u can choose between 5 colors. Red, green, magenta, blue and yellow.
After hiting the start button the game begins.

In the first level your cube will move straight forward on a long plane. Several obstacles are in your way to the finish line. Hitting an obstacle or falling
of the side of the plane will make you automaticly restart the level. In the first few seconds the keybindings are shown.

The cube cube can be controled by pressing "A" or "Left Arrow Key" to go left and "D" or "Right Arrow Key" to go right. Pressin "space" will make the cube jump.
Pressing "R" will slow down time for 2 seconds to half the normal time passage. That is so you can clear difficult obstacles. You only have two charges per Level.

The first level is pretty basic with only static objects and some jumps.

The second level adds moving obstacles. YOu have to activly dodge these or you have to restart. Your own movmentspeed has also increased making it more difficult.
If you are having a hard time clearing this level, remeber that you can slow down time by pressing "R".

In the third level there are several "trigger points". When passing these more obstacles will fall from the sky trying to block off you war. Also the speed was
increased again. This level is by far the hardest of the three. After clering this level you get taken to the last scene.

The last scene is the exit menu. There is only my name and a thank you message.

#### Scripts:
All scripts are written in C#
The game has the following scripts:

playermovment.cs : controll the Playermovment like jumping, left-right but also losing the game when going off the edge.

PlayerCollision.cs : This is the collision detection between the player and obstacles.

Score.cs : tracks the distance traveled

Welcome.cs : starts the game

Credits.cs : ends the game

FollowPlayer.cs : makes the camera follow the player

LevelCompleted.cs : makes transitions between levels

EndTrigger.cs : triggers Credits.cs

ColorChange.cs : handels main menu cube color changing

MovingObstacleScript.cs : makes obstacles move from left to right without falling down.

StoneTrapTrigger.cs : Makes obstacles fall from the sky after hitting a trigger point

#### Assets:
Most images (Skybox/Menuscreen) were taken from open source stock foto libs.

#### Copyright:
All scripts were handwritten by myself but had influence from the Youtuber "Brackeys". He provided mutliple unity tutorias.



