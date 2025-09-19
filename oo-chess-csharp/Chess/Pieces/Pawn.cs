namespace Chess.Pieces;

internal class Pawn : IPiece
{
    public Colour Colour { get; }

    public Pawn(Colour colour)
    {
        Colour = colour;
    }
    public override string ToString() => "P";
}