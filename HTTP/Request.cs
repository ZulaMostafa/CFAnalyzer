using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CFAnalyzer.HTTP
{
    public class Request
    {
        public static string sha512(string value)
        {
            using (SHA512 sha512Hash = SHA512.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(value);
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash.ToLower();
            }
        }

        public static string RequestCreator(string order, string APIKey, string APISecret, string contestID)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string toHash = @"123456/" + order + "?" +
                             "apiKey=" + APIKey +
                             "&contestId=" + contestID +
                             "&time=" + unixTimestamp.ToString() +
                             "#" + APISecret;
            string Hashed = sha512(toHash);
            string Link = "https://codeforces.com/api/" + order + "?" +
                            "contestId=" + contestID +
                            "&apiKey=" + APIKey +
                            "&time=" + unixTimestamp.ToString() +
                            "&apiSig=123456" + Hashed;
            return Link;
        }
    }
}
