using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez.Core.Entities
{
    public abstract class Piece
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public bool IsWhite { get; set; }

        public Piece(int row, int column, bool isWhite)
        {
            Row = row;
            Column = column;
            IsWhite = isWhite;
        }
    }
}
