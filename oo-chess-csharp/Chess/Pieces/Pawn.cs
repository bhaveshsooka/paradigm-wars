namespace Chess;

internal class Pawn : IPiece
{
    public Colour Colour { get; }

    public Pawn(Colour colour)
    {
        Colour = colour;
    }
}