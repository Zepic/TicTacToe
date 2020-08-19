using System;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;

namespace Modul_3
{
    class BoardView
    {
        public static void Show(BoardModel boardModel)
        {
            var content = boardModel.Content;
            Console.WriteLine("  1 2 3");
            Console.WriteLine(" ┌─────┐");
            Console.Write("A");
            AssignLine(0, content);
            Console.Write("B");
            AssignLine(3, content);
            Console.Write("C");
            AssignLine(6, content);
            Console.WriteLine(" └─────┘");
        }

        private static void AssignLine(int startIndex, CellContent[] content)
        {
            Console.Write("│");
            for (var i = startIndex; i < startIndex+3; i++)
            {
                if (i > startIndex) Console.Write(" ");
                char c;
                if (content[i] == CellContent.None)
                    c = ' ';
                else if (content[i] == CellContent.Cross)
                    c = 'x';
                else
                    c = 'o';
                Console.Write(c);
            }
            Console.WriteLine("│");
        }

        /*
            var A1 = new string("-");
            var A2 = new string("-");
            var A3 = new string("-");
            var B1 = new string("-");
            var B2 = new string("-");
            var B3 = new string("-");
            var C1 = new string("-");
            var C2 = new string("-");
            var C3 = new string("-");
            Console.WriteLine("  A B C");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine("1│" + A1 + " " + B1 + " " + C3 + "│");
            Console.WriteLine("2│" + A2 + " " + B2 + " " + C2 + "│");
            Console.WriteLine("3│" + A3 + " " + B3 + " " + C3 + "│");
            Console.WriteLine(" └─────┘");
        */
    }
}