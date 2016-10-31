using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game that broke the class! Tic Tac Toe! ...No, seriously.");



            char cross = 'X';
            char circle = 'O';
            bool boolOptionToPlay = true;



            string[] myArray = new string[9];

            NumberInGrid(myArray);
            Grid(myArray);

            while (boolOptionToPlay)
            {
                do
                {

                    FirstPlayer(myArray, cross);
                    if (!checker(myArray, cross))
                    {
                        boolOptionToPlay = PlayAgain(myArray);
                        break;
                    }

                    if (tied(myArray))
                    {
                        boolOptionToPlay = PlayAgain(myArray);
                        break;
                    }

                    SecondPlayer(myArray, circle);
                    if (!checker(myArray, cross))
                    {
                        boolOptionToPlay = PlayAgain(myArray);
                        break;
                    }
                    if (tied(myArray))
                    {
                        boolOptionToPlay = PlayAgain(myArray);
                        break;
                    }

                } while (checker(myArray, cross));

            }

            Console.ReadLine();

        }
      
        static void NumberInGrid(string[] myArray1)
        {

            for (int i = 0; i < myArray1.Length; i++)
            {
                myArray1[i] = i.ToString();

            }
        }

        static void Grid(string[] myArray)
        {
            Console.WriteLine("");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[0], myArray[1], myArray[2]));
            Console.WriteLine("____________");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[3], myArray[4], myArray[5]));
            Console.WriteLine("____________");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[6], myArray[7], myArray[8]));
            Console.WriteLine("");

        }
        

        static void FirstPlayer(string[] myArray2, char gamepiece)
        {
            Console.WriteLine("Player 1 pick a number");
            string player1 = Console.ReadLine();

            int a;

            bool infoCorrect = false;
            while (!infoCorrect)
            {
                if (!Int32.TryParse(player1, out a))
                {
                    Console.WriteLine("Dude, you didn't enter a number!");
                    Console.WriteLine("Gotta enter a number!");
                    player1 = Console.ReadLine();
                    Int32.TryParse(player1, out a);
                    infoCorrect = false;


                }
                else if (a > 8)

                {
                    Console.WriteLine("The number you pick must be less than 8");
                    Console.WriteLine("Player 1 pick a number");
                    player1 = Console.ReadLine();
                    Int32.TryParse(player1, out a);
                    infoCorrect = false;


                }
                else if (a < 0)
                {
                    Console.WriteLine("The number you pick must be greater than 0");
                    Console.WriteLine("Player 1 pick a number");
                    player1 = Console.ReadLine();
                    Int32.TryParse(player1, out a);
                    infoCorrect = false;


                }

                else if (myArray2[a].ToString() == "O" || myArray2[a].ToString() == "X")
                {
                    Console.WriteLine("Someone beat you to it! Gotta pick another spot.");
                    Console.WriteLine("Player 1 pick another number");
                    player1 = Console.ReadLine();
                    Int32.TryParse(player1, out a);
                    infoCorrect = false;

                }
                else
                {
                    myArray2[a] = gamepiece.ToString();
                    Grid(myArray2);
                    infoCorrect = true;
                }
            }
        }


        static void SecondPlayer(string[] myArray3, char gamepiece2)
        {

            Console.WriteLine("Player 2 pick a number");
            string player2 = Console.ReadLine();


            int b;

            bool infoCorrect = false;
            while (!infoCorrect)
            {
                if (!Int32.TryParse(player2, out b))
                {
                    Console.WriteLine("Dude, you didn't enter a number!");
                    Console.WriteLine("Gotta enter a number");
                    player2 = Console.ReadLine();
                    Int32.TryParse(player2, out b);
                    infoCorrect = false;


                }
                else if (b > 8)

                {
                    Console.WriteLine("The number you pick must be less than 8");
                    Console.WriteLine("Player 1 pick a number");
                    player2 = Console.ReadLine();
                    Int32.TryParse(player2, out b);
                    infoCorrect = false;


                }
                else if (b < 0)
                {
                    Console.WriteLine("The number you pick must be greater than 0");
                    Console.WriteLine("Player 1 pick a number");
                    player2 = Console.ReadLine();
                    Int32.TryParse(player2, out b);
                    infoCorrect = false;


                }

                else if (myArray3[b].ToString() == "O" || myArray3[b].ToString() == "X")
                {
                    Console.WriteLine("Someone beat you to it! Gotta pick another spot");
                    Console.WriteLine("Player 1 pick another number");
                    player2 = Console.ReadLine();
                    Int32.TryParse(player2, out b);
                    infoCorrect = false;

                }
                else
                {
                    myArray3[b] = gamepiece2.ToString();
                    Grid(myArray3);
                    infoCorrect = true;
                }
            }

        }

     
        static bool checker(string[] myArray4, char gamepiece3)
        {

            if (myArray4[0] == myArray4[1] && myArray4[1] == myArray4[2])
            {
                if (myArray4[0] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won! Congrats!");

                }
                else
                {
                    Console.WriteLine("Player 2 you won! Congrats!");

                }

                return false;

            }
            else if (myArray4[3] == myArray4[4] && myArray4[4] == myArray4[5])
            {
                if (myArray4[3] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won! Congrats!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won! Congrats!");

                }
                return false;
            }
            else if (myArray4[6] == myArray4[7] && myArray4[7] == myArray4[8])
            {
                if (myArray4[6] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won! Congrats!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won! Congrats!");

                }
                return false;
            }
            else if (myArray4[0] == myArray4[3] && myArray4[3] == myArray4[6])
            {
                if (myArray4[0] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won! Congrats!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won! Congrats!");

                }
                return false;
            }
            else if (myArray4[1] == myArray4[4] && myArray4[4] == myArray4[7])
            {
                if (myArray4[7] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won! Congrats!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won! Congrats!");

                }
                return false;
            }
            else if (myArray4[2] == myArray4[5] && myArray4[5] == myArray4[8])
            {
                if (myArray4[8] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won! Congrats!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won! Congrats!");

                }
                return false;
            }
            else if (myArray4[0] == myArray4[4] && myArray4[4] == myArray4[8])
            {
                if (myArray4[8] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won! Congrats!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won! Congrats!");

                }
                return false;
            }
            else if (myArray4[2] == myArray4[4] && myArray4[4] == myArray4[6])
            {
                if (myArray4[6] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won! Congrats!");

                }
                else
                {
                    Console.WriteLine("Player 2 you won! Congrats!");

                }


                return false;
            }


            return true;
        }

        static bool tied(string[] myArray5)
        {


            for (int i = 0; i < myArray5.Length; i++)
            {
                if (myArray5[i] != "X" && myArray5[i] != "O")
                {

                    return false;
                }


            }


            Console.WriteLine("How'd you get a tie??");
            return true;

        }

        static bool PlayAgain(string[] myArray6)
        {

            Console.WriteLine("Play Again Y|N");
            string playAnswer = Console.ReadLine().ToUpper();
            if (playAnswer == "Y")
            {
                Console.Clear();
                NumberInGrid(myArray6);
                Grid(myArray6);
                return true;

            }
            else if (playAnswer == "N")
            {
                Console.WriteLine("Thanks for playing!");
                return false;
            }
            else
            {
                Console.WriteLine("Wrong asnwer. Gotta say Y|N");
                return false;
            }

        }

    }
}

