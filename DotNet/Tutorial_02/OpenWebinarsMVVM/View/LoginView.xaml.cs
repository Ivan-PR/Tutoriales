using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OpenWebinarsMVVM.ViewModel;
using ReactiveUI;

namespace OpenWebinarsMVVM.View
{
    /// <summary>
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    public partial class LoginView
    {
        public LoginView()
        {
            InitializeComponent();
            this.WhenActivated(d =>
            {
                d(this.Bind(ViewModel, vm => vm.UserName, v => v.TextBoxUsername.Text));
                d(this.Bind(ViewModel, vm => vm.PassWord, v => v.TextBoxPassword.Text));
                d(this.BindCommand(ViewModel, vm => vm.DoLoginCommand, v => v.ButtonLogin));
            });

            this.WhenAnyValue(v => v.ViewModel.UserName, v => v.ViewModel.PassWord)
                .Where(x => !string.IsNullOrEmpty(x.Item1))
                .Select(x => x.Item1)
                .Subscribe(username =>
                {
                    if (!string.IsNullOrEmpty(username))
                    {
                        TextBoxUsername.Background = new SolidColorBrush(Colors.Aquamarine);
                    }
                });

            var textEvent = Observable.FromEventPattern<TextChangedEventArgs>(TextBoxUsername, nameof(TextBoxUsername.PreviewTextInput));
            textEvent.Subscribe();
        }
    }
}