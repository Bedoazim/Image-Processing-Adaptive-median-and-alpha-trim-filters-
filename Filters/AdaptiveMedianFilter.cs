using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_Project.Algorithms;

namespace Algorithms_Project.Filters
{
    class AdaptiveMedianFilter
    {
        private const int minWindowSize = 3;

        public byte[,] ImageFiltering(int maxWindowSize, bool countSort,byte[,] imageMatrix)
        {
            int width=imageMatrix.GetLength(0);
            int height=imageMatrix.GetLength(1);

            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {


                }

            }
            return imageMatrix;
        }



    }
}