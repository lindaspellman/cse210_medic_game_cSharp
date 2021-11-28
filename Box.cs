using System;

namespace cse210_medic_game_cSharp
{
    /// <summary>
    /// Represents a square in the snakes body.
    /// </summary>
    class Box : Actor
    {
        
        public Box(Point position, Point velocity)
        {
            _position = position;
            _velocity = velocity;
        }
        
    }

}