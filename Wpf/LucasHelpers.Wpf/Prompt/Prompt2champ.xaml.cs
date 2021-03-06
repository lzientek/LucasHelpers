﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace LucasHelpers.Wpf.Prompt
{
    /// <summary>
    /// Logique d'interaction pour Prompt2champ.xaml
    /// </summary>
    public partial class Prompt2Champ 
    {
        public Champ2 Champ { get; set; }

        public Prompt2Champ(Champ2 c)
        {
            

            Champ = c;
            InitializeComponent();
            DataContext = Champ;
            TextBox1.Focus();
            Application.Current.MainWindow.IsEnabled = false;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Champ.TextUn) && Champ.Selected != null)
            {
                OnValided();
                Close();
            }
            else
                MessageBox.Show(this, "Remplir tous les champs.");
        }

        public event EventHandler<EventArgs> Valided;

        protected virtual void OnValided()
        {
            EventHandler<EventArgs> handler = Valided;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        private void Prompt2Champ_OnClosed(object sender, EventArgs e)
        {
            Application.Current.MainWindow.IsEnabled = true;
        }
    }

    
}
