﻿using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            if (age > 15 )
            {
                var person = new Person(name, age);
                Console.WriteLine(person);
            }
            else
            {
                var child = new Child(name, age);
                Console.WriteLine(child);
            }

        }
    }
}