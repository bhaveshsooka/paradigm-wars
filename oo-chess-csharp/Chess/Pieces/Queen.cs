namespace Chess.Pieces;

internal class Queen : IPiece
{
    public Colour Colour { get; }

    public Queen(Colour colour)
    {
        Colour = colour;
    }
    public override string ToString() => "Q";
}