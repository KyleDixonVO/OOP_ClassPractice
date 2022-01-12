using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassPractice
{
    class Mapper
    {

        public char[,] map = new char[,]

            {
            {'^','^','^','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'^','^','\'','\'','\'','\'','*','*','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','~','\'','\'','\''},
        {'^','^','\'','\'','\'','*','*','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\''},
        {'^','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','~','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','^','^','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','~','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','^','^','\'','\'','\''},
        {'\'','\'','\'','\'','\'','\'','\'','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        //{'\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''}, //extra row for testing
        };

        public int rows;
        public int columns;
        public int dimension;
        public int scale = 2;
        public int i;
        public int j;

        public void SetBounds()
        {
            rows = map.GetUpperBound(dimension) + 1;
            columns = map.GetUpperBound(dimension + 1) + 1;
        }

        public void DisplayMap(int scale)
        {
            Console.SetWindowSize(((columns * scale) + 2), ((rows * scale) + 3));
            Console.SetBufferSize(((columns * scale) + 2), ((rows * scale) + 3));
            HorizontalBorder(scale);
            for (i = 0; i < (rows); i++)
            {
                for (int l = 0; l < scale; l++)
                {
                    VerticalBorder();
                    for (j = 0; j < (columns); j++)
                    {
                        for (int k = 0; k < scale; k++)
                        {
                            ColorMap(i, j);
                            Console.Write(map[i, j]);
                        }
                    }
                    VerticalBorder();
                }
            }
            HorizontalBorder(scale);
            Console.ResetColor();
        }

        public void ColorMap(int i, int j)
        {
            if(map[i, j] == '\'')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            if (map[i, j] == '^')
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            if (map[i, j] == '*')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            if (map[i, j] == '~')
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.Blue;
            }
        }

        public void VerticalBorder()
        {
            Console.ResetColor();
            Console.Write('¦');
        }

        public void HorizontalBorder(int scale)
        {
            for (int m = 0; m < ((columns * scale) + 2); m++)
            {
                Console.Write('»');
            }
        }
    }
}
