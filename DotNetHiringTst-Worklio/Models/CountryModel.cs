using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetHiringTst_Worklio.Models
{

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
    }

    public class CountryModel
    {
        public Name name { get; set; }
        public string cioc { get; set; }
        public List<string> capital { get; set; }
        public List<string> borders { get; set; }
        public TranslationsModels translations { get; set; }
    }
}