using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class AdvancedCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            string a_str = Convert.ToString(a, 10);
            string b_str = Convert.ToString(b, 10);
            DigitAlignment(ref a_str, ref b_str);

            int cin = 0;
            int add = 0;
            string result = "";

            for (int i = a_str.Length - 1; i >= 0; i--)
            {
                add = (cin + (a_str[i] - '0') + (b_str[i] - '0'));
                cin = add / 10;
                add = add % 10;

                result += add.ToString();
            }

            result += cin;

            result = ReverseString(result);
            int result_int = int.Parse(result);
            return result_int;
        }

        public int Subtract(int a, int b)
        {
            int sign = 1;
            if(a < b)
            {
                int temp = a;
                a = b;
                b = temp;
                sign = -1;
            }

            string a_str = Convert.ToString(a, 10);
            string b_str = Convert.ToString(b, 10);
            DigitAlignment(ref a_str, ref b_str);

            int cout = 0;
            int subtract = 0;
            string result = "";

            for (int i = a_str.Length - 1; i >= 0; i--)
            {
                subtract = a_str[i] - cout - b_str[i];
                if (subtract < 0)
                {
                    cout = 1;
                    subtract += 10;
                }
                else cout = 0;

                result += subtract.ToString();
            }

            result = ReverseString(result);
            int result_int = int.Parse(result) * sign;
            return result_int;
        }

        public void DigitAlignment(ref string a_str, ref string b_str)
        {
            if (a_str.Length > b_str.Length)
            {
                b_str = b_str.PadLeft(a_str.Length, '0');
            }
            else if (a_str.Length < b_str.Length)
            {
                a_str = a_str.PadLeft(b_str.Length, '0');
            }
        }

        public string ReverseString(string srtVarable)
        {
            return new string(srtVarable.Reverse().ToArray());
        }
    }
}
