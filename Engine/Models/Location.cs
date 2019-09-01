using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public List<Quest> QuestsAvailableHere { get; set; } = new List<Quest>();

        public List<MonsterEncounter> MonstersHere { get; set; } = new List<MonsterEncounter>();

        public void AddMonster(int monsterID, int chanceOfEncountering) // function that add monster and check if it there before add
        {
            if (MonstersHere.Exists(m => m.MonsterID == monsterID))
            {
                // This monster has already been added to the location
                // overwrite chance of encountering 
                MonstersHere.First(m => m.MonsterID == monsterID)
                    .ChanceOfEncoutering = chanceOfEncountering;
            }
            else
            {
                // This Monster not already in that location
                MonstersHere.Add(new MonsterEncounter(monsterID, chanceOfEncountering));
            }
        }

        public Monster GetMonster()
        {
            if (!MonstersHere.Any()) // if no monsters encounter objects 
            {
                return null;
            }

            // Toatal the percentages of all monsters at this locations , monsters at this location 
            int totalChances = MonstersHere.Sum(m => m.ChanceOfEncoutering);

            // Select the random number between 1 and the total
            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalChances);


            int runningTotal = 0;

            foreach (MonsterEncounter monsterEncounter in MonstersHere)
            {
                runningTotal += monsterEncounter.ChanceOfEncoutering;
                
                // chance of encountering on last monster more than on first
                if (randomNumber <= runningTotal)
                {
                    return MonsterFactory.GetMonster(monsterEncounter.MonsterID);
                }

            }

            // if no return any monster for assure return last monster  
            return MonsterFactory.GetMonster(MonstersHere.Last().MonsterID);
        }
    }
}
