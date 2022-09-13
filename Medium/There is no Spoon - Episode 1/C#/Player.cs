using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Don't let the machines win. You are humanity's last hope...
 **/
class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis

        char[,] map = new char[height, width];

        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine(); // width characters, each either 0 or .
            for (int j = 0; j < width; j++)
            {
                map[i, j] = (char)line[j];
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if(map[i, j] == '0')
                {
                    string right = CheckRight(i, j, map);
                    string down = CheckDown(i, j, map);

                    Console.WriteLine("{0} {1} {2} {3}", j, i, right, down);
                }
            }
        }

        // Three coordinates: a node, its right neighbor, its bottom neighbor
        //Console.WriteLine("0 0 1 0 0 1");
    }

    public static string CheckRight(int i, int j, char[,] map)
    {
        for (int x = j+1; x < map.GetLength(1); x++)
        {
            if(map[i, x] == '0')
            {
                return x + " " +i;
            }
        }
        return "-1 -1";
    }

    public static string CheckDown(int i, int j, char[,] map)
    {
        for (int x = i+1; x < map.GetLength(0); x++)
        {
            if(map[x, j] == '0')
            {
                return j + " " + x;
            }
        }
        return "-1 -1";
    }
}