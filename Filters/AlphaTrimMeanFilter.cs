using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_Project.Algorithms;
using Algorithms_Project.Filters;


namespace Algorithms_Project.Filters
{
    class AlphaTrimMeanFilter
    {

        public static byte[,] ImageFiltering(int windowSize, int trimValue, bool countingSort, byte[,] imageMatrix)
        {
            int width = ImageOperations.GetWidth(imageMatrix);
            
            int height = ImageOperations.GetHeight(imageMatrix);

            byte[,] newImageMatrix = new byte[height, width];

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    byte[] pixels = ImageOperations.constructWindowOfPixels(imageMatrix, x, y, windowSize);

                    byte[] middlePixels = removingTMaxAndMin(pixels, trimValue, countingSort);

                    newImageMatrix[x, y] =  getMeanOfPixels(middlePixels);
                }
            }

            return newImageMatrix;
        }
        private static byte[] removingTMaxAndMin(byte[] pixels, int trimValue, bool countingSort)
        {
            byte[] remainingPixels=new byte[(pixels.Length)-(2*trimValue)];
            if (countingSort)
            {
                byte[] sortedPixels = Algorithms.Sort.countingSort(pixels);
                int index = 0;
                for(int i=trimValue; i<sortedPixels.Length-trimValue; i++)
                {
                    remainingPixels[index++] = sortedPixels[i]; 
                } 
            }
            else
            {
                remainingPixels = Algorithms.SelectingKthElemenet.smallest(pixels,trimValue);
                remainingPixels = Algorithms.SelectingKthElemenet.largest(remainingPixels,trimValue);
            }
            return remainingPixels;
        }
        private static byte getMeanOfPixels(byte[] pixels)
        {
            int meanOfPixels = 0;
            for (int i = 0; i < pixels.Length; i++)
            {
                meanOfPixels += (int)pixels[i];
            }
            meanOfPixels /= pixels.Length;
            return (byte)meanOfPixels;
        }
        public static double[] getTimeForGraph(int maxWindow, int trimValue, bool countSort, byte[,] imageMatrix)
        {
            int size = ((maxWindow - 3) / 2) + 2;
            double[] time = new double[size];
            time[0] = 0;
            double timeBefore, timeAfter, totalTime;
            int index = 1;
            for (int i = 3; i <= maxWindow; i += 2)
            {
                byte[,] newImageMatrix = imageMatrix;
                timeBefore = System.Environment.TickCount;
                ImageFiltering(maxWindow, trimValue, countSort, newImageMatrix);
                timeAfter= System.Environment.TickCount;
                totalTime = (timeAfter - timeBefore);
                time[index++] = totalTime;
            }
            return time;
        }
    }
}
