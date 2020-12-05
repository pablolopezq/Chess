using Ajedrez.Core.Entities;
using Ajedrez.Core.MoveCheckers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez.Core
{
    public class PieceMover
    {
        public bool MovePiece(Piece piece, IMoveChecker checker, int newRow, int newColumn)
        {
            if (checker.CheckMove(piece, newRow, newColumn))
            {
                piece.Move(newRow, newColumn);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
