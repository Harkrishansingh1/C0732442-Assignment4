﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Wordfinder();

            Console.ReadLine();

        }
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:\\Users\\732442/beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) !=null )
                {
                    Console.WriteLine(ln);
                        Beowulf.Add(ln);

                }
                file.Close();
                Console.WriteLine("$ file has counter.");

            }
        }
        public int FindNumberofBlankspaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

            foreach(char c in line)
            {
                if(char.IsLetter(c)) { countletters++; }
                if(char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}
