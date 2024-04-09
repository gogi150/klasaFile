﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kako se zoves: ");
            string ime = Console.ReadLine();
            // postavljanje putanje
            string putanja = @"c:\test";
            Console.WriteLine(putanja);
            // definiranje naziva datoteke
            string datoteka = "ime.txt";
            string putanjaDatoteke = putanja + datoteka;
            // provjera da li datoteka postoji u zadanoj putanji
            if (File.Exists(putanja))
            {
                Console.WriteLine("Datoteka postoji!");
                if (!Directory.Exists(putanja + "bkp"))
                {
                    Directory.CreateDirectory(putanja + "bkp");
                    File.Copy(putanjaDatoteke, putanja + "bkp\\ime_"
                    + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt");
                }
                else
                {
                    File.Create(putanjaDatoteke);
                    Console.WriteLine("Datoteka kreirana!");
                }
               
            }
            File.WriteAllText(putanjaDatoteke, ime);
            Console.ReadKey();
        }
    }
}
