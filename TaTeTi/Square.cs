using System;
using System.Xml.Serialization;

namespace TaTeTi
{
    [Serializable]
    public class Square
    {
        private char _char = '\0';

        [XmlIgnore]
        public char Char { get => _char; }

        [XmlElement(elementName: "Char")]
        public string CharView
        {
            get => _char == (char)SquareValue.O ? "O" 
                : _char == (char)SquareValue.X ? "X"
                : "";
            set { _char = value[0]; }
        }

        public void SetValue(SquareValue value)
        {
            if (_char == '\0')
                _char = (char)value;
            else
                throw new InvalidOperationException("Cuadrado ya utilizado");
        }

        public override string ToString()
        {
            return Char.ToString();
        }
    }

    public enum SquareValue
    {
        X = 88,
        O = 79
    }
}
