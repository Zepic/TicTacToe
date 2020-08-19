using System;
using System.Data;

namespace Modul_3
{
    class BoardModel
    {
        public CellContent[] Content { get; }

        public BoardModel()
        {
            Content = new CellContent[9];
        }


        public void Cross(string positionStr)
        {
            var positionLower = positionStr.ToLower();
            var row = positionLower[0] == 'a' ? 0 : positionLower[0] == 'b' ? 1 : 2;
            var col = Convert.ToInt32(positionLower[1].ToString());
            var position = row * 3 + col - 1;
            Content[position] = CellContent.Cross;
        }
        public void Circle(string positionStr)
        {
            var positionLower = positionStr.ToLower();
            var row = positionLower[0] == 'a' ? 0 : positionLower[0] == 'b' ? 1 : 2;
            var col = Convert.ToInt32(positionLower[1].ToString());
            var position = row * 3 + col - 1;
            Content[position] = CellContent.Circle;
        }
    }

}