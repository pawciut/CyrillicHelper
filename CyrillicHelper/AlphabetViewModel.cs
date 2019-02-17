using CyrillicHelper.WPFControls;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Resources;
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
            //AlphabetItems = new ObservableCollection<Letter>();
            //AlphabetItems.Add(new Letter(
            //    "a",
            //    @"А а",
            //    "like ar in far",
            //    Properties.Resources.a2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/a2.jpg",
            //     Properties.Resources.Sound1));

            //AlphabetItems.Add(new Letter(
            //    "be",
            //    @"Б б",
            //    "like b in box",
            //    Properties.Resources.b2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/b2.jpg",
            //     Properties.Resources.Sound2));

            //AlphabetItems.Add(new Letter(
            //    "ve",
            //    @"В в",
            //    "like v in voice",
            //    Properties.Resources.v2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/v2.jpg",
            //     Properties.Resources.Sound3));

            //AlphabetItems.Add(new Letter(
            //    "ge",
            //    @"Г г",
            //    "like g in go",
            //    Properties.Resources.g2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/g2.jpg",
            //     Properties.Resources.Sound4));

            //AlphabetItems.Add(new Letter(
            //    "de",
            //    @"Д д",
            //    "like d in day",
            //    Properties.Resources.d2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/d2.jpg",
            //     Properties.Resources.Sound5));

            //AlphabetItems.Add(new Letter(
            //    "ye",
            //    @"Е е",
            //    "like ye in yet or e in exit",
            //    Properties.Resources.e2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/e2.jpg",
            //     Properties.Resources.Sound6));

            //AlphabetItems.Add(new Letter(
            //    "yo",
            //    @"Ё ё",
            //    "like yo in your",
            //    Properties.Resources.yo2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/yo2.jpg",
            //     Properties.Resources.Sound7));

            //AlphabetItems.Add(new Letter(
            //    "zhe",
            //    @"Ж ж",
            //    "like s in pleasure",
            //    Properties.Resources.zh2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/zh2.jpg",
            //     Properties.Resources.Sound8));

            //AlphabetItems.Add(new Letter(
            //    "ze",
            //    @"З з",
            //    "like z in zoo",
            //    Properties.Resources.z2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/zh2.jpg",
            //     Properties.Resources.Sound9));

            //AlphabetItems.Add(new Letter(
            //    "ee",
            //    @"И и",
            //    "like ee in meet",
            //    Properties.Resources.ee2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ee2.jpg",
            //     Properties.Resources.Sound10,
            //    @"І і Ѵ ѵ"));

            //AlphabetItems.Add(new Letter(
            //   "ee kratkoye (short i)",
            //   @"Й й",
            //   "like y in boy",
            //   Properties.Resources.ee_kratkoe2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ee_kratkoe2.jpg",
            //    Properties.Resources.Sound11));

            //AlphabetItems.Add(new Letter(
            //   "ka",
            //   @"К к",
            //   "like k in key or c in cat",
            //   Properties.Resources.k2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/k2.jpg",
            //    Properties.Resources.Sound12));

            //AlphabetItems.Add(new Letter(
            //   "el",
            //   @"Л л",
            //   "like l in lamp",
            //   Properties.Resources.l2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/l2.jpg",
            //    Properties.Resources.Sound13));

            //AlphabetItems.Add(new Letter(
            //   "em",
            //   @"М м",
            //   "like m in man",
            //   Properties.Resources.m2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/m2.jpg",
            //    Properties.Resources.Sound14));

            //AlphabetItems.Add(new Letter(
            //   "en",
            //   @"Н н",
            //   "like n in note",
            //   Properties.Resources.n2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/n2.jpg",
            //    Properties.Resources.Sound15));

            //AlphabetItems.Add(new Letter(
            //   "o",
            //   @"О о",
            //   "like o in not",
            //   Properties.Resources.o2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/o2.jpg",
            //    Properties.Resources.Sound16));

            //AlphabetItems.Add(new Letter(
            //   "pe",
            //   @"П п",
            //   "like p in pet",
            //   Properties.Resources.p2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/p2.jpg",
            //    Properties.Resources.Sound17));

            //AlphabetItems.Add(new Letter(
            //   "er",
            //   @"Р р",
            //   "like r in rock (but rolled)",
            //   Properties.Resources.r2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/r2.jpg",
            //    Properties.Resources.Sound18));

            //AlphabetItems.Add(new Letter(
            //   "es",
            //   @"С с",
            //   "like s in sun",
            //   Properties.Resources.s2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/s2.jpg",
            //    Properties.Resources.Sound19));

            //AlphabetItems.Add(new Letter(
            //   "te",
            //   @"Т т",
            //   "like t in table",
            //   Properties.Resources.t2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/t2.jpg",
            //    Properties.Resources.Sound20));

            //AlphabetItems.Add(new Letter(
            //   "oo",
            //   @"У у",
            //   "like oo in moon",
            //   Properties.Resources.u2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/u2.jpg",
            //    Properties.Resources.Sound21));

            //AlphabetItems.Add(new Letter(
            //   "ef",
            //   @"Ф ф",
            //   "like f in food",
            //   Properties.Resources.f2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/f2.jpg",
            //    Properties.Resources.Sound22,
            //    @"Ѳ ѳ"));

            //AlphabetItems.Add(new Letter(
            //   "kha",
            //   @"Х х",
            //   "like ch in Scottish loch",
            //   Properties.Resources.h2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/h2.jpg",
            //    Properties.Resources.Sound23));

            //AlphabetItems.Add(new Letter(
            //   "tse",
            //   @"Ц ц",
            //   "like ts in boots",
            //   Properties.Resources.ts2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ts2.jpg",
            //    Properties.Resources.Sound24));

            //AlphabetItems.Add(new Letter(
            //   "che",
            //   @"Ч ч",
            //   "like ch in chat",
            //   Properties.Resources.ch2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ch2.jpg",
            //    Properties.Resources.Sound25));

            //AlphabetItems.Add(new Letter(
            //   "sha",
            //   @"Ш ш",
            //   "like sh in short",
            //   Properties.Resources.sh2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/sh2.jpg",
            //    Properties.Resources.Sound26));

            //AlphabetItems.Add(new Letter(
            //   "shcha",
            //   @"Щ щ",
            //   "like sh_ch in fresh_cheese",
            //   Properties.Resources.shch2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/shch2.jpg",
            //    Properties.Resources.Sound27));

            //AlphabetItems.Add(new Letter(
            //   "tviordiy znak (hard sign)",
            //   @"ъ",
            //   "has no sound",
            //   Properties.Resources.tv_znak2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/tv_znak2.jpg",
            //    Properties.Resources.Sound28));

            //AlphabetItems.Add(new Letter(
            //   "ih*",
            //   @"ы",
            //   "like i in ill",
            //   Properties.Resources.y2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/y2.jpg",
            //    Properties.Resources.Sound29));

            //AlphabetItems.Add(new Letter(
            //   "myagkiy znak (soft sign)",
            //   @"ь",
            //   "has no sound",
            //   Properties.Resources.m_znak2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/m_znak2.jpg",
            //    Properties.Resources.Sound30));

            //AlphabetItems.Add(new Letter(
            //   "e",
            //   @"Э э",
            //   "like e in end",
            //   Properties.Resources.ue2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ue2.jpg",
            //    Properties.Resources.Sound31));

            //AlphabetItems.Add(new Letter(
            //   "yoo",
            //   @"Ю ю",
            //   "like u in use",
            //   Properties.Resources.yu2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/yu2.jpg",
            //    Properties.Resources.Sound32));

            //AlphabetItems.Add(new Letter(
            //   "ya",
            //   @"Я я",
            //   "like ya in yard",
            //   Properties.Resources.ya2,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/ya2.jpg",
            //    Properties.Resources.Sound33));

            //AlphabetItems.Add(new Letter(
            //   "",
            //   @"",
            //   "",
            //   Properties.Resources.,//"http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/.jpg",
            //    Properties.Resources.Sound));
            InitLetters();

            PlaySoundCommand = new RelayCommand(cmd => true, PlaySoundCommandExecute);
        }


        void InitDictionary()
        {
            CommonDictionary = new ObservableCollection<DictionaryEntry>();
            string category = "Dni";
            CommonDictionary.Add( new DictionaryEntry("1", "один / первый", category));
            CommonDictionary.Add(new DictionaryEntry("2", "два / второй", category));
            CommonDictionary.Add(new DictionaryEntry("3", "три / третий", category));
            CommonDictionary.Add(new DictionaryEntry("4", "четыре / четвертый", category));
            CommonDictionary.Add(new DictionaryEntry("5", "пять / пятый", category));
            CommonDictionary.Add(new DictionaryEntry("6", "шесть / шестой", category));
            CommonDictionary.Add(new DictionaryEntry("7", "семь / седьмой", category));
            CommonDictionary.Add(new DictionaryEntry("8", "восемь / восьмой", category));
            CommonDictionary.Add(new DictionaryEntry("9", "девять / девятый", category));
            CommonDictionary.Add(new DictionaryEntry("10", "десять / десятый", category));
            CommonDictionary.Add(new DictionaryEntry("11", "одиннадцать / одиннадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("12", "двенадцать / двенадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("13", "тринадцать / тринадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("14", " четырнадцать / четырнадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("15", "пятнадцать / пятнадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("16", "шестнадцать / шестнадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("17", "семнадцать / семнадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("18", "восемнадцати / восемнадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("19", "девятнадцать / девятнадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("20", "двадцать / двадцатый", category));
            CommonDictionary.Add(new DictionaryEntry("21", "двадцать один / двадцать первый", category));
            CommonDictionary.Add(new DictionaryEntry("30", "тридцать / тридцатый", category));

            category = "Miesiące";
            CommonDictionary.Add(new DictionaryEntry("styczeń", "январь", category));
            CommonDictionary.Add(new DictionaryEntry("luty", "февраль", category));
            CommonDictionary.Add(new DictionaryEntry("marzec", "март", category));
            CommonDictionary.Add(new DictionaryEntry("kwiecień", "апрель", category));
            CommonDictionary.Add(new DictionaryEntry("maj", "май", category));
            CommonDictionary.Add(new DictionaryEntry("czerwiec ", "июнь", category));
            CommonDictionary.Add(new DictionaryEntry("lipiec", "июль", category));
            CommonDictionary.Add(new DictionaryEntry("sierpień", "август", category));
            CommonDictionary.Add(new DictionaryEntry("wrzesień", "сентябрь", category));
            CommonDictionary.Add(new DictionaryEntry("październik", "октябрь", category));
            CommonDictionary.Add(new DictionaryEntry("listopad", "ноябрь", category));
            CommonDictionary.Add(new DictionaryEntry("grudzień", "декабрь", category));

            category = "Określenia czasu:";

            CommonDictionary.Add(new DictionaryEntry("wieczór", "вечером", category));
            CommonDictionary.Add(new DictionaryEntry("wczoraj", "вчера", category));
            CommonDictionary.Add(new DictionaryEntry("rok", "год", category));
            CommonDictionary.Add(new DictionaryEntry("dzień", "день", category));
            CommonDictionary.Add(new DictionaryEntry("miesiąc", "месяц", category));
            CommonDictionary.Add(new DictionaryEntry("noc", "ночь", category));
            CommonDictionary.Add(new DictionaryEntry("południe", "полдень", category));
            CommonDictionary.Add(new DictionaryEntry("północ", "полночь", category));
            CommonDictionary.Add(new DictionaryEntry("dziś", "сегодня", category));
            CommonDictionary.Add(new DictionaryEntry("rano", "утро", category));

            category = "Określenia stanu/ pokrewieństwa:";

            CommonDictionary.Add(new DictionaryEntry("kawaler", "xoлocтяк", category));
            CommonDictionary.Add(new DictionaryEntry("panna", "дeвицa", category));
            CommonDictionary.Add(new DictionaryEntry("wdowiec", "вдовец", category));
            CommonDictionary.Add(new DictionaryEntry("wdowa", "вдова", category));
            CommonDictionary.Add(new DictionaryEntry("syn", "сын", category));
            CommonDictionary.Add(new DictionaryEntry("córka", "дочь", category));
            CommonDictionary.Add(new DictionaryEntry("mąż", "муж", category));
            CommonDictionary.Add(new DictionaryEntry("żona", "жена", category));
            CommonDictionary.Add(new DictionaryEntry("brat", "брат", category));
            CommonDictionary.Add(new DictionaryEntry("siostra", "сестра", category));


            //CommonDictionary.Add(new DictionaryEntry("", "", category));



//            Zawody:

//            administrator parafii – администратор прихода
//akuszerka – aкушерка
//parobek – батрак
//bednarz – бондаръ
//borowy(gajowy) – боровый
//piekarz – пекар
//burmistrz – бургемистръ
//właściciel – владелецъ
//włościanin – влостянинъ
//furman, woźnica – возчикъ
//wójt gminy – войт гмины
//garncarz – гончаръ
//górnik – горнорабочий
//sługa dworski – дворовый
//lekarz – докторъ
//dróżnik – дорожный мастеръ
//zagrodnik – загродникъ
//rolnik – земледелецъ
//chłop – крестянинъ земледелецъ
//zakrystian, kościelny – ключаръ
//kolonista – колонистъ
//kowal – кузнецъ
//gajowy, strażnik leśny –
//лесникъ
//drwal – лесорубъ
//młynarz – мельникъ
//owczarz – овчаръ
//pisarz, kopista, skryba – писец
//kucharz – поваръ
//robotnik – работникъ
//rybak – рыбак
//ogrodnik, sadownik – садoвникъ
//ekonom – экономъ
//tkacz – ткачъ
        }

        void InitLetters()
        {
            AlphabetItems = new ObservableCollection<Letter>();

            AlphabetItems.Add(InitLetter("a",
                @"А", @"а",
                "like ar in far",
                "A", "a", 1));

            AlphabetItems.Add(InitLetter("be",
                @"Б", @"б",
                "like b in box",
                "B", "b", 2));

            AlphabetItems.Add(InitLetter("ve",
                @"В", @"в",
                "like v in voice",
                "V", "v", 3
                ));

            AlphabetItems.Add(InitLetter("ge",
                @"Г", @"г",
                "like g in go",
                "G", "g", 4
                ));

            AlphabetItems.Add(InitLetter(
                "de",
                @"Д", @"д",
                "like d in day",
                "D", "d", 5
                ));

            AlphabetItems.Add(InitLetter("ye",
                @"Е", @"е",
                "like ye in yet or e in exit",
                "E", "e", 6
                ));

            AlphabetItems.Add(InitLetter(
                "yo",
                @"Ё", @"ё",
                "like yo in your",
                "JO", "yo", 7
                ));

            AlphabetItems.Add(InitLetter(
                "zhe",
                @"Ж", @"ж",
                "like s in pleasure",
                "ŻE"/*rze*/, "zh", 8));

            AlphabetItems.Add(InitLetter(
                "ze",
                @"З", @"з",
                "like z in zoo",
                "Z", "z", 9));

            AlphabetItems.Add(InitLetter(
                "ee",
                @"И", @"и",
                "like ee in meet",
                "I", "ee", 10,
                @"І і Ѵ ѵ"));

            AlphabetItems.Add(InitLetter(
               "ee kratkoye (short i)",
               @"Й", @"й",
               "like y in boy",
               "J", "ee_kratkoe", 11));

            AlphabetItems.Add(InitLetter(
               "ka",
               @"К", @"к",
               "like k in key or c in cat",
               "K", "k", 12));

            AlphabetItems.Add(InitLetter(
               "el",
               @"Л", @"л",
               "like l in lamp",
               "L", "l", 13));

            AlphabetItems.Add(InitLetter(
               "em",
               @"М",@"м",
               "like m in man",
               "M","m",14));

            AlphabetItems.Add(InitLetter(
               "en",
               @"Н",@"н",
               "like n in note",
               "N","n",15));

            AlphabetItems.Add(InitLetter(
               "o",
               @"О",@"о",
               "like o in not",
               "O","o",16));

            AlphabetItems.Add(InitLetter(
               "pe",
               @"П",@"п",
               "like p in pet",
               "P","p",17));

            AlphabetItems.Add(InitLetter(
               "er",
               @"Р",@"р",
               "like r in rock (but rolled)",
               "R","r",18));

            AlphabetItems.Add(InitLetter(
               "es",
               @"С",@"с",
               "like s in sun",
               "S","s",19));

            AlphabetItems.Add(InitLetter(
               "te",
               @"Т",@"т",
               "like t in table",
               "T","t",20));

            AlphabetItems.Add(InitLetter(
               "oo",
               @"У",@"у",
               "like oo in moon",
               "U","u",21));

            AlphabetItems.Add(InitLetter(
               "ef",
               @"Ф",@"ф",
               "like f in food",
               "F","f",22,
                @"Ѳ ѳ"));

            AlphabetItems.Add(InitLetter(
               "kha",
               @"Х",@"х",
               "like ch in Scottish loch",
               "H","h",23));

            AlphabetItems.Add(InitLetter(
               "tse",
               @"Ц",@"ц",
               "like ts in boots",
               "C","ts",24));

            AlphabetItems.Add(InitLetter(
               "che",
               @"Ч",@"ч",
               "like ch in chat",
               "CZ","ch",25));

            AlphabetItems.Add(InitLetter(
               "sha",
               @"Ш",@"ш",
               "like sh in short",
               "SZ","sh",26));

            AlphabetItems.Add(InitLetter(
               "shcha",
               @"Щ",@"щ",
               "like sh_ch in fresh_cheese",
               "SZCZ","shch",27));

            AlphabetItems.Add(InitLetter(
               "tviordiy znak (hard sign)",
               null,
               @"ъ",
               "has no sound",
               "","tv_znak",28));

            AlphabetItems.Add(InitLetter(
               "ih*",
               null,
               @"ы",
               "like i in ill",
               "I","y",29));

            AlphabetItems.Add(InitLetter(
               "myagkiy znak (soft sign)",
               null,
               @"ь",
               "has no sound",
               "","m_znak",30));

            AlphabetItems.Add(InitLetter(
               "e",
               @"Э",@"э",
               "like e in end",
               "E","ue",31));

            AlphabetItems.Add(InitLetter(
               "yoo",
               @"Ю",@"ю",
               "like u in use",
               "JU","yu",32));

            AlphabetItems.Add(InitLetter(
               "ya",
               @"Я",@"я",
               "like ya in yard",
               "ia","ya",33));

        }

        Letter InitLetter(string name, string printedUpper, string printedLower, string pronEN, string pronPL, string resourceShortKey, short soundId, string oldPrinted = null)
        {
            string mainImageKey = resourceShortKey + "2";
            string upperCaseKey = "UPP_" + mainImageKey;
            string lowerCaseKey = "LOW_" + mainImageKey;
            string soundKey = "Sound" + soundId;

            //http://www.russianforeveryone.com/RufeA/Lessons/Introduction/Alphabet/{mainImageKey}.jpg
            var mainImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(mainImageKey);
            Bitmap upperImage = null;
            Bitmap lowerImage = null;

            if (!String.IsNullOrEmpty(printedUpper))
                upperImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(upperCaseKey);

            if (!String.IsNullOrEmpty(printedLower))
                lowerImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(lowerCaseKey);

            var sound = (byte[])Properties.Resources.ResourceManager.GetObject(soundKey);


            return new Letter(
                name,
                printedUpper,
                printedLower,
                pronEN,
                pronPL,
                mainImage,
                upperImage,
                lowerImage,
                sound, oldPrinted);
        }

        public ICommand PlaySoundCommand { get; }

        public static ObservableCollection<Letter> AlphabetItems { get; set; }
        public static ObservableCollection<DictionaryEntry> CommonDictionary { get; set; }

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
