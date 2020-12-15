using Ajedrez.Core;
using Ajedrez.Core.Entities;
using System;
using Xunit;

namespace Ajedrez.Tests
{
    public class PieceFactoryTests
    {
        [Fact]
        public void CreatePawnTest()
        {
            var pawn = new Pawn(2, 2, true);
            var factory = new PieceFactory();

            var testPawn = factory.CreatePiece(PieceType.PAWN, 2, 2, true);

            Assert.Equal(pawn, testPawn);
        }

        [Fact]
        public void CreateBishopTest()
        {
            var bishop = new Bishop(2, 2, true);
            var factory = new PieceFactory();

            var testBishop = factory.CreatePiece(PieceType.BISHOP, 2, 2, true);

            Assert.Equal(bishop, testBishop);
        }

        [Fact]
        public void CreateKingTest()
        {
            var king = new King(2, 2, true);
            var factory = new PieceFactory();

            var testKing = factory.CreatePiece(PieceType.KING, 2, 2, true);

            Assert.Equal(king, testKing);
        }

        [Fact]
        public void CreateKnightTest()
        {
            var knight = new Knight(2, 2, true);
            var factory = new PieceFactory();

            var testKnight = factory.CreatePiece(PieceType.KNIGHT, 2, 2, true);

            Assert.Equal(knight, testKnight);
        }

        [Fact]
        public void CreateQueenTest()
        {
            var queen = new Queen(2, 2, true);
            var factory = new PieceFactory();

            var testQueen = factory.CreatePiece(PieceType.QUEEN, 2, 2, true);

            Assert.Equal(queen, testQueen);
        }

        [Fact]
        public void CreateRookTest()
        {
            var rook = new Rook(2, 2, true);
            var factory = new PieceFactory();

            var testRook = factory.CreatePiece(PieceType.ROOK, 2, 2, true);

            Assert.Equal(rook, testRook);
        }
    }
}
