/*using System.Collections.Generic;

namespace TicTacToeMVC
{
    public class Model
    {

        public char[] array = { '0','1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public int player = 1;

        public int position;

        public int win = 0;


        private static void Play()
        {
            do
            {
                if(player==1)
                {
                    player--;
                }
                else
                {
                    player++;
                }

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                
                
                win = CheckWin();

            }while (win != 1);


            private static int CheckWin()
            {                   
                //Winning Condition For First Row
                if (arr[1] == arr[2] && arr[2] == arr[3])
                {
                    return 1;
                }
                //Winning Condition For Second Row
                else if (arr[4] == arr[5] && arr[5] == arr[6])
                {
                    return 1;
                }
                //Winning Condition For Third Row
                else if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    return 1;
                }
                
                //Winning Condition For First Column
                else if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    return 1;
                }
                //Winning Condition For Second Column
                else if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    return 1;
                }
                //Winning Condition For Third Column
                else if (arr[3] == arr[6] && arr[6] == arr[9])
                {
                    return 1;
                }
                
                else if (arr[1] == arr[5] && arr[5] == arr[9])
                {
                    return 1;
                }
                else if (arr[3] == arr[5] && arr[5] == arr[7])
                {
                    return 1;
                }
                
                // If all the cells or values filled with X or O then any player has won the match
                else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
                {
                    return -1;
                }
                #endregion
                else
                {
                    return 0;
                }
            }
        }
    }
}*/