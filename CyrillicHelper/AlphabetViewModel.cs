using CyrillicHelper.WPFControls;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CyrillicHelper
{
    public class AlphabetViewModel
    {
        public AlphabetViewModel()
        {
            AlphabetItems = new ObservableCollection<Letter>();
            AlphabetItems.Add(new Letter(
                "a",
                @"А а",
                "like ar in far",
                Properties.Resources.a2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/a2.jpg",
                 Properties.Resources.Sound1));

            AlphabetItems.Add(new Letter(
                "be",
                @"Б б",
                "like b in box",
                Properties.Resources.b2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/b2.jpg",
                 Properties.Resources.Sound2));

            AlphabetItems.Add(new Letter(
                "ve",
                @"В в",
                "like v in voice",
                Properties.Resources.v2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/v2.jpg",
                 Properties.Resources.Sound3));
            
            AlphabetItems.Add(new Letter(
                "ge",
                @"Г г",
                "like g in go",
                Properties.Resources.g2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/g2.jpg",
                 Properties.Resources.Sound4));

            AlphabetItems.Add(new Letter(
                "de",
                @"Д д",
                "like d in day",
                Properties.Resources.d2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/d2.jpg",
                 Properties.Resources.Sound5));

            AlphabetItems.Add(new Letter(
                "ye",
                @"Е е",
                "like ye in yet or e in exit",
                Properties.Resources.e2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/e2.jpg",
                 Properties.Resources.Sound6));

            AlphabetItems.Add(new Letter(
                "yo",
                @"Ё ё",
                "like yo in your",
                Properties.Resources.yo2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/yo2.jpg",
                 Properties.Resources.Sound7));

            AlphabetItems.Add(new Letter(
                "zhe",
                @"Ж ж",
                "like s in pleasure",
                Properties.Resources.zh2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/zh2.jpg",
                 Properties.Resources.Sound8));

            AlphabetItems.Add(new Letter(
                "ze",
                @"З з",
                "like z in zoo",
                Properties.Resources.z2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/zh2.jpg",
                 Properties.Resources.Sound9));
            
            AlphabetItems.Add(new Letter(
                "ee",
                @"И и",
                "like ee in meet",
                Properties.Resources.ee2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ee2.jpg",
                 Properties.Resources.Sound10,
                @"І і Ѵ ѵ"));

            AlphabetItems.Add(new Letter(
               "ee kratkoye (short i)",
               @"Й й",
               "like y in boy",
               Properties.Resources.ee_kratkoe2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ee_kratkoe2.jpg",
                Properties.Resources.Sound11));

            AlphabetItems.Add(new Letter(
               "ka",
               @"К к",
               "like k in key or c in cat",
               Properties.Resources.k2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/k2.jpg",
                Properties.Resources.Sound12));

            AlphabetItems.Add(new Letter(
               "el",
               @"Л л",
               "like l in lamp",
               Properties.Resources.l2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/l2.jpg",
                Properties.Resources.Sound13));

            AlphabetItems.Add(new Letter(
               "em",
               @"М м",
               "like m in man",
               Properties.Resources.m2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/m2.jpg",
                Properties.Resources.Sound14));

            AlphabetItems.Add(new Letter(
               "en",
               @"Н н",
               "like n in note",
               Properties.Resources.n2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/n2.jpg",
                Properties.Resources.Sound15));

            AlphabetItems.Add(new Letter(
               "o",
               @"О о",
               "like o in not",
               Properties.Resources.o2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/o2.jpg",
                Properties.Resources.Sound16));

            AlphabetItems.Add(new Letter(
               "pe",
               @"П п",
               "like p in pet",
               Properties.Resources.p2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/p2.jpg",
                Properties.Resources.Sound17));

            AlphabetItems.Add(new Letter(
               "er",
               @"Р р",
               "like r in rock (but rolled)",
               Properties.Resources.r2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/r2.jpg",
                Properties.Resources.Sound18));

            AlphabetItems.Add(new Letter(
               "es",
               @"С с",
               "like s in sun",
               Properties.Resources.s2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/s2.jpg",
                Properties.Resources.Sound19));

            AlphabetItems.Add(new Letter(
               "te",
               @"Т т",
               "like t in table",
               Properties.Resources.t2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/t2.jpg",
                Properties.Resources.Sound20));

            AlphabetItems.Add(new Letter(
               "oo",
               @"У у",
               "like oo in moon",
               Properties.Resources.u2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/u2.jpg",
                Properties.Resources.Sound21));

            AlphabetItems.Add(new Letter(
               "ef",
               @"Ф ф",
               "like f in food",
               Properties.Resources.f2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/f2.jpg",
                Properties.Resources.Sound22,
                @"Ѳ ѳ"));

            AlphabetItems.Add(new Letter(
               "kha",
               @"Х х",
               "like ch in Scottish loch",
               Properties.Resources.h2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/h2.jpg",
                Properties.Resources.Sound23));

            AlphabetItems.Add(new Letter(
               "tse",
               @"Ц ц",
               "like ts in boots",
               Properties.Resources.ts2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ts2.jpg",
                Properties.Resources.Sound24));

            AlphabetItems.Add(new Letter(
               "che",
               @"Ч ч",
               "like ch in chat",
               Properties.Resources.ch2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ch2.jpg",
                Properties.Resources.Sound25));

            AlphabetItems.Add(new Letter(
               "sha",
               @"Ш ш",
               "like sh in short",
               Properties.Resources.sh2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/sh2.jpg",
                Properties.Resources.Sound26));

            AlphabetItems.Add(new Letter(
               "shcha",
               @"Щ щ",
               "like sh_ch in fresh_cheese",
               Properties.Resources.shch2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/shch2.jpg",
                Properties.Resources.Sound27));

            AlphabetItems.Add(new Letter(
               "tviordiy znak (hard sign)",
               @"ъ",
               "has no sound",
               Properties.Resources.tv_znak2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/tv_znak2.jpg",
                Properties.Resources.Sound28));

            AlphabetItems.Add(new Letter(
               "ih*",
               @"ы",
               "like i in ill",
               Properties.Resources.y2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/y2.jpg",
                Properties.Resources.Sound29));

            AlphabetItems.Add(new Letter(
               "myagkiy znak (soft sign)",
               @"ь",
               "has no sound",
               Properties.Resources.m_znak2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/m_znak2.jpg",
                Properties.Resources.Sound30));

            AlphabetItems.Add(new Letter(
               "e",
               @"Э э",
               "like e in end",
               Properties.Resources.ue2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ue2.jpg",
                Properties.Resources.Sound31));

            AlphabetItems.Add(new Letter(
               "yoo",
               @"Ю ю",
               "like u in use",
               Properties.Resources.yu2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/yu2.jpg",
                Properties.Resources.Sound32));

            AlphabetItems.Add(new Letter(
               "ya",
               @"Я я",
               "like ya in yard",
               Properties.Resources.ya2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ya2.jpg",
                Properties.Resources.Sound33));

            //AlphabetItems.Add(new Letter(
            //   "",
            //   @"",
            //   "",
            //   Properties.Resources.,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/.jpg",
            //    Properties.Resources.Sound));

            PlaySoundCommand = new RelayCommand(cmd => true, PlaySoundCommandExecute);
        }

        public ICommand PlaySoundCommand { get; }

        public ObservableCollection<Letter> AlphabetItems { get; set; }

        private void PlaySoundCommandExecute(object param)
        {
            if (param is Letter)
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
            }
        }
    }
}
