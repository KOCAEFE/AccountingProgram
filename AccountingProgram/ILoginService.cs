using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    public interface ILoginService
    {
        void Login(string userName, string password);
        void SendMail(string mail);
    }
}
