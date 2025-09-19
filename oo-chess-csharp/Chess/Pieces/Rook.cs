namespace Chess.Pieces;

internal class Rook : IPiece
{
    public Colour Colour { get; }

    public Rook(Colour colour)
    {
        Colour = colour;
    }
    public override string ToString() => "R";
}