using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlG
{
    public class Tag : HtmlTag
    {
        LinkedList<HtmlObject> _content;
        static string openTagFormat = "<{0}{1}>";//0: name; 1: atributes
        static string closeTagFormat = "</{0}>";//0: name
        static string format = "{0}{1}{2}";//0: openTag; 1:content; 2:closeTag

        public Tag(string name) : base(name)
        {
            _content = new LinkedList<HtmlObject>();
        }

        public void AddContent( HtmlObject item)
        {
            _content.AddLast(item);
        }

        public override string ToHtml()
        {
            StringBuilder atributesBuilder = new StringBuilder();

            var currentAtributeNode = _atributes.First;
            while(currentAtributeNode != null)
            {
                atributesBuilder.Append(" ");
                atributesBuilder.Append(currentAtributeNode.Value.ToHtml());
                currentAtributeNode = currentAtributeNode.Next;
            }

            StringBuilder contentBuilder = new StringBuilder();

            var currentContentNode = _content.First;
            while (currentContentNode != null)
            {
                contentBuilder.Append(currentContentNode.Value.ToHtml());
                currentContentNode = currentContentNode.Next;
            }

            var result = string.Format(
                format,
                string.Format(openTagFormat, _name, atributesBuilder),
                contentBuilder,
                string.Format(closeTagFormat, _name));

            return result;                
        }
    }
}
