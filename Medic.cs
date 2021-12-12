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

            SetHeight(Constants.MEDIC_HEIGHT);
            SetWidth(Constants.MEDIC_WIDTH);

            Point position = new Point(Constants.MEDIC_X, Constants.MEDIC_Y);

            SetPosition(position);

        }

    }
}
