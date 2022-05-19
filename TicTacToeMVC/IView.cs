using System.Collections.Generic;

namespace TicTacToeMVC
{
    public interface IView
    {

        int MainMenu();

        void ShowBoard(Model m);

        void ShowWinner(Model m);

        char GetInput();
    }
}
