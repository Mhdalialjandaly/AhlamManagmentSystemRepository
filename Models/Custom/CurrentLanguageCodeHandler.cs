using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Custom
{
    public static class CurrentLanguageCodeHandler
    {
        public static string ArLanguageCode = "en-GB";
        public static string EnLanguageCode = "en";

        public static string? CurrentLanguageCode { get; set; }
    }
}
