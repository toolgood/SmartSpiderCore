using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpiderCore.ExcelRules.HapCss.Selectors
{
    internal class TagNameSelector : CssSelector
    {
        public override string Token
        {
            get { return string.Empty; }
        }

        protected internal override IEnumerable<HtmlNode> FilterCore(IEnumerable<HtmlNode> currentNodes)
        {
            foreach (var node in currentNodes)
            {
                if (node.Name.Equals(this.Selector, StringComparison.InvariantCultureIgnoreCase))
                    yield return node;
            }
        }
    }
}
