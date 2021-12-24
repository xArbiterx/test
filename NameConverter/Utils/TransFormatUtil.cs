using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameConverter.Utils
{
    public class TransFormatUtil
    {
        static public string TransKebabToCamel(string str, char symbol, bool isUpper)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            StringBuilder sb = new();

            var arr = str.Split(symbol);
            foreach (var unit in arr)
            {
                if (string.IsNullOrEmpty(unit))
                {
                    continue;
                }
                var firstWord = unit.First().ToString();
                sb.Append(isUpper ? firstWord.ToUpper() : firstWord.ToLower());
                if (unit.Length > 1)
                {
                    sb.Append(unit.AsSpan(1));
                }
            }
            return sb.ToString();
        }

        static public string TransCamelToKebab(string str, char symbol, bool isUpper)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            StringBuilder sb = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || char.IsUpper(str[i]))
                {
                    if (i != 0)
                    {
                        sb.Append(symbol);
                    }
                    sb.Append(isUpper ? str[i].ToString().ToUpper() : str[i].ToString().ToLower());
                }
                else
                {
                    sb.Append(str[i].ToString().ToLower());
                }
            }
            return sb.ToString();
        }

        static public string TransCamelToOtherType(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            StringBuilder sb = new();
            return sb.ToString();
        }
    }
}
