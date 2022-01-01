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

        public static byte[,] ImageFiltering(int windowSize, int trimValue, bool countingSort, byte[,] imageMatrix) // O( max( pixels.Length, maxPixel - minPixel, frequency[i], windowSize ^ 2  ) )
        {
            int width = ImageOperations.GetWidth(imageMatrix); // O(1)

            int height = ImageOperations.GetHeight(imageMatrix); // O(1)

            byte[,] newImageMatrix = new byte[height, width]; // O(1) not sure

            for (int x = 0; x < height; x++) // O(height)
            {
                for (int y = 0; y < width; y++) // O(width)
                {
                    byte[] pixels = ImageOperations.constructWindowOfPixels(imageMatrix, x, y, windowSize); // O(windowSize ^ 2)

                    byte[] middlePixels = removingTMaxAndMin(pixels, trimValue, countingSort); // O( max(  pixels.Length, maxPixel - minPixel, frequency[i] ))

                    newImageMatrix[x, y] = getMeanOfPixels(middlePixels); //O(pixels.Length)
                }
            }

            return newImageMatrix;
        }
        private static byte[] removingTMaxAndMin(byte[] pixels, int trimValue, bool countingSort) // O( max(  pixels.Length, maxPixel - minPixel, frequency[i] ))
        {
            byte[] remainingPixels = new byte[(pixels.Length) - (2 * trimValue)]; // O(1) not sure
            if (countingSort)
            {
                byte[] sortedPixels = Algorithms.Sort.countingSort(pixels); //O(max(pixels.Length, maxPixel))
                int index = 0; //O(1)
                for (int i = trimValue; i < sortedPixels.Length - trimValue; i++) //O( sortedPixels.length - 2 * trimValue )
                {
                    remainingPixels[index++] = sortedPixels[i]; //O(1)
                }
            }
            else
            {
                remainingPixels = Algorithms.SelectingKthElemenet.smallest(pixels, trimValue);// O( max(  pixels.Length, maxPixel - minPixel, frequency[i] ))
                remainingPixels = Algorithms.SelectingKthElemenet.largest(remainingPixels, trimValue); // O( max(pixels.Length, maxPixel - minPixel )
            }
            return remainingPixels; //O(1)
        }
        private static byte getMeanOfPixels(byte[] pixels) //O(pixels.Length)
        {
            int meanOfPixels = 0;//O(1)
            for (int i = 0; i < pixels.Length; i++) //O(pixels.Length)
            {
                meanOfPixels += (int)pixels[i]; //O(1)
            }
            meanOfPixels /= pixels.Length; //O(1)
            return (byte)meanOfPixels; //O(1)
        }
        public static double[] getTimeForGraph(int maxWindow, int trimValue, bool countSort, byte[,] imageMatrix)
        {
            int size = ((maxWindow - 3) / 2) + 2; //O(1)
            double[] time = new double[size]; //O(1)
            time[0] = 0; //O(1)
            int index = 1; //O(1)
            for (int i = 3; i <= maxWindow; i += 2) //O(maxWindow)
            {
                byte[,] newImageMatrix = imageMatrix; //O(1) not sure
                Stopwatch stopwatch = new Stopwatch(); //O(1)
                stopwatch.Start(); //O(1)
                ImageFiltering(maxWindow, trimValue, countSort, newImageMatrix); 
                stopwatch.Stop(); //O(1)
                time[index++] = stopwatch.ElapsedMilliseconds; //O(1)
            }
            return time; //O(1)
        }
    }
}
