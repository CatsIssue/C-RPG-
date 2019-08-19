using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        private int _experiencePoint;
        private string _characterClass;
        private int _level;
        private string _name;
        private int _gold;
        private int _hitPoints;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                onPropertyChanged(nameof(Name));
            }
        }
        public string CharacterClass
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                onPropertyChanged(nameof(CharacterClass));
            }
        }
        public int ExperiencePoints
        {
            get { return _experiencePoint; }
            set
            {
                _experiencePoint = value;
                onPropertyChanged(nameof(ExperiencePoints));
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                onPropertyChanged(nameof(Level));
            }
        }

        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                onPropertyChanged(nameof(Gold));
            }
        }
        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                onPropertyChanged(nameof(HitPoints));
            }
        }

        
    }
}
