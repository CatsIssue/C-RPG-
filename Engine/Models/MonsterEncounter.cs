using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class MonsterEncounter
    {
        public int MonsterID { get; set; }
        public int ChanceOfEncoutering { get; set; }
        public int ChanceOfEncountering { get; internal set; }

        public MonsterEncounter(int monsterID, int chanceOfEncoutering)
        {
            MonsterID = monsterID;
            ChanceOfEncoutering = chanceOfEncoutering;
        }
    }
}
