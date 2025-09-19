namespace Chess;

internal class Queen : IPiece
{
    public Colour Colour { get; }

    public Queen(Colour colour)
    {
        Colour = colour;
    }
}