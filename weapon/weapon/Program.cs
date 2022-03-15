using System;
using weapon.Models;

namespace weapon.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note the capacity of the comb:");
            int bulletCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Record the number of bullets in the comb:");
            int numberOfBullet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Record the seconds of a bullet's release:");
            double secondsOfCombDischarge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Note the type of shot:");
            bool sootingMode = Convert.ToBoolean(Console.ReadLine());

            weapon W1 = new weapon(bulletCapacity,numberOfBullet,secondsOfCombDischarge,sootingMode);

            int key = 0;
            do
            {
                Console.WriteLine("Enter the number: ");
                
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        W1.ChangeFireMode();
                        break;
                    case 2:
                        W1.Shoot();
                        break;
                    case 3:
                        W1.Fire();
                        break;
                    case 4:
                        W1.GetRemainBulletCount();
                        break;
                    case 5:
                        W1.Reload();
                        break;
                    case 6:
                        Console.WriteLine("END");
                        break;
                    case 0:
                        W1.Getinfo();
                        break;
                    default:
                        Console.WriteLine("Entered incorrectly");
                        break;
                }
            } while (key != 6);


        }
    }
}
