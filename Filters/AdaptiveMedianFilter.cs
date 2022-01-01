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

        public static byte[,] ImageFiltering(int maxWindowSize, bool countSort,byte[,] imageMatrix)
        {
            int width = ImageOperations.GetWidth(imageMatrix);

            int height = ImageOperations.GetHeight(imageMatrix);

            byte[,] newImageMatrix = new byte[height, width];

            for (int x = 0; x < height; x++)
            {
                for(int y = 0; y < width; y++)
                { 

                    for (int windowSize = minWindowSize; windowSize <= maxWindowSize; windowSize++)
                    {
                        byte[] pixels = ImageOperations.constructWindowOfPixels(imageMatrix,x,y,windowSize);

                        byte[] sortedPixels = sortPixels(pixels, countSort); 
                        
                        byte median = getMedianPixel(sortedPixels);
                        
                        if (!isNoisyPixel(median, sortedPixels))
                        {
                            if (isNoisyPixel(imageMatrix[x, y], sortedPixels))
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
                            windowSize++;
                            if (windowSize >= maxWindowSize)
                            {
                                
                                /*byte neValue = 0;
                                for(int k = 0; k < sortedPixels.Length; k++)
                                {
                                    if (sortedPixels[k] != (byte)0 && sortedPixels[k] != (byte)255)
                                    {
                                        neValue = sortedPixels[k];
                                        break;
                                    }
                                }
                                if (neValue != (byte)0)
                                {
                                    newImageMatrix[x, y] = neValue;
                                }
                                else*/
                                    newImageMatrix[x, y] = median;
                            }
                        }              
                    }
                }
            }
            return newImageMatrix;
        }
        private static byte getMedianPixel(byte[] pixels)
        {
            int med = (pixels.Length) / 2;
            if (pixels.Length % 2 == 0)
            {
                int median = pixels[med] + pixels[med - 1];
                return (byte)(median / 2);
            }
            return pixels[med];
        } 
        private static bool isNoisyPixel(byte pixel,byte[] pixels)
        {
            byte minPixel = pixels[pixels.Length-1];
            byte maxPixel = pixels[0];
            return (pixel == minPixel || pixel == maxPixel);
        }
        private static byte[] sortPixels(byte[] pixels,bool countSort)
        {
            byte[] sortedPixels;

            if (countSort)
                sortedPixels = Algorithms.Sort.countingSort(pixels);
            else
                sortedPixels = Algorithms.Sort.quickSort(pixels, 0, pixels.Length - 1);

            return sortedPixels;
        }

        public static double[] getTimeForGraph(int maxWindow, bool countSort, byte[,] imageMatrix)
        {
            int size = ((maxWindow - 3) / 2) + 2;
            double[] time = new double[size];
            time[0] = 0;
            int index = 1;
            for (int i = 3; i <= maxWindow; i += 2)
            {
                byte[,] newImageMatrix = imageMatrix;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                ImageFiltering(maxWindow, countSort, newImageMatrix);
                stopwatch.Stop();
                time[index++] = stopwatch.ElapsedMilliseconds;
                Console.Write(stopwatch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine();
            return time;
        }
    }
}