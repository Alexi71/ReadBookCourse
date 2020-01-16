using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Crashes;

namespace ReadBooks
{
    public class Books
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }

        public bool SaveBook()
        {
            var properties = new Dictionary<string, string>
            {
                {"book_info", this.Name  },
                {"book_author",this.Author }
            };
            AppCenterHelper.TrackEvent("book_saved",properties);
            return true;
        }
    }
}
