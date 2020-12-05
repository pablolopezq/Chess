using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez.Core.Entities
{
    public class Pawn : Piece
    {
        public Pawn(string row, string column, bool isWhite) : base(row, column, isWhite)
        {

        }
    }
}
