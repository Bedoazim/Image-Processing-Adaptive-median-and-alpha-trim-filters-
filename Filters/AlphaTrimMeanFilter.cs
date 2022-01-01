using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Algorithms_Project.Algorithms;
using Algorithms_Project.Filters;


namespace Algorithms_Project.Filters
{
    class AlphaTrimMeanFilter
    {

        // O((height*width)*(windowSize*windowSize)*(pixels.Length + maxPixel - minPixel)*pixels.Length))
        public static byte[,] ImageFiltering(int windowSize, int trimValue, bool countingSort, byte[,] imageMatrix)
        {
            int width = ImageOperations.GetWidth(imageMatrix); // O(1)

            int height = ImageOperations.GetHeight(imageMatrix); // O(1)

            byte[,] newImageMatrix = new byte[height, width]; // O(1) 

            for (int x = 0; x < height; x++) // O(height)
            {
                for (int y = 0; y < width; y++) // O(width)
                {
                    byte[] pixels = ImageOperations.constructWindowOfPixels(imageMatrix, x, y, windowSize); // O(windowSize*windowSize)

                    byte[] middlePixels = removingTMaxAndMin(pixels, trimValue, countingSort); // O(pixels.Length + maxPixel - minPixel)

                    newImageMatrix[x, y] = getMeanOfPixels(middlePixels); //O(pixels.Length)
                }
            }

            return newImageMatrix;
        }
        private static byte[] removingTMaxAndMin(byte[] pixels, int trimValue, bool countingSort) // O(pixels.Length + maxPixel - minPixel)
        {
            byte[] remainingPixels = new byte[(pixels.Length) - (2 * trimValue)]; // O(1) 
            if (countingSort)
            {
                byte[] sortedPixels = Algorithms.Sort.countingSort(pixels); // O(pixels.Length + maxPixel - minPixel)
                int index = 0; // O(1)
                for (int i = trimValue; i < sortedPixels.Length - trimValue; i++) // O(sortedPixels.length - (trimValue*2))
                {
                    remainingPixels[index++] = sortedPixels[i]; // O(1)
                }
            }
            else
            {
                remainingPixels = Algorithms.SelectingKthElemenet.smallest(pixels, trimValue);// O(pixels.Length + maxPixel - minPixel))
                remainingPixels = Algorithms.SelectingKthElemenet.largest(remainingPixels, trimValue); // O(remainingPixels.Length + maxPixel - minPixel))
            }
            return remainingPixels; // O(1)
        }
        private static byte getMeanOfPixels(byte[] pixels) // O(pixels.Length)
        {
            int meanOfPixels = 0; // O(1)
            for (int i = 0; i < pixels.Length; i++) // O(pixels.Length)
            {
                meanOfPixels += (int)pixels[i]; // O(1)
            }
            meanOfPixels /= pixels.Length; // O(1)
            return (byte)meanOfPixels; // O(1)
        }
        public static double[] getTimeForGraph(int maxWindow, int trimValue, bool countSort, byte[,] imageMatrix)
        {
            int size = ((maxWindow - 3) / 2) + 2; // O(1)
            double[] time = new double[size]; // O(1)
            time[0] = 0; // O(1)
            int index = 1; // O(1)
            for (int i = 3; i <= maxWindow; i += 2) // O(maxWindow)
            {
                byte[,] newImageMatrix = imageMatrix; // O(1) 
                Stopwatch stopwatch = new Stopwatch(); // O(1)
                stopwatch.Start(); // O(1)
                ImageFiltering(maxWindow, trimValue, countSort, newImageMatrix); 
                stopwatch.Stop(); // O(1)
                time[index++] = stopwatch.ElapsedMilliseconds; // O(1)
            }
            return time; // O(1)
        }
    }
}
