using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    class Figure
    {
        public int[,,] Array { get; private set; }
        public int N { get; private set; }
        //ширина и высота одинаковые, фигура помещается в квадрат
        public int Count { get; private set; }//кол-во слоев, глубина
        //положение фигуры в поле
        public int Top { get; set; }
        public int Left { get; set; }
        public int Layer { get; private set; }//поворот фигуры
        public void NextLayer()
        {
            Layer++;
            Layer %= Count;
        }
        public Figure(int[,,]array,int n,int count)
        {
            Array = array;
            N = n;
            Count = count;
            Top = 0;
            Left = 0;
        }


    }
}
