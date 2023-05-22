using System;
using System.Collections.Generic;
using System.IO;
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

namespace PR06
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

        /// <summary>
        /// 
        /// Empty TextBox Inputs and Uncheck CheckBoxes
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            AbsPathTextBox.Text = string.Empty;
            OutputTextBlock.Text = string.Empty;

            Subdir_CheckBox.IsChecked = false;
            Subdir_File_CheckBox.IsChecked = false;
            File_CheckBox.IsChecked = false;
        }

        /// <summary>
        /// 
        /// Show Directory Content according to checked CheckBoxes
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Show(object sender, RoutedEventArgs e) {
            string absolutePath = AbsPathTextBox.Text;

            if(absolutePath.Equals("")) {
                OutputTextBlock.Text = "Please input an absolute path to your directory.";
            } else
            {
                //Check if Directory Exists
                if(Directory.Exists(absolutePath))
                {
                    //Make sure that OutputTextBlock is empty
                    OutputTextBlock.Text = string.Empty;
                    //If Directory Exists Check CheckBoxes and Display Accordingly
                    if ((Subdir_CheckBox.IsChecked == true) && 
                        (File_CheckBox.IsChecked == false) &&
                        (Subdir_File_CheckBox.IsChecked == false)) 
                    {
                        DisplaySubdirectories(absolutePath);

                    } else if ((Subdir_CheckBox.IsChecked == false) &&
                        (File_CheckBox.IsChecked == true) &&
                        (Subdir_File_CheckBox.IsChecked == false))
                    {
                        DisplayFiles(absolutePath);

                    } else if((Subdir_CheckBox.IsChecked == false) &&
                        (File_CheckBox.IsChecked == false) &&
                        (Subdir_File_CheckBox.IsChecked == true))
                    {
                        DisplaySubdirectoriesWithFiles(absolutePath);                    

                    } else
                    {
                        OutputTextBlock.Text = "Too many CheckBoxes checked.";
                    }

                } else
                {
                    OutputTextBlock.Text = "Input is no Directory.";
                }
            }
            
        }

        /// <summary>
        /// 
        /// Display Subdirectories of Directory dir
        /// 
        /// </summary>
        /// <param name="dir"></param>
        private void DisplaySubdirectories(string dir)
        {
            OutputTextBlock.Text += dir + "\n";
            string[] subDirectories = Directory.GetDirectories(dir);
            foreach(string subDir in subDirectories)
            {
                DisplaySubdirectories(subDir);
            }
        }

        /// <summary>
        /// 
        /// Show Files of Directory dir
        /// 
        /// </summary>
        /// <param name="dir"></param>
        private void DisplayFiles(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            foreach(string file in files)
            {
                OutputTextBlock.Text += file + "\n";
            }
        }

        /// <summary>
        /// 
        /// Display Subdirectories with Files of Directory dir
        /// 
        /// </summary>
        /// <param name="dir"></param>
        private void DisplaySubdirectoriesWithFiles(string dir)
        {
            OutputTextBlock.Text += dir + "\n";
            string[] subDirectories = Directory.GetDirectories(dir);
            foreach (string subDir in subDirectories)
            {
                DisplaySubdirectories(subDir);
                DisplayFiles(subDir); //display all files of current dir
                OutputTextBlock.Text += "\n";
            }
        }


    }


}
