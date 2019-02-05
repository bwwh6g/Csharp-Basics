using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800f;
            float mass = 14.6f;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const String greeting = "Hello";
            String name = "Karen";

            if (sample1 == sample2)
            {
                Console.Out.WriteLine("The samples are equal.");
            }
            else
            {
                Console.Out.WriteLine("The samples are not equal.");
            }

            if ((heartRate >= 40) && (heartRate <= 80))
            {
                Console.Out.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.Out.WriteLine("Heart rate is not normal.");
            }

            if (deposits >= 100000000)
            {
                Console.Out.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.Out.WriteLine("Sorry you are so poor.");
            }

            float force = (mass * acceleration);

            Console.Out.WriteLine("force = {0}", force);

            Console.Out.WriteLine("{0} is the distance", distance);

            if ((lost == true) && (expensive == true))
            {
                Console.Out.WriteLine("I am really sorry! I will get the manager.");
            }
            else if ((lost == true) && (expensive == false))
            {
                Console.Out.WriteLine("Here is coupon for 10% off.");
            }

            switch (choice)
            {
                case 1:
                    Console.Out.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.Out.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.Out.WriteLine("You chose 3.");
                    break;
                default:
                    Console.Out.WriteLine("You made an unknown choice.");
                    break;
            }

            Console.Out.WriteLine("{0} is an integral", integral);

            for(int i = 5; i < 11; i++)
            {
                Console.Out.WriteLine("i = {0}", i);
            }

            int age = 0;

            while(age < 6)
            {
                Console.Out.WriteLine("age = {0}", age);
                age++;
            }

            Console.Out.WriteLine("{0} {1}", greeting, name);
        }
    }
}
