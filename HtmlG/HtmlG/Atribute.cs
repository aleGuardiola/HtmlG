using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlG
{
    public abstract class Atribute : HtmlObject
    {
        public Atribute( string name )
        {
            _name = name;           
        }

        protected string _name;
        public string Name
        {
            get => _name;
        }
        
        public abstract string ToHtml();        
    }
}
