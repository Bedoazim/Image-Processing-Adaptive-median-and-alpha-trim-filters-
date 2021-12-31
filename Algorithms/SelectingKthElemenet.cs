using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Project.Algorithms
{
    class SelectingKthElemenet
    {
        public static byte[] smallest(byte[] pixels,int k)
        {
            int [] frequency= new int[256];
            byte[] selected = new byte[pixels.Length - k];
            int index = 0;
            byte minPixel = 255, maxPixel = 0;

            for (int i = 0; i < pixels.Length; i++)
            {
                frequency[(int)pixels[i]]++;
                minPixel=Math.Min(minPixel, pixels[i]);
                maxPixel=Math.Max(maxPixel, pixels[i]);
            }

            for(int i = (int)minPixel; i <= (int)maxPixel; i++)
            {
                if (k > frequency[i])
                {
                    k-=frequency[i];
                }
                else
                {
                    frequency[i] -= k;
                    k = 0;
                }

                if (k == 0 )
                {
                    for(int j = 0; j < frequency[i]; j++)
                    {
                        selected[index++] = (byte)i;
                    }
                }
            }

            return selected;
        }

        public static byte[] largest(byte[] pixels,int k)
        {
            byte[] frequency = new byte[256];
            byte[] selected = new byte[pixels.Length - k];           
            int index = 0;
            byte minPixel = 255, maxPixel = 0;
            for (int i = 0; i < pixels.Length; i++)
            {
                frequency[(int)pixels[i]]++;
                minPixel = Math.Min(minPixel, pixels[i]);
                maxPixel = Math.Max(maxPixel, pixels[i]);
            }

            for (int i = (int)maxPixel; i >= (int)minPixel; i--)
            {
                if (k > frequency[i])
                {
                    k -= frequency[i];
                }
                else
                {
                    frequency[(int)i] -= (byte)k;
                    k = 0;
                }

                if (k == 0)
                {
                    for (int j = 0; j < frequency[i]; j++)
                    {
                        selected[index++] = (byte)i;
                    }
                }
            }

            return selected;

        }


    }

}