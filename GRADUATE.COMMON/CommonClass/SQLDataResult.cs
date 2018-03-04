using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Common
{
    public class SQLDataResult<T>
    {
        public ExeSQLResult IsSuccess=ExeSQLResult.Success;

        public bool Status { get; set; } = true;

        public List<T> DataList { get; set; }
    }

    public enum ExeSQLResult
    {
        NoConnection,
        NullCommandString,
        NoResult,
        Success
    }
}
