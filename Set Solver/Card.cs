using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetSolver
{
    class Card
    {
        public int colour;
        public int shape;
        public int fill;
        public int amount;
        public int position;

        public Card(int id)
        {
            position = id;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Card " + position + ": ");
            sb.Append(" " + amount.ToString());
            sb.Append(" " + FillName(fill));
            sb.Append(" " + ColourName(colour));
            sb.Append(" " + ShapeName(shape));
            return sb.ToString();
        }

        string ShapeName(int i)
        {
            switch (i)
            {
                case 1: return "Diamond";
                case 2: return "Oval";
                case 3: return "Squigly";
                default: return "unknown value";
            }

        }
        string ColourName(int i)
        {
            switch (i)
            {
                case 1: return "Red";
                case 2: return "Green";
                case 3: return "Purple";
                default: return "unknown value";
            }

        }
        string FillName(int i)
        {
            switch (i)
            {
                case 1: return "Empty";
                case 2: return "Striped";
                case 3: return "Full";
                default: return "unknown value";
            }

        }    
    }
}
