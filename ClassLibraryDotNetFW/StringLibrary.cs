

using Newtonsoft.Json.Linq;
using NLog;
using System;

namespace ClassLibraryDotNetFW
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string str)
        {
            var logger = LogManager.GetCurrentClassLogger();
            logger.Trace("StartsWithUpper");
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }

        public static string GetTimeObject()
        {
            JArray array = new JArray();
            array.Add("Time");
            array.Add(DateTime.Now);

            JObject o = new JObject();
            o["MyArray"] = array;

            return o.ToString();
        }
    }
}
