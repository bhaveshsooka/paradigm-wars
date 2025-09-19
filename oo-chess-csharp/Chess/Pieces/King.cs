namespace Chess.Pieces;

internal class King : IPiece
{
    public Colour Colour { get; }

    public King(Colour colour)
    {
        Colour = colour;
    }
    
    public override string ToString() => "K";
}