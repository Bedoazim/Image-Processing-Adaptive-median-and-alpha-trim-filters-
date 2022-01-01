using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Project.Algorithms
{
    class SelectingKthElemenet
    {
        public static byte[] smallest(byte[] pixels,int k) // O( max(  pixels.Length, maxPixel - minPixel, frequency[i] ))
        {
            int [] frequency= new int[256]; // O(1) not sure
            byte[] selected = new byte[pixels.Length - k]; //O(1) not sure
            int index = 0; //O(1)
            byte minPixel = 255, maxPixel = 0; // O(1)

            for (int i = 0; i < pixels.Length; i++) //O( pixels.Length)
            {
                frequency[(int)pixels[i]]++; // O(1)
                minPixel=Math.Min(minPixel, pixels[i]); //O(1)
                maxPixel=Math.Max(maxPixel, pixels[i]); //O(1)
            }

            for(int i = (int)minPixel; i <= (int)maxPixel; i++) // O( maxPixel - minPixel)
            {
                if (k > frequency[i])  //O(1)
                {
                    k-=frequency[i]; //O(1)
                }
                else
                {
                    frequency[i] -= k; // O(1)
                    k = 0; // O(1)
                }

                if (k == 0) // O(1)
                {
                    for(int j = 0; j < frequency[i]; j++) // O(frequency[i])
                    {
                        selected[index++] = (byte)i; // O(1)
                    }
                }
            }

            return selected; // O(1)
        }

        public static byte[] largest(byte[] pixels,int k) // O( max(pixels.Length, maxPixel - minPixel )
        {
            byte[] frequency = new byte[256]; // O(1)
            byte[] selected = new byte[pixels.Length - k];      // O(1)     
            int index = 0;// O(1)
            byte minPixel = 255, maxPixel = 0;// O(1)
            for (int i = 0; i < pixels.Length; i++) // O(pixels.Length)
            {
                frequency[(int)pixels[i]]++; // O(1)
                minPixel = Math.Min(minPixel, pixels[i]); // O(1)
                maxPixel = Math.Max(maxPixel, pixels[i]); // O(1)
            }

            for (int i = (int)maxPixel; i >= (int)minPixel; i--) // O(maxPixel - minPixel)
            {
                if (k > frequency[i]) // O(1)
                { 
                    k -= frequency[i]; // O(1)
                }
                else
                {
                    frequency[(int)i] -= (byte)k; // O(1)
                    k = 0; // O(1)
                }

                if (k == 0) // O(1)
                {
                    for (int j = 0; j < frequency[i]; j++) // O(frequency[i])
                    {
                        selected[index++] = (byte)i; // O(1)
                    }
                }
            }

            return selected; // O(1)

        }


    }

}