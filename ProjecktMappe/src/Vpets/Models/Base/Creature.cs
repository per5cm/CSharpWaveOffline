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
        private int _oxygen, _hunger, _energy, _mood, _health;
        protected int MaxValue = 100;
        protected const int MinValue = 0;
        // Object Fields (zur Speicherung von Daten)
        public string Name { get; set; }
        public int Health {
            get { return _health; }
            set { _health = Math.Clamp(value, MinValue, MaxValue); }
        } 
        public int Level { get; private set; } = 1;
        public int Xp { get; private set; } = 0;
        public int XpToLevel => 500 * Level; // xp amount goes up with level.
        public void GainXp(int amount, string reason = null) // string so it can say a message as well
        {
            if (amount <= 0) return;
            Xp += amount;
            Console.WriteLine($"{Name} erhalten {amount} XP. und [{Xp}/{XpToLevel}]");

            while (Xp >= XpToLevel)
            {
                Xp -= XpToLevel; // xp sets to 0 with level up.
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Level++;
            MaxValue += 1;
            Console.WriteLine($"------{Name}----- level steigt auf {Level}!");
        }

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

        protected int Clamp(int v) => v < 0 ? 0 : (v > MaxValue ? MaxValue : v); // if bellow 0 force it to up to 0, if above max value force it down to maxvalue, else leave alone.
        protected Creature(string name)
        {
            Name = name;
            Health = MaxValue;
            Oxygen = 90;
            Hunger = 50;
            Energy = 90;
            Mood = 50;
        }

        public virtual void RefillOxygen()
        {
            Oxygen = Clamp(Oxygen + 50);
            Console.WriteLine($"{Name} wurde Sauerstoff erhöht. Sauerstoff = {Oxygen} ausgegeben.");
            GainXp(5, "Sauerstoff nachgefüllt!");
        }
        public virtual void Feed()
        {
            Hunger = Clamp(Hunger - 25);
            Mood = Clamp(Mood + 5);
            Console.WriteLine($"{Name} wurde gefüttert. Hunger = {Hunger}, Laune = {Mood} ausgegeben.");
            GainXp(6, "Fütterung!");
        }
        public virtual void Sleep()
        {
            Energy = Clamp(Energy + 35);
            Hunger = Clamp(Hunger + 5);
            Console.WriteLine($"{Name} hat geschlafen. Energie = {Energy}, Hunger = {Hunger} ausgegeben.");
            GainXp(10, "Shlafruhe!");
        }
        public virtual void PassTime()
        {
            Oxygen = Clamp(Oxygen - 1);
            Hunger = Clamp(Hunger + 2);
            Energy = Clamp(Energy - 2);
            Mood = Clamp(Mood - 1);

            GainXp(10); // pasive xp

            if (Hunger >= 90) Mood = Clamp(Mood - 3);
            if (Oxygen <= 10) Energy = Clamp(Energy - 3);
        }
        public virtual void ShowStats()
        {
            Console.WriteLine($"Status von: {Name}: LvL = {Level}, XP = {Xp} / {XpToLevel}, Oxygen = {Oxygen}, Hunger = {Hunger}, Laune = {Mood}, Energie = {Energy}");
        }
    }
}