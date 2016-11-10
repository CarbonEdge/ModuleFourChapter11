using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourChapter11
{
    public static class UpgradeString
    {
        public static string upperCaseString(this string input)
        {
            if(input !=null)
            {
                input = input.ToUpper()+" this word has been changed to upper case and had a few words added on";
            }
            return input;
        }
    }
}
