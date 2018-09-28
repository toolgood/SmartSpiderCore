using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpiderCore.ExcelRules.HapCss.Selectors
{
    internal class ClassNameSelector : CssSelector
    {
        public override string Token
        {
            get { return "."; }
        }

        protected internal override IEnumerable<HtmlNode> FilterCore(IEnumerable<HtmlNode> currentNodes)
        {
            foreach (var node in currentNodes)
            {
                if (node.GetClassList().Any(c => c.Equals(this.Selector, StringComparison.InvariantCultureIgnoreCase)))
                    yield return node;
            }
        }
    }
}
