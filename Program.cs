using System;

namespace Modul_3
{
    class Program
    {

        static void Main(string[] args)
        {
            var boardModel = new BoardModel();
            var Player = true;
            while (true)
            {
                if (Player)
                {
                    BoardView.Show(boardModel);
                    Console.Write("Skriv kordinatene til x: ");
                    var position = Console.ReadLine();
                    boardModel.Cross(position);
                    Player = false;
                }
                else
                {
                    BoardView.Show(boardModel);
                    Console.Write("Skriv kordinatene til o: ");
                    var position = Console.ReadLine();
                    boardModel.Circle(position);
                    Player = true;
                }
            }
            
        }
        
    }
}

