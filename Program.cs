using System;

namespace wizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Jay = new Human("Jay");
            Ninja Rey = new Ninja("Rey");
            Samurai Solo = new Samurai("Solo");
            Wizard Kim = new Wizard("Kim");

            while(Solo.healthProp > 50)
            {
                Kim.Attack(Solo);
            }
            Console.WriteLine(Solo.Dexterity);

            Solo.Meditate();
            Kim.Heal(Solo);
            Console.WriteLine(Solo.Intelligence);
            Console.WriteLine(Solo.healthProp);
            
        }
    }
    }
