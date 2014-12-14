using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LucasHelpers.Wpf.Prompt
{
    public class Champ : INotifyPropertyChanged
    {
        private string _title;
        private string _champUn;
        private string _textUn;

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

        public string TextUn
        {
            get { return _textUn; }
            set { _textUn = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
