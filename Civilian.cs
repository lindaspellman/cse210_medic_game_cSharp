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
    public class Civilian : Actor 
    {
        public Civilian()
        {
            int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y / 2;

            SetHeight(Constants.CIVILIAN_HEIGHT);
            SetWidth(Constants.CIVILIAN_WIDTH);

            Point position = new Point(200, 300);
            Point velocity = new Point(0, 0);

            SetPosition(position);

            

            // Point position = new Point(Constants.MEDIC_X, Constants.MEDIC_Y);
            // SetPosition(position);
        }
    }
}
