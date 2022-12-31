using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmlakModel
{
    public class OperationResult
    {
        public long RecordID { get; set; }
        public long LongRecordID { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public string ClassName { get; set; }
        public string FunctionName { get; set; }
    }
}
