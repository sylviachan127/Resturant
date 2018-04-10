We chose to design a standard bar & grill restaurant. Each member of our team had different responsibilities:
Cheng Hann: Parking lot/back-end code
Sylvia: Main dining area
Rupert: Bar

Note: An additional keybind, left shift, has been added to the character controller. It makes the character run, increasing movement speed while held. All other controls are unmodified from the initial package.

Sounds that are present throughout the entire scene:
-Footsteps that increase in frequency as the player moves faster.
-Sounds for hitting walls. The volume at which these sounds are played depends on the velocity of the player as contact is made with the wall. There is also a more metallic sound when hitting a car.


Scenario description:
Everywhere
-When the player walks, footstep sounds are played. These sounds play more frequently as the player moves faster (i.e., by running) to sonify the player's movement speed. They cease to play if the player is blocked by an obstacle or not moving at all; along with adhering to common sense, this also provides an additional indicator that the player has collided with a wall if the player does not pay attention to the wall hit sound.
-A collision sound plays if the player bumps into an obstacle. The volume of the sound is proportional to the speed at which the player collides with the object. There are two different sounds: a generic wood hit sound for a wall/table and a more metallic sound for a car.

Parking lot
-The main object of interest in the parking lot is a car that moves around the lot in a rectangular path. If the player is in front of the car, the car will abruptly screech to a halt, with a skidding/honking sound being played. This is meant to alarm the player, as walking in front of a moving car is obviously not safe. The car also has a persistent engine sound that changes based on the speed of the car. This is mainly noticeable as the car speeds up after stopping. The engine sound also doubles as an indicator for when the car is not moving, as it does not play while the car is stopped.
-Other parked cars simply play the car collisiion sound when collided with.-There is a person walking to and from the restaurant, generating periodic footstep noises. He is alone, so he does not need to talk to anyone.-There is an ambient sound of trees rustling in the wind while the player is in the parking lot.
-There is an reverb zone encompassing the parking lot, set to the built-in "parking lot" reverb settings.

Main dining area
-When first coming in, there is a receptionist who greets the player by asking if the player has a reservation. If the player is not nearby, the doorman also plays from a small selection of other sound clips. He moves around between the doorway and the reception desk, greeting guests and handling reservations.
-Four tables are located in the dining area. Each has different people, including a family chatting, waitresses taking orders, and another waitress setting tables (moving between and around them). As this is a lively bar and grill, the conversations are all light-hearted and casual, not too calm or too serious.
-One of the tables has a baby making playful baby noises. However, if the player gets too close to the baby or commits the socially unacceptable act of standing on the table that it's at, it will be frightened and begin to cry for a while. The baby is another indicator that the environment is casual enough for young people to be present.
-There is a kitchen door with various cooking sounds playing from a sound bank. It lets the player know that a restricted area is nearby which should not (and cannot) be entered.
-A band is playing music in the corner of the room. It adds to the casual atmosphere by providing a more soothing sound than just the ambient crowd chatter.
-There is an ambient "crowd chatter" sound that is present when the player is in the restaurant. This keeps the restaurant sounding busy and upbeat.
-There is a reverb zone around the restaurant. It emulates a building's reverb.

Bar
-A bartender moves around behind the bar counter, pouring drinks into glasses for customers.
-Various customers are drinking alcohol and having a good time. Several people are laughing, as they have had a few drinks and are under the influences of alcohol.
-A service bell on the counter can be approached to play a distinctive bell sound, as if the player pressed the bell.


Sources:
Everywhere
-Footstep: https://www.freesound.org/people/Yoyodaman234/sounds/166508/
-Wall Hit: https://www.freesound.org/people/zerolagtime/sounds/245033/

Parking lot
-Car Engine: https://www.freesound.org/people/qubodup/sounds/147242/
-Car Hit: https://www.freesound.org/people/Kane53126/sounds/257947/
-Car Stop: Combination of https://www.freesound.org/people/alukahn/sounds/144137/ and http://soundbible.com/262-Car-Screech-And-Crash.html
-Outside Ambience: https://www.freesound.org/people/Jeffreys2/sounds/137023/

Main dining area
-Baby Crying: https://www.freesound.org/people/eguaus/sounds/321712/
-Baby Talk - http://www.freesound.org/people/klankbeeld/sounds/198407/
-Boiling: https://www.freesound.org/people/superandy/sounds/167477/
-Chopping: https://www.freesound.org/people/ancorapazzo/sounds/181612/
-Ding: https://www.freesound.org/people/gloriaeffect/sounds/108428/
-Grill: https://www.freesound.org/people/Ch0cchi/sounds/15292/
-Group Chat: https://www.youtube.com/watch?v=76I9sUPgko4
-Holly Dunn - Daddy's Hands: https://www.youtube.com/watch?v=Y5AdgQQ2j70
-Man Order Steak - https://www.youtube.com/watch?v=GLACfxlmfT4
-People Order Drinks - https://www.youtube.com/watch?v=S1CfItpKg7c
-Restaurant Ambience: http://www.freesound.org/people/Leandros.Ntounis/sounds/163995/
-Setting Table - http://www.freesound.org/people/Handfan/sounds/71236/
-Waiter Speech: http://www.freesound.org/people/SamKolber/sounds/210032/

Bar
-Cheers: Manual recording
-Crowd Laugh: http://www.freesound.org/people/ondrosik/sounds/207797/
-Female Laugh: http://www.freesound.org/people/fmaudio/sounds/152997/
-Glass Clank: http://www.freesound.org/people/HDM2013/sounds/179438/
-Pouring Wine: http://www.freesound.org/people/Tobias_Sieben/sounds/194253/
-Service Bell: http://www.freesound.org/people/AlaskaRobotics/sounds/221515/