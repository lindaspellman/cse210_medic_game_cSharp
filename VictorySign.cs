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
    public class VictorySign : Actor
    {
        public VictorySign(int level)
        {
            _position = new Point(Constants.SIGN_POSITION_X - 120, Constants.SIGN_POSITION_Y);
            _text = $"Level {level} Complete!";

        }

        public void UpdateText(int points)
        {
            if (points >= 300)
            {
                _text = "";
            }
        }

        public override int GetFontSize()
        {
            return Constants.GAMEOVER_FONT_SIZE;
        }

    }
}
