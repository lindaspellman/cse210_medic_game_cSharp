using System;
using System.Collections.Generic;

namespace cse210_medic_game_cSharp
{
    /// <summary>
    /// 
    /// 
    /// Stereotype:
    ///     
    /// </summary>
    public class LevelSign : Actor
    {
        private int _levelNum = 1;
        private int _newLevel;

        
        public LevelSign()
        {
            _position = new Point(600, 20);
            _width = 0;
            _height = 0;
            
            UpdateText();
        }

        /// <summary>
        /// Increments the level by 1 and updates the
        /// text.
        /// </summary>
        /// <param name="points"></param>
        public void IncreaseLevel(int level)
        {
            _levelNum = level;
            _newLevel = _levelNum++;
            UpdateText();
        }

        /// <summary>
        /// Updates the text to reflect the new points amount.
        /// This should be called whenever the points are updated.
        /// </summary>
        private void UpdateText()
        {
            _text = $"Level: {_levelNum}";
        }

        public int GetLevelNum()
        {
            return _levelNum; 
        }

        public override int GetFontSize()
        {
            // if (GameOver())
            // {
            //     return Constants.GAMEOVER_FONT_SIZE - 50;
            // }
            return Constants.DEFAULT_FONT_SIZE;
        }

    }
}
