using EDefectiveTrade.Business.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.DTOs.Authentication
{
    public class LoginDto : BaseDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
