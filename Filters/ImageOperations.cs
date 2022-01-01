using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Algorithms_Project.Filters
{
    class ImageOperations
    {
        public static byte[,] OpenImage(string ImagePath)
        {
            Bitmap original_bm = new Bitmap(ImagePath);
            int Height = original_bm.Height;
            int Width = original_bm.Width;

            byte[,] Buffer = new byte[Height, Width];

            unsafe
            {
                BitmapData bmd = original_bm.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, original_bm.PixelFormat);
                int x, y;
                int nWidth = 0;
                bool Format32 = false;
                bool Format24 = false;
                bool Format8 = false;

                if (original_bm.PixelFormat == PixelFormat.Format24bppRgb)
                {
                    Format24 = true;
                    nWidth = Width * 3;
                }
                else if (original_bm.PixelFormat == PixelFormat.Format32bppArgb || original_bm.PixelFormat == PixelFormat.Format32bppRgb || original_bm.PixelFormat == PixelFormat.Format32bppPArgb)
                {
                    Format32 = true;
                    nWidth = Width * 4;
                }
                else if (original_bm.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    Format8 = true;
                    nWidth = Width;
                }
                int nOffset = bmd.Stride - nWidth;
                byte* p = (byte*)bmd.Scan0;
                for (y = 0; y < Height; y++)
                {
                    for (x = 0; x < Width; x++)
                    {
                        if (Format8)
                        {
                            Buffer[y, x] = p[0];
                            p++;
                        }
                        else
                        {
                            Buffer[y, x] = (byte)((int)(p[0] + p[1] + p[2]) / 3);
                            if (Format24) p += 3;
                            else if (Format32) p += 4;
                        }
                    }
                    p += nOffset;
                }
                original_bm.UnlockBits(bmd);
            }

            return Buffer;
        }

        public static int GetHeight(byte[,] ImageMatrix)
        {
            return ImageMatrix.GetLength(0);
        }

        public static int GetWidth(byte[,] ImageMatrix)
        {
            return ImageMatrix.GetLength(1);
        }

        public static void DisplayImage(byte[,] ImageMatrix, PictureBox PicBox)
        {

            int Height = ImageMatrix.GetLength(0);
            int Width = ImageMatrix.GetLength(1);

            Bitmap ImageBMP = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);

            unsafe
            {
                BitmapData bmd = ImageBMP.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, ImageBMP.PixelFormat);
                int nWidth = 0;
                nWidth = Width * 3;
                int nOffset = bmd.Stride - nWidth;
                byte* p = (byte*)bmd.Scan0;
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        p[0] = p[1] = p[2] = ImageMatrix[i, j];
                        p += 3;
                    }

                    p += nOffset;
                }
                ImageBMP.UnlockBits(bmd);
            }
            PicBox.Image = ImageBMP;
        }

        public static byte[] constructWindowOfPixels(byte[,] imageMatrix, int x, int y, int windowSize) // O(windowSize*windowSize)
        {
            
            byte[] pixels = new byte[windowSize * windowSize]; // O(1) not sure

            int border = (windowSize - 1) / 2; // O(1)
            int upper = x - border, lower = x + border, right = y + border, left = y - border; // O(1)
            int height = GetHeight(imageMatrix), width = GetWidth(imageMatrix), index = 0; // O(1)

            if (upper < 0)
            {
                lower += 0 - upper; // O(1)
                upper = 0; // O(1)
            }
            else if (lower >= height)
            {
                upper -= lower - height; // O(1)
                lower = height - 1;  // O(1)
            }

            if (left < 0)
            {
                right += 0 - left; // O(1)
                left = 0; // O(1)
            }
            else if (right >= width)
            {
                left -= right - width; // O(1)
                right = width - 1;  // O(1)
            }

            for (int i = upper; i <= lower; i++) // O(lower-upper+1) windowsize
            {
                for (int j = left; j <= right; j++) // O(right-left+1) windowsize
                {
                    pixels[index++] = imageMatrix[i, j]; // O(1)
                }
            }
            return pixels; // O(1)
        }

        public static double[] constructingArrayOfWindowSizes(int maxWindow) // O(maxWindow)
        {
            int size=((maxWindow-3)/2)+2; // O(1)
            double[] windowSizes = new double[size]; // O(1) not sure
            windowSizes[0] = 0; // O(1)
            int index = 1; // O(1)
            for (int i = 3; i <= maxWindow; i+=2) // O(maxWindow)
            {
                windowSizes[index++] = i; // O(1)
            }
            return windowSizes; // O(1)
        } 

    }
}