using System;
using System.Collections.Generic;

namespace cse210_medic_game_cSharp
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        private bool _keepPlaying = true;
        private Dictionary<string, List<Actor>> _cast;
        private Dictionary<string, List<Action>> _script;
        private int _points;
        private int _currentLevel;
        // private int _newLevel;
        private bool countDown = false;
        private int frameCount = 150;
        // AudioService _audioService = new AudioService();


        public Director(Dictionary<string, List<Actor>> cast, Dictionary<string, List<Action>> script)
        {
            _cast = cast;
            _script = script;
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void Direct()
        {
            // bool countDown = false;
            // int frameCount = 150;

            while (_keepPlaying)
            {
                CueAction("input");
                CueAction("update");
                CueAction("output");

                List<Actor> scoreboard = _cast["scoreboard"]; // Only one
                ScoreBoard sb = (ScoreBoard)scoreboard[0];

                List<Actor> levelSign = _cast["levelSign"]; // Only one
                LevelSign ls = (LevelSign)levelSign[0];

                if (sb.GameOver())
                {
                    if (countDown == false)
                    {
                        countDown = true;
                    }
                    else 
                    {
                        
                        frameCount--;

                        _points = sb.GetPoints();
                        _currentLevel = ls.GetLevelNum();
                        
                        if (_points <= 0)
                        {
                            
                            _cast["defeatSign"] = new List<Actor>();
                            DefeatSign defeatSign = new DefeatSign(_currentLevel);
                            _cast["defeatSign"].Add(defeatSign);

                            if (frameCount <= 0)
                            {
                                
                                _keepPlaying = false;
                            }
                        }

                        if (_points >= Constants.VICTORY_POINTS)
                        {
                            
                            _cast["victorySign"] = new List<Actor>();
                            VictorySign victorySign = new VictorySign(_currentLevel);
                            _cast["victorySign"].Add(victorySign);

                            List<Actor> victSign = _cast["victorySign"]; // Only one
                            VictorySign vs = (VictorySign)victSign[0];

                            if (frameCount <= 0)
                            {
                                sb.ResetScore();
                                Enemy enemy = new Enemy();
                                _cast["enemies"].Add(enemy);
                                ResetFrameCount();
                                ls.IncreaseLevel(_currentLevel);
                                vs.UpdateText(_points);
                            }
                        }
                    }

                    

                    if (Raylib_cs.Raylib.WindowShouldClose())
                    {
                        _keepPlaying = false;
                    }

                    // level system: when frameCount gets to 0, reset score, increment enemies, reset frameCount
                }
                Invulnerability.count++;
                int randomRoll = Invulnerability.randomGenerator.Next(0, Constants.POWER_UP_INTERVAL);
                if (randomRoll < _currentLevel / 2 || Invulnerability.count == Constants.POWER_UP_INTERVAL)
                {
                    Invulnerability.count = 0;
                    PowerUp powerUp = new PowerUp();
                    _cast["powerUps"].Add(powerUp);
                }
            }

            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Executes all of the actions for the provided phase.
        /// </summary>
        /// <param name="phase"></param>
        private void CueAction(string phase)
        {
            List<Action> actions = _script[phase];

            foreach (Action action in actions)
            {
                action.Execute(_cast);
            }

        }

        public void ResetFrameCount()
        {
            frameCount = 150;
        }

    }
}
