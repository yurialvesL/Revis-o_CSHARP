using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_ex.Exception
{
    public class AccountException : System.Exception
    {
       

        public AccountException(string message) : base(message)
        {
           
        }
    }
}
