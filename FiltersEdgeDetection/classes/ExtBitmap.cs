/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using PictureBox.Image.Testes;

namespace ImageEdgeDetection
{
    public static class ExtBitmap
    {
        public static Bitmap AdaptToSquareCanvas(this Bitmap sourceBitmap, int canvasWidthLenght)
        {
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ?
                          sourceBitmap.Width : sourceBitmap.Height;

            float ratio = maxSide / (float)canvasWidthLenght;

            Bitmap bitmapResult = (sourceBitmap.Width > sourceBitmap.Height ?
                                    new Bitmap(canvasWidthLenght, (int)(sourceBitmap.Height / ratio))
                                    : new Bitmap((int)(sourceBitmap.Width / ratio), canvasWidthLenght));

            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
                graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

                graphicsResult.DrawImage(sourceBitmap,
                                        new Rectangle(0, 0,
                                            bitmapResult.Width, bitmapResult.Height),
                                        new Rectangle(0, 0,
                                            sourceBitmap.Width, sourceBitmap.Height),
                                            GraphicsUnit.Pixel);
                graphicsResult.Flush();
            }

            return bitmapResult;
        }

        public static Bitmap ConvolutionFilter(this Bitmap sourceBitmap, double[,] xFilterMatrix, double[,] yFilterMatrix = null, int bias = 0, bool grayscale = false, double factor = 1)
        {

            Boolean oneMatrixMode = yFilterMatrix == null;
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                                       ImageLockMode.ReadOnly,
                                                  PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            if (grayscale)
            {
                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    float rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;

                    Color greyscalColor = Color.FromArgb(255, (int)rgb, (int)rgb, (int)rgb);
                    ImageFilters.SetPixel(pixelBuffer, k, greyscalColor);
                }
            }

            int filterOffset = 1;
            if(oneMatrixMode){
                int filterWidth = xFilterMatrix.GetLength(1);
                filterOffset = (filterWidth - 1) / 2;
            }


            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                { 
                    double greenX = 0, redX = 0, blueX = 0;
                    double greenY = 0, redY = 0, blueY = 0;

                    int byteOffset = offsetY *sourceData.Stride +offsetX * 4;

                    for (int filterY = -filterOffset;filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;filterX <= filterOffset; filterX++)
                        {
                            int calcOffset = byteOffset + (filterX * 4) +  (filterY * sourceData.Stride);
                            blueX += pixelBuffer[calcOffset] *
                                      xFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            greenX += pixelBuffer[calcOffset + 1] *
                                      xFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            redX += pixelBuffer[calcOffset + 2] *
                                      xFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            if(!oneMatrixMode){
                                blueY += pixelBuffer[calcOffset] *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                greenY += pixelBuffer[calcOffset + 1] *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                redY += pixelBuffer[calcOffset + 2] *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];
                            }
                        }
                    }

                    double blue, green, red;
                    if (!oneMatrixMode)
                    {

                        blue = Math.Sqrt((blueX * blueX) + (blueY * blueY));
                        green = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                        red = Math.Sqrt((redX * redX) + (redY * redY));

                    }
                    else
                    {

                        blue = factor * blueX + bias;
                        green = factor * greenX + bias;
                        red = factor * redX + bias;
                    }

                    LimitColorRange(ref red);
                    LimitColorRange(ref green);
                    LimitColorRange(ref blue);

                    Color newColor = Color.FromArgb(255, (int)red, (int)green, (int)blue);
                    ImageFilters.SetPixel(resultBuffer, byteOffset, newColor);
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                                      ImageLockMode.WriteOnly,
                                                  PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static void LimitColorRange(ref double value)
        {
            value = (value < 0) ? 0 : (value > 255) ? 255 : value;
        }

        public static Bitmap LaplacianFilter(this Bitmap sourceBitmap, double[,] matrix, bool grayscale){
            return ConvolutionFilter(sourceBitmap, matrix, null, 0, grayscale, 1.0);
        }

        public static Bitmap GaussianFilter(this Bitmap sourceBitmap, double[,] matrix, double factor, bool grayscale)
        {
            return ConvolutionFilter(sourceBitmap, matrix, null, 0, grayscale, factor);
        }

        public static Bitmap Laplacian3x3OfGaussian3x3Filter(this Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = GaussianFilter(sourceBitmap, Matrix.Gaussian3x3, 1.0 / 16.0, true);
            return LaplacianFilter(resultBitmap, Matrix.Laplacian3x3, false);
        }

        public static Bitmap Laplacian3x3OfGaussian5x5Filter1(this Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = GaussianFilter(sourceBitmap, Matrix.Gaussian5x5Type1, 1.0 / 159.0, true);
            return LaplacianFilter(resultBitmap, Matrix.Laplacian3x3, false);
        }

        public static Bitmap Laplacian3x3OfGaussian5x5Filter2(this Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = GaussianFilter(sourceBitmap, Matrix.Gaussian5x5Type2, 1.0 / 256.0, true);
            return LaplacianFilter(resultBitmap, Matrix.Laplacian3x3, false);
        }

        public static Bitmap Laplacian5x5OfGaussian3x3Filter(this Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = GaussianFilter(sourceBitmap, Matrix.Gaussian3x3, 1.0 / 16.0, true);
            return LaplacianFilter(resultBitmap, Matrix.Laplacian5x5, false);
        }

        public static Bitmap Laplacian5x5OfGaussian5x5Filter1(this Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = GaussianFilter(sourceBitmap, Matrix.Gaussian5x5Type1, 1.0 / 159.0, true);
            return LaplacianFilter(resultBitmap, Matrix.Laplacian5x5, false);
        }

        public static Bitmap Laplacian5x5OfGaussian5x5Filter2(this Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = GaussianFilter(sourceBitmap, Matrix.Gaussian5x5Type2, 1.0 / 256.0, true);
            return LaplacianFilter(resultBitmap, Matrix.Laplacian5x5, false);
        }

        public static Bitmap DoubleMatrixFilter(this Bitmap sourceBitmap, double[,] matrix, double[,] matrix2, bool grayscale)
        {
            return ConvolutionFilter(sourceBitmap, matrix, matrix2, 0, grayscale);
        }

    }
}
