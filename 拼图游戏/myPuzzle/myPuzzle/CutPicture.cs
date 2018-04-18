using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace myPuzzle
{
    class CutPicture
    {
        public static string PicturePath = "";
        public static List<Bitmap> BitMapList = null;
        
        
        /*
         保存图片到根目录下的Pictures文件夹下
         path文件路径
         iWidth调整的宽
         iHeight调整的高
         */


         //作用缩放图片
        public static Image Reszie(string path,int iWidth, int iHeight)
        {
            Image thumbnail = null;
            try
            {
                var img = Image.FromFile(path);
                thumbnail = img.GetThumbnailImage(iWidth, iHeight, null, IntPtr.Zero);
                thumbnail.Save(Application.StartupPath.ToString() + "\\Picture\\img.jpeg");

            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return thumbnail;
        }

        /*
         剪切图片
         b 图片
         StartX x坐标
         StartY y坐标
         iWidth宽
         iHeight高
         */

        public static Bitmap Cut(Image b, int StartX, int StartY,int iWidth,int iHeight)
        {
            if (b == null)
            {
                return null;
            }
            int w = b.Width;
            int h = b.Height;
            if (StartX >= w || StartY >= h)
            {
                return null;
            }
            if (StartX + iWidth > w)
            {
                iWidth = w - StartX;
            }
            if (StartY + iHeight > h)
            {
                iHeight = h - StartY;
            }
            try
            {
                Bitmap bmpOut = new Bitmap(iWidth,iHeight,PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(bmpOut);
                g.DrawImage(b, new Rectangle(0, 0, iWidth, iHeight), new Rectangle(StartX, StartY, iWidth, iHeight), GraphicsUnit.Pixel);
                g.Dispose();
                return bmpOut;
            }
            catch {
                return null;
            }
        }
    }
}
