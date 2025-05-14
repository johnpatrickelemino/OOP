using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class otp
    {
        private static Dictionary<string, (string otp, DateTime expiry)> otpStorage = new();

        public static string Generate()
        {
            Random random = new Random();
            return random.Next(10000, 99999).ToString();
        }

        public static void StoreOtp(string email, string otp)
        {
            otpStorage[email] = (otp, DateTime.Now.AddMinutes(1)); 
        }

        
    }
}

