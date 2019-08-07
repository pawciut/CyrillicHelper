using CyrillicHelper.WPFControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace CyrillicHelper
{
    public class LookupRecordViewModel : ViewModelBase, ILookupRecordViewModel
    {
        public event EventHandler DeleteRequested;

        public LookupRecordViewModel()
        {
            Letters = new ObservableCollection<Letter>(AlphabetViewModel.AlphabetItems.OrderBy(l => l.SoundLikePolish));
            ToggleLettersCommand = new RelayCommand(cmd => true, ToggleLettersCommandExecute);
            UpperCommand = new RelayCommand(cmd => true, UpperCommandExecute);
            LowerCommand = new RelayCommand(cmd => true, LowerCommandExecute);
            ClearCommand = new RelayCommand(cmd => true, ClearCommandExecute);
            CopyCommand = new RelayCommand(cmd => true, CopyCommandExecute);
            TranslateCommand = new RelayCommand(cmd => true, TranslateCommandExecute);
            DeleteCommand = new RelayCommand(cmd => true, DeleteCommandExecute);

        }

        public ICommand ToggleLettersCommand { get; }
        public ICommand UpperCommand { get; }
        public ICommand LowerCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand CopyCommand { get; }
        public ICommand TranslateCommand { get; }
        public ICommand DeleteCommand { get; }

        Visibility lettersVisibility = Visibility.Visible;
        public Visibility LettersVisibility
        {
            get { return lettersVisibility; }
            set { SetProperty(ref lettersVisibility, value); }
        }

        string text;
        public string Text
        {
            get { return text; }
            set
            {
                SetProperty(ref text, value);
                UpdateTextImages();
            }
        }


        int selectionStart;
        public int SelectionStart 
    {
            get { return selectionStart; }
            set
            {
                SetProperty(ref selectionStart, value);
            }
        }

        int selectionLength;
        public int SelectionLength
        {
            get { return selectionLength; }
            set
            {
                SetProperty(ref selectionLength, value);
            }
        }


        public List<BitmapImage> TextImages { get; private set; }
        public ObservableCollection<Letter> Letters { get; }

        private void ToggleLettersCommandExecute(object param)
        {
            if (LettersVisibility == Visibility.Visible)
                LettersVisibility = Visibility.Collapsed;
            else
                LettersVisibility = Visibility.Visible;
        }

        private void UpperCommandExecute(object param)
        {
            if (param is Letter)
            {
                var letter = param as Letter;

                int index = SelectionStart + SelectionLength;

                Text = Text.Insert(index, letter.PrintedUpper);
            }
        }
        private void LowerCommandExecute(object param)
        {
            if (param is Letter)
            {
                var letter = param as Letter;
                int index = SelectionStart + SelectionLength;
                Text = Text.Insert(index, letter.PrintedLower);
            }
        }
        private void ClearCommandExecute(object param)
        {
            Text = String.Empty;
        }
        private void CopyCommandExecute(object param)
        {
            Clipboard.SetText(Text);
        }
        private void TranslateCommandExecute(object param)
        {
            var splitted = Text.Split(new char[] { ' ' });
            if (splitted.Length > 0)
                foreach (var part in splitted)
                    Process.Start("chrome.exe", HttpUtility.HtmlEncode("https://translate.google.com/?um=1&ie=UTF-8&hl=pl&client=tw-ob#ru/pl/" + part));
        }
        private void DeleteCommandExecute(object param)
        {
            DeleteRequested?.Invoke(this, new EventArgs());
        }

        void UpdateTextImages()
        {
            List<BitmapImage> images = new List<BitmapImage>();

            for (int i = 0; i < text.Length; ++i)
            {
                var letter = text.Substring(i, 1);

                bool isUpperCase = false;
                if (char.IsUpper(text[i]))
                    isUpperCase = true;

                var foundLetter = Letters.FirstOrDefault(l =>
                    (isUpperCase && l.PrintedUpper == letter)
                    || (!isUpperCase && l.PrintedLower == letter));
                if (foundLetter != null)
                {
                    if (isUpperCase)
                        images.Add(foundLetter.HandwrittenUpperImage);
                    else
                        images.Add(foundLetter.HandwrittenLowerImage);
                }
                else
                {
                    //TODO:To nie jest cyrylica
                }
            }

            TextImages = images;
            OnPropertyChanged(nameof(TextImages));
        }
    }
}
