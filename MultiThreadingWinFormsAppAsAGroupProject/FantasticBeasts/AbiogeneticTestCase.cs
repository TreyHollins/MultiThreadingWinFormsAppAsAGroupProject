﻿/*
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
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingWinFormsAppAsAGroupProject {
    /// <summary>
    /// Test case. Do not edit. 
    /// </summary>
    class AbiogeneticTestCase : FantasticBeast {
        public override void SayHello() {
            Console.WriteLine("Hello from " +  this.GetType());
        }
        public override void RunThread() {
            msg = "Hello from AbiogeneticTestCase.RunThread()";
            Thread.Sleep(2000);
            long num = Convert.ToInt64(request);
            response = Convert.ToString(19541);
        }
    }
}
