﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int delayInSeconds = 3;
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(delayInSeconds * 1000);

                
                Dispatcher.Invoke(() =>
                {
                    LoginWindow obj = new LoginWindow();
                    obj.Show();

                    this.Close();
                });
            });

            thread.Start();
        }
    }
}
