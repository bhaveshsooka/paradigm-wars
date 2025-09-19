namespace Chess;

internal class ChessBoard
{
    private readonly Block[,] _board;

    public ChessBoard()
    {
        _board = new Block[8, 8];
    }
}