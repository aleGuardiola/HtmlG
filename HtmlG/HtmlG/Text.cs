using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlG
{
    public class Text : HtmlObject
    {
        string _text;
        public string TText
        {
            get => _text;
        }

        public Text(string text)
        {
            _text = text;
        }

        string HtmlObject.ToHtml()
        {
            return _text;
        }
    }
}
