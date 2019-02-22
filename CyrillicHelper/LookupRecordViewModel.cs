﻿using CyrillicHelper.WPFControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace CyrillicHelper
{
    public class LookupRecordViewModel : ViewModelBase
    {
        public LookupRecordViewModel()
        {
            Letters = new ObservableCollection<Letter>(AlphabetViewModel.AlphabetItems.OrderBy(l => l.SoundLikePolish));
            ToggleLettersCommand = new RelayCommand(cmd => true, ToggleLettersCommandExecute);
            UpperCommand = new RelayCommand(cmd => true, UpperCommandExecute);
            LowerCommand = new RelayCommand(cmd => true, LowerCommandExecute);
            ClearCommand = new RelayCommand(cmd => true, ClearCommandExecute);
            CopyCommand = new RelayCommand(cmd => true, CopyCommandExecute);
        }

        public ICommand ToggleLettersCommand { get; }
        public ICommand UpperCommand { get; }
        public ICommand LowerCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand CopyCommand { get; }

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
                Text = Text + letter.PrintedUpper;
            }
        }
        private void LowerCommandExecute(object param)
        {
            if (param is Letter)
            {
                var letter = param as Letter;
                Text = Text + letter.PrintedLower;
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