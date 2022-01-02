using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_Project.Algorithms;

namespace Algorithms_Project.Algorithms
{
    public static class SuperSort
    {
        public static byte getMedian (byte[] pixels,int mid,int low,int high) //O(high-low)
        {
            int expectedMedianPosition = partition(pixels, low, high); //O(high-low)
            int pos = expectedMedianPosition - low + 1; //O(1)

            if (pos == mid) //O(1)
            {
                return pixels[expectedMedianPosition]; //O(1)
            }
            if (pos > mid) //O(1)
            {
                return getMedian(pixels, mid, low, expectedMedianPosition - 1); //O(expectedMedianPosition - 1 - low)
            }
            else //O(1)
            {
                return getMedian(pixels, mid-pos, expectedMedianPosition + 1, high); //O(high-expectedMedianPosition + 1)
            }

        }
        private static int partition(byte[] pixels,int low,int high) //O(high-low)
        {
            byte pivot = getPivotValue(pixels, low, high); //O(Log5(pixels.Length))

            while (low < high) //O(high-low)
            {
                while (pixels[low] < pivot) //O(high-low)
                    low++; //O(1)

                while (pixels[high] > pivot) //O(high-low)
                    high--; //O(1)

                if (pixels[low] == pixels[high]) //O(1)
                    low++; //O(1)

                else if (low < high) //O(1)
                {
                    Algorithms_Project.Algorithms.Sort.Swap(pixels, low, high); //O(1)      
                }
            }

            return high; //O(1)
        }

        private static byte getPivotValue(byte[] pixels,int low,int high) //O(Log5(pixels.Length))
        {

            if ((high - low) + 1 <= 9) //O(1)
            {
                Array.Sort(pixels); //O(pixels.Length*Log(pixels.Length))
                return pixels[(pixels.Length / 2)]; //O(1)
            }

            byte[] chunck = null; //O(1)
            double numberOfChunks = Math.Ceiling((double)(high - low + 1) / 5); //O(1)
            byte[] medians = new byte[(int)numberOfChunks]; //O(1)
            int index = 0; //O(1)
            while (high >= low) //O(high-low)
            {
                chunck = new byte[Math.Min(5,(high-low+1))]; //O(1)

                for (int i = 0; i < chunck.Length && low <= high; i++) //O(chunck.length)
                {
                    chunck[i] = pixels[low++]; //O(1)
                }
                Array.Sort(chunck); //O(chucnk.Length*Log(chunck.Length))
                medians[index++] = chunck[(chunck.Length / 2)]; //O(1) 
            }
            return getPivotValue(medians, 0, (medians.Length - 1)); //O(Log5(medians.Length))
        }
    }

}
