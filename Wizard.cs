using System;
namespace wizardNinjaSamurai
{
class Wizard : Human
    {
        public Wizard(string wiName) : base(wiName)
        {
            health = 50;
            Intelligence = 25;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            int damage = 5 * Intelligence;
            target.Intelligence -= damage;
            health += damage;

            return target.Intelligence;
        }
        public void Heal(Human target)
        {
            int addedIntel = 10* Intelligence;
            target.Intelligence += addedIntel;
        }
    }

}