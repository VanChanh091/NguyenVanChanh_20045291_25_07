using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    public class FindString
    {
        public object FindSubString(string s, string s1)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(s1))
            {
                return -1;
            }
            
            int position = s.IndexOf(s1, StringComparison.Ordinal);

            if(position == -1)
            {
                return "khong tim thay s1 trong s";
            }
            return position;
        }
    }
}
