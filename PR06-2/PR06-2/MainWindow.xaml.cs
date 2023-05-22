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
using System.IO;

namespace PR06_2
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

        private void Button_Click_Insert(object sender, RoutedEventArgs e)
        {
            //Store Inputs into Variables
            string data = InsertData.Text;
            string path = FilePath.Text;
            string file = TxtFile.Text + ".txt";

            string filepath = path + "\\" + file;

            //Empty TextBoxes
            InsertData.Text = string.Empty;
            FilePath.Text = string.Empty;
            TxtFile.Text = string.Empty;

            //Test if File already exists
            if(!File.Exists(filepath))
            {
                //Create File
                FileStream fs = File.Create(filepath);
                //Close File
                fs.Close();
            }

            //Append String to existing File
            File.AppendAllText(filepath, data + Environment.NewLine);
        }
    }
}
