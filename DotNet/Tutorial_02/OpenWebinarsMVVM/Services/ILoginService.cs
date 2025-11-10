using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWebinarsMVVM.Model;

namespace OpenWebinarsMVVM.Services
{
    public interface ILoginService
    {
        UserData DoLogin(string userName, string password);
    }
}