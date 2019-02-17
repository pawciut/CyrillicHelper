using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CyrillicHelper.WPFControls
{
    public class Letter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="printed"></param>
        /// <param name="pronounciationEn"></param>
        /// <param name="image">image of handwriting</param>
        /// <param name="sound"></param>
        public Letter(string name, string printed, string pronounciationEn, Bitmap image, byte[] sound)
        {
            Name = name;
            Printed = printed;
            SoundLikeEnglish = pronounciationEn;
            Image = Convert(image);
            Sound = sound;
        }
        public Letter(string name, string printed, string pronounciationEn, Bitmap image, byte[] sound, string oldPrinted)
        {
            Name = name;
            Printed = printed;
            SoundLikeEnglish = pronounciationEn;
            Image = Convert(image);
            Sound = sound;
            OldPrinted = oldPrinted;
        }
        public string Name { get; }
        public string Printed { get; }
        public string SoundLikeEnglish { get; }
        public string SoundLikePolish { get; }
        public BitmapImage Image { get; }
        public byte[] Sound { get;  }
        public string OldPrinted { get; }

        BitmapImage Convert(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }
    }
}
