using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez.Core.Entities
{
    public class King : Piece
    {
        public King(string row, string column, bool isWhite) : base(row, column, isWhite)
        {
        }
    }
}
