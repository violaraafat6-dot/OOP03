using OOP03;
using System;
using System.Collections.Generic;
using System.Text;

#region internationalshipment

//namespace OOP03
//{
//    public class InternationalShipment : Shipment
//    {
//        private string destinationCountry;

//        public string DestinationCountry
//        {
//            get { return destinationCountry; }
//            set
//            {
//                if (!string.IsNullOrWhiteSpace(value))
//                    destinationCountry = value;
//            }
//        }
//        private decimal customsFee;

//        public decimal CustomsFee
//        {
//            get { return customsFee; }
//            set
//            {
//                if (value >= 0)
//                    customsFee = value;
//            }
//        }

//        public override decimal EstimatedCost
//        {
//            get
//            {
//                return DeliveryFee + (Weight * 5) + CustomsFee;
//            }
//        }

//        public InternationalShipment(
//            string trackingCode,
//            string description,
//            decimal weight,
//            decimal deliveryFee,
//            DeliveryAddress destination,
//            string destinationCountry,
//            decimal customsFee)
//            : base(trackingCode, description, weight, deliveryFee, destination)
//        {
//            DestinationCountry = destinationCountry;
//            CustomsFee = customsFee;
//        }

//        public override void PrintShipment()
//        {
//            Console.WriteLine("International Shipment");
//            Console.WriteLine($"Tracking Code : {TrackingCode}");
//            Console.WriteLine($"Description : {Description}");
//            Console.WriteLine($"Weight : {Weight} KG");
//            Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
//            Console.WriteLine($"Destination Country : {DestinationCountry}");
//            Console.WriteLine($"Customs Fee : {CustomsFee} EGP");
//            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
//        }

//        public virtual void GenerateCustomsReport()
//        {
//            Console.WriteLine($"Customs Report for {DestinationCountry}");
//        }
//    }
//}

#endregion
