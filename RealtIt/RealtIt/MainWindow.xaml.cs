using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Security;

namespace RealtIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<Tongue, bool> tongues;

        private List<Accomodation> Accomodations;

        private Accomodation SearchTemplate;

        private List<string> MinskStreets;

        private DispatcherTimer blurTimer;

        public User currentUser;

        private int Radius = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            
            tongues = new Dictionary<Tongue, bool>() {/*, new KeyValuePair<Tongue, bool>(TongueMoneyDown, false),
                 new KeyValuePair<Tongue, bool>(TongueRoomUp, false),  new KeyValuePair<Tongue, bool>(TongueRoomDown, false),  new KeyValuePair<Tongue, bool>(TongueAdd, false)*/ };
            SearchTemplate = new Accomodation() { offerType = OfferType.Buy, accomodationType = AccomodationType.Flat, RoomsAmount = Convert.ToString(0)};
            List<string> Districts = new List<string>() { "Заводской", "Ленинский", "Московский", "Октябрьский", "Партизанский", "Первомайский", "Советский", "Фрунзенский", "Центральный" };
            //District.ItemsSource = Districts;          
            using (FileStream fs = new FileStream("Info.dat", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MinskStreets = (List<string>)formatter.Deserialize(fs);
            }
            District.ItemsSource = Districts;
            Street.ItemsSource = MinskStreets;
            tongues.Add(TongueMoneyUp, false);
            tongues.Add(TongueMoneyDown, false);
            tongues.Add(TongueRoomUp, false);
            tongues.Add(TongueRoomDown, false);
            tongues.Add(TongueAdd, false);
            TongueMoneyUp.imageSource = (new ImageSourceConverter().ConvertFromString("C:\\Users\\Yoga\\Desktop\\Практика\\RealtIt\\RealtIt\\Resources\\Images\\Coin.png") as ImageSource);
            TongueMoneyDown.imageSource = (new ImageSourceConverter().ConvertFromString("C:\\Users\\Yoga\\Desktop\\Практика\\RealtIt\\RealtIt\\Resources\\Images\\Coin.png") as ImageSource);
            TongueMoneyDown.SetArrowState(ArrowState.Down);
            TongueRoomUp.imageSource = (new ImageSourceConverter().ConvertFromString("C:\\Users\\Yoga\\Desktop\\Практика\\RealtIt\\RealtIt\\Resources\\Images\\Room.png") as ImageSource);
            TongueRoomDown.imageSource = (new ImageSourceConverter().ConvertFromString("C:\\Users\\Yoga\\Desktop\\Практика\\RealtIt\\RealtIt\\Resources\\Images\\Room.png") as ImageSource);
            TongueRoomDown.SetArrowState(ArrowState.Down);
            TongueAdd.imageSource = (new ImageSourceConverter().ConvertFromString("C:\\Users\\Yoga\\Desktop\\Практика\\RealtIt\\RealtIt\\Resources\\Images\\Add.png") as ImageSource);
            TongueAdd.SetArrowState(ArrowState.None);
            using (UserContext db = new UserContext())
            {
                Accomodations = db.Accomodation.ToList();
            }
            AccomodationList.ItemsSource = Accomodations;
            this.Effect = new BlurEffect() {Radius = 0, KernelType = KernelType.Gaussian};
        }

        private void TongueMouseEnter(object sender, MouseEventArgs e)
        {
            Thickness mar = (sender as Tongue).Margin;
            if (tongues.Where(q => q.Key.Equals((sender as Tongue))).First().Value == false)
            {
                (sender as Tongue).Margin = new Thickness(mar.Left, mar.Top + 55, mar.Right, mar.Bottom);
            }
        }
        private void TongueMouseLeave(object sender, MouseEventArgs e)
        {
            Thickness mar = (sender as Tongue).Margin;
            if (tongues.Where(q => q.Key.Equals((sender as Tongue))).First().Value == false)
                (sender as Tongue).Margin = new Thickness(mar.Left, mar.Top - 55, mar.Right, mar.Bottom);
        }
        private void AddMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddWindow addWindow = new AddWindow(currentUser);
            addWindow.Show();
        }
        private void TongueMouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (var q in tongues.Keys.ToList())
            {
                if (tongues[q].Equals(true))
                {
                    tongues[q] = false;
                    q.Margin = new Thickness(q.Margin.Left, -80, q.Margin.Right, q.Margin.Bottom);
                }
            }
            tongues[sender as Tongue] = true;
            switch((sender as Tongue).Name)
            {
                case "TongueMoneyUp":
                    SortedByWhat.Text = "стоимости";
                    SortedHow.Text = "убыванию";
                    Accomodations = Accomodations.OrderBy(q => q.Cost).ToList();
                    AccomodationList.ItemsSource = Accomodations;
                    break;
                case "TongueMoneyDown":
                    SortedByWhat.Text = "стоимости";
                    SortedHow.Text = "возрастанию";
                    Accomodations = Accomodations.OrderByDescending(q => q.Cost).ToList();
                    AccomodationList.ItemsSource = Accomodations;
                    break;
                case "TongueRoomUp":
                    SortedByWhat.Text = "комнатам";
                    SortedHow.Text = "убыванию";
                    Accomodations = Accomodations.OrderByDescending(q => q.RoomsAmount).ToList();
                    AccomodationList.ItemsSource = Accomodations;
                    break;
                case "TongueRoomDown":
                    SortedByWhat.Text = "комнатам";
                    SortedHow.Text = "возрастанию";
                    Accomodations = Accomodations.OrderBy(q => q.RoomsAmount).ToList();
                    AccomodationList.ItemsSource = Accomodations;
                    break;
            }
        }

        private void CloseFromMouseDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
        private void FindSuitableAccomodation()
        {
            List<Accomodation> FiltredAccomodations = Accomodations;
            try
            {
                FiltredAccomodations =
                    FiltredAccomodations.Where(item =>
                        item.offerType == SearchTemplate.offerType
                        & item.accomodationType == SearchTemplate.accomodationType).ToList();

                if (SearchTemplate.RoomsAmount != "0" & SearchTemplate.RoomsAmount != string.Empty)
                    FiltredAccomodations = FiltredAccomodations
                        .Where(item => item.RoomsAmount == SearchTemplate.RoomsAmount).ToList();

                if (SearchTemplate.Street != null & SearchTemplate.Street != "")
                    FiltredAccomodations = FiltredAccomodations.Where(item => item.Street == SearchTemplate.Street)
                        .ToList();

                if (SearchTemplate.District != null & SearchTemplate.District != "")
                    FiltredAccomodations = FiltredAccomodations.Where(item => item.District == SearchTemplate.District)
                        .ToList();

                FiltredAccomodations = FiltredAccomodations.Where(item =>
                    double.Parse(item.Cost) > double.Parse(FromCost.Text) &
                    double.Parse(item.Cost) < double.Parse(ToCost.Text)).ToList();

                AccomodationList.ItemsSource = FiltredAccomodations;
            }
            catch (Exception) { }
        }

        private void OfferTypeSwitchClick(object sender, MouseButtonEventArgs e)
        {
            SearchTemplate.SwitchOfferType();
            if (SearchTemplate.offerType.Equals(OfferType.Buy))
                OfferTypeLabel.Content = "Покупка";
            else
                OfferTypeLabel.Content = "Аренда";
            FindSuitableAccomodation();
        }

        private void AccomodationTypeSwitchClick(object sender, MouseButtonEventArgs e)
        {
            SearchTemplate.SwitchAccomodationType();
            if (SearchTemplate.accomodationType.Equals(AccomodationType.Flat))
                AccomodationTypeLabel.Content = "Квартира";
            else
                AccomodationTypeLabel.Content = "Частный дом";
            FindSuitableAccomodation();
        }
        private void RoomsAmountSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RoomsAmountLabel.Content = Math.Round((sender as Slider).Value);
            SearchTemplate.RoomsAmount = RoomsAmountLabel.Content.ToString();
            FindSuitableAccomodation();
        }
        private void DistrictSelected(object sender, SelectionChangedEventArgs e)
        {
            SearchTemplate.District = (sender as ComboBox).SelectedItem.ToString();
            SearchTemplate.Street = "";
            FindSuitableAccomodation();
        }
        private void StreetSelected(object sender, SelectionChangedEventArgs e)
        {
            SearchTemplate.Street = (sender as ComboBox).SelectedItem.ToString();
            SearchTemplate.District = "";
            FindSuitableAccomodation();
        }

        private void LogInButtob_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow(this);
            this.IsEnabled = false;
            logInWindow.Show();
        }

        private void MainWindow_OnDeactivated(object sender, EventArgs e)
        {
            this.IsEnabled = false;
            (this.Effect as BlurEffect).Radius = 0;
            blurTimer = new DispatcherTimer();
            blurTimer.Interval = TimeSpan.FromMilliseconds(15);
            blurTimer.Tick += BlurWindow;
            blurTimer.Start();
            this.Activated += MainWindow_OnActivated;
        }

        private void BlurWindow(object sender, EventArgs e)
        {
            BlurEffect blur = new BlurEffect() {Radius = this.Radius++, KernelType = KernelType.Gaussian};
            this.Effect = blur;
            if((this.Effect as BlurEffect).Radius >= 20)
                blurTimer.Stop();
        }

        private void MainWindow_OnActivated(object sender, EventArgs e)
        {
            (this.Effect as BlurEffect).Radius = 20;
            blurTimer = new DispatcherTimer();
            blurTimer.Interval = TimeSpan.FromMilliseconds(15);
            blurTimer.Tick += UnBlurWindow;
            blurTimer.Start();
            this.IsEnabled = true;
            this.Activated -= MainWindow_OnActivated;
            this.Topmost = false;
        }

        private void UnBlurWindow(object sender, EventArgs e)
        {
            BlurEffect blur = new BlurEffect() { Radius = this.Radius--, KernelType = KernelType.Gaussian };
            this.Effect = blur;
            if (this.Radius <= 0)
                blurTimer.Stop();
        }

        private void DetailsButton_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                Accomodation accomodation = db.Accomodation.Single(accom =>
                    accom.AccomodationId == Convert.ToInt32((sender as Button).Tag));
                User user = db.User.Single(usr => usr.OwnerId == accomodation.OwnerId);

                AccomodationWindow window = new AccomodationWindow(accomodation, user);
                window.Show();
            }
        }

        public void CurrentUserActivate()
        {
            LogInButtob.Opacity = 0;
            LogInButtob.IsEnabled = false;
            LogInBlock.Text = currentUser.Login;
            LogInGrid.IsEnabled = true;
            LogInGrid.Opacity = 1;
            TongueAdd.IsEnabled = true;
        }

        public void StrongClose(Window window)
        {
            try
            {
                window.Close();
            }
            catch (Exception e) { }
            
            this.Activate();
            Thread.Sleep(20);
            LeftMouseClick(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
    }
}
