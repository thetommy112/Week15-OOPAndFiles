using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        //Anna wants new earrings for Christmas
        class SecretSanta
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            //getters for SecretSanta

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }

        }
        static void Main(string[] args)
        {
            List<SecretSanta> wishlist = new List<SecretSanta>();
            string[] wishlistFromFile = GetDataFromFile();

            foreach (string line in wishlistFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newWishlist = new SecretSanta(tempArray[0], tempArray[1]);
                wishlist.Add(newWishlist);
            }

            foreach (SecretSanta nameFromList in wishlist)
            {
                Console.WriteLine($"{nameFromList.Name} wants {nameFromList.Gift} for christmas.");
            }


        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"D:\Koolitööd\Programmeerimise alused\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
