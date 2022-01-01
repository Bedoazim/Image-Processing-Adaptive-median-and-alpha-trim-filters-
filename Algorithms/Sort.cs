using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Project.Algorithms
{
    public static class Sort{

        public static byte[] quickSort(byte[] pixels,int low, int high)
        {
            if (low < high)
            {
                int pivotPosition = Partition(pixels, low, high);
                quickSort(pixels, low, pivotPosition - 1);
                quickSort(pixels, pivotPosition + 1, high);
            }
            return pixels;   
        }
        private static int Partition(byte[] pixels, int low, int high)
        {
            byte pivot = pixels[high];
            int lowWall = low;            
            for(int i = low ; i < high; i++)
            {
                if(pixels[i] <= pivot)
                {
                    Swap(pixels, i, lowWall);
                    lowWall++;
                }
            }
            Swap(pixels, high, lowWall);
            return lowWall;
        }
        private static void Swap(byte[] pixels,int first, int second)
        {
            byte swap = pixels[first];
            pixels[first] = pixels[second];
            pixels[second] = swap;
        }

        public static byte[] countingSort(byte[] pixels) // O(max(pixels.Length, maxPixel))
        {
            byte[] sortedPixels = new byte[pixels.Length]; // O(1)
            int[] frequency=new int[256]; // O(1)
            int index = 0; // O(1)
            byte minPixel = 255, maxPixel = 0; // O(1)
            for (int i = 0; i < pixels.Length; i++) // O(pixels.Length)
            {
                frequency[(int)pixels[i]]++; // O(1)
                minPixel = Math.Min(minPixel, pixels[i]); // O(1)
                maxPixel = Math.Max(maxPixel, pixels[i]); // O(1)
            }

            for (int i = minPixel; i <= maxPixel; i++) // O(maxPixel-minPixel+1)
            {
                for (int j = 0; j < frequency[i]; j++) // O(frequancy[i])
                {
                    sortedPixels[index++] = (byte)i; // O(1)
                }
            }
            /* 
             * Another implementation for counting sort in O(log(uniquePixels.Length)*Log(uniquePixels.Length)) which is preferred in small n (n < 197) *
              
            if (pixels.Length < 197)
            {
                SortedSet<byte> uniquePixels = new SortedSet<byte>(); // O(1)
                for (int i = 0; i < pixels.Length; i++) // O(pixels.Length)
                {
                    uniquePixels.Add(pixels[i]); // O(log(uniquePixels.Length))
                }
                foreach (int i in uniquePixels) // O(uniquePixels.Length)
                {
                    for (int j = 0; j < frequency[i]; j++) //O(frequancy[i])
                    {
                        sortedPixels[index++] = (byte)i; // O(1)
                    }
                }
            }*/
            return sortedPixels; // O(1)
        }

    }
}
