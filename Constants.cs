using System;

namespace cse210_medic_game_cSharp
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int VICTORY_POINTS = 300;
        public const int STARTING_POINTS = 50;
        public const int ENEMY_POINTS = -20;
        public const int CIVILIAN_POINTS = 15;


        public const int MAX_X = 800;
        public const int MAX_Y = 600;
        public const int FRAME_RATE = 30;

        public const int MINIMUM_SPEED = 4;
        public const int MAXIMUM_SPEED = 9;
        public const int ENEMY_FRACTION = 5;


        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 30;

        public const int GAMEOVER_FONT_SIZE = 100;
        public const int DEFAULT_TEXT_OFFSET = 4;

        // public const string IMAGE_BRICK = "./Assets/brick-3.png";
        // public const string IMAGE_PADDLE = "./Assets/bat.png";
        // public const string IMAGE_BALL = "./Assets/ball.png";

        public const string SOUND_START = "./Assets/start.wav";
        public const string SOUND_BOUNCE = "./Assets/boing.wav";
        public const string SOUND_OVER = "./Assets/over.wav";

        // public const int BALL_X = MAX_X / 2;
        // public const int BALL_Y = MAX_Y - 125;

        // public const int BALL_DX = 8;
        // public const int BALL_DY = BALL_DX * -1;

        public const int MEDIC_X = MAX_X / 2;
        public const int MEDIC_Y = MAX_Y - 25;

        public const int CIVILIAN_WIDTH = 30;
        public const int CIVILIAN_HEIGHT = 30;

        public const int CIVILIAN_SPACE = 5;

        public const int CIVILIANS_PRESENT = 12;

        public const int MEDIC_SPEED = 15;
        public const int MEDIC_WIDTH = 25;
        public const int MEDIC_HEIGHT = 25;

        public const int ENEMY_WIDTH = 25;
        public const int ENEMY_HEIGHT = 25;

        public const int ENEMY_SPACE = 5;

        public const int ENEMIES_PRESENT = 5;

        
        // public const int BALL_WIDTH = 24;
        // public const int BALL_HEIGHT = 24;
    }

}