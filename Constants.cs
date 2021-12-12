using System;

namespace cse210_medic_game_cSharp
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        // POINTS 
        public const int VICTORY_POINTS = 300;
        public const int STARTING_POINTS = 50;
        public const int ENEMY_POINTS = -30; //Original: -20 // Trying to lose with -40
        public const int CIVILIAN_POINTS = 15; //Original: 15 // Trying to win with 50

        // DEFAULTS //////////////////////////////////////////////////////////////////////////
        public const int MAX_X = 800;
        public const int MAX_Y = 600;
        public const int FRAME_RATE = 30;

        public const int MINIMUM_SPEED = 4;
        public const int MAXIMUM_SPEED = 9;
        public const int DEFAULT_SQUARE_SIZE = 20;

        public const int DEFAULT_FONT_SIZE = 30;
        public const int GAMEOVER_FONT_SIZE = 60;
        public const int DEFAULT_TEXT_OFFSET = 4;
        public const int SIGN_POSITION_X = Constants.MAX_X / 2 - Constants.GAMEOVER_FONT_SIZE * 2;
        public const int SIGN_POSITION_Y = Constants.MAX_Y / 2 - Constants.GAMEOVER_FONT_SIZE / 2;
        public const int INVUlNERABILITY_FRAME_COUNT = 120;
        public const int POWER_UP_INTERVAL = 600;
        public const string IMAGE_POWERUP = "./Assets/powerup_square.png";



        // CIVILIAN //////////////////////////////////////////////////////////////////////////////////
        public const int CIVILIAN_WIDTH = 30;
        public const int CIVILIAN_HEIGHT = 30;
        public const int CIVILIAN_SPACE = 5;
        public const int CIVILIANS_PRESENT = 12;
        public const string IMAGE_CIVILIAN = "./Assets/civilian_square.png";


        // MEDIC //////////////////////////////////////////////////////////////////////////////////
        public const int MEDIC_X = MAX_X / 2;
        public const int MEDIC_Y = MAX_Y - 25;
        public const int MEDIC_SPEED = 15;
        public const int MEDIC_WIDTH = 25;
        public const int MEDIC_HEIGHT = 25;

        public const string IMAGE_MEDIC_BLUE = "./Assets/.png";
        public const string IMAGE_MEDIC_VIOLET = "./Assets/.png";



        // ENEMY ///////////////////////////////////////////////////////////////////////////////////
        public const int ENEMY_WIDTH = 25;
        public const int ENEMY_HEIGHT = 25;
        public const int ENEMY_SPACE = 5;
        public const int ENEMIES_PRESENT = 3;
        public const int ENEMY_FRACTION = 5;
        public const string IMAGE_ENEMY = "./Assets/enemy_square.png";


        // SOUND ASSETS ////////////////////////////////////////////////////////////////////////////////////
        public const string SOUND_START = "./Assets/start.wav";
        // public const string SOUND_START = "./Assets/mixkit-ominous-drums-227.wav"; // start sound

        // public const string SOUND_START = "./Assets/mixkit-arcade-game-complete-or-approved-mission-205.wav"; // I don't really like it???

        public const string SOUND_CIV_EN_COLLISION = "./Assets/mixkit-electronic-retro-block-hit-2185.wav"; // enemy hits civilians.
        public const string SOUND_CIVILIAN_COLLISION = "./Assets/mixkit-game-ball-tap-2073.wav"; // medic hits civilians. :D
        public const string SOUND_POWERUP_COLLISION = "./Assets/mixkit-extra-bonus-in-a-video-game-2045.wav"; // medic hits power up
        public const string SOUND_ENEMY_COLLISION = "./Assets/mixkit-quick-positive-video-game-notification-interface-265.wav"; // medic hit enemies

        // public const string SOUND_CIVILIAN_COLLISION = "./Assets/mixkit-bubbly-achievement-tone-3193.wav"; // hit civilians. Not happy with it.
        // public const string SOUND_CIVILIAN_COLLISION = "./Assets/mixkit-extra-bonus-in-a-video-game-2045.wav"; // hit civilians. Meh.
        // public const string SOUND_CIVILIAN_COLLISION = "./Assets/mixkit-small-hit-in-a-game-2072.wav"; // hit civilians. Lil annoying
        // public const string SOUND_CIVILIAN_COLLISION = "./Assets/mixkit-video-game-treasure-2066.wav"; // hit civilians. No.

        // public const string SOUND_GAME_OVER = "./Assets/mixkit-player-losing-or-failing-2042.wav"; // game over 
        

        
    }

}