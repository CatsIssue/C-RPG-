using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;


namespace Engine.Models.viewModels
{
   public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();

            CurrentPlayer.Name = "Scott";
            CurrentPlayer.CharacterClass = "Fihter";
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold  = 10000000;


        }
    }
}
