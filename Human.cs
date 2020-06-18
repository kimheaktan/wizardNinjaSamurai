using System;
namespace wizardNinjaSamurai
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
         
        public int healthProp
        {
            get { return health; }
            set { health = value;}
        }
         
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        public Human(string name, int str, int intel, int dex, int h)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = h;
        }
         
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.healthProp -= dmg;

            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");

            return target.healthProp;
        }
    }
}
