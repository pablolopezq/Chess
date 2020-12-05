using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez.Core.MoveCheckers
{
    public class MoveCheckerBuilder
    {
        public IMoveChecker CreateChecker(PieceType type)
        {
            return type switch
            {
                PieceType.BISHOP => new BishopChecker(),
                PieceType.KING => new BishopChecker(),
                PieceType.KNIGHT => new BishopChecker(),
                PieceType.PAWN => new BishopChecker(),
                PieceType.QUEEN => new BishopChecker(),
                PieceType.ROOK => new BishopChecker(),
            };
        }
    }
}
