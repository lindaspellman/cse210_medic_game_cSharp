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

        int invulnerabilityFrameCount = Constants.INVUlNERABILITY_FRAME_COUNT;

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
            List<Actor> powerUps = cast["powerUps"];

            ScoreBoard sb = (ScoreBoard)scoreboard[0];

            List<Actor> toRemoveEnemies = new List<Actor>();
            List<Actor> toRemoveCivilians = new List<Actor>();
            List<Actor> toRemovePowerUps = new List<Actor>();

            ///

            if (Invulnerability._invulnerable)
            {
                invulnerabilityFrameCount--;
                if (invulnerabilityFrameCount <= 0)
                {
                    Invulnerability._invulnerable = false;
                }
            }

            // Medic-PowerUp

            foreach (Actor p in powerUps)
            {
                if (_physicsService.IsCollision(medic[0], p))
                {
                    PowerUp powerUp = (PowerUp)p;
                    _audioService.PlaySound(Constants.SOUND_POWERUP_COLLISION);

                    toRemovePowerUps.Add(powerUp);
                    Invulnerability._invulnerable = true;
                    invulnerabilityFrameCount = 120;
                }
            }
            

            foreach (PowerUp pow in toRemovePowerUps)
            {
                powerUps.Remove(pow);
                
            }

            // Medic-Civilian
            
            foreach (Actor c in civilians)
            {
                if (_physicsService.IsCollision(medic[0], c))
                {
                    Civilian civilian = (Civilian)c;
                    _audioService.PlaySound(Constants.SOUND_CIVILIAN_COLLISION); 
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
                
            // Enemy-Medic

            foreach (Actor e in enemies)
            {
                if(!Invulnerability._invulnerable && _physicsService.IsCollision(medic[0], e))
                {
                    Enemy enemy = (Enemy)e;
                    _audioService.PlaySound(Constants.SOUND_ENEMY_COLLISION); 
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
            
            // Enemy-Civilian

            foreach (Civilian civ in civilians)
            {
                foreach (Enemy e in enemies)
                {
                    if (!Invulnerability._invulnerable && _physicsService.IsCollision(civ, e))
                    {
                        Civilian civilian = (Civilian)civ;
                        _audioService.PlaySound(Constants.SOUND_CIV_EN_COLLISION);
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
