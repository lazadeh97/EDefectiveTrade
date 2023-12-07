using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Exceptions
{
    public class CustomException : Exception
    {
        private string ExMessage { get; set; }
        public CustomException() : base()
        { }
        public CustomException(string msj) : base()

        {
            ExMessage = msj;
        }

        public override string Message
        {
            get
            {
                return ExMessage;
            }
        }

        public override string StackTrace
        {
            get
            {
                return "";
            }
        }
    }
}
