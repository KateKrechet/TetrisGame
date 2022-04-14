using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    interface IFigureCreator
    {
        Figure CreateFigure(string filePath);
    }
}
