﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Galeotti_Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(() => StampaNumeri(true));
            thread.Start();

            StampaNumeri(false);

            Console.ReadLine();
        }

        public static void StampaNumeri(bool pari)
        {
            Console.WriteLine("ID Thread: " + Thread.CurrentThread.ManagedThreadId);
            if (pari == true)
            {
                StampaNumeriPari();
            }
            else
            {
                StampaNumeriDispari();
            }
        }

        public static void StampaNumeriPari()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Il numero {i} è PARI.");
            }
        }

        public static void StampaNumeriDispari()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine($"Il numero {i} è DISPARI.");
            }
        }
    }
}
