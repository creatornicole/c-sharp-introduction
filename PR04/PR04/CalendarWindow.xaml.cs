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
using System.Windows.Shapes;

namespace PR04
{
    /// <summary>
    /// Interaktionslogik für CalendarWindow.xaml
    /// </summary>
    public partial class CalendarWindow : Window
    {
        public CalendarWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Back_To_Page(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Calendar_Selected_Date_Changed(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = (DateTime) calendarView.SelectedDate;
            DateTime currentDate = DateTime.Now;

            int dayDifference = (int) (selectedDate - currentDate).TotalDays;

            string dayDiffInfo = "";
            if(dayDifference > 0) //selectedDate in future
            {
                dayDifference++; //counts total days
                dayDiffInfo = "Ausgewähltes Datum in " + dayDifference + " Tag(en).";
            } else //selectedDate in past
            {
                dayDiffInfo = "Ausgewähltes Datum war vor " + -dayDifference + " Tag(en).";
            }
            infoBox.Text = dayDiffInfo;
        }
    }
}
