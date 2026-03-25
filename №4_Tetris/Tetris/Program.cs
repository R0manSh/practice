using System;
using System.Threading;

class Figure
{
    public int[,] Shape;
    public int X;
    public int Y;

    public Figure(int[,] shape)
    {
        Shape = shape;
        X = 4;
        Y = 0;
    }

    public void Rotate()
    {
        int h = Shape.GetLength(0);
        int w = Shape.GetLength(1);

        int[,] rotated = new int[w, h];

        for (int y = 0; y < h; y++)
            for (int x = 0; x < w; x++)
                rotated[x, h - y - 1] = Shape[y, x];

        Shape = rotated;
    }
}

class GameField
{
    public int Width = 10;
    public int Height = 20;

    public int[,] Field;

    public GameField()
    {
        Field = new int[Height, Width];
    }

    public bool CheckCollision(Figure fig)
    {
        for (int y = 0; y < fig.Shape.GetLength(0); y++)
            for (int x = 0; x < fig.Shape.GetLength(1); x++)
            {
                if (fig.Shape[y, x] == 0)
                    continue;

                int newX = fig.X + x;
                int newY = fig.Y + y;

                if (newX < 0 || newX >= Width || newY >= Height)
                    return true;

                if (newY >= 0 && Field[newY, newX] == 1)
                    return true;
            }

        return false;
    }

    public void Merge(Figure fig)
    {
        for (int y = 0; y < fig.Shape.GetLength(0); y++)
            for (int x = 0; x < fig.Shape.GetLength(1); x++)
            {
                if (fig.Shape[y, x] == 1)
                    Field[fig.Y + y, fig.X + x] = 1;
            }
    }

    public int ClearLines()
    {
        int linesCleared = 0;

        for (int y = Height - 1; y >= 0; y--)
        {
            bool full = true;

            for (int x = 0; x < Width; x++)
            {
                if (Field[y, x] == 0)
                {
                    full = false;
                    break;
                }
            }

            if (full)
            {
                linesCleared++;

                for (int row = y; row > 0; row--)
                    for (int col = 0; col < Width; col++)
                        Field[row, col] = Field[row - 1, col];

                for (int col = 0; col < Width; col++)
                    Field[0, col] = 0;

                y++;
            }
        }

        return linesCleared;
    }

    public void Draw(Figure current, Figure next, int score)
    {
        Console.SetCursorPosition(0, 0);

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                bool isFigure = false;

                for (int fy = 0; fy < current.Shape.GetLength(0); fy++)
                    for (int fx = 0; fx < current.Shape.GetLength(1); fx++)
                    {
                        if (current.Shape[fy, fx] == 1 &&
                            current.X + fx == x &&
                            current.Y + fy == y)
                        {
                            Console.Write("[]");
                            isFigure = true;
                        }
                    }

                if (!isFigure)
                    Console.Write(Field[y, x] == 1 ? "[]" : " .");
            }

            if (y == 1)
                Console.Write($"   Score: {score}");

            if (y == 3)
                Console.Write("   Next:");

            if (y >= 4 && y < 4 + next.Shape.GetLength(0))
            {
                Console.Write("   ");
                for (int x = 0; x < next.Shape.GetLength(1); x++)
                {
                    Console.Write(next.Shape[y - 4, x] == 1 ? "[]" : "  ");
                }
            }

            Console.WriteLine();
        }
    }
}

class TetrisGame
{
    GameField field = new GameField();
    Random rand = new Random();

    Figure current;
    Figure next;

    int score = 0;

    int[][,] figures =
    {
        new int[,] {{1,1,1,1}},
        new int[,] {{1,1},{1,1}},
        new int[,] {{0,1,0},{1,1,1}},
        new int[,] {{1,0,0},{1,1,1}},
        new int[,] {{0,0,1},{1,1,1}},
        new int[,] {{1,1,0},{0,1,1}},
        new int[,] {{0,1,1},{1,1,0}}
    };

    public void Start()
    {
        Console.CursorVisible = false;

        next = RandomFigure();
        SpawnFigure();

        while (true)
        {
            HandleInput();
            Update();

            field.Draw(current, next, score);

            Thread.Sleep(200);
        }
    }

    Figure RandomFigure()
    {
        return new Figure(figures[rand.Next(figures.Length)]);
    }

    void SpawnFigure()
    {
        current = next;
        current.X = 4;
        current.Y = 0;

        next = RandomFigure();

        if (field.CheckCollision(current))
        {
            Console.Clear();
            Console.WriteLine("GAME OVER");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("Press any key to restart");
            Console.ReadKey();

            field = new GameField();
            score = 0;

            next = RandomFigure();
            SpawnFigure();
        }
    }

    void HandleInput()
    {
        if (!Console.KeyAvailable)
            return;

        var key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.LeftArrow)
        {
            current.X--;
            if (field.CheckCollision(current))
                current.X++;
        }

        if (key == ConsoleKey.RightArrow)
        {
            current.X++;
            if (field.CheckCollision(current))
                current.X--;
        }

        if (key == ConsoleKey.DownArrow)
        {
            current.Y++;
            if (field.CheckCollision(current))
                current.Y--;
        }

        if (key == ConsoleKey.UpArrow)
        {
            current.Rotate();

            if (field.CheckCollision(current))
            {
                current.Rotate();
                current.Rotate();
                current.Rotate();
            }
        }
    }

    void Update()
    {
        current.Y++;

        if (field.CheckCollision(current))
        {
            current.Y--;

            field.Merge(current);

            int cleared = field.ClearLines();
            score += cleared * 100;

            SpawnFigure();
        }
    }
}

class Program
{
    static void Main()
    {
        TetrisGame game = new TetrisGame();
        game.Start();
    }
}