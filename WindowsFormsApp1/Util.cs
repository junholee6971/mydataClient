using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace MydataClient
{
    class Util
    {
        public static bool isYyyyyMMdd(string date)
        {
            return Regex.IsMatch(date, @"^(19|20)\d{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[0-1])$");
        }

    }
}
