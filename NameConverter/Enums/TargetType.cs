using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameConverter.Enums
{
    public enum TargetType
    {
        Java,
        CSharp,
    }

    public static class TargetTypeExtensions
    {
        public static string GetString(this TargetType dt)
        {
            switch (dt)
            {
                case TargetType.Java:
                    return "java";
                case TargetType.CSharp:
                    return "c#";
                default:
                    return "";
            }
        }
    }

}
