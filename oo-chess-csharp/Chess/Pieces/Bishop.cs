namespace Chess;

internal class Bishop : IPiece
{
    public Colour Colour { get; }

    public Bishop(Colour colour)
    {
        Colour = colour;
    }
}