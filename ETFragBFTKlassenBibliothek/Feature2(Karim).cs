﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFragBFTKlassenBibliothek
{
    public class Feature2
    {
        public static void Feature2Funcion2()

        {
            string Ausw;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                     "                              >>> Ohmisches Gesetz <<<\n" +
                                     "------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
            Console.WriteLine("\t1 - Wiederstand");
            Console.WriteLine("\t2 - Spannung");
            Console.WriteLine("\t3 - Stromstärke");
            Console.WriteLine("\t4 - Spannungsfall\n");
            Console.Write("Eingabe:");
            Ausw = Console.ReadLine();

            switch (Ausw)
            {

                case "1":
                    Console.Clear();
                    Feature1.Feature1Funcion1();

                    break;

                case "2":
                    Console.Clear();
                    Feature2.Feature2Funcion2();

                    break;

                case "3":
                    Console.Clear();
                    Feature3.Feature3Funcion3();

                    break;

                case "4":
                    Console.Clear();
                    Feature4.Feature4Funcion4();

                    break;
                   
                  
























            }

        }
    }
}