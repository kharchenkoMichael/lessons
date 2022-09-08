int[,] map = new int[3, 3];//0 - пуста клітка; 1 - хрестик; 2 - нулик;

bool firstPlayer = true; // другий гравець - false
int row = 0, column = 0;

while (true)
{
    DrawMap(map);
    if (firstPlayer)
    {
        Console.WriteLine("First Player turn (X)");
    }
    else
    {
        Console.WriteLine("Second Player turn (0)");
    }

    Console.WriteLine("Enter row:");
    row = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter column:");
    column = int.Parse(Console.ReadLine());

    map[row, column] = firstPlayer ? 1 : 2;

    if (CheckMapState(map))
    {
        break;
    }

    firstPlayer = !firstPlayer;
}

void DrawMap(int[,] map)
{
    for (int i = 0; i < map.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < map.GetUpperBound(1) + 1; j++)
        {
            switch (map[i, j])
            {
                case 0:
                    Console.Write(' ');
                    break;
                case 1:
                    Console.Write('X');
                    break;
                case 2:
                    Console.Write('O');
                    break;
            }
            if (j != map.GetUpperBound(1))
            {
                Console.Write('|');
            }
        }

        Console.WriteLine();
        if (i != map.GetUpperBound(0))
        {
            Console.Write("-----");
        }
        Console.WriteLine();
    }
}

bool CheckMapState(int[,] map)
{
    //TODO: Implent method
    return false;
}