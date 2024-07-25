using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    public class ClassCau2
    {
        public bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 1)
            { 
                if (n % i == 0) return false; 
            }
            return true;
        }
        // Hàm tính tổng các chữ số của một số
        public int SumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10; n /= 10;
            }
            return sum;
        }
    }
}
