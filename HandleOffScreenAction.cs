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

            if (x > Constants.MAX_X - Constants.MEDIC_WIDTH)
            {
                x = Constants.MAX_X - Constants.MEDIC_WIDTH;
            }

            if (x < 0)
            {
                x = 0;
            }

            if (y > Constants.MAX_Y - Constants.MEDIC_HEIGHT)
            {
                y = Constants.MAX_Y - Constants.MEDIC_HEIGHT;
            }

            if (y < 0)
            {
                y = 0;
            }

            medic.SetPosition(new Point(x, y));

            foreach (Actor enemy in cast["enemies"])
            {
                int ex = enemy.GetX();
                int ey = enemy.GetY();

                int edx = enemy.GetVelocity().GetX();
                int edy = enemy.GetVelocity().GetY();

                if (ex > Constants.MAX_X - Constants.ENEMY_WIDTH)
                {
                    edx = -edx;
                    ex = Constants.MAX_X - Constants.ENEMY_WIDTH;
                }

                if (ex < 0)
                {
                    edx = -edx;
                    ex = 0;
                }

                if (ey > Constants.MAX_Y - Constants.ENEMY_HEIGHT)
                {
                    edy = -edy;
                    ey = Constants.MAX_Y - Constants.ENEMY_HEIGHT;
                }

                if (ey < 0)
                {
                    edy = -edy;
                    ey = 0;
                }

                enemy.SetPosition(new Point(ex, ey));
                enemy.SetVelocity(new Point(edx, edy));
            }
        
        }
    }
}
