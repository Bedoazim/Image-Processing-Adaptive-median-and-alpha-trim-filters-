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

            for(int x = 0; x < height; x++)
            {
                for(int y = 0; y < width; y++)
                {
                    for (int windowSize = minWindowSize; windowSize <= maxWindowSize; windowSize++)
                    {
                        byte[] pixels = ImageOperations.constructWindowOfPixels(imageMatrix,x,y,windowSize);

                        byte[] sortedPixels = sortPixels(pixels, countSort);                      
                        
                        if (isTrueMedian(sortedPixels))
                        {
                            if (isNoisyPixel(imageMatrix[x, y],sortedPixels)) 
                                imageMatrix[x, y] = getMedianPixel(sortedPixels);
                            break;
                        }
                        else
                        {
                            windowSize++;

                            if(windowSize >= maxWindowSize)
                                imageMatrix[x, y] = getMedianPixel(sortedPixels);
                        }              
                    }
                }
            }
            return imageMatrix;
        }
        private byte getMedianPixel(byte[] pixels)
        {
            byte median;
            int med= pixels.Length / 2;
            if(pixels.Length % 2 != 0)
            {
                median = pixels[med];    
            }
            else
            {
                median = (byte)((pixels[med]) + (pixels[med - 1]) / 2);
            }
            return median;
        }
        private byte getMaxPixel(byte[] pixels)
        {
            int last= pixels.Length-1;
            return pixels[last];
        }
        private byte getMinPixel(byte[] pixels)
        {
            return pixels[0];
        }  
        private bool isTrueMedian(byte[] pixels)
        {
            int medianPixel = getMedianPixel(pixels);
            int minPixel = getMinPixel(pixels);
            int maxPixel = getMaxPixel(pixels);
            int diffBetweenMedianAndMax = maxPixel - medianPixel;
            int diffBetweenMedianAndMin = medianPixel - minPixel;

            return (diffBetweenMedianAndMax > 0 && diffBetweenMedianAndMin > 0);
        }
        private bool isNoisyPixel(int pixel,byte[] pixels)
        {
            byte minPixel = getMinPixel(pixels);
            byte maxPixel = getMaxPixel(pixels);
            int diffBetweenCurrentPixelAndMaxPixel = maxPixel - pixel;
            int diffBetweenCurrentPixelAndMinPixel = pixel - minPixel;

            return (diffBetweenCurrentPixelAndMaxPixel <= 0 && diffBetweenCurrentPixelAndMinPixel <= 0);
        }
        private byte[] sortPixels(byte[] pixels,bool countSort)
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