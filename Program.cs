using System;
using System.Collections.Generic;

namespace factoryLab
{
    class Program
    {
        /*
        The goal of this lab is to create a console application to allow a business to manually run
        a rocket factory.

        We should be able to do this in an Object Oriented (OOP) manner.  This will mean making classes
        for each of the entities we need to track as well as creating instances of those classes
        in the program.

        Below, you will find a standard input loop that you can use to get input from the user and take
        action based on that input.

        We want to be able to create new rockets, destroy rockets, show all of the rockets that have been created
        and change an existing rocket.

        Stretch goals:
        
        Add the functionality to delete a rocket by id (instead of last rocket)
        Create an interact method where a user can interact with an rocket and launch it to space.

         */

        public static string height { get; set; }
        public static string fuel { get; set; }
        public static string id {get; set;}

        static void Main(string[] args)
        {
            string input = "";
            Factory storage = new Factory();

            while (input != "exit")
            {
                Console.WriteLine("What do you want to do? (create, destroy, print, launch or exit)");
                input = Console.ReadLine();

                Rocket r = new Rocket();


                switch (input)
                {
                    case "create":

                        Console.WriteLine("what's the ID?");
                        id = Console.ReadLine();

                        Console.WriteLine("How tall do you want the rocket?");
                        r.height = Console.ReadLine();

                        Console.WriteLine("What type of fuel does it use?");
                        r.fuel = Console.ReadLine();

                        storage.rockets.Add(r);

                        // Add code to create a rocket
                        // Make sure to ask about how tall the rocket is and what type of fuel it uses
                        break;
                    case "destroy":
                        // Add code to delete last rocket
                        Console.WriteLine("Remove at what id:");
                        // int length = int.Parse(Prompt("some text"));
                        id = Console.ReadLine();
                        int convert = int.Parse(id);
                        storage.rockets.RemoveAt(convert);
                        break;
                    case "print":
                        foreach(Rocket rock in storage.rockets){
                            rock.Print();
                        }
                        break;
                        // Add code to print out all rockets
                    case "launch":
                        Console.WriteLine("Which Rocket do you want to launch?");
                        id = Console.ReadLine();
                        int launch = int.Parse(id);
                        Console.WriteLine($"Rocket {id} is launching to space");
                        storage.rockets.RemoveAt(launch);

                        break;
                }
            }
        }
    }
}
