using System;

namespace Projekt_ClassLibrary
{
    public class Game
    {
        Computer computer;
        Player player;

        public Game()
        {
            player = new Player();
            computer = new Computer();

            bool playAgain = true;

            //Rozpoczęcie gry
            Start();

            //Pobranie nazwy gracza
            player.getUserName();

            //wykonaj ponownie rozgrywke
            while (playAgain)
            {
                //Punktacja
                player.userScore = 0;
                computer.computerScore = 0;

                while (player.userScore < 3 && computer.computerScore < 3)
                {
                    infoGra();
                    player.getUserInput();
                    Console.WriteLine("\n-----\n");

                    switch (computer.arrMoves[computer.randomMove()])
                    {
                        case "kamien":
                            Console.WriteLine("Komputer: Kamien");

                            if (player.userInput == 1)
                            {
                                Remis();
                            }
                            else if (player.userInput == 2)
                            {
                                computerWin();
                            }
                            else if (player.userInput == 3)
                            {
                                userWin();
                            }
                            break;

                        case "papier":
                            Console.WriteLine("Komputer: Papier");

                            if (player.userInput == 1)
                            {
                                computerWin();
                            }
                            else if (player.userInput == 2)
                            {
                                Remis();
                            }
                            else if (player.userInput == 3)
                            {
                                userWin();
                            }
                            break;

                        case "nozyce":
                            Console.WriteLine("Komputer: Nozyce");

                            if (player.userInput == 1)
                            {
                                userWin();
                            }
                            else if (player.userInput == 2)
                            {
                                computerWin();
                            }
                            else if (player.userInput == 3)
                            {
                                Remis();
                            }
                            break;

                        default:
                            Console.WriteLine("Zle! Wpisz poprawny wybor!");
                            break;
                    }
                }

                Winner();

                //Zagraj ponownie
                Console.WriteLine("Czy chcesz zagrać ponownie?\n");
                Console.Write("\nWpisz t - Tak lub n - Nie: ");
                string loop = Console.ReadLine();

                //mozliwosc wyboru true lub false dla playAgain
                if (loop == "t")
                {
                    playAgain = true;

                }
                else if (loop == "n")
                {
                    playAgain = false;
                    Console.WriteLine("\n** KONIEC GRY! **");
                }
                else
                {

                }

            }

        }

        public void Start()
        {
            //Powitanie gracza
            Console.WriteLine("\n");
            Console.WriteLine("*** *****   *    **** *****");
            Console.WriteLine("*     *    * *   *  *   *");
            Console.WriteLine("***   *   *****  ****   *");
            Console.WriteLine("  *   *   *   *  *  *   *");
            Console.WriteLine("***   *   *   *  *   *  *");
            Console.WriteLine("\nWitaj w grze => kamien | papier | nozyce! " + "W tej grze zmierzysz sie z komputerem w walce o 3 punkty!");
            Console.WriteLine("\n------");
        }

        public void infoGra()
        {
            Console.WriteLine("\nW tej grze do wyboru masz trzy opcje: \n1 - kamien \n2 - papier \n3 - nozyce");
            Console.WriteLine("\n-----");
            Console.WriteLine("\nCo wybierasz..?\n");
            Console.Write("\nWpisz swoj wybor (1 - kamien, 2 - papier, 3 - nozyce): ");
        }

        public void Remis()
        {
            player.userChoice();
            Console.WriteLine("* REZULTAT *");
            Console.WriteLine("Remis!!\n");
            Console.WriteLine("* OBECNY WYNIK *");
            Console.WriteLine(player.userNameInput + ": " + player.userScore);
            Console.WriteLine("Komputer: " + computer.computerScore);
        }
        public void userWin()
        {
            player.userChoice();
            Console.WriteLine("* REZULTAT *");
            Console.WriteLine(player.userNameInput + " wygrał te runde!\n");
            player.userScore++;
            Console.WriteLine("* OBECNY WYNIK *");
            Console.WriteLine(player.userNameInput + ": " + player.userScore);
            Console.WriteLine("Komputer: " + computer.computerScore);
        }

        public void computerWin()
        {
            player.userChoice();
            Console.WriteLine("* REZULTAT *");
            Console.WriteLine("Komputer wygral te runde!\n");
            computer.computerScore++;
            Console.WriteLine("* OBECNY WYNIK *");
            Console.WriteLine(player.userNameInput + ": " + player.userScore);
            Console.WriteLine("Komputer: " + computer.computerScore);
        }

        public void Winner()
        {
            //Sprawdz i wypisz wygranego
            if (player.userScore == 3)
            {
                Console.WriteLine("\n*** " + player.userNameInput + " wygrał zdobywając 3 punkty!! ***\n");
            }
            else if (computer.computerScore == 3)
            {
                Console.WriteLine("\n*** Komputer wygrał zdobywając 3 punkty!! ***\n");
            }
            else
            {

            }
        }

    }

}
