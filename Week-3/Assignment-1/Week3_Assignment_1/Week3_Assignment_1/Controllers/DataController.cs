using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Week3_Assignment_1.Controllers
{
    public class DataController : Controller
    {
        public string Index(string? number)
        {
            string message = "";

            if(number == null)
            {
                message = "Lack of Parameter";
            }
            else
            {
                BigInteger num;
                bool isNum = BigInteger.TryParse(number, out num);

                if(isNum)
                {
                    BigInteger result = (1 + num) * num / 2;
                    message = result.ToString();
                }
                else
                {
                    message = "Wrong Parameter";
                }
            }

            return message;
        }
    }
}
