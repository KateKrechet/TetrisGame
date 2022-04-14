using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TetrisGame
{
    class FigureFromFile : IFigureCreator
    {
        public Figure CreateFigure(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
            StreamReader
                     reader = new StreamReader(fileStream);
            //читаем фигуру из файла
            int n = Convert.ToInt32(reader.ReadLine());
            int count = Convert.ToInt32(reader.ReadLine());
            int[,,] buffer = new int[n, n, count];
            //считаываем на 0 слой символы из файла
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    buffer[i, j, 0] = reader.Read()-48;//Read читает 1 символ
            for (int i = 0; i < count - 1; i++)
                Rotate(buffer, n, i);
            return new Figure(buffer, n, count);
        }
        void Rotate(int[,,] m, int n, int layer)
        {
            //int[,] result = new int[n,n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    m[i, j, layer + 1] = m[n - j - 1, i, layer];

            // return result;
        }
    }
}
