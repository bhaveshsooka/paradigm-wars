namespace Chess.Pieces;

internal class Knight : IPiece
{
    public Colour Colour { get; }

    public Knight(Colour colour)
    {
        Colour = colour;
    }
    public override string ToString() => "N";
}