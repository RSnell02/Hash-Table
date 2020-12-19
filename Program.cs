/*
 * Project: HashTable
 * Filename: Program.cs
 * Author: R. Snell
 * Date: 12/19/2020
 * Purpose: To demonstrate the function of a HashTable
 */

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable htable = new Hashtable();
            htable["A pair of shoes"] = 70;
            htable["iPod Nano"] = 200;
            htable.Add("Earphones", 15);
            htable.Add("A pair of socks", 6);
            htable.Add("Running shorts", 30);
            htable.Add("Water bottle", 14);
            htable.Add("Tank top", 12);

            Console.WriteLine("Store pricing");
            ICollection htKeys = htable.Keys;
            Console.WriteLine("\nThe available workout gear are: ");
            foreach (string str in htKeys)
                Console.WriteLine("-{0}", str);
            Console.WriteLine("\nThe prices of different workout gear items: ");
            foreach (DictionaryEntry de in htable)
                Console.WriteLine("Price of {0} is ${1}", de.Key, de.Value);
            htable.Remove("iPod Nano");
            Console.WriteLine("\nPrice of items without the iPad Nano: ");
            foreach (DictionaryEntry de in htable)
                Console.WriteLine("Price of {0} is ${1}", de.Key, de.Value);
            htable.Add("iPod Nano", 200);
            htable.Remove("Earphones");
            Console.WriteLine("\nPrice of items without earphones: ");
            foreach (DictionaryEntry de in htable)
                Console.WriteLine("Price of {0} is ${1}", de.Key, de.Value);
        }   //End Main()
    }   //End class
}   //End namespace
