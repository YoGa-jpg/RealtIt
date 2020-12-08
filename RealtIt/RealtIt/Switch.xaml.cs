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

namespace RealtIt
{
    /// <summary>
    /// Interaction logic for Switch.xaml
    /// </summary>
    public partial class Switch : UserControl
    {
        public bool SwitchMode { get; set; }
        public Switch()
        {
            InitializeComponent();
            SwitchMode = false;
        }

        private async void SwitchChange(object sender, MouseButtonEventArgs e)
        {
            if (SwitchDot.Margin.Left.Equals(0))
            {
                for (int i = 0, j = Convert.ToInt32(SwitchDot.Margin.Right); i < 84; i += 8, j -= 8)
                {
                    await Task.Delay(1);
                    SwitchDot.Margin = new Thickness(i, 0, j, 0);
                }
                SwitchDot.Margin = new Thickness(83, 0, 0, 0);
                SwitchMode = true;
            }
            else
            {
                for (double i = SwitchDot.Margin.Left, j = 0; i >= 0; i -= 8, j += 8)
                {
                    await Task.Delay(1);
                    SwitchDot.Margin = new Thickness(i, 0, j, 0);
                }
                SwitchDot.Margin = new Thickness(0, 0, 83, 0);
                SwitchMode = false;
            }
        }
    }
}
