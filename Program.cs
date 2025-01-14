﻿using System;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace AOC._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AoC 2021");
            Console.WriteLine("=======================================================");

            Dec25();
            /*
            Dec24();
            Dec23();
            Dec22();
            Dec21();
            Dec20();
            Dec19();
            Dec18();
            Dec17();
            Dec16();
            Dec15();
            Dec14();
            Dec13();
            Dec12();
            Dec11();
            Dec10();
            Dec9();
            Dec8();
            Dec7();
            Dec6();
            Dec5();
            Dec4();
            Dec3();
            Dec2();
            Dec1();
            */

            Console.ReadLine();
        }

        private static void Dec25()
        {
            var date = new Dec25();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec25.txt"));

            Console.WriteLine(string.Format("Dec25 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec25 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec24()
        {
            var date = new Dec24();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec24.txt"));

            Console.WriteLine(string.Format("Dec24 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec24 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec23()
        {
            var date = new Dec23();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec23.txt"));

            //Console.WriteLine(string.Format("Dec23 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec23 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec22()
        {
            var date = new Dec22();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec22.txt"));

            Console.WriteLine(string.Format("Dec22 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec22 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec21()
        {
            var date = new Dec21();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec21.txt"));

            Console.WriteLine(string.Format("Dec21 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec21 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec20()
        {
            var date = new Dec20();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec20.txt"));

            Console.WriteLine(string.Format("Dec20 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec20 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec19()
        {
            var date = new Dec19();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec19.txt"));

            Console.WriteLine(string.Format("Dec19 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec19 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec18()
        {
            var date = new Dec18();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec18.txt"));

            Console.WriteLine(string.Format("Dec18 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec18 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec17()
        {
            var date = new Dec17();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec17.txt"));

            Console.WriteLine(string.Format("Dec17 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec17 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec16()
        {
            var date = new Dec16();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec16.txt"));

            Console.WriteLine(string.Format("Dec16 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec16 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec15()
        {
            var date = new Dec15();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec15.txt"));

            Console.WriteLine(string.Format("Dec15 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec15 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec14()
        {
            var date = new Dec14();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec14.txt"));

            Console.WriteLine(string.Format("Dec14 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec14 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec13()
        {
            var date = new Dec13();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec13.txt"));


            Console.WriteLine(string.Format("Dec13 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec13 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec12()
        {
            var date = new Dec12();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec12.txt"));


            Console.WriteLine(string.Format("Dec12 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec12 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec11()
        {
            var date = new Dec11();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec11.txt"));


            Console.WriteLine(string.Format("Dec11 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec11 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec10()
        {
            var date = new Dec10();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec10.txt"));


            Console.WriteLine(string.Format("Dec10 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec10 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec9()
        {
            var date = new Dec9();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec9.txt"));


            Console.WriteLine(string.Format("Dec9 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec9 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec8()
        {
            var date = new Dec8();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec8.txt"));


            Console.WriteLine(string.Format("Dec8 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec8 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec7()
        {
            var date = new Dec7();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec7.txt"));


            Console.WriteLine(string.Format("Dec7 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec7 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec6()
        {
            var date = new Dec6();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec6.txt"));


            Console.WriteLine(string.Format("Dec6 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            //Console.WriteLine(string.Format("Dec6 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec5()
        {
            var date = new Dec5();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec5.txt"));


            Console.WriteLine(string.Format("Dec5 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec5 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec4()
        {
            var date = new Dec4();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec4.txt"));

            int[] numbersToCall = lines[0].Split(',', StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();

            List<int[][]> boards = new List<int[][]>();
            int noOfBoards = -1;
            int j = 0;

            for(int i=1; i<= lines.Length -1; i++)
            {
                if(lines[i] == "")
                {
                    i++;
                    //new board
                    noOfBoards++;
                    j = 0;
                    boards.Add(new int[5][]);
                }

                int[] values = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();
                boards[noOfBoards][j] = values;
                j++;
            }


            Console.WriteLine(string.Format("Dec4 Puzzle1 Result : {0}", date.Puzzle1(numbersToCall, boards)));
            Console.WriteLine(string.Format("Dec4 Puzzle2 Result : {0}", date.Puzzle2(numbersToCall, boards)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec3()
        {
            var date = new Dec3();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec3.txt"));


            Console.WriteLine(string.Format("Dec3 Puzzle1 Result : {0}", date.Puzzle1(lines)));
            Console.WriteLine(string.Format("Dec3 Puzzle2 Result : {0}", date.Puzzle2(lines)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec2()
        {
            var date = new Dec2();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec2.txt"));

            var input = new List<InstructionDec2>();
            foreach (var line in lines)
            {
                var segments = line.Split(new char[] { ' ' });
                input.Add(new InstructionDec2 { Direction = segments[0], Unit = int.Parse(segments[1]) });
            }

            Console.WriteLine(string.Format("Dec2 Puzzle1 Result : {0}", date.Puzzle1(input)));
            Console.WriteLine(string.Format("Dec2 Puzzle2 Result : {0}", date.Puzzle2(input)));
            Console.WriteLine("=======================================================");
        }

        private static void Dec1()
        {
            var date = new Dec1();

            var lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Input/Dec1.txt"));

            var input = lines.Select(item => int.Parse(item)).ToArray();

            Console.WriteLine(string.Format("Dec1 Puzzle1 Result : {0}", date.Puzzle1(input)));
            Console.WriteLine(string.Format("Dec1 Puzzle2 Result : {0}", date.Puzzle2(input)));
            Console.WriteLine("=======================================================");
        }
        
    }
}
