using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlG
{
    public class NameValueAtribute : Atribute
    {
        static string format = "{0}=\"{1}\"";//0:name, 1:value
        protected string _value;
        public string Value
        {
            get => _value;
        }

        public NameValueAtribute(string name, string value) : base(name)
        {
            _value = value;
        }

        public override string ToHtml()
        {
            var result = string.Format(format, _name, _value);
            return result;
        }
    }
}
