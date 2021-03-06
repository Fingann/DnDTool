﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DnDTool.Converters
{
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Windows.Data;
    using System.Windows.Media;

    public class PositiveNegativeColorConverter : IValueConverter
    {
        public object Convert(object values, Type targetType, object parameter, CultureInfo culture)
        {
            int number;
            
            if (!(values is int))
            {
                return new SolidColorBrush(Colors.Black);
            }
            
            number = (int)values;
            return (number >= 0) ? parameter : new SolidColorBrush(Colors.OrangeRed);

          
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string number = value as string;

            if (number != null)
            {
                var tempnum = 
                    Regex.Replace(number, @"[^\d]", string.Empty);
                return tempnum;
            }
            return int.Parse(string.Empty);
        }

      
    }
}