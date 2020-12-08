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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RealtIt
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        private DispatcherTimer activateTimer;

        private bool IsSwap = false;

        private MainWindow mainWindow;

        public SignUpWindow(MainWindow window)
        {
            InitializeComponent();

            this.mainWindow = window;
        }

        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void LogInLink_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            IsSwap = true;
            LogInWindow window = new LogInWindow(mainWindow);
            window.Show();
            window.Activate();
            this.Close();
        }

        private void CloseLink_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void SignUpWindow_OnDeactivated(object sender, EventArgs e)
        {
            if (!IsSwap)
            {
                mainWindow.StrongClose(this);
            }
        }

        private void SignUpWindow_OnActivated(object sender, EventArgs e)
        {
            activateTimer = new DispatcherTimer();
            activateTimer.Interval = TimeSpan.FromMilliseconds(15);
            activateTimer.Tick += OpacityChanger;
            activateTimer.Start();
        }

        private void OpacityChanger(object sender, EventArgs e)
        {
            SignUpForm.Opacity += 0.1;
            if (SignUpForm.Opacity >= 1)
                activateTimer.Stop();
        }

        private void RegButton_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                User newUser = new User(NameBox.Text, SurnameBox.Text, PatronymicBox.Text, LogInBox.Text, PassBox.Password);
                db.User.Add(newUser);
                db.SaveChanges();
            }
        }

    }
}
