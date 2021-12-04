using System;

namespace cse210_medic_game_cSharp
{
    /// <summary>
    /// The score board in the top portion of the game.
    /// </summary>
    class ScoreBoard : Actor
    {
        private int _points = Constants.STARTING_POINTS;

        public ScoreBoard()
        {
            _position = new Point(20, 20);
            _width = 0;
            _height = 0;
            
            UpdateText();
        }

        /// <summary>
        /// Increments the points by the amount specified and updates the
        /// text.
        /// </summary>
        /// <param name="points"></param>
        public void AddPoints(int points)
        {
            _points += points;
            UpdateText();
        }

        /// <summary>
        /// Updates the text to reflect the new points amount.
        /// This should be called whenever the points are updated.
        /// </summary>
        private void UpdateText()
        {
            _text = $"Score: {_points}";
            if (_points <= 0)
            {
                _position = new Point(Constants.MAX_X / 2 - Constants.GAMEOVER_FONT_SIZE * 2, Constants.MAX_Y / 2 - Constants.GAMEOVER_FONT_SIZE / 2);
                _text = $"Defeat!";
            }
            if (_points >= Constants.VICTORY_POINTS)
            {
                _position = new Point(Constants.MAX_X / 2 - Constants.GAMEOVER_FONT_SIZE * 2, Constants.MAX_Y / 2 - Constants.GAMEOVER_FONT_SIZE / 2);
                _text = $"Victory!";
            }
        }

        public bool GameOver()
        {
            if (_points <= 0 || _points >= Constants.VICTORY_POINTS)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public override int GetFontSize()
        {
            if (GameOver())
            {
                return Constants.GAMEOVER_FONT_SIZE;
            }
            return Constants.DEFAULT_FONT_SIZE;
        }
    }

}