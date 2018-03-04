using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRONGER.COMMON.CommonClass
{
    public class EmailResult
    {
        public EmailResultEnum Status { get; set; } = EmailResultEnum.Success;
        public string Message { get; set; } = "ok";
    }

    public enum EmailResultEnum
    {
        Fail,
        Success
    }
}
