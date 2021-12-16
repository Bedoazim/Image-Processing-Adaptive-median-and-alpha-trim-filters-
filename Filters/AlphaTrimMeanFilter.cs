using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_Project.Algorithms;


namespace Algorithms_Project.Filters
{
    class AlphaTrimMeanFilter
    {

        public static byte[,] ImageFiltering(int windowSize, int trimValue, bool countingSort, byte[,] imageMatrix)
        {
            int width = imageMatrix.GetLength(0);
            int height = imageMatrix.GetLength(1);

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {

                    byte[] pixels = ImageOperations.constructWindowOfPixels(imageMatrix, x, y, windowSize);

                    byte[] middlePixels = removingTMaxAndMin(pixels, trimValue, countingSort);

                    imageMatrix[x, y] =  getMeanOfPixels(middlePixels);
                }
            }

            return imageMatrix;
        }
        private static byte[] removingTMaxAndMin(byte[] pixels, int trimValue, bool countingSort)
        {
            byte[] remainingPixels=new byte[(pixels.Length)-(2*trimValue)];
            if (countingSort)
            {
                byte[] sortedPixels = Algorithms.Sort.countingSort(pixels);
                for(int i=trimValue; i<sortedPixels.Length-trimValue; i++)
                {
                    remainingPixels.Append(sortedPixels[i]); 
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
            byte meanOfPixels = 0;
            for (int i = 0; i < pixels.Length; i++)
            {
                meanOfPixels += pixels[i];
            }
            
            meanOfPixels /= (byte)pixels.Length;
         
            return meanOfPixels;
        }
    }
}
