using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_ClassLibrary
{
    public class Player
    {
        public int userScore;
        public string userNameInput;
        public int userInput;

        public void getUserName()
        {
            //Pobranie nazwy gracza
            Console.Write("\nWpisz swoje imie: ");
            userNameInput = Console.ReadLine();
            Console.WriteLine("\n------");
            Console.WriteLine("\nWitaj " + userNameInput + "!" + " Zaczynamy gre!\n");
            Console.WriteLine("------");
        }

        public void getUserInput()
        {
            userInput = int.Parse(Console.ReadLine());
        }

        public void userChoice()
        {
            if (userInput == 1)
            {
                Console.WriteLine(userNameInput + ": Kamien");
            }
            else if (userInput == 2)
            {
                Console.WriteLine(userNameInput + ": Papier");
            }
            else if (userInput == 3)
            {
                Console.WriteLine(userNameInput + ": Nozyce");
            }
            else
            {
                Console.WriteLine("Błedny wybor!!!");
            }
        }
    }
}
