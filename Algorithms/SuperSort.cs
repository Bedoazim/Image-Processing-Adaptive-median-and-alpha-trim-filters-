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
        public static byte getMedian (byte[] pixels,int mid,int low,int high)
        {
            int expectedMedianPosition = partition(pixels, low, high);
            int pos = expectedMedianPosition - low + 1;

            if (pos == mid)
            {
                return pixels[expectedMedianPosition];
            }
            if (pos > mid)
            {
                return getMedian(pixels, mid, low, expectedMedianPosition - 1);
            }
            else
            {
                return getMedian(pixels, mid, expectedMedianPosition + 1, high);
            }

        }
        private static int partition(byte[] pixels,int low,int high)
        {
            byte pivot = getPivotValue(pixels, low, high);

            while(low< high)
            {
                while (pixels[low] < pivot) low++;
                while (pixels[high] > pivot) high--;

                if (pixels[low] == pixels[high]) low++;

                else if (low < high)
                {
                    //Algorithms_Project.Algorithms.Sort.Swap(pixels, low, high);
                    byte tmp=pixels[low];
                    pixels[low] = pixels[high];
                    pixels[high] = tmp;
                }
            }

            return high;
        }

        private static byte getPivotValue(byte[] pixels,int low,int high)
        {

            if ((high - low) + 1 <= 9)
            {
                Array.Sort(pixels);
                return pixels[(pixels.Length / 2)];
            }

            byte[] chunck = null;
            double numberOfChunks = Math.Ceiling((double)(high - low + 1) / 5);
            byte[] medians = new byte[(int)numberOfChunks];
            int index = 0;
            while (high >= low)
            {
                chunck = new byte[Math.Min(5,(high-low+1))];

                for(int i = 0; i < chunck.Length && low <= high; i++)
                {
                    chunck[i] = pixels[low++];
                }
                Array.Sort(chunck);
                medians[index++] = chunck[(chunck.Length / 2)]; 
            }
            return getPivotValue(medians, 0, (medians.Length - 1));
        }
    }

}
