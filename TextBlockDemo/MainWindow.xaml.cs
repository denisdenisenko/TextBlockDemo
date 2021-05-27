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

namespace TextBlockDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbOne_Checked(object sender, RoutedEventArgs e)
        {
            lbOne.Background = Brushes.Red;
        }

        private void rbOne_Unchecked(object sender, RoutedEventArgs e)
        {
            lbOne.Background = Brushes.White;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            lblCh.Background = Brushes.Red;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            lblCh.Background = Brushes.White;

        }

        private void cbParent_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbParent.IsChecked == true);
            cbOne.IsChecked = newVal;
            cbTwo.IsChecked = newVal;
            cbThree.IsChecked = newVal;
        }

        private void cbParent_Unchecked(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbParent.IsChecked == true);
            cbOne.IsChecked = newVal;
            cbTwo.IsChecked = newVal;
            cbThree.IsChecked = newVal;
        }

        private void cbGroupCheckedChanged(object sender, RoutedEventArgs e) 
        {
            cbParent.IsChecked = null;
            if ((cbOne.IsChecked==true) &&
                    (cbTwo.IsChecked==true) && (cbThree.IsChecked==true)) 
            {
                cbParent.IsChecked = true;
            }
            if ((cbOne.IsChecked==false) &&
                    (cbTwo.IsChecked==false) && (cbThree.IsChecked==false))
            {
                cbParent.IsChecked = false;
            }
        }
    }
}