using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlG
{
    class HtmlText : HtmlObject
    {
        string _text;
        public string Text
        {
            get => _text;
        }

        public string ToHtml()
        {
            return _text;
        }
    }
}
