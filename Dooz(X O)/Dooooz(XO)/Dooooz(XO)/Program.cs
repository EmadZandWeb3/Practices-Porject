char[,] board = { { '?', '?', '?' },
                  { '?', '?', '?' },
                  { '?', '?', '?' }
                                   };

int turn = 1;
bool gameOver = false;
bool win = false;
bool draw = false;

while (!gameOver)
{
    Console.Clear();

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(board[i, j] + " ");
        }
        Console.WriteLine();
    }
    
    if (turn == 1)
    {
        Console.WriteLine("Player 1 (X) : ");
    }
    else
    {
        Console.WriteLine("Player 2 (0) : ");
    }
    try
    {
        int x = int.Parse(Console.ReadLine()) - 1;
        int y = int.Parse(Console.ReadLine()) - 1;

        if (x < 0 || x > 2 || y < 0 || y > 2 || board[x, y] != '?')
        {
            Console.WriteLine("Invalid input YA cell taken. try another input...");
            Console.ReadKey();
            continue;
        }



        char symbol;
        if (turn == 1)
        {
            symbol = 'X';
        }
        else
        {
            symbol = 'O';
        }
        board[x, y] = symbol;

        win = false;

        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol) ||
                (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol))
            {
                win = true;
            }
        }

        if ((board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
            (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol))
        {
            win = true;
        }

        draw = true;
        for (int i = 0; i < 3 && draw; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == '?')
                {
                    draw = false;
                    break;
                }
            }
        }

        if (win)
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }

            if (turn == 1)
            {
                Console.WriteLine("Player number 1 (X) Win!!!");

            }
            else
            {
                Console.WriteLine("Player number 2 (O) Win!!!");
            }
            gameOver = true;
        }
        else if (draw)
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("It's a MOSAVI!");
            gameOver = true;
        }
        else
        {
            if (turn == 1)
            {
                turn = 2;
            }
            else
            {
                turn = 1;
            }
        }
    }
    catch
    {
        Console.WriteLine("Invalid input YA cell taken. try another input...");
        Console.ReadKey();
        continue;
    }
}
Console.ReadKey();