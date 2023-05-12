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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace PR05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string question = "Do you want to get more Message Boxes?";
            string title = "Message Boxes";
            string instructionText = "Instruction Example";
            string text = "Text Example";
            string yesHeader = "Yes";
            string yesDesc = "Get more Messages.";
            string noHeader = "No";
            string noDesc = "Get no more Messages";
            string cancelHeader = "Cancel";
            string cancelDesc = "Escape the Rat Race";

            while(showQuestionBox(question, title, instructionText, text, yesHeader, yesDesc, noHeader, noDesc, cancelHeader, cancelDesc) == MessageBoxResult.Yes)
            {
                question = "Alright - as you wish. Here is your next Message Box.";
            }
            
        }

        /// <summary>
        /// 
        /// Display MessageBox/TaskDialog
        /// 
        /// </summary>
        /// <param name="question"></param>
        /// <param name="title"></param>
        /// <param name="instructionText"></param>
        /// <param name="text"></param>
        /// <param name="yesHeader"></param>
        /// <param name="yesDesc"></param>
        /// <param name="noHeader"></param>
        /// <param name="noDesc"></param>
        /// <param name="cancelHeader"></param>
        /// <param name="cancelDesc"></param>
        /// <returns></returns>
        private MessageBoxResult showQuestionBox(string question, string title, string instructionText, string text, string yesHeader,
            string yesDesc, string noHeader, string noDesc, string cancelHeader, string cancelDesc)
        {
            MessageBoxResult mbRes = new MessageBoxResult();

            //Create new TaskDialog
            TaskDialog td = new TaskDialog();

            //Add Properties
            td.Icon = TaskDialogStandardIcon.Information;
            td.Caption = title;
            td.InstructionText = instructionText;
            td.Text = text;
            td.Cancelable = true;

            //Define Buttons
            TaskDialogCommandLink btnYes = new TaskDialogCommandLink("btnYes", yesHeader, yesDesc); //Yes Button
            TaskDialogCommandLink btnNo = new TaskDialogCommandLink("btnNo", noHeader, noDesc); //No Button
            TaskDialogCommandLink btnCancel = new TaskDialogCommandLink("btnCancel", cancelHeader, cancelDesc); //Cancel Button

            //Add Buttons to TaskDialog
            td.Controls.Add(btnYes);
            td.Controls.Add(btnNo);
            td.Controls.Add(btnCancel);

            //Add Event Handler
            btnYes.Click += new EventHandler(btnYes_Click);
            btnNo.Click += new EventHandler(btnNo_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);

            //Connection to current Window
            WindowInteropHelper winInteropHelper = new WindowInteropHelper(this);
            td.OwnerWindowHandle = winInteropHelper.Handle;

            //Show TaskDialog
            try
            {
                TaskDialogResult tdRes = td.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                mbRes = MessageBox.Show(question, title, MessageBoxButton.YesNoCancel, MessageBoxImage.Information);
            }

            //return mbRes;
            return mbRes;
        }

        /// <summary>
        /// 
        /// EventHandler Yes-Button of TaskDialog
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            TaskDialogCommandLink cmdLnk = (TaskDialogCommandLink)sender;
            if(cmdLnk != null)
            {
                ((TaskDialog)cmdLnk.HostingDialog).Close(TaskDialogResult.Yes);
            }
        }

        /// <summary>
        /// 
        /// EventHandler No-Button of TextDialog
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            TaskDialogCommandLink cmdLnk = (TaskDialogCommandLink)sender;
            if (cmdLnk != null)
            {
                ((TaskDialog)cmdLnk.HostingDialog).Close(TaskDialogResult.No);
            }
        }

        /// <summary>
        /// 
        /// EventHandler Cancel-Button of TextDialog
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TaskDialogCommandLink cmdLnk = (TaskDialogCommandLink)sender;
            if (cmdLnk != null)
            {
                ((TaskDialog)cmdLnk.HostingDialog).Close(TaskDialogResult.Cancel);
            }
        }
    }
}
