using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    class Filters
    {
        public static Bitmap boxBlur(Bitmap srcImage)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.Matrix = new int[5, 5]{ {1,1,1,1,1},
                                            {1,1,1,1,1},
                                            {1,1,1,1,1},
                                            {1,1,1,1,1},
                                            {1,1,1,1,1}
                                          };

            Convolution(srcImage, matrix);
            return srcImage;
        }

        public static Bitmap gaussianBlur(Bitmap srcImage)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.Matrix = new int[5, 5]{  {1, 4, 7, 4,1},
                                            {4,16,26,16,4},
                                            {7,26,41,26,7},
                                            {4,16,26,16,4},
                                            {1, 4, 7, 4,1}
                                          };

            Convolution(srcImage, matrix);
            return srcImage;
        }

        public static Bitmap segmentation(Bitmap srcImage)
        {
            int treshold = 90;

            Bitmap outImage = (Bitmap)srcImage.Clone();
            srcImage = Greyscale(srcImage);
            srcImage = gaussianBlur(srcImage);
            srcImage = sharpen2(srcImage);
          

            BitmapData srcImageData = srcImage.LockBits(new Rectangle(0, 0, srcImage.Width, srcImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData outImageData = outImage.LockBits(new Rectangle(0, 0, outImage.Width, outImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            int stride = srcImageData.Stride;
            IntPtr scan0 = srcImageData.Scan0;

            int red, green, blue, xCor, yCor;

            unsafe
            {
                byte* tempPixel;

                for (yCor = 0; yCor < srcImageData.Height; yCor++)
                {
                    for (xCor = 0; xCor < srcImageData.Width; xCor++)
                    {
                        
                        tempPixel = (byte*)scan0 + (yCor * stride) + (xCor * 4);

                        if (*(tempPixel) > treshold)
                        {
                            red = 255;
                            green = 0;
                            blue  = 0;

                        }
                        else
                        {
                            red = 0;
                            green = 255;
                            blue = 0;  
                        }

                     
                        byte* outpixel = (byte*)outImageData.Scan0 + (yCor * outImageData.Stride) + (xCor * 4);
                        *outpixel = (byte)blue;
                        *(outpixel + 1) = (byte)green;
                        *(outpixel + 2) = (byte)red;
                        *(outpixel + 3) = 255;
                    }
                }
            }

            outImage.UnlockBits(outImageData);
            srcImage.UnlockBits(srcImageData);



            return outImage;
        }

        public static Bitmap sharpen1(Bitmap srcImage)
        {
            Bitmap outImage = (Bitmap)srcImage.Clone();
            Bitmap tempImage = (Bitmap)srcImage.Clone();
            srcImage = boxBlur(srcImage);
            BitmapData srcImageData = srcImage.LockBits(new Rectangle(0, 0, srcImage.Width, srcImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData tempImageData = tempImage.LockBits(new Rectangle(0, 0, tempImage.Width, tempImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData outImageData = outImage.LockBits(new Rectangle(0, 0, outImage.Width, outImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            int sstride = srcImageData.Stride;
            IntPtr sscan0 = srcImageData.Scan0;
            int tstride = tempImageData.Stride;
            IntPtr tscan0 = tempImageData.Scan0;

            int ttempb, ttempg, ttempr, stempb, stempg, stempr, red, green, blue;

            unsafe
            {
                byte* stempPixel, ttempPixel;

                for (int yCor = 0; yCor < srcImageData.Height; yCor++)
                {
                    for (int xCor = 0; xCor < srcImageData.Width; xCor++)
                    {
                        red = green = blue = 0;

                        ttempPixel = (byte*)tscan0 + (yCor * tstride) + (xCor * 4);
                        stempPixel = (byte*)sscan0 + (yCor * sstride) + (xCor * 4);

                        // BGRA
                        ttempb = (int)*ttempPixel;
                        ttempg = (int)*(ttempPixel + 1);
                        ttempr = (int)*(ttempPixel + 2);

                        stempb = (int)*stempPixel;
                        stempg = (int)*(stempPixel + 1);
                        stempr = (int)*(stempPixel + 2);

                        red += ttempr - stempr;
                        green += ttempg - stempg;
                        blue += ttempb - stempb;

                        byte* outpixel = (byte*)outImageData.Scan0 + (yCor * outImageData.Stride) + (xCor * 4);
                        *outpixel = (byte)blue;
                        *(outpixel + 1) = (byte)green;
                        *(outpixel + 2) = (byte)red;
                        *(outpixel + 3) = 255;
                    }
                }
            }

            outImage.UnlockBits(outImageData);
            srcImage.UnlockBits(srcImageData);
            tempImage.UnlockBits(tempImageData);

            return outImage;
        }

        public static Bitmap sharpen2(Bitmap srcImage)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.Matrix = new int[5, 5] {  {0,0,0,0,0},
                                            {0,0,-1,0,0},
                                            {0,-1,5,-1,0},
                                            {0,0,-1,0,0},
                                            {0,0,0,0,0}
                                          };

            /*{ {-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1},
                {-1,-1,24,-1,-1},
                {-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1}
              };*/



            //matrix.SetFactor(0.04);
            Convolution(srcImage, matrix);
            return srcImage;

        }

        public static Bitmap vertEdges(Bitmap srcImage)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.Matrix = new int[5, 5] {
                                    { 0 ,  0 , 0 , 0 , 0 },
                                    { 0 , -1 , 0 , 1 , 0 },
                                    { 0 , -2,  0,  2,  0 },
                                    { 0 , -1 , 0 , 1 , 0 },
                                    { 0 ,  0,  0 , 0 , 0 }
                                    };


            matrix.Factor = 1;
            Filters.Convolution(srcImage, matrix);
            return srcImage;

        }

        public static Bitmap horEdges(Bitmap srcImage)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.Matrix = new int[5, 5] {
                                    { 0 ,  0 , 0 , 0 , 0 },
                                    { 0 , -1 ,-2 ,-1 , 0 },
                                    { 0 ,  0,  0,  0,  0 },
                                    { 0 ,  1 , 2 , 1 , 0 },
                                    { 0 ,  0,  0 , 0 , 0 }
                                    };


            matrix.Factor = 1;
            Filters.Convolution(srcImage, matrix);
            return srcImage;

        }

        public static Bitmap diagEdges1(Bitmap srcImage)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.Matrix = new int[5, 5] {
                                    { 0 ,  0 , 0 , 0 , 0 },
                                    { 0 ,  0 , 1 , 2 , 0 },
                                    { 0 , -1,  0 , 1,  0 },
                                    { 0 , -2 ,-1 , 0 , 0 },
                                    { 0 ,  0,  0 , 0 , 0 }
                                    };


            matrix.Factor = 1;
            Filters.Convolution(srcImage, matrix);
            return srcImage;

        }

        public static Bitmap diagEdges2(Bitmap srcImage)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.Matrix = new int[5, 5] {
                                    { 0 ,  0 , 0 , 0 , 0 },
                                    { 0 , -2 ,-1 , 0 , 0 },
                                    { 0 , -1,  0 , 1,  0 },
                                    { 0 ,  0 , 1 , 2 , 0 },
                                    { 0 ,  0,  0 , 0 , 0 }
                                    };


            matrix.Factor = 1;
            Filters.Convolution(srcImage, matrix);
            return srcImage;

        }

        private static void Convolution(Bitmap outImage, ConvolutionMatrix matrix)
        {
            //  Takes the source data and copies it to the bitmap data. ////////////////////////
            //  32bppArgb is used since it has all the default colors and an alpha channel.  /// 
            //  However for images which use less than 32 bits, this is costly and redundant. //

            Bitmap srcImage = (Bitmap)outImage.Clone();
            BitmapData srcImageData = srcImage.LockBits(new Rectangle(0, 0, srcImage.Width, srcImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData outImageData = outImage.LockBits(new Rectangle(0, 0, outImage.Width, outImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            int stride = srcImageData.Stride;
            IntPtr scan0 = srcImageData.Scan0;

            int s = ((matrix.size - 1) / 2);
            int red, green, blue, xCor, yCor, fxCor, fyCor, tempx, tempy, tempb, tempg, tempr;

            unsafe
            {
                byte* tempPixel;

                // The first two foor loops iterate through s and borders - s. ////////////////////////////////////////////
                // Which means that the first s and the last s pixels were ignored and were not included in calculation. //

                for (yCor = s; yCor < srcImageData.Height - s; yCor++)
                {
                    for (xCor = s; xCor < srcImageData.Width - s; xCor++)
                    {
                        red = green = blue = 0;

                        for (fyCor = 0; fyCor < matrix.size; fyCor++)
                        {
                            for (fxCor = 0; fxCor < matrix.size; fxCor++)
                            {
                                tempx = xCor + fxCor - s;
                                tempy = yCor + fyCor - s;

                                // Finding the pixel in the array.  //////////////////////////////////////////////////////////////////////
                                // For an (x,y) point we have [(x-1) * pixels per row + (y-1)* pixels per cell] number of pixels.  ///////
                                // Stride = the number of pixels per row. tempx and tempy are x-1 and y-1 since matrices begin from 0.  //
                                // Since we picked 32bppARGB we have 4 pixels.  ////////////////////////////////////////////////////////// 
                                tempPixel = (byte*)scan0 + (tempy * stride) + (tempx * 4);

                                // BGRA
                                tempb = (int)*tempPixel;
                                tempg = (int)*(tempPixel + 1);
                                tempr = (int)*(tempPixel + 2);

                                red += matrix.Matrix[fyCor, fxCor] * tempr;
                                green += matrix.Matrix[fyCor, fxCor] * tempg;
                                blue += matrix.Matrix[fyCor, fxCor] * tempb;

                            }
                        }

                        red = (int)Math.Min(Math.Max((red / matrix.Factor) + matrix.Offset, 0), 255);
                        green = (int)Math.Min(Math.Max((green / matrix.Factor) + matrix.Offset, 0), 255);
                        blue = (int)Math.Min(Math.Max((blue / matrix.Factor) + matrix.Offset, 0), 255);


                        byte* outpixel = (byte*)outImageData.Scan0 + (yCor * outImageData.Stride) + (xCor * 4);
                        *outpixel = (byte)blue;
                        *(outpixel + 1) = (byte)green;
                        *(outpixel + 2) = (byte)red;
                        *(outpixel + 3) = 255;
                    }
                }
            }

            outImage.UnlockBits(outImageData);
            srcImage.UnlockBits(srcImageData);
        }

        public static Bitmap Greyscale(Bitmap image)
        {
            int x, y;
            int r, g, b;

            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            int stride = imageData.Stride;
            IntPtr scan0 = imageData.Scan0;

            unsafe
            {
                byte* pixel;
                int greyTone;

                for (y = 0; y < imageData.Height; y++)
                {
                    for (x = 0; x < imageData.Width; x++)
                    {

                        pixel = (byte*)scan0 + (y * stride) + (x * 4);

                        b = (int)*pixel;
                        g = (int)*(pixel + 1);
                        r = (int)*(pixel + 2);

                        greyTone = (int)(0.3 * r + 0.59 * g + 0.11 * b);

                        *pixel = (byte)greyTone;
                        *(pixel + 1) = (byte)greyTone;
                        *(pixel + 2) = (byte)greyTone;
                        *(pixel + 3) = 255;

                    }

                }
            }

            image.UnlockBits(imageData);
            return image;
        }

    }
}
