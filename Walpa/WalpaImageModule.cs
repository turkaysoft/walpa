using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace Walpa{
    public class WalpaImageModule{
        // ADVANCED POINTER-BASED UNIVERSAL IMAGE COLOR CHANGER
        // ======================================================================================================
        public static unsafe Bitmap TS_CI_Engine(Image sourceImage, Color targetColor){
            if (sourceImage == null){
                throw new ArgumentNullException(nameof(sourceImage));
            }
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            //
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            //
            using (Graphics g = Graphics.FromImage(bmp)){
                g.CompositingMode = CompositingMode.SourceCopy;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = PixelOffsetMode.Half;
                //
                g.DrawImage(sourceImage, 0, 0, width, height);
            }
            //
            byte targetB = targetColor.B;
            byte targetG = targetColor.G;
            byte targetR = targetColor.R;
            //
            const int bytesPerPixel = 4;
            //
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            //
            try{
                int stride = bmpData.Stride;
                byte* scan0 = (byte*)bmpData.Scan0.ToPointer();
                //
                Parallel.For(0, height, y =>{
                    byte* pixel = scan0 + (y * stride);
                    for (int x = 0; x < width; x++){
                        //
                        if (pixel[3] > 0){
                            pixel[0] = targetB; // Blue
                            pixel[1] = targetG; // Green
                            pixel[2] = targetR; // Red
                            // pixel[3] We do not alter the (Alpha) channel; the original transparency is preserved exactly as is.
                        }
                        pixel += bytesPerPixel;
                    }
                });
            }
            finally{
                bmp.UnlockBits(bmpData);
            }
            return bmp;
        }
    }
}