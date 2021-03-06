/**********************************************************************
Student Name:           Khisro Hashimi  
Student No:				040-950-673
Lab name:		        Hello World!!! My First C# App
Lab Number:             01
Course Name and Number:	.NET Enterprise  - CST8359
Lab Section:			303
Professor Name:         Amir Afrasiabi
*********************************************************************/


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Lab1
{
    class Program
    {
        public static List<string> words = new List<string>();
        public static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Hello World!!! My First C# App");
                Console.WriteLine("Options\r\n----------");
                Console.WriteLine("1 - Import Words From File");
                Console.WriteLine("2 - Bubble Sort words");
                Console.WriteLine("3 - LINQ/Lambda sort words");
                Console.WriteLine("4 - Count the Distinct Words");
                Console.WriteLine("5 - Take the first 10 words");
                Console.WriteLine("6 - Get the number of words that start with 'j' and display the count");
                Console.WriteLine("7 - Get and display of words that end with 'd' and display the count");
                Console.WriteLine("8 - Get and display of words that are greater than 4 characters long, and display the count");
                Console.WriteLine("9 - Get and display of words that are less than 3 characters long and start with the letter 'a', and display the count");
                Console.WriteLine("x – Exit" + "\r\n");
                Console.Write("Make a Selection: ");

                string userinput = Console.ReadLine();
                Console.Clear();

                switch (userinput)
                {
                    case "1": ImportF(); break;
                    case "2": SortF(words); break;
                    case "3": LinqSort(); break;
                    case "4": DistinctWords(); break;
                    case "5": FirstTen(); break;
                    case "6": JWords(); break;
                    case "7": DWords(); break;
                    case "8": FourChars(); break;
                    case "9": ThreeChars(); break;
                    case "x":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input" + "\r\n\r\n");
                        break;
                }
            } while (loop);



            void ImportF()    //stores words in a list from the text file
            {
                string str = string.Empty;
                using (StreamReader reader = new StreamReader("Words.txt"))
                {
                    while ((str = reader.ReadLine()) != null)
                    {
                        words.Add(str);
                    }
                }
                Console.WriteLine("Reading Words");
                Console.WriteLine("Reading Words Complete");
                Console.WriteLine("Number of words found " + words.Count + "\r\n\r\n");
            }



            void LinqSort()              //  sorting list of strings
            {
                stopwatch.Start();
                new List<string>(words).Sort();
                stopwatch.Stop();
                Console.Write("Time elapsed: " + stopwatch.ElapsedMilliseconds + "ms" + "\r\n\r\n");
            }



            void DistinctWords()             //  counting the distinct words 
            {
                Console.WriteLine("The number of distinct words is: " + words.Distinct<string>().Count<string>() + "\r\n\r\n");
            }



            void FirstTen()              //  taking only the first 10 words from the list 
            {
                var temp = words.Take(10);
                foreach (var tWords in temp)
                {
                    Console.WriteLine(tWords);
                }
                Console.WriteLine("\r\n\r\n");
            }



            void JWords()              //  displaying the number of words that start with ‘j’ and display the count
            {
                var temp = from wList in words where wList.StartsWith("j") select wList;
                int count = 0;
                foreach (var tWords in temp)
                {
                    Console.WriteLine(tWords);
                    count++;
                }
                Console.WriteLine("Number of words that start with 'j': " + count + "\r\n\r\n");
            }



            void DWords()             //  displaying the number of words that ends with ‘d’ and display the count
            {
                var temp = from wList in words where wList.EndsWith("d") select wList;
                int count = 0;
                foreach (var tWords in temp)
                {
                    Console.WriteLine(tWords);
                    count++;
                }
                Console.WriteLine("Number of words that end with 'd': " + count + "\r\n\r\n");
            }



            void FourChars()             //  displaying the words that are greater than 4 characters long, and display the count
            {
                var temp = words.Where(w => w.Length > 4);
                int count = 0;
                foreach (var tWords in temp)
                {
                    Console.WriteLine(tWords);
                    count++;
                }
                Console.WriteLine("Number of words that are greater than 4 characters long: " + count + "\r\n\r\n");
            }


            void ThreeChars()              // Given method display the words that are less than 3 characters long and start with the letter ‘a’
            {
                var temp = from tWords in words where tWords.Length < 3 && tWords.StartsWith("a") select tWords;
                int count = 0;

                foreach (var a in temp)
                {
                    Console.WriteLine(a);
                    count++;
                }
                Console.WriteLine("Number of words that are less than 3 characters long and start with 'a': " + count + "\r\n\r\n");
            }
        }


        static string[] SortF(List<string> words)          // Given method Bubble sorts the list
        {
            stopwatch.Start();

            for (int i = 1; i < words.Count; i++)
            {
                for (int j = 0; j < (words.Count - i); j++)
                {
                    if (words[j + 1].CompareTo(words[j]) < 0)
                    {
                        string temp = words[j + 1];
                        words[j + 1] = words[j];
                        words[j] = temp;
                    }
                }
            }

            stopwatch.Stop();

            Console.Write("Time elapsed: " + stopwatch.ElapsedMilliseconds + "ms" + "\r\n\r\n");

            return words.ToArray();
        }
    }
}