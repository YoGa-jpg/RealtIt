using System;
using System.Collections.Generic;
using System.IO;
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

namespace RealtIt
{
    /// <summary>
    /// Interaction logic for AccomodationWindow.xaml
    /// </summary>
    public partial class AccomodationWindow : Window
    {
        private Accomodation currentAccomodation;

        private User currentUser;

        public AccomodationWindow(Accomodation currentAccomodation, User currentUser)
        {
            InitializeComponent();

            this.currentAccomodation = currentAccomodation;
            this.currentUser = currentUser;

            UserIdentify();
            AccomodationIdentify();
        }

        public void UserIdentify()
        {
            NameBlock.Text = $"{currentUser.Surname} {currentUser.Name} {currentUser.Patronymic}";
        }

        public void AccomodationIdentify()
        {
            PhoneLabel.Content = currentAccomodation.PhoneNumber;

            DistrictBlock.Text = currentAccomodation.District;

            StreetBlock.Text = currentAccomodation.Street;

            HouseLabel.Content = currentAccomodation.HouseNumber;

            if (currentAccomodation.offerType == OfferType.Buy)
                OfferTypeLabel.Text = "Покупка";
            else
                OfferTypeLabel.Text = "Аренда";

            if (currentAccomodation.accomodationType == AccomodationType.Flat)
                AccomodationTypeLabel.Text = "Квартира";
            else
                AccomodationTypeLabel.Text = "Частный дом";

            RoomsAmountLabel.Content = currentAccomodation.RoomsAmount;

            AreaLabel.Content = currentAccomodation.Area;

            CostLabel.Content = currentAccomodation.Cost;

            DescriptionBox.Text = currentAccomodation.Description;

            MainScreen.Background = new ImageBrush(new ImageSourceConverter().ConvertFromString(currentAccomodation.imageSource) as ImageSource);

            List<CustomImage> imagesList = Directory
                .GetFiles($"{currentAccomodation.OwnerId}-{currentAccomodation.AccomodationId}").ToList()
                .Where(file => !file.Contains("MainScreen"))
                .Select(file => new CustomImage(file)).ToList();

            SourceList.ItemsSource = imagesList;
        }

        private void CloseImage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
