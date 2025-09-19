using Chess.Pieces;

namespace Chess;

internal record Block(BoardLetter Letter, int Number, IPiece? Piece = null)
{
    public override string ToString() => Piece?.ToString() ?? " ";
}