/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
/*
 * Name: David Hollins
 * Email: hollindv@mail.uc.edu
 * Course: IT 3045C
 * Due Date: 11/05/2020
 * Assignment #: 07
 * Description: FantasticBeasts
 * Citations: https://stackoverflow.com/questions/2113069/c-sharp-getting-its-own-class-name 
 * https://stackoverflow.com/questions/2535251/c-finding-the-largest-prime-factor-of-a-number/2535285#2535285
 */
using System;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class SuperSheep : FantasticBeast
    {
        public override void SayHello() {
            Console.WriteLine("Hello from " + this.GetType().Name); 
        }
        public override void RunThread()
        {
            long num = Convert.ToInt64(request);
            response = Convert.ToString(BiggestPrimeFactor(num));
        }

        private static long BiggestPrimeFactor(long num)
        {
            long x = 2;
            while (x * x <= num)
            {
                if (num % x == 0)
                {
                    num /= x;
                }
                else
                {
                    ++x;
                }
            }

            return num;
        }

    }
}
