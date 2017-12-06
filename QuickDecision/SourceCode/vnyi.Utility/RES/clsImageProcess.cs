using System;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace vnyi.Utility.RES
{
    public class clsImageProcess
    {

        public static string ExtJpg = ".jpg";
        public static string ExtPng = ".png";
        public static string ExtBmp = ".bmp";

        public static Bitmap ResizeImage(Stream pstream, int? pwidth, int? pheight)
        {
            System.Drawing.Bitmap bmpOut = null;
            const int defaultWidth = 800;
            const int defaultHeight = 600;
            int lnWidth = pwidth == null ? defaultWidth : (int)pwidth;
            int lnHeight = pheight == null ? defaultHeight : (int)pheight;
            try
            {
                Bitmap loBMP = new Bitmap(pstream);
                ImageFormat loFormat = loBMP.RawFormat;
                decimal lnRatio;
                int lnNewWidth = 0;
                int lnNewHeight = 0;
                if (loBMP.Width < lnWidth && loBMP.Height < lnHeight)
                {
                    return loBMP;
                }

                if (loBMP.Width > loBMP.Height)
                {
                    lnRatio = (decimal)lnWidth / loBMP.Width;
                    lnNewWidth = lnWidth;
                    decimal lnTemp = loBMP.Height * lnRatio;
                    lnNewHeight = (int)lnTemp;
                }
                else
                {
                    lnRatio = (decimal)lnHeight / loBMP.Height;
                    lnNewHeight = lnHeight;
                    decimal lnTemp = loBMP.Width * lnRatio;
                    lnNewWidth = (int)lnTemp;
                }

                bmpOut = new Bitmap(lnNewWidth, lnNewHeight);
                Graphics g = Graphics.FromImage(bmpOut);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.FillRectangle(Brushes.White, 0, 0, lnNewWidth, lnNewHeight);
                g.DrawImage(loBMP, 0, 0, lnNewWidth, lnNewHeight);
                loBMP.Dispose();
            }
            catch
            {
                return null;
            }
            return bmpOut;
        }

        private static ImageCodecInfo GetEncoder(ImageFormat pformat)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == pformat.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        public static void SaveImage(Image pimg, ImageFormat pimgfm, string ptenfile)
        {
            ImageCodecInfo jgpEncoder = GetEncoder(pimgfm);
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 300L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            pimg.Save(ptenfile, jgpEncoder, myEncoderParameters);
        }
    }
}
