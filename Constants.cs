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




        // CIVILIAN //////////////////////////////////////////////////////////////////////////////////
        public const int CIVILIAN_WIDTH = 30;
        public const int CIVILIAN_HEIGHT = 30;
        public const int CIVILIAN_SPACE = 5;
        public const int CIVILIANS_PRESENT = 12;

        // MEDIC //////////////////////////////////////////////////////////////////////////////////
        public const int MEDIC_X = MAX_X / 2;
        public const int MEDIC_Y = MAX_Y - 25;
        public const int MEDIC_SPEED = 15;
        public const int MEDIC_WIDTH = 25;
        public const int MEDIC_HEIGHT = 25;

        // ENEMY ///////////////////////////////////////////////////////////////////////////////////
        public const int ENEMY_WIDTH = 25;
        public const int ENEMY_HEIGHT = 25;
        public const int ENEMY_SPACE = 5;
        public const int ENEMIES_PRESENT = 3;
        public const int ENEMY_FRACTION = 5;

        // ASSETS ////////////////////////////////////////////////////////////////////////////////////
        // public const string SOUND_START = "./Assets/start.wav";
        // public const string SOUND_BOUNCE = "./Assets/boing.wav";
        // public const string SOUND_OVER = "./Assets/over.wav"; 
        // public const string IMAGE_BRICK = "./Assets/brick-3.png";
        // public const string IMAGE_PADDLE = "./Assets/bat.png";
        // public const string IMAGE_BALL = "./Assets/ball.png";
        
    }

}