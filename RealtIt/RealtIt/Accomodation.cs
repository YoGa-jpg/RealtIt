using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RealtIt
{
    public class Accomodation 
    {
        [Key]
        public int AccomodationId { get; set; }
        public int OwnerId { get; set; }
        public string PhoneNumber { get; set; }        
        public string District { get; set; }
        public string Street { get; set; }
        public OfferType offerType { get; set; }
        public AccomodationType accomodationType { get; set; }
        public string HouseNumber { get; set; }
        public string RoomsAmount { get; set; }
        public string Area { get; set; }
        public string Cost { get; set; }
        public string imageSource { get; set; }
        public string Description { get; set; }

        public Accomodation(string PhoneNumber, string Disctrict, string Street, OfferType offerType, AccomodationType accomodationType,
            string HouseNumber, string RoomsAmount, string Area, string Cost, string imageSource, string Description)
        {
            this.PhoneNumber = PhoneNumber;
            this.District = Disctrict;
            this.Street = Street;
            this.offerType = offerType;
            this.accomodationType = accomodationType;
            this.HouseNumber = HouseNumber;
            this.RoomsAmount = RoomsAmount;
            this.Area = Area;
            this.Cost = Cost;
            this.imageSource = imageSource;
            this.Description = Description;
        }

        public Accomodation(OfferType offerType, AccomodationType accomodationType)
        {
            this.offerType = offerType;
            this.accomodationType = accomodationType;
        }

        public Accomodation() { }

        public void SwitchOfferType()
        {
            if (offerType.Equals(OfferType.Rent))
                offerType = OfferType.Buy;
            else
                offerType = OfferType.Rent;
        }

        public void SwitchAccomodationType()
        {
            if (accomodationType.Equals(AccomodationType.Flat))
                accomodationType = AccomodationType.PrivateHouse;
            else
                accomodationType = AccomodationType.Flat;
        }
    }
    public enum OfferType
    {
        Rent,
        Buy
    }
    public enum AccomodationType
    {
        Flat,
        PrivateHouse
    }
}
