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

namespace BestHospital.Usercontrols
{
    /// <summary>
    /// Interaction logic for UCDate.xaml
    /// </summary>
    public partial class UCDate : UserControl
    {
        public UCDate()
        {
            InitializeComponent();
            DateTime d1 = DateTime.Now;
            d1 = d1.AddDays(-1);
            CalendarDateRange cdr = new CalendarDateRange(DateTime.MinValue, d1);
            myCalendar.BlackoutDates.Add(cdr);
        }
    }
}
