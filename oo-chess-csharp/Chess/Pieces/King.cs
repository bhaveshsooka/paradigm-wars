namespace Chess;

internal class King : IPiece
{
    public Colour Colour { get; }

    public King(Colour colour)
    {
        Colour = colour;
    }
}