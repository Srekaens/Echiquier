using System.Text;

static string CreateChessboard(int size)
{
    StringBuilder board = new StringBuilder();

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if ((row + col) % 2 == 0)
            {
                board.Append(' ');
            }
            else
            {
                board.Append('#');
            }
        }
        board.AppendLine();
    }

    return board.ToString();
}

    int size = 4;
    Console.WriteLine(CreateChessboard(size));

