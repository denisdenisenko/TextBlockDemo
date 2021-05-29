using System;
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

        public bool shifted = false; 
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (shifted == false) 
            {
                myImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQb8AUrmARudAxlGSh23Usv7YY0KtMcR4qwQA&usqp=CAU"));
                shifted = true;
            }
            else if (shifted == true)
            {
                myImg.Source = new BitmapImage(new Uri("https://analyticsindiamag.com/wp-content/uploads/2020/10/7d744a684fe03ebc7e8de545f97739dd.jpg"));
                shifted = false;
            }
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (mySldTxtBlock != null)
                mySldTxtBlock.Text =" Slider value is : " +  mySlider.Value.ToString();
            mySldTxtBlock.FontSize = (mySlider.Value/10) + 10;
        }
    }
}