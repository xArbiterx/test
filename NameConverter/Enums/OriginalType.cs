using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameConverter.Enums
{
    public enum OriginalType
    {
        Json,
        Xml,
    }

    public static class OriginalTypeExtensions
    {
        public static string GetString(this OriginalType dt)
        {
            switch (dt)
            {
                case OriginalType.Json:
                    return "json";
                case OriginalType.Xml:
                    return "xml";
                default:
                    return "";
            }
        }
    }
}
