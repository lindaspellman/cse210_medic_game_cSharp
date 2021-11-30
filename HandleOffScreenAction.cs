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
    public class HandleOffScreenAction : Action 
    {
        //OutputService _outputService = new OutputService();
        public HandleOffScreenAction()
        {

        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor medic = cast["medic"][0]; // There is only one

            int x = medic.GetX();
            int y = medic.GetY();

            int dx = medic.GetVelocity().GetX();
            int dy = medic.GetVelocity().GetY();

            if (x > Constants.MAX_X || x < 0)
            {
                dx = -dx;
            }

            if (y > Constants.MAX_Y || y < 0)
            {
                dy = -dy;
            }

            medic.SetVelocity(new Point(dx, dy));
        
        }
    }
}
