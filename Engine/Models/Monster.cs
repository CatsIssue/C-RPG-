using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : BaseNotificationClass // for to be able to use OnPropertyChanged to notify the UI
    {
        private int _hitPoints; // points to hit for kill monster

        public string Name { get; private set; }
        public string ImageName { get; set; } // where keep image
        public int MaximumHitPoints { get; private set; }

        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                onPropertyChanged(nameof(HitPoints));
            }
        }

        public int RewardExperiencePoints { get; private set; } // Reward when win
        public int RewardGold { get; private set; }
        
        public ObservableCollection<ItemQuantity> Inventory { get; set; } // Inventory of the monster has

        public Monster(string name, string imageName, int maximumHitPoints, 
            int hitPoints, int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = string.Format("/Engine;component/Images/Monsters/{0}", imageName); // take name of file from imageName 
            MaximumHitPoints = maximumHitPoints;
            HitPoints = hitPoints;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }

    }
}
