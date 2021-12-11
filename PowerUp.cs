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
    public class PowerUp : Actor 
    {
        Random randomGenerator = new Random();
        
        public PowerUp()
        {
            int randomX = randomGenerator.Next(Constants.CIVILIAN_SPACE, Constants.MAX_X - Constants.CIVILIAN_WIDTH - Constants.CIVILIAN_SPACE);
            int randomY = randomGenerator.Next(Constants.CIVILIAN_SPACE, Constants.MAX_Y - Constants.CIVILIAN_HEIGHT - Constants.CIVILIAN_SPACE);
            Point _point = new Point(randomX, randomY);
            SetPosition(_point);

            SetHeight(Constants.CIVILIAN_HEIGHT);
            SetWidth(Constants.CIVILIAN_WIDTH);
        }

    }
}
