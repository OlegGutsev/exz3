﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace exz3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Button1.Style = (Style)this.TryFindResource("Style1");
            Button2.Style = (Style)this.TryFindResource("Style1");
            Button3.Style = (Style)this.TryFindResource("Style1");
            Button4.Style = (Style)this.TryFindResource("Style1");
            Button5.Style = (Style)this.TryFindResource("Style1");
            Button6.Style = (Style)this.TryFindResource("Style1");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Button1.Style = (Style)this.TryFindResource("Style2");
            Button2.Style = (Style)this.TryFindResource("Style2");
            Button3.Style = (Style)this.TryFindResource("Style2");
            Button4.Style = (Style)this.TryFindResource("Style2");
            Button5.Style = (Style)this.TryFindResource("Style2");
            Button6.Style = (Style)this.TryFindResource("Style2");
        }
    }
}
