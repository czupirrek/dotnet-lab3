using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_lab3_images
{
    class ImageTransform
    {

        public Bitmap src;
        private static Mutex mtx = new Mutex();
        public ImageTransform(Bitmap src)
        {
            this.src = src;
        }

        public Bitmap Invert()
        {
            mtx.WaitOne();
            Bitmap inverted = new Bitmap(src.Width, src.Height);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color pixelColor = src.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    inverted.SetPixel(x, y, invertedColor);
                }
            }
            mtx.ReleaseMutex();
            return inverted;
        }


        // w tej funkcji mocno pomoglem sobie chatemgpt 
        public Bitmap Rotate(double angle)
        {
            mtx.WaitOne();
            Bitmap rotated = new Bitmap(src.Width, src.Height);
            double angleRadians = angle * Math.PI / 180.0;

            int width = src.Width;
            int height = src.Height;



            double cosTheta = Math.Cos(angleRadians);
            double sinTheta = Math.Sin(angleRadians);

            int cx = width / 2;
            int cy = height / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // przeniesienie ukladu wspolrzednych do srodka obrazu
                    int x0 = x - cx;
                    int y0 = y - cy;

                    // macierz obrotu
                    int xr = (int)(x0 * cosTheta - y0 * sinTheta);
                    int yr = (int)(x0 * sinTheta + y0 * cosTheta);

                    // powrot z ukladem wspolrzednych do lewego gornego rogu
                    int newX = xr + cx;
                    int newY = yr + cy;

                    if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                    {
                        rotated.SetPixel(x, y, src.GetPixel(newX, newY));
                    }
                    else
                    {
                        rotated.SetPixel(x, y, Color.White); 
                    }
                }
            }
            mtx.ReleaseMutex();
            return rotated;
        }


        public Bitmap Greyscale()
        {
            mtx.WaitOne();
            Bitmap greyscale = new Bitmap(src.Width, src.Height);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color pixelColor = src.GetPixel(x, y);
                    int greyValue = (int)(pixelColor.R * 0.33 + pixelColor.G * 0.33 + pixelColor.B * 0.33);
                    Color greyColor = Color.FromArgb(greyValue, greyValue, greyValue);
                    greyscale.SetPixel(x, y, greyColor);
                }
            }
            mtx.ReleaseMutex();
            return greyscale;
        }

        public Bitmap Threshold(int thresholdValue)
        {
            mtx.WaitOne();
            Bitmap threshold = new Bitmap(src.Width, src.Height);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color pixelColor = src.GetPixel(x, y);
                    int greyValue = (int)(pixelColor.R * 0.33 + pixelColor.G * 0.33 + pixelColor.B * 0.33);
                    int BlackOrWhite = greyValue >= thresholdValue ? 255 : 0;
                    threshold.SetPixel(x, y, Color.FromArgb(BlackOrWhite, BlackOrWhite, BlackOrWhite));

                }
            }
            mtx.ReleaseMutex();
            return threshold;

        }

        public Bitmap ChannelSwap()
        {
            mtx.WaitOne();
            Bitmap swapped = new Bitmap(src.Width, src.Height);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color pixelColor = src.GetPixel(x, y);
                    Color swappedColor = Color.FromArgb(pixelColor.B, pixelColor.R, pixelColor.G);
                    swapped.SetPixel(x, y, swappedColor);
                }
            }
            mtx.ReleaseMutex();
            return swapped;
        }


        public Bitmap ChannelThreshold(int thresholdValue)
        {
            mtx.WaitOne();
            Bitmap threshold = new Bitmap(src.Width, src.Height);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color pixelColor = src.GetPixel(x, y);
                    int redValue = pixelColor.R;
                    int greenValue = pixelColor.G;
                    int blueValue = pixelColor.B;

                    int newRed = redValue >= thresholdValue ? 255 : 0;
                    int newGreen = greenValue >= thresholdValue ? 255 : 0;
                    int newBlue = blueValue >= thresholdValue ? 255 : 0;
                    threshold.SetPixel(x, y, Color.FromArgb(newRed, newGreen, newBlue));

                }
            }
            mtx.ReleaseMutex();
            return threshold;

        }


    }
}
