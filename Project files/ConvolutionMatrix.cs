using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class ConvolutionMatrix
    {
        public int size = 5;
        public double Factor { get; set; }
        public double Offset { get; set; }

        private int[,] matrix = {  {0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0},
                                    {0, 0, 1, 0, 0},
                                    {0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0}
                                };

        public int[,] Matrix
        {
            get { return matrix; }
            set
            {
                matrix = value;

                Factor = 0;
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        Factor += matrix[i, j];

                if (Factor == 0)
                    Factor = 1;
            }
        }

        public ConvolutionMatrix()
        {
            Factor = 1;
            Offset = 0;
        }

        public void SetFactor(double fac)
        {
            Factor = fac;
        }
    }
}
