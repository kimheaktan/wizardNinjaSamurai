using System;
namespace wizardNinjaSamurai
{
    class Ninja : Human
    {
        public Ninja(string NinName) : base(NinName) 
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            int damage = 5 * Dexterity;
            target.Dexterity -= damage;

            Random Chance = new Random();
            int rand = Chance.Next(1,5);
            if (rand == 1)
            {
                target.Dexterity -= 10;
            }
            return target.Dexterity;
        }
        public void Steal(Human target)
        {
            target.healthProp -= 5;
            healthProp += 5;
        }
    }
}
