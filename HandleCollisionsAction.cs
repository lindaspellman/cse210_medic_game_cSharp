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
    public class HandleCollisionsAction : Action 
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService = new AudioService();

        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> civilians = cast["civilian"]; // Get all the civilians
            List<Actor> medic = cast["medic"]; // Only one 
            List<Actor> enemies = cast["enemy"]; // Get all the enemies
            List<Actor> toRemoveEnemies = new List<Actor>();
            List<Actor> toRemoveCivilians = new List<Actor>();
            List<Actor> toRemoveMedic = new List<Actor>();

            ///

            // foreach (Actor c in civilians)
            // {
            //     if (_physicsService.IsCollision(medic, c))
            //     {
            //         Civilian civilian = (Civilian)c;
            //         _audioService.PlaySound(Constants.SOUND_BOUNCE);
            //         toRemoveCivilians.Add(civilian);
            //     }
            // }
            // foreach (Civilian civ in toRemoveCivilians)
            // {
            //     civilians.Remove(civ);
            // }
                
            // ///

            // foreach (Actor e in enemies)
            // {
            //     if(_physicsService.IsCollision(medic, e))
            //     {
            //         Enemy e = (Enemy)enemy;
            //         _audioService.PlaySound(Constants.SOUND_BOUNCE);
            //         toRemoveEnemies.Add(e);
            //     }
            // }

            // foreach (Enemy en in toRemoveEnemies)
            // {
            //     enemies.Remove(en);
            // }
            
            // ///

            // if (_physicsService.IsCollision(medic, enemies))
            // {
            //     Civilian civilian = (Civilian)c;
            //     _audioService.PlaySound(Constants.SOUND_BOUNCE);
            //     toRemoveMedic.Add(medic);
            // }
            // foreach (Medic m in toRemoveMedic)
            // {
            //     medic.Remove(m);
            // }
        }
    }
}
