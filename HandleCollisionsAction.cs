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
            List<Actor> civilians = cast["civilians"]; // Get all the civilians
            List<Actor> medic = cast["medic"]; // Only one 
            List<Actor> enemies = cast["enemies"]; // Get all the enemies
            List<Actor> scoreboard = cast["scoreboard"]; // Only one

            ScoreBoard sb = (ScoreBoard)scoreboard[0];

            List<Actor> toRemoveEnemies = new List<Actor>();
            List<Actor> toRemoveCivilians = new List<Actor>();
            // List<Actor> toRemoveMedic = new List<Actor>();

            ///

            foreach (Actor c in civilians)
            {
                if (_physicsService.IsCollision(medic[0], c))
                {
                    Civilian civilian = (Civilian)c;
                    _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    toRemoveCivilians.Add(civilian);
                    sb.AddPoints(Constants.CIVILIAN_POINTS);
                }
            }
            foreach (Civilian civ in toRemoveCivilians)
            {
                civilians.Remove(civ);
                Civilian civilian = new Civilian();
                civilians.Add(civilian);
            }
                
            // ///

            foreach (Actor e in enemies)
            {
                if(_physicsService.IsCollision(medic[0], e))
                {
                    Enemy enemy = (Enemy)e;
                    _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    sb.AddPoints(Constants.ENEMY_POINTS);
                    toRemoveEnemies.Add(enemy);
                }
            }

            foreach (Enemy en in toRemoveEnemies)
            {
                enemies.Remove(en);
                Enemy enemy = new Enemy();
                enemies.Add(enemy);
            }
            
            // ///

            foreach (Civilian civ in civilians)
            {
                foreach (Enemy e in enemies)
                {
                    if (_physicsService.IsCollision(civ, e))
                    {
                        Civilian civilian = (Civilian)civ;
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                        toRemoveCivilians.Add(civilian);
                    }
                }
            }
            foreach (Civilian civ in toRemoveCivilians)
            {
                civilians.Remove(civ);
                if (civilians.Count < Constants.CIVILIANS_PRESENT)
                {
                    Civilian civilian = new Civilian();
                    civilians.Add(civilian);
                }
            }
        }
    }
}
