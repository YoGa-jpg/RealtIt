using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RealtIt
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private Accomodation addTemplate;

        private User currentUser;

        private List<string> descriptionImageSources;

        private int lastAccomodation;

        public AddWindow(User currentUser)
        {
            InitializeComponent();

            DistrictBox.ItemsSource = new List<string>() { "Заводской", "Ленинский", "Московский", "Октябрьский", "Партизанский", "Первомайский", "Советский", "Фрунзенский", "Центральный" };

            using (FileStream fs = new FileStream("Info.dat", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                StreetBox.ItemsSource = (List<string>)formatter.Deserialize(fs);
            }

            using (UserContext db = new UserContext())
            {
                try
                {
                    lastAccomodation = db.Accomodation.ToList().Last().AccomodationId + 1;
                }
                catch (InvalidOperationException)
                {
                    lastAccomodation = 1;
                }
            }

            addTemplate = new Accomodation(OfferType.Buy, AccomodationType.Flat);

            addTemplate.AccomodationId = 0;

            this.currentUser = currentUser;

            descriptionImageSources = new List<string>();
        }
        private void OfferTypeSwitchClick(object sender, MouseButtonEventArgs e)
        {
            addTemplate.SwitchOfferType();
            if (addTemplate.offerType.Equals(OfferType.Buy))
                OfferTypeLabel.Content = "Покупка";
            else
                OfferTypeLabel.Content = "Аренда";
        }

        private void AccomodationTypeSwitchClick(object sender, MouseButtonEventArgs e)
        {
            addTemplate.SwitchAccomodationType();
            if (addTemplate.accomodationType.Equals(AccomodationType.Flat))
                AccomodationTypeLabel.Content = "Квартира";
            else
                AccomodationTypeLabel.Content = "Частный дом";
        }

        private void DistrictBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                addTemplate.District = (sender as ComboBox).SelectedItem.ToString();
            }
            catch (Exception) { }
        }

        private void StreetBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                addTemplate.Street = (sender as ComboBox).SelectedItem.ToString();
            }
            catch (Exception) { }
        }

        private void HouseBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                // ReSharper disable once PossibleNullReferenceException
                addTemplate.HouseNumber = (sender as TextBox).Text;
            }
            catch (Exception) { }
        }

        private void AreaBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                addTemplate.Area = (sender as TextBox).Text;
            }
            catch (Exception) { }
        }

        private void PriceBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                addTemplate.Cost = (sender as TextBox).Text;
            }
            catch (Exception) { }
        }

        private void PhoneBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                addTemplate.PhoneNumber = (sender as TextBox).Text;
            }
            catch (Exception) { }
        }

        private void RoomsAmountSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                RoomsAmountLabel.Content = Math.Round((sender as Slider).Value);
                addTemplate.RoomsAmount = RoomsAmountLabel.Content.ToString();
            }
            catch (Exception) { }
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                addTemplate.Description = DescriptionBox.Text;
            }
            catch (Exception) { }
        }

        private void CloseButton_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void DropBorder_OnDrop(object sender, DragEventArgs e)
        {
            DroppedImage.Source =
                new ImageSourceConverter().ConvertFromString(((string[])e.Data.GetData(DataFormats.FileDrop)).First()) as ImageSource;

            if (!Directory.Exists($"{currentUser.OwnerId}-{lastAccomodation}"))
            {
                Directory.CreateDirectory($"{currentUser.OwnerId}-{lastAccomodation}");

                File.Copy(((string[])e.Data.GetData(DataFormats.FileDrop)).First(),
                    $"{currentUser.OwnerId}-{lastAccomodation}\\MainScreen.jpg");

                addTemplate.imageSource =
                    $@"C:\Users\Yoga\Desktop\Практика\RealtIt\RealtIt\bin\Debug\{currentUser.OwnerId}-{lastAccomodation}\MainScreen.jpg";
            }
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists($"{currentUser.OwnerId}-{lastAccomodation}"))
            {
                Directory.CreateDirectory($"{currentUser.OwnerId}-{lastAccomodation}");
                descriptionImageSources.ForEach(source => File.Copy(source.ToString(), $"{currentUser.OwnerId}-{lastAccomodation}\\{new FileInfo(source.ToString()).Name}"));
            }
            else
            {
                descriptionImageSources.ForEach(source => File.Copy(source.ToString(),
                    $"{currentUser.OwnerId}-{lastAccomodation}\\{new FileInfo(source.ToString()).Name}"));
            }

            using (UserContext db = new UserContext())
            {
                addTemplate.OwnerId = currentUser.OwnerId;
                db.Accomodation.Add(addTemplate);
                db.SaveChanges();
            }
        }

        private void ScreensFolder_OnDrop(object sender, DragEventArgs e)
        {
            foreach (var source in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                descriptionImageSources.Add(source);
            }
        }
    }
}
