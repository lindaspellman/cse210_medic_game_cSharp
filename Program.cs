using System;
using System.Collections.Generic;

namespace cse210_medic_game_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();
            // Medic

            cast["medic"] = new List<Actor>();
            Medic medic = new Medic();
            cast["medic"].Add(medic);

            // Enemy //////////////////////////////////////////////////////////////

            cast["enemies"] = new List<Actor>();
            
            for (int numEnemies = 0; numEnemies < Constants.ENEMIES_PRESENT; numEnemies++)
            {
                Enemy enemy = new Enemy();
                cast["enemies"].Add(enemy);
            }

            //Civilian ///////////////////////////////////////////////////////////

            cast["civilians"] = new List<Actor>();

            for (int x = 0; x < Constants.CIVILIANS_PRESENT; x++)
            {
                Civilian civilian = new Civilian();

                cast["civilians"].Add(civilian);
            }

            cast["powerUps"] = new List<Actor>();
            

            cast["scoreboard"] = new List<Actor>();
            ScoreBoard scoreBoard = new ScoreBoard();
            cast["scoreboard"].Add(scoreBoard);

            cast["levelSign"] = new List<Actor>();
            LevelSign levelSign = new LevelSign();
            cast["levelSign"].Add(levelSign);

            // Create the script ///////////////////////////////////////////////////////////
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            // Services ////////////////////////////////////////////////////////////////////

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            // Actions //////////////////////////////////////////////////////////////////////
            
            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);
            
            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            HandleOffScreenAction handleOffScreenAction = new HandleOffScreenAction();
            script["update"].Add(handleOffScreenAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["input"].Add(controlActorsAction);

            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            script["update"].Add(handleCollisionsAction);

            // Start up the game ///////////////////////////////////////////////////////////////////////
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Medic", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}
