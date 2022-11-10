# The Maze
##Overview of the Game:
The idea for the project was essentially PACMAN but in 3D, however unlike PACMAN, the game is in first person and the player cannot see the full maze. The goal of the game is for the player to get a score of 30 before getting caught by the shadow. The game is supposed to be a horror game, with the constant feeling of being chased.

##The main parts of the game are:
•	Player – collision with the points and the enemy. Is moved with WASD.
•	Camera – pivoting around the center. The player moves forward towards where the camera is looking.
•	Points – glowing, tilted, rotating cubes. The player needs 30 of these to win.
•	Enemy – the shadow, kills the player upon collision. Constantly chasing the player.
•	The maze – the game area. The player is unable to leave this area.

##Game features:
•	The game keeps track of the score.
•	High enough difficulty to not complete the game on the first try.
•	Ambient sound to help the theme.

##Project Parts:

###•	Scripts:
o	MovementSc – does so the player can move around. A part of being able to move the player.
o	LookSc – does so the player can look around. Another part of being able to move the player.
o	PointSc – rotates the point around itself and does so the player can pick it up. Communicates with CountingSc to count how many points the player has picked up.
o	CountingSc – makes the label that shows how many points have been picked up. Gets info from PointSc every time a point gets picked up. Also triggers the win function when a certain score has been achieved
o	ShadowSc – makes the enemy track and follow the player. Also looks for when the shadow has caught the player.
o	GameManager – got the win and game over functions. Makes the fitting UI appear with buttons for retry and quit.

###•	Models & Prefabs:
o	All from Unity Primitives.

###•	Materials:
o	All from Unity Primitives.

###•	Scenes:
o	The game is made up of a single scene.

###•	Sound:
o	Sound “Secrets Of The House On The Hill” (supposedly royalty free) from TuneTank. 

###•	Testing:
o	The game has been tested on Windows and Android. On Windows it works as intended, on android however the movement does not, so testing the remaining parts on android have been put on hold.

##Used Resources:
###FIRST PERSON MOVEMENT in Unity - FPS Controller
-	https://www.youtube.com/watch?v=_QajrabyTJc&ab_channel=Brackeys
###MAKING YOUR FIRST LEVEL in Unity with ProBuilder!
-	https://www.youtube.com/watch?v=YtzIXCKr8Wo&ab_channel=Brackeys
###Unity Tutorial | Coin Pickups
-	https://www.youtube.com/watch?v=XnKKaL5iwDM&ab_channel=BeepBoopIndie
###How to set the font size in GUI.Label
-	https://answers.unity.com/questions/137143/how-to-set-the-font-size-in-guilabel.html
###Sound from TuneTank
-	https://tunetank.com/scary/
