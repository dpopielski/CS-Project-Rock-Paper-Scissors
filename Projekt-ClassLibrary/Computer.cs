using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Projekt_ClassLibrary
{
    public class Computer
    {
        public int computerScore;
        public int randomNumber;
        public string[] arrMoves = {"kamien", "papier", "nozyce"};
        public enum rps
        {
            Rock,
            Paper,
            Scissors
        }

        public int randomMove()
        {
            Random rd = new Random();
            randomNumber = rd.Next(0, 3);

            return randomNumber;
        }
    }
}
