using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWebinarsMVVM.ViewModel.Base;

namespace OpenWebinarsMVVM.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private string userName;
        private string passWord;

        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                RaiseProperty();
            }
        }

        public string PassWord
        {
            get => passWord;
            set
            {
                passWord = value;
                RaiseProperty();
            }
        }
    }
}