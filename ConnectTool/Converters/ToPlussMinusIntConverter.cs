using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Converters
{
    using System.Globalization;
    using System.Windows.Data;

    class ToPlussMinusIntConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int input;
            int.TryParse(value.ToString(), out input);
            if (input < 0)
            {
                return "-" + Math.Abs(input);
            }
            if (input > 0)
            {
                return "+" + Math.Abs(input);
            }

            return 0;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string input = value as string;
            if (input == null) return 0;

            if (input.Contains('+'))
            {
                int number;
                int.TryParse(input.ToCharArray().Where(x => x != '+').ToString(), out number);
                return number;
            }
            if (input.Contains('-'))
            {
                int number;
                int.TryParse(input.ToCharArray().Where(x => x != '-').ToString(), out number);
                return number - (number * 2);
            }
            return 0;
        }
    }
}
