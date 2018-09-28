using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpiderCore.ExcelRules.HapCss.Selectors
{
    internal class ImediateChildrenSelector : CssSelector
    {
        public override bool AllowTraverse
        {
            get { return false; }
        }

        public override string Token
        {
            get { return ">"; }
        }

        protected internal override IEnumerable<HtmlNode> FilterCore(IEnumerable<HtmlNode> currentNodes)
        {
            return currentNodes.SelectMany(i => i.ChildNodes);
        }
    }
}