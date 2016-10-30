using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace Fractal
{
    class MyFractal
    {
        private const string alpha = "60"; //угол поворота
        private const String Aksiom = "FXF--FF--FF"; //аксиома
        private const String Rule1 = "FF"; //первое правило
        private const String Rule2 = "--FXF++FXF++FXF--"; //второе правило
        

        public void TurtleDrawMyFractal(string lengthLine,int N)
        {
            string formula = FractalParcer.FullRule(Aksiom,Rule1,Rule2,N);
            Microsoft.SmallBasic.Library.GraphicsWindow.Width = 800;
            Microsoft.SmallBasic.Library.GraphicsWindow.Height = 680;
            Microsoft.SmallBasic.Library.GraphicsWindow.Clear();
            Turtle.Show();
            Turtle.X = 100;
            Turtle.Y = 650;
            Turtle.TurnRight();
            Turtle.Speed = 10;
            foreach (char c in formula)
            {
                switch (c)
                {
                    case 'F':
                        Turtle.Move(lengthLine);
                        break;
                    case '+':
                        Turtle.Turn(alpha);
                        break;
                    case '-':
                        Turtle.Turn("-" + alpha);
                        break;
                    case 'X':
                        break;
                    default:
                        throw new Exception();
                }
            }
            Turtle.Hide();
        }


    }
}
