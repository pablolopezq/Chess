using Ajedrez.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez.Core
{
    public class PieceFactory
    {
        public Piece CreatePiece(PieceType pieceType, string row, string column, bool isWhite)
        {
            return pieceType switch
            {
                PieceType.BISHOP => new Bishop(row, column, isWhite),
                PieceType.KING => new King(row, column, isWhite),
                PieceType.KNIGHT => new Knight(row, column, isWhite),
                PieceType.PAWN => new Pawn(row, column, isWhite),
                PieceType.QUEEN => new Queen(row, column, isWhite),
                PieceType.ROOK => new Rook(row, column, isWhite),
                _ => new Pawn(row, column, isWhite),
            };
        }
    }
}
