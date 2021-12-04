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
        Random randomGenerator = new Random();
        public Enemy()
        {
            // set random velocity
            int dy = randomGenerator.Next(Constants.MINIMUM_SPEED, Constants.MAXIMUM_SPEED);
            int dx = randomGenerator.Next(Constants.MINIMUM_SPEED, Constants.MAXIMUM_SPEED);
            _fractionalMovement = new Point(0,0);
            _velocity = new Point(dx,dy);

            // set random position
            int randomX = randomGenerator.Next(Constants.ENEMY_SPACE, Constants.MAX_X);
            int randomY = randomGenerator.Next(Constants.ENEMY_SPACE, Constants.MAX_Y);
            Point _point = new Point(randomX, randomY);
            SetPosition(_point);
            
            // create box
            SetHeight(Constants.ENEMY_HEIGHT);
            SetWidth(Constants.ENEMY_WIDTH);
        }

        public override void MoveNext()
        {
            int x;
            int y;
            // slowing the velocity by a fraction of a enemy
            _fractionalMovement = _fractionalMovement.Add(_velocity);

            if (_fractionalMovement.GetX() > Constants.ENEMY_FRACTION)
            {
                x = _position.GetX();
                x += _fractionalMovement.GetX() / Constants.ENEMY_FRACTION;

                y = _position.GetY();
                _position = new Point(x, y);

                x = _fractionalMovement.GetX();
                x %= Constants.ENEMY_FRACTION;

                y = _fractionalMovement.GetY();
                _fractionalMovement = new Point(x, y);
            }
            else
            {
                if (_fractionalMovement.GetX() < -Constants.ENEMY_FRACTION)
                {
                    x = _position.GetX();
                    x -= _fractionalMovement.GetX() / Constants.ENEMY_FRACTION;

                    y = _position.GetY();
                    _position = new Point(x, y);

                    x = _fractionalMovement.GetX();
                    x %= Constants.ENEMY_FRACTION;

                    y = _fractionalMovement.GetY();
                    _fractionalMovement = new Point(x, y);
                }
            }

            if (_fractionalMovement.GetY() > Constants.ENEMY_FRACTION)
            {
                y = _position.GetY();
                y += _fractionalMovement.GetY() / Constants.ENEMY_FRACTION;
                
                x = _position.GetX();
                _position = new Point(x, y);

                y = _fractionalMovement.GetY();
                y %= Constants.ENEMY_FRACTION;
                
                x = _fractionalMovement.GetX();
                _fractionalMovement = new Point(x, y);
            }
            else
            {
                if (_fractionalMovement.GetY() < -Constants.ENEMY_FRACTION)
                {
                    y = _position.GetY();
                    y -= _fractionalMovement.GetY() / Constants.ENEMY_FRACTION;
                    
                    x = _position.GetX();
                    _position = new Point(x, y);

                    y = _fractionalMovement.GetY();
                    y %= Constants.ENEMY_FRACTION;
                    
                    x = _fractionalMovement.GetX();
                    _fractionalMovement = new Point(x, y);
                }
            }
        }
    }
}
