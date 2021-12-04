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
    public class Medic : Actor 
    {
        public Medic()
        {
            // int x = Constants.MAX_X / 2;
            // int y = Constants.MAX_Y / 2;

            SetHeight(Constants.MEDIC_HEIGHT);
            SetWidth(Constants.MEDIC_WIDTH);

            Point position = new Point(Constants.MEDIC_X, Constants.MEDIC_Y);
            // Point velocity = new Point(0, 0);

            SetPosition(position);

            // Point position = new Point(Constants.MEDIC_X, Constants.MEDIC_Y);
            // SetPosition(position);
        }

    }
}
