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
            int [] frequency= new int[pixels.Length];
            byte[] selected = new byte[pixels.Length-k];
            int index = 0;
            byte minPixel = 255, maxPixel = 0;

            for (int i = minPixel; i <= maxPixel; i++)
            {
                frequency[i] = 0;
            }

            for (int i = 0; i < pixels.Length; i++)
            {
                frequency[pixels[i]]++;
            }

            for(byte i = minPixel; i <= maxPixel; i++)
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
                        selected[index++] = i;
                    }
                }
            }

            return selected;
        }

        public static byte[] largest(byte[] pixels,int k)
        {
            byte[] frequency = new byte[pixels.Length];
            
            byte[] selected = new byte[pixels.Length - k];
            
            int index = 0;

            byte minPixel = 255, maxPixel = 0;

            for (int i = minPixel; i <= maxPixel; i++)
            {
                frequency[i] = 0;
            }

            for (byte i = maxPixel; i >= minPixel; i--)
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
                        selected[index++] = i;
                    }
                }
            }

            return selected;

        }


    }

}