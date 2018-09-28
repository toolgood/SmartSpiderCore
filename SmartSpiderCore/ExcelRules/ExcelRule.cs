using SmartSpiderCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSpiderCore.ExtractRule
{
    /// <summary>
    /// 类 excel 公式提取类,传入值为[html]
    /// 支持OuterHtml、InnerHtml、InnerText、Attr、HasClass、HasAttr
    /// 及 ToolGood.Algorithm 各种类 excel 公式
    /// </summary>
    public class ExcelRule : Rule
    {
		[ThreadStatic]
		private static ExcelEngine _excelEngine = new ExcelEngine() { UseExcelIndex = false };

		public ExcelRule(string formula)
		{
			Formula = formula;
		}
		public ExcelRule(string formulaName, string formula)
		{
			FormulaName = formulaName;
			Formula = formula;
		}

		public string FormulaName { get;  set; }

		public string Formula { get; set; }

	 

        public override Content Exec(Content content)
        {
            if (content.ContentText != null) {
                content.ContentText= _excelEngine.TryWork(FormulaName, Formula, content.ContentText.ToString());
            }
            return content;
        }
    }
}
