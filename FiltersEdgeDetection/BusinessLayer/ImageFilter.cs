using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace BLL
{
    public static class ImageFilters
    {
        private static BitmapData bitmapData, bitmapResult;

        public static Bitmap ApplyFilterCrazy(Bitmap bmp)
        {
            byte[] pixelBuffer = BitmapToByteArray(bmp, ref bitmapData);

            Color c0,c1,c2;

            for (int x = 0; x < bitmapData.Width; ++x)
            {
                for (int y = 0; y < bitmapData.Height; ++y)
                {
                    int pixelIndex = y * bitmapData.Stride + x * 4;

                    if(pixelIndex < pixelBuffer.Length) {

                        c0 = GetColorFromBuffer(pixelBuffer,pixelIndex);
                        c1 = Color.FromArgb(c0.A, c0.G/2, c0.B, c0.R);
                        c2 = Color.FromArgb(c1.A, c1.G, c1.B, c1.R);
                        SetPixel(pixelBuffer,pixelIndex, c2);

                    }
                }
            }

            Marshal.Copy(pixelBuffer, 0, bitmapData.Scan0, pixelBuffer.Length);
            bmp.UnlockBits(bitmapData);
            return bmp;
        }

        //black and white filter
        public static Bitmap ApplyBlackWhite(Bitmap bmp)
        {
            byte[] pixelBuffer = BitmapToByteArray(bmp, ref bitmapData);
            int rgb;
            Color c0,c1;

            for (int y = 0; y < bitmapData.Height; y++)
                for (int x = 0; x < bitmapData.Width; x++)
                {
                    int pixelIndex = y * bitmapData.Stride + x * 4;
                    c0 = GetColorFromBuffer(pixelBuffer, pixelIndex);
                    rgb = (c0.R + c0.G + c0.B) / 3;
                    c1 = Color.FromArgb(c0.A, rgb, rgb, rgb);
                    SetPixel(pixelBuffer, pixelIndex, c1);
                }

            Marshal.Copy(pixelBuffer, 0, bitmapData.Scan0, pixelBuffer.Length);
            bmp.UnlockBits(bitmapData);
            return bmp;
        }

        public static Color GetColorFromBuffer(byte[] pixelBuffer, int index)
        {
            int blue = pixelBuffer[index];
            int green = pixelBuffer[index + 1];
            int red = pixelBuffer[index + 2];
            int alpha = pixelBuffer[index + 3];

            return Color.FromArgb(alpha, red, green, blue);
        }

        public static void SetPixel(byte[] pixelBuffer, int index, Color color) {
            // BGRA
            pixelBuffer[index] = color.B;
            pixelBuffer[index + 1] = color.G;
            pixelBuffer[index + 2] = color.R;
            pixelBuffer[index + 3] = color.A;
        }

        public static int GetArea(int x, int y, int limitX, int limitY) {

            int areaX = x / limitX +1;
            int areaY = y / limitY;
            int area = areaY * 3 + areaX;

            if (area > 9)
                throw new ArgumentException("Unable to find area from pixel x/y: " + x + "/" + y);

            return area;
        }

        public static byte[] BitmapToByteArray(Bitmap image, ref BitmapData bitmapData1) {
            bitmapData1 = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);
            byte[] pixelBuffer = new byte[bitmapData1.Stride * bitmapData1.Height];
            Marshal.Copy(bitmapData1.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            return pixelBuffer;
        }

        public static string BitmapToHash(Bitmap image) {

            BitmapData bitmapData = null;
            byte[] pixelBuffer = BitmapToByteArray(image, ref bitmapData);
            Marshal.Copy(pixelBuffer, 0, bitmapData.Scan0, pixelBuffer.Length);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] realHash = md5.ComputeHash(pixelBuffer);
            string realHashStr = "";
            foreach (byte hashpart in realHash)
            {
                realHashStr += hashpart.ToString();
            }
            image.UnlockBits(bitmapData);

            return realHashStr;
        }

        public static Bitmap ApplyFilterMagicMosaic(Bitmap bmp)
        {

            int razX = Convert.ToInt32(bmp.Width / 3) + 1;
            int razY = Convert.ToInt32(bmp.Height / 3) + 1;
            Bitmap result = new Bitmap(bmp);

            byte[] pixelBufferSource = BitmapToByteArray(bmp, ref bitmapData);
            byte[] pixelBufferResult = BitmapToByteArray(result, ref bitmapResult);

            int pixelSource,pixelDestination;
            int workingArea;

            for (int x = 0; x < bmp.Width; ++x)
            {
                for (int y = 0; y < bmp.Height; ++y)
                {
                    pixelDestination = y * bitmapData.Stride + x * 4;

                    pixelSource = -1;
                    workingArea = GetArea(x, y, razX, razY);

                    switch (workingArea) {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                            pixelSource = y * bitmapData.Stride + x * 4;
                            break;
                        case 2:
                        case 4:
                            pixelSource =  x * bitmapData.Stride + y * 4;
                            break;
                        case 8:
                        case 9:
                            pixelSource = x / 3 * bitmapData.Stride + y / 3 * 4;
                            break;
                        case 6:
                            pixelSource =  x / 2 * bitmapData.Stride + y / 2 * 4;
                            break;
                    }

                    if (pixelDestination >= 0 && pixelSource < pixelBufferSource.Length && pixelDestination < pixelBufferResult.Length)
                    {
                        Color color = GetColorFromBuffer(pixelBufferSource, pixelSource);
                        SetPixel(pixelBufferResult, pixelDestination, color);
                    }
                }
            }

            Marshal.Copy(pixelBufferResult, 0, bitmapResult.Scan0, pixelBufferResult.Length);
            bmp.UnlockBits(bitmapData);
            result.UnlockBits(bitmapResult);
            return result;
        }
    }
}