using System;
using System.Collections.Generic;
using System.Text;

namespace TaTeTi
{
    [Serializable]
    public class Board
    {
        public List<List<Square>> Squares { get; }

        public Board()
        {
            Squares = new List<List<Square>>();
            for (int i = 0; i < 3; i++)
            {
                List<Square> row = new List<Square>();
                for (int j = 0; j < 3; j++)
                {
                    row.Add(new Square());
                }
                Squares.Add(row);
            }
        }

        public void Set(int posX, int posY, SquareValue squareValue)
        {
            switch (squareValue)
            {
                case SquareValue.O:
                    SetO(posX, posY);
                    break;
                case SquareValue.X:
                    SetX(posX, posY);
                    break;
            }
        }

        public void SetX(int posX, int posY)
        {
            Squares[posX][posY].SetValue(SquareValue.X);
        }

        public void SetO(int posX, int posY)
        {
            Squares[posX][posY].SetValue(SquareValue.O);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char temp = Squares[i][j].Char == '\0' ? ' ' : Squares[i][j].Char;
                    sb.Append(temp).Append('|');
                }
                sb.Append('\n');
            }

            return sb.ToString();
        }

        public bool WinX()
        {
            char xVal = (char)SquareValue.X;
            if (Squares[0][0].Char == xVal && Squares[0][1].Char == xVal && Squares[0][2].Char == xVal)
                return true;
            if (Squares[1][0].Char == xVal && Squares[1][1].Char == xVal && Squares[1][2].Char == xVal)
                return true;
            if (Squares[2][0].Char == xVal && Squares[2][1].Char == xVal && Squares[2][2].Char == xVal)
                return true;
            if (Squares[0][0].Char == xVal && Squares[1][0].Char == xVal && Squares[2][0].Char == xVal)
                return true;
            if (Squares[0][1].Char == xVal && Squares[1][1].Char == xVal && Squares[2][1].Char == xVal)
                return true;
            if (Squares[0][2].Char == xVal && Squares[1][2].Char == xVal && Squares[2][2].Char == xVal)
                return true;
            if (Squares[0][0].Char == xVal && Squares[1][1].Char == xVal && Squares[2][2].Char == xVal)
                return true;
            if (Squares[0][2].Char == xVal && Squares[1][1].Char == xVal && Squares[2][0].Char == xVal)
                return true;

            // Poner otros ifs...
            return false;
        }

        public bool WinO()
        {
            char oVal = (char)SquareValue.O;
            if (Squares[0][0].Char == oVal && Squares[0][1].Char == oVal && Squares[0][2].Char == oVal)
                return true;
            if (Squares[1][0].Char == oVal && Squares[1][1].Char == oVal && Squares[1][2].Char == oVal)
                return true;
            if (Squares[2][0].Char == oVal && Squares[2][1].Char == oVal && Squares[2][2].Char == oVal)
                return true;
            if (Squares[0][0].Char == oVal && Squares[1][0].Char == oVal && Squares[2][0].Char == oVal)
                return true;
            if (Squares[0][1].Char == oVal && Squares[1][1].Char == oVal && Squares[2][1].Char == oVal)
                return true;
            if (Squares[0][2].Char == oVal && Squares[1][2].Char == oVal && Squares[2][2].Char == oVal)
                return true;
            if (Squares[0][0].Char == oVal && Squares[1][1].Char == oVal && Squares[2][2].Char == oVal)
                return true;
            if (Squares[0][2].Char == oVal && Squares[1][1].Char == oVal && Squares[2][0].Char == oVal)
                return true;
            return false;
        }
    }
}
