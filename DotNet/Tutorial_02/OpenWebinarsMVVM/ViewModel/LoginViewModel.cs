using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using OpenWebinarsMVVM.Services;
using OpenWebinarsMVVM.ViewModel.Base;

namespace OpenWebinarsMVVM.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private string userName;
        private string passWord;
        private ICommand loginCommand;

        public LoginViewModel()
        {
            loginCommand = new Command(PerformDoLoginCommand);
        }

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

        public ICommand DoLoginCommand => loginCommand;

        private void PerformDoLoginCommand()
        {
            new LoginService().DoLogin(userName, passWord);
        }
    }
}