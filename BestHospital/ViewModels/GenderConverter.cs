using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BestHospital.ViewModels
{
	class GenderConverter : IValueConverter
	{

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{

			if (value is int)
			{
				if ((int)value == 1)
					return "male";
				else if ((int)value == 2)
					return "female";
				else if ((int)value == 3)
					return "unknown";
			}
			return "Not selected";
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
		

			switch (value.ToString().ToLower())
			{
				case "male":

					return 1;
				case "female":

					return 2;
				case "unknown":

					return 3;
				default:
					return -1;
			}
		}
	}
	
}
