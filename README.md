# Stack Mouth Game


In the game, the character is constantly moving and the direction changes as the mouse moves left and right. Pies and donuts are collectibles. As an obstacle, there is a cactus. The character's mouth gets bigger as character collides donuts and pies, and gets smaller as character collides cactus.

There are 4 scripts:


![Player components](https://user-images.githubusercontent.com/36795459/137100051-443f326d-8ccc-4ab3-970a-43b1d8c401cd.jpg)

PlayerMovement - This class ensures that the character moves along a certain axis throughout the game. In addition, as the mouse scrolls to the screen, the character moves in the right and left directions(swerving mechanic). The character's speed, maximum and minimum x-axis can be edited on the Unity editor.

CollectItem – Collectible items include donuts and pies. There is a cactus as an obstacle. The character gets bigger or smaller when character collides them. Thanks to this script, it does what action it should take when character collides which item.

StackingItem - Contains the character's growth and shrinkage functions.

GameOver – Includes GameOver function.

![CineMachine](https://user-images.githubusercontent.com/36795459/137099997-7bf5ac96-bf57-4891-b976-1b1eaa396c5f.jpg)

I also made it using the Cinemachine tool to follow the character by the camera. The relevant link is below.

https://unity.com/unity/features/editor/art-and-design/cinemachine

Finally, The gameplay video is below.


https://user-images.githubusercontent.com/36795459/137100918-1c488bfa-1168-4c22-bc54-6b75aed0c5d2.mp4

