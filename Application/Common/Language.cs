using Models.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public class Language
    {
        public string? Name { get; set; }
        public string? Code { get; set; }

        public List<Language> GetLanguages()
        {
            return new()
            {
                new Language { Code = CurrentLanguageCodeHandler.ArLanguageCode, Name = "Arabic" },
                new Language { Code = CurrentLanguageCodeHandler.EnLanguageCode, Name = "English" }
            };
        }
    }
}
