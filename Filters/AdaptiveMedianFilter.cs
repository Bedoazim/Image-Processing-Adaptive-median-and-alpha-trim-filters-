﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using Algorithms_Project.Algorithms;

namespace Algorithms_Project.Filters
{
    class AdaptiveMedianFilter
    {
        private const int minWindowSize = 3;
        // Quick Sort
        // O((height * width)*((maxWindowSize - minWindowSize + 1))*(windowSize * windowSize)*((pixels.Length)*(pixels.Length)))
        // Counting Sort
        // O((height * width)*((maxWindowSize - minWindowSize + 1))*(windowSize * windowSize)*(O(pixels.Length + maxPixel - minPixel)))
        public static byte[,] ImageFiltering(int maxWindowSize, bool countSort,byte[,] imageMatrix)
        {
            int width = ImageOperations.GetWidth(imageMatrix); // O(1)

            int height = ImageOperations.GetHeight(imageMatrix); // O(1)

            byte[,] newImageMatrix = new byte[height, width]; // O(1) 

            for (int x = 0; x < height; x++)  // O(height)
            {
                for(int y = 0; y < width; y++) // O(width)
                { 

                    for (int windowSize = minWindowSize; windowSize <= maxWindowSize; windowSize+=2) // O(maxWindowSize - minWindowSize + 1)
                    {
                        byte[] pixels = ImageOperations.constructWindowOfPixels(imageMatrix,x,y,windowSize); // O(windowSize*windowSize)

                        byte[] sortedPixels = sortPixels(pixels, countSort); // O((pixels.Length)*(pixels.Length))

                                               byte median = getMedianPixel(sortedPixels); // O(1)

                        //byte median = Algorithms_Project.Algorithms.SuperSort.getMedian(pixels, (pixels.Length / 2) + 1, 0, (pixels.Length - 1));
                        
                        if (!isNoisyPixel(median, sortedPixels)) // O(1)
                        {
                            if (isNoisyPixel(imageMatrix[x, y], sortedPixels)) // O(1)
                            {
                                newImageMatrix[x, y] = median; // O(1)
                            }
                            else
                            {
                                newImageMatrix[x, y] = imageMatrix[x, y]; // O(1)
                            }
                            break;
                        }
                        else
                        {
                            if (windowSize + 2 > maxWindowSize) // O(1)
                            {

                                /*byte neValue = 0; // O(1)
                                for(int k = 0; k < sortedPixels.Length; k++) // O(sortedPixels.Length)
                                {
                                    if (sortedPixels[k] != (byte)0 && sortedPixels[k] != (byte)255) // O(1)
                                    {
                                        neValue = sortedPixels[k]; // O(1)
                                        break; 
                                    }
                                }
                                if (neValue != (byte)0) // O(1)
                                {
                                    newImageMatrix[x, y] = neValue; // O(1)
                                }
                                else*/
                                newImageMatrix[x, y] = median; // O(1)
                            }
                        }              
                    }
                }
            }
            return newImageMatrix; // O(1)
        }
        private static byte getMedianPixel(byte[] pixels) // O(1)
        {
            int med = (pixels.Length) / 2; // O(1)
            if (pixels.Length % 2 == 0) // O(1)
            {
                int median = pixels[med] + pixels[med - 1]; // O(1)
                return (byte)(median / 2); // O(1)
            }
            return pixels[med]; // O(1)
        } 
        private static bool isNoisyPixel(byte pixel,byte[] pixels) // O(1)
        {
            byte minPixel = pixels[pixels.Length-1]; // O(1)
            byte maxPixel = pixels[0]; // O(1)
            return (pixel == minPixel || pixel == maxPixel); // O(1)
        }
        private static byte[] sortPixels(byte[] pixels,bool countSort) 
        {
            byte[] sortedPixels; // O(1)

            if (countSort) // O(1)
                sortedPixels = Algorithms.Sort.countingSort(pixels); // O(pixels.Length + maxPixel - minPixel)
            else
                sortedPixels = Algorithms.Sort.quickSort(pixels, 0, pixels.Length - 1);  // O((pixels.Length)*(pixels.Length))

            return sortedPixels; // O(1)
        }

        public static double[] getTimeForGraph(int maxWindow, bool countSort, byte[,] imageMatrix)
        {
            int size = ((maxWindow - 3) / 2) + 2; // O(1)
            double[] time = new double[size]; // O(1)
            time[0] = 0; // O(1)
            int index = 1; // O(1)
            for (int i = 3; i <= maxWindow; i += 2) // O(maxWindow)
            {
                byte[,] newImageMatrix = imageMatrix; // O(1)
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                // O((height * width)*((maxWindowSize - minWindowSize + 1))*(windowSize * windowSize)*((pixels.Length)*(pixels.Length)))
                ImageFiltering(maxWindow, countSort, newImageMatrix); 
                stopwatch.Stop();
                time[index++] = stopwatch.ElapsedMilliseconds; // O(1)
            }
            return time; // O(1)
        }
    }
}