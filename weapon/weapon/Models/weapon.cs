using System;
using System.Collections.Generic;
using System.Text;

namespace weapon.Models
{
    class weapon
    {
        public int bulletCapacity ;
        public int numberOfBullet;
        public double secondsOfCombDischarge;
        public bool sootingMode;
        public weapon(int bulletCapacity, int numberOfBullet, double secondsOfCombDischarge, bool sootingMode)
        {
            this.bulletCapacity = bulletCapacity;
            this.numberOfBullet = numberOfBullet;
            this.secondsOfCombDischarge = secondsOfCombDischarge;
            this.sootingMode = sootingMode;
        }

        public void Shoot()
        {
            if (numberOfBullet>0)
            {
                numberOfBullet = numberOfBullet - 1;
                Console.WriteLine($"pew pew {numberOfBullet}");
            }
            else
                Console.WriteLine("There are no bullets in the comb");
        }

        public void Fire()
        {
            if (bulletCapacity>0)
            {
                secondsOfCombDischarge = numberOfBullet * secondsOfCombDischarge;
                Console.WriteLine($"seconds of comb discharge:{secondsOfCombDischarge}");
            }
            else
                Console.WriteLine("There are no bullets in the comb");
        }

        public void GetRemainBulletCount()
        {
            if (bulletCapacity>numberOfBullet)
            {
                bulletCapacity = bulletCapacity - numberOfBullet;
                Console.WriteLine($"The number of bullets needed to fill the comb:{bulletCapacity}");
            }
            else
                Console.WriteLine("Enter the numbers correctly");
            
        }
         
        public void Reload()
        {
            if (bulletCapacity>numberOfBullet)
            {
                int Empty = bulletCapacity - numberOfBullet;
                bulletCapacity = Empty + numberOfBullet;
                Console.WriteLine("The comb is full");
            }
           

        }
         
        public void ChangeFireMode()
        {
            if (sootingMode == true )
            {

                Console.WriteLine("Single shot was fired");
            }
            else if (sootingMode == false)
            {
                Console.WriteLine("Automatic firing");
            }
        }
         
        public void Getinfo()
        {
            Console.WriteLine("1 Shoot ");
            Console.WriteLine("2 Fire ");
            Console.WriteLine("3 GetRemainBulletCount ");
            Console.WriteLine("4 Reload ");
            Console.WriteLine("5 ChangeFireMode ");
        }
            
            



    }   


}
