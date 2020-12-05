using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez.Core.Entities
{
    public abstract class Piece
    {
        public string Row { get; set; }

        public string Column { get; set; }

        public bool IsWhite { get; set; }

        public Piece(string row, string column, bool isWhite)
        {
            Row = row;
            Column = column;
            IsWhite = isWhite;
        }
    }
}
