using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintCoinach.Xiv {
    public class LogKindCategoryText : XivRow {
        #region Properties
        public string Text { get { return AsString("Text"); } }
        #endregion

        #region Constructor
        public LogKindCategoryText(IXivSheet sheet, Ex.Relational.IRelationalRow sourceRow) : base(sheet, sourceRow) { }
        #endregion

        public override string ToString() {
            return Text;
        }
    }
}