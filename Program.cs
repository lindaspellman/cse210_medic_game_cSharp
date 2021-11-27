using System;
using cse210_batter_csharp.Services;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Scripting;
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
            Point medicStar = new Point(Constants.MEDIC_X, Constants.MEDIC_Y);

            // Enemy //////////////////////////////////////////////////////////////

            // cast["enemies"] = new List<Actor>();
            // Enemy enemy = new Enemy();

            //Civilian ///////////////////////////////////////////////////////////

            // cast["civilians"] = new List<Actor>();
            // Civilian civilian = new Civilian();

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.
            // MoveActorsAction moveActorsAction = new MoveActorsAction();
            // script["update"].Add(moveActorsAction);

            // HandleOffScreenAction handleOffScreenAction = new HandleOffScreenAction();
            // script["update"].Add(handleOffScreenAction);

            // ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            // script["input"].Add(controlActorsAction);

            // HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            // script["update"].Add(handleCollisionsAction);

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Medic", Constants.FRAME_RATE);
            // audioService.StartAudio();
            // audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            // audioService.StopAudio();
        }
    }
}
