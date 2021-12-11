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
    public class DefeatSign : Actor
    {
        public DefeatSign(int level)
        {
            _position = new Point(Constants.SIGN_POSITION_X, Constants.SIGN_POSITION_Y - 30);
            _text = $"Game Over!\nScore = {level - 1}";
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
