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

        public static byte[,] ImageFiltering(int maxWindowSize, bool countSort,byte[,] imageMatrix)
        {
            int width = ImageOperations.GetWidth(imageMatrix);

            int height = ImageOperations.GetHeight(imageMatrix);

            byte[,] newImageMatrix = new byte[height, width];

            for (int x = 0; x < height; x++)
            {
                for(int y = 0; y < width; y++)
                { 

                    for (int windowSize = minWindowSize; windowSize <= maxWindowSize; windowSize+=2)
                    {
                        byte[] pixels = ImageOperations.constructWindowOfPixels(imageMatrix,x,y,windowSize);

                        byte[] sortedPixels = sortPixels(pixels, countSort); 
                        
                        byte median = getMedianPixel(sortedPixels);
                        
                        if (!isNoisyPixel(median, sortedPixels))
                        {
                            if (isNoisyPixel(newImageMatrix[x, y], sortedPixels))
                            {
                                newImageMatrix[x, y] = median;
                            }
                            else
                            {
                                newImageMatrix[x, y] = imageMatrix[x, y];
                            }
                            break;
                        }
                        else
                        {
                            if (windowSize + 2 > maxWindowSize) 
                                newImageMatrix[x, y] = median;
                        }              
                    }
                }
            }
            return newImageMatrix;
        }
        private static byte getMedianPixel(byte[] pixels)
        {
            int med = (pixels.Length) / 2;
            return pixels[med];
        }
        private static byte getMaxPixel(byte[] pixels)
        {
            int last = pixels.Length - 1;
            return pixels[last];
        }
        private static byte getMinPixel(byte[] pixels)
        {
            return pixels[0];
        }  
        private static bool isNoisyPixel(int pixel,byte[] pixels)
        {
            byte minPixel = getMinPixel(pixels);
            byte maxPixel = getMaxPixel(pixels);
            int diffBetweenCurrentPixelAndMaxPixel = maxPixel - pixel;
            int diffBetweenCurrentPixelAndMinPixel = pixel - minPixel;

            return (diffBetweenCurrentPixelAndMaxPixel == 0 || diffBetweenCurrentPixelAndMinPixel == 0);
        }
        private static byte[] sortPixels(byte[] pixels,bool countSort)
        {
            byte[] sortedPixels;

            if (countSort)
                sortedPixels = Algorithms.Sort.countingSort(pixels);
            else
                sortedPixels = Algorithms.Sort.quickSort(pixels,0,pixels.Length);

            return sortedPixels;
        }
    }
}