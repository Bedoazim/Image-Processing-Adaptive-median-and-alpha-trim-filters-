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

        public static byte[] countingSort(byte[] pixels)
        {
            byte[] sortedPixels = new byte[pixels.Length];
            int[] frequency=new int[256];
            int index = 0;
            SortedSet<byte> uniquePixels = new SortedSet<byte>();
            for (int i = 0; i < pixels.Length; i++)
            {
                frequency[(int)pixels[i]]++;
                uniquePixels.Add(pixels[i]);
            }
            foreach(int i in uniquePixels)
            {
                for (int j = 0; j < frequency[i]; j++)
                {
                    sortedPixels[index++] = (byte)i;
                }   
            }
            return sortedPixels;
        }

    }
}
