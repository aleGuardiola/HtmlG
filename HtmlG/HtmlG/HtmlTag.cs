using System;
using System.Collections.Generic;

namespace HtmlG
{
    public abstract class HtmlTag : HtmlObject
    {
        protected string _name;
        public string Name
        {
            get => _name;
        }

        protected LinkedList<Atribute> _atributes;

        public HtmlTag( string name )
        {
            _name = name;
            _atributes = new LinkedList<Atribute>();
        }

        public void AddAtribute( Atribute atribute )
        {
            _atributes.AddLast(atribute);
        }

        public abstract string ToHtml();   
    }
}
