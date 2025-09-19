using System.Text;
using Chess.Pieces;

namespace Chess;

internal class ChessBoard
{
    private readonly Block[,] _board;

    public ChessBoard()
    {
        _board = new Block[8, 8];
        Reset();
    }

    public void Reset()
    {
        _board[(int)BoardLetter.A, 0] = new Block(BoardLetter.A, 0, new Rook(Colour.White));
        _board[(int)BoardLetter.A, 1] = new Block(BoardLetter.A, 1, new Knight(Colour.White));
        _board[(int)BoardLetter.A, 2] = new Block(BoardLetter.A, 2, new Bishop(Colour.White));
        _board[(int)BoardLetter.A, 3] = new Block(BoardLetter.A, 3, new Queen(Colour.White));
        _board[(int)BoardLetter.A, 4] = new Block(BoardLetter.A, 4, new King(Colour.White));
        _board[(int)BoardLetter.A, 5] = new Block(BoardLetter.A, 5, new Bishop(Colour.White));
        _board[(int)BoardLetter.A, 6] = new Block(BoardLetter.A, 6, new Knight(Colour.White));
        _board[(int)BoardLetter.A, 7] = new Block(BoardLetter.A, 7, new Rook(Colour.White));
        for (var col = 0; col < _board.GetLength(1); col++)
        {
            _board[(int)BoardLetter.B, col] = new Block(BoardLetter.B, col, new Pawn(Colour.White));
        }

        for (var row = 2; row < _board.GetLength(0) - 2; row++)
        {
            for (var col = 0; col < _board.GetLength(1); col++)
            {
                _board[row, col] = new Block((BoardLetter)row, col);
            }
        }

        for (var col = 0; col < _board.GetLength(1); col++)
        {
            _board[(int)BoardLetter.G, col] = new Block(BoardLetter.G, col, new Pawn(Colour.White));
        }

        _board[(int)BoardLetter.H, 0] = new Block(BoardLetter.H, 0, new Rook(Colour.Black));
        _board[(int)BoardLetter.H, 1] = new Block(BoardLetter.H, 1, new Knight(Colour.Black));
        _board[(int)BoardLetter.H, 2] = new Block(BoardLetter.H, 2, new Bishop(Colour.Black));
        _board[(int)BoardLetter.H, 3] = new Block(BoardLetter.H, 3, new Queen(Colour.Black));
        _board[(int)BoardLetter.H, 4] = new Block(BoardLetter.H, 4, new King(Colour.Black));
        _board[(int)BoardLetter.H, 5] = new Block(BoardLetter.H, 5, new Bishop(Colour.Black));
        _board[(int)BoardLetter.H, 6] = new Block(BoardLetter.H, 6, new Knight(Colour.Black));
        _board[(int)BoardLetter.H, 7] = new Block(BoardLetter.H, 7, new Rook(Colour.Black));
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        sb.Append('+');
        sb.Append('-', 8);
        sb.Append('+');
        sb.AppendLine();
        for (var row = 0; row < _board.GetLength(0); row++)
        {
            sb.Append("|");

            for (var col = 0; col < _board.GetLength(1); col++)
            {
                var isBlackSquare = (row + col) % 2 == 0;
                sb.Append(isBlackSquare ? "\x1b[0;1;7m" : "\x1b[0m");
                sb.Append(_board[row, col]);
                sb.Append("\x1b[0m");
            }

            sb.AppendLine("|");
        }

        sb.Append('+');
        sb.Append('-', 8);
        sb.Append('+');

        return sb.ToString();
    }
}