using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlG
{
    public class LightTag : HtmlTag
    {
        const string openTagFormat = "<{0}{1}/>";//0: name; 1: atributes
        
        public LightTag(string name) : base(name)
        {
           
        }

        public override string ToHtml()
        {
            StringBuilder atributesBuilder = new StringBuilder();

            var currentAtributeNode = _atributes.First;
            while (currentAtributeNode != null)
            {
                atributesBuilder.Append(" ");
                atributesBuilder.Append(currentAtributeNode.Value.ToHtml());
                currentAtributeNode = currentAtributeNode.Next;
            }

            var result = string.Format(openTagFormat, _name, atributesBuilder);

            return result;
        }
    }
}
