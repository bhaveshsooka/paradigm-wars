namespace Chess;

internal class Knight : IPiece
{
    public Colour Colour { get; }

    public Knight(Colour colour)
    {
        Colour = colour;
    }
}