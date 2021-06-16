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

namespace FirstWPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Example how to add the event at code behind:
            //MainGrid.MouseDown += new MouseButtonEventHandler(Grid_MouseDown);
        }

        // sender comes from the control element 
        // MouseButtonEventArgs gives additional informations
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString() + "\n"
                            + e.MouseDevice.ToString());
            
        }
    }
}
