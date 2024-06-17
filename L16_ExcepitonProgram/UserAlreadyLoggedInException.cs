using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_ExcepitonProgram
{
    internal class UserAlreadyLoggedInException:Exception
    {
        //custom exception handling
        public UserAlreadyLoggedInException(string message) :base(message)
        {
            
        }
        //if base is not used it'll show a exception was thrown by the UseralreadyloggedinException class
        //if base is used it'll show the exception message passed from there
    }
}
