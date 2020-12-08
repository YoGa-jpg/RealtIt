using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        private DispatcherTimer activateTimer;

        private bool IsSwap = false;

        private MainWindow mainWindow;

        public LogInWindow(MainWindow window)
        {
            InitializeComponent();

            this.mainWindow = window;
        }

        public LogInWindow()
        {
            InitializeComponent();
        }

        private void SignUpLink_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            IsSwap = true;
            SignUpWindow window = new SignUpWindow(mainWindow);
            window.Show();
            window.Activate();
            this.Close();
        }

        private void CloseLink_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void LogInWindow_OnActivated(object sender, EventArgs e)
        {
            activateTimer = new DispatcherTimer();
            activateTimer.Interval = TimeSpan.FromMilliseconds(15);
            activateTimer.Tick += OpacityChanger;
            activateTimer.Start();
        }

        private void OpacityChanger(object sender, EventArgs e)
        {
            LogInForm.Opacity += 0.1;
            if(LogInForm.Opacity >= 1)
                activateTimer.Stop();
        }

        private void LogInWindow_OnDeactivated(object sender, EventArgs e)
        {
            if (!IsSwap)
            {
                mainWindow.StrongClose(this);
            }
        }

        private void LogInButton_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                if (db.User.Any(q => q.Login == LogInBox.Text & q.Password == PassBox.Password))
                {
                    mainWindow.currentUser =
                        db.User.Single(q => q.Login == LogInBox.Text & q.Password == PassBox.Password);
                    mainWindow.CurrentUserActivate();
                    CloseLink_OnMouseDown(sender, e);
                }
            }
        }

        private void LogInForm_Closed(object sender, EventArgs e)
        {
            
        }
    }
}
