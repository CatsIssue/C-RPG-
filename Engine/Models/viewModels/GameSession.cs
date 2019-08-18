using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.Models.viewModels
{
   public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();

            CurrentPlayer.Name = "Scott";
            CurrentPlayer.CharacterClass = "Fihter";
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold  = 10000000;

            CurrentWorld.AddLocation(0, -1, "Home", "This is your house", "/Engine;component/Images/Locations/Home.png");
            CurrentLocation = CurrentWorld.LocationAt(0, -1);

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

        }
    }
}
