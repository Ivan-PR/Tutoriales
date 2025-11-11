using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using OpenWebinarsMVVM.Services;
using OpenWebinarsMVVM.ViewModel.Base;
using ReactiveUI;
using ReactiveUI.Wpf;

namespace OpenWebinarsMVVM.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly ILoginService loginService;

        private string userName;
        private string passWord;
        private ReactiveCommand<Unit, Unit> loginCommand;

        public LoginViewModel()
        {
            loginCommand = ReactiveCommand.CreateFromTask<Unit, Unit>(PerformDoLoginAsync);
            loginService = CustomDependecyService.Get<LoginService>();
        }

        private Task<Unit> PerformDoLoginAsync(Unit arg)
        {
            CustomDependecyService.Get<LoginService>().DoLogin(userName, passWord);
            return Task.FromResult(Unit.Default);
        }

        public string UserName
        {
            get => userName;
            set => this.RaiseAndSetIfChanged(ref userName, value);
        }

        public string PassWord
        {
            get => passWord;
            set => this.RaiseAndSetIfChanged(ref passWord, value);
        }

        public ReactiveCommand<Unit, Unit> DoLoginCommand => loginCommand;
    }
}