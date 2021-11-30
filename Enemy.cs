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
    public class Enemy : Actor 
    {
        public Enemy()
        {
            int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y / 2;

            SetHeight(Constants.ENEMY_HEIGHT);
            SetWidth(Constants.ENEMY_WIDTH);

            Point position = new Point(500, 500);
            Point velocity = new Point(0, 0);

            SetPosition(position);

            

            // Point position = new Point(Constants.MEDIC_X, Constants.MEDIC_Y);
            // SetPosition(position);
        }
    }
}
