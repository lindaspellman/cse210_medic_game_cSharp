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
    public class MoveActorsAction : Action
    {
        public MoveActorsAction()
        {
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor actor in group)
                {
                    MoveActor(actor);
                }
            }
        }

        private void MoveActor(Actor actor)
        {
            int x = actor.GetX();
            int y = actor.GetY();

            int dx = actor.GetVelocity().GetX();
            int dy = actor.GetVelocity().GetY();

            int newX = (x + dx);
            int newY = (y + dy);

            actor.SetPosition(new Point(newX, newY));
        }

    }
}
