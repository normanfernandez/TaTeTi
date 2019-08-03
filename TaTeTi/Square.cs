using System;

namespace TaTeTi
{
    public class Square
    {
        private char _char = '\0';

        public char Char { get => _char; }

        public void SetValue(SquareValue value)
        {
            if (_char == '\0')
                _char = (char)value;
            else
                throw new InvalidOperationException("Cuadrado ya utilizado");
        }
    }

    public enum SquareValue
    {
        X = 88,
        O = 79
    }
}
