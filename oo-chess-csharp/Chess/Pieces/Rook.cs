namespace Chess;

internal class Rook : IPiece
{
    public Colour Colour { get; }

    public Rook(Colour colour)
    {
        Colour = colour;
    }
}