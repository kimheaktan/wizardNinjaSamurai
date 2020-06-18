using System;
namespace wizardNinjaSamurai
{
    class Samurai : Human
    {
        public Samurai(string SamName) : base (SamName)
        {
            healthProp = 200;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.healthProp < 50)
            {
                target.healthProp = 0;
            }
            return target.healthProp;
        }
        public void Meditate()
        {
            healthProp = 200;
        }
    }
}