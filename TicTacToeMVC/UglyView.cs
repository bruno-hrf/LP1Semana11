using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class UglyView : IView
    {
        private Controller controller;

        public UglyView(Controller controller)
        {
            this.controller = controller;
        }

        public int MainMenu()
        {
            Console.WriteLine("1-Play");
            Console.WriteLine("2-Exit");

            return char.Parse(Console.ReadLine());

        }

        public void ShowBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");

            if (flag == 1)
            // if flag value is 1 then someone has win or
            //means who played marked last time which has win
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
        }       
    }
}
