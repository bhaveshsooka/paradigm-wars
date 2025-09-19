namespace Chess.Pieces;

internal class Bishop : IPiece
{
    public Colour Colour { get; }

    public Bishop(Colour colour)
    {
        Colour = colour;
    }

    public override string ToString() => "B";
}