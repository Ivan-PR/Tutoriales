using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OpenWebinarsWPF
{
    /// <summary>
    /// Lógica de interacción para UserControlPAthButton.xaml
    /// </summary>
    public partial class UserControlPathButton : UserControl
    {
        public static DependencyProperty LabelTextProperty =
            DependencyProperty.Register(nameof(LabelText), typeof(string), typeof(UserControlPathButton),
                new PropertyMetadata(LabelTextPropertyChanged));

        public UserControlPathButton()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get => (string) GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }

        private static void LabelTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var userControlPath = (UserControlPathButton) d;
            userControlPath.LabelPath.Content = e.NewValue.ToString();
        }
    }
}