using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
     class GameBoy
    {
        public int[,] Area { get;  set; }
        public int Score { get; protected set; }
        public int Level { get; protected set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        protected List<Figure> Figures { get; set; }

        public GameBoy(int height,int width)
        {
            Area = new int[height, width];
            Height = height;
            Width = width;
            Score = 0;
            Level = 1;

            //стенки
            for(int i = 0;i<height;i++)//левая и правая стенки
            {
                Area[i, width - 1] = -1;
                Area[i, 0] = -1;
            }
            for (int i = 0; i < width; i++)//верхняя и нижняя стенки
            {
                Area[height-1, i] = -1;
                Area[0,i] = -1;
            }

        }
       // public abstract void Control(int key);
    }
}
