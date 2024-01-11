using System.Collections.Generic;

namespace GMapExtractor
{
    public class Language
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
    public class LangList
    {
        public static List<Language> GetList()
        {
            return new List<Language> {
                 new Language { Name = "English (United States)", Code = "hl=en" },
                new Language { Name = "Afrikaans", Code = "hl=af" },
                new Language { Name = "azərbaycan", Code = "hl=az" },
                new Language { Name = "Bahasa Indonesia", Code = "hl=id" },
                new Language { Name = "Bahasa Melayu", Code = "hl=ms" },
                new Language { Name = "bosanski", Code = "hl=bs" },
                new Language { Name = "català", Code = "hl=ca" },
                new Language { Name = "Čeština", Code = "hl=cs" },
                new Language { Name = "Dansk", Code = "hl=da" },
                new Language { Name = "Deutsch (Deutschland)", Code = "hl=de" },
                new Language { Name = "eesti", Code = "hl=et" }
            };
        }
    }
}
