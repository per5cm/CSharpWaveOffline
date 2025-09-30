using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vpets.Models.Base

{
    public abstract class Creature // 
    {
        private int _oxygen, _hunger, _energy, _mood;
        protected const int MaxValue = 100;
        protected const int MinValue = 0;
        // Object Fields (zur Speicherung von Daten)
        public string Name { get; set; }
        public int Oxygen
        {
            get { return _oxygen; }
            set { _oxygen = Math.Clamp(value, MinValue, MaxValue); }
        }
        public int Hunger
        {
            get { return _hunger; }
            set { _hunger = Math.Clamp(value, MinValue, MaxValue); }
        }
        public int Energy
        {
            get { return _energy; }
            set { _energy = Math.Clamp(value, MinValue, MaxValue); }
        }
        public int Mood
        {
            get { return _mood; }
            set { _mood = Math.Clamp(value, MinValue, MaxValue); }
        }

        protected static int Clamp(int v) => v < 0 ? 0 : (v > MaxValue ? MaxValue : v);
        protected Creature(string name)
        {
            Name = name;
            Oxygen = 100;
            Hunger = 100;
            Energy = 100;
            Mood = 100;
        }

        public virtual void RefillOxygen()
        {
            Oxygen = Clamp(Oxygen + 50);
            Console.WriteLine($"{Name} wurde Sauerstoff erhöht. Sauerstoff = {Oxygen} ausgegeben.");
        }
        public virtual void Feed()
        {
            Hunger = Clamp(Hunger - 25);
            Mood = Clamp(Mood + 5);
            Console.WriteLine($"{Name} wurde gefüttert. Hunger = {Hunger}, Laune = {Mood} ausgegeben.");
        }
        public virtual void Sleep()
        {
            Energy = Clamp(Energy + 35);
            Hunger = Clamp(Hunger + 5);
            Console.WriteLine($"{Name} hat geschlafen. Energie = {Energy}, Hunger = {Hunger} ausgegeben.");
        }
        public virtual void PassTime()
        {
            Oxygen = Clamp(Oxygen - 1);
            Hunger = Clamp(Hunger + 2);
            Energy = Clamp(Energy - 2);
            Mood = Clamp(Mood - 1);

            if (Hunger >= 90) Mood = Clamp(Mood - 3);
            if (Oxygen <= 10) Energy = Clamp(Energy - 3);
        }
        public virtual void ShowStats()
        {
            Console.WriteLine($"Status von: {Name}: Oxygen = {Oxygen}, Hunger = {Hunger}, Laune = {Mood}, Energie = {Energy}");
        }
    }
}