using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
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
        public Letter(string name, string printedUpper, string printedLower, string pronounciationEn, string prononunciationPL, Bitmap image, Bitmap imageUpper, Bitmap imageLower, byte[] sound)
             : this(name, printedUpper, printedLower, pronounciationEn, prononunciationPL, image, imageUpper, imageLower, sound, null)
        {
        }

        public Letter(string name, string printedUpper, string printedLower, string pronounciationEn, string prononunciationPL, Bitmap image, Bitmap imageUpper, Bitmap imageLower, byte[] sound, string oldPrinted)
        {
            PlaySoundCommand = new RelayCommand(cmd => true, PlaySoundCommandExecute);

            Name = name;
            PrintedUpper = printedUpper;
            PrintedLower = printedLower;
            SoundLikeEnglish = pronounciationEn;
            SoundLikePolish = prononunciationPL;
            Image = Convert(image);
            if (imageUpper != null)
                HandwrittenUpperImage = Convert(imageUpper);
            if (imageLower != null)
                HandwrittenLowerImage = Convert(imageLower);
            Sound = sound;
            OldPrinted = oldPrinted;
        }
        public string Name { get; }
        public string PrintedUpper { get; }
        public string PrintedLower { get; }
        public string SoundLikeEnglish { get; }
        public string SoundLikePolish { get; }
        public BitmapImage Image { get; }
        public byte[] Sound { get; }
        public string OldPrinted { get; }
        public BitmapImage HandwrittenUpperImage { get; }
        public BitmapImage HandwrittenLowerImage { get; }

        public static bool MuteSounds { get; set; } = false;


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

        public ICommand PlaySoundCommand { get; }


        private void PlaySoundCommandExecute(object param)
        {
            if (MuteSounds)
                return;
            if (param is Letter)
            {
                var bgw = new BackgroundWorker();

                bgw.DoWork += (s, e) =>
                {
                    using (var audioStream = new MemoryStream((param as Letter).Sound))
                    using (var rdr = new Mp3FileReader(audioStream))
                    using (var wavStream = WaveFormatConversionStream.CreatePcmStream(rdr))
                    using (var baStream = new BlockAlignReductionStream(wavStream))
                    using (var waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                    {
                        waveOut.Init(baStream);
                        waveOut.Play();
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(100);
                        }
                    }



                    //string file1 = @"D:\Repos\CyrillicHelper\CyrillicHelper\Audio\Sound1.mp3";
                    //List<byte> soundBytes = new List<byte>(File.ReadAllBytes(file1));
                    ////create media player loading the first half of the sound file
                    //MediaPlayer mPlayer = new MediaPlayer(soundBytes.ToArray());
                    ////begin playing the file
                    //mPlayer.Play();

                    //using (var audioStream = new MemoryStream((param as Letter).Sound))
                    //{
                    //    audioStream.Position = 0;     // Manually rewind stream 

                    //    using (var player = new SoundPlayer(audioStream))
                    //    {
                    //        if (audioStream.CanSeek) audioStream.Seek(0, System.IO.SeekOrigin.Begin);
                    //        player.PlaySync();
                    //    }
                    //}
                };
                bgw.RunWorkerCompleted += (s, e) =>
                {
                    
                };
                bgw.RunWorkerAsync();

               
            }
        }
    }
}
