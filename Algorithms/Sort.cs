﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Project.Algorithms
{
    public static class Sort{

        public static byte[] quickSort(byte[] pixels,int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(pixels, left, right);
                if (pivot > 1)
                {
                    quickSort(pixels, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(pixels, pivot + 1, right);
                }
            }
            return pixels;
        }
        private static int Partition(byte[] pixels, int left, int right)
        {
            byte pivot;
            pivot = pixels[left];
            while (true)
            {
                while (pixels[left] < pivot)
                {
                    left++;
                }
                while (pixels[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    byte temp = pixels[right];
                    pixels[right] = pixels[left];
                    pixels[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public static byte[] countingSort(byte[] pixels)
        {
            
            byte[] sortedPixels = new byte[pixels.Length];
         
            int[] frequency=new int[260];
            
            byte minPixel=255, maxPixel=0;
            
            for(int i = 0; i < pixels.Length; i++)
            {
                frequency[pixels[i]]++;
            
                minPixel = Math.Min(pixels[i],minPixel);
                
                maxPixel = Math.Max(pixels[i],maxPixel);
            }
            for(byte i = minPixel;i <= maxPixel; i++)
            {
                for(int j = 0; j < frequency[i]; j++)
                {
                    sortedPixels.Append(i);
                }
            }
            return sortedPixels;
        }

    }
}