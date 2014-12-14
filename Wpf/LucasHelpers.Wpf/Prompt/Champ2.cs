using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LucasHelpers.Wpf.Prompt
{
    public class Champ2 : INotifyPropertyChanged
    {
        private string _title;
        private string _champUn;
        private string _champDeux;
        private string _textUn;
        private List<string> _textDeux;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        public string TextBouton
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        public string ChampUn
        {
            get { return _champUn; }
            set { _champUn = value; OnPropertyChanged(); }
        }

        public string ChampDeux
        {
            get { return _champDeux; }
            set { _champDeux = value; OnPropertyChanged(); }
        }

        public string TextUn
        {
            get { return _textUn; }
            set { _textUn = value; OnPropertyChanged(); }
        }

        public List<string> TextDeux
        {
            get { return _textDeux; }
            set { _textDeux = value; OnPropertyChanged(); }
        }

        public string Selected { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
