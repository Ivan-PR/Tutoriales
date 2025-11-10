using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using OpenWebinarsMVVM.Services;

namespace OpenWebinarsMVVM
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            CustomDependecyService.Register<LoginService>();
        }
    }
}