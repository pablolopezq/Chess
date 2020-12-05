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
            switch (pieceType)
            {
                case PieceType.BISHOP:
                    return new Bishop(row, column, isWhite);
                case PieceType.KING:
                    return new King(row, column, isWhite);
                case PieceType.KNIGHT:
                    return new Knight(row, column, isWhite);
                case PieceType.PAWN:
                    return new Pawn(row, column, isWhite);
                case PieceType.QUEEN:
                    return new Queen(row, column, isWhite);
                case PieceType.ROOK:
                    return new Rook(row, column, isWhite);
                default:
                    return new Pawn(row, column, isWhite);
            }
        }
    }
}
