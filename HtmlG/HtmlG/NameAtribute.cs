using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlG
{
    public class NameAtribute : Atribute
    {
        public NameAtribute(string name) : base(name)
        {

        }

        public override string ToHtml()
        {
            return _name;
        }
    }
}
