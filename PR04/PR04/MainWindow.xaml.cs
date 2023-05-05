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

namespace PR04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Focus(); //Set Focus to TextBox when starting Application
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        /// <summary>
        /// 
        /// Close window on button click except textbox contains "schließen"
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            String textBoxValue = textBox.Text.ToLower(); //ignore large and lower case
            if(!textBoxValue.Equals("schließen"))
            {
                Close(); //Close Application
            }
        }

        /// <summary>
        /// 
        /// Open new Window with Calendar on Button Click
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Show_Calendar(object sender, RoutedEventArgs e)
        {
            CalendarWindow calendarWindow = new CalendarWindow();
            calendarWindow.ShowDialog(); //locks current window and opens new one
        }
    }
}
