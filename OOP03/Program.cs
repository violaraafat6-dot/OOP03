using System.Numerics;
using System.Xml.Linq;

namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //            a) What is the difference between Method Overloading and Method Overriding?

            //Method Overloading:
            //Having multiple methods with the same name in the same class but with different parameters

            //Method Overriding:
            //A derived class provides a specific implementation of a method that already exists in the base class


            //            b) What is the difference between Static Binding and Dynamic Binding?

            //Static Binding:
            //The method to execute is determined at compile time

            //Dynamic Binding:
            //The method to execute is determined at runtime depending on the actual object

            #endregion

            #region question2

            //            a) What is the purpose of the sealed keyword when applied to a class?

            //A sealed class cannot be inherited.It stops the inheritance chain

            //b) What is the difference between a sealed class and a sealed method?

            //A sealed class prevents other classes from inheriting from it.

            //A sealed method prevents further overriding of that method in derived classes

            //c) Can a sealed method be overridden? Why?
            //No.A sealed method cannot be overridden because the sealed keyword prevents further overriding down the inheritance chain


            #endregion

            #region practical

         
    //            Driver driver = new Driver(
    //                1,
    //                "Ahmed Mohamed",
    //                "01000000000");

    //            DeliveryCenter center = new DeliveryCenter();

    //            Console.Write("Enter Delivery Center Name: ");
    //            center.CenterName = Console.ReadLine();

    //            center.Driver = driver;

    //            Console.WriteLine();

    //            Console.WriteLine("Enter Standard Shipment Data");

    //            Console.Write("Tracking Code: ");
    //            string trackingCode = Console.ReadLine();

    //            Console.Write("Description: ");
    //            string description = Console.ReadLine();

    //            Console.Write("Weight: ");
    //            decimal weight = Convert.ToDecimal(Console.ReadLine());

    //            Console.Write("Delivery Fee: ");
    //            decimal deliveryFee = Convert.ToDecimal(Console.ReadLine());

    //            DeliveryAddress standardAddress =
    //                new DeliveryAddress("Unknown", "Unknown", 0);

    //            StandardShipment standardShipment =
    //                new StandardShipment(
    //                    trackingCode,
    //                    description,
    //                    weight,
    //                    deliveryFee,
    //                    standardAddress);

    //            if (center.AddShipment(standardShipment))
    //                Console.WriteLine("Shipment Added Successfully.");

    //            Console.WriteLine();

    //            Console.WriteLine("Enter Express Shipment Data");

    //            Console.Write("Tracking Code: ");
    //            trackingCode = Console.ReadLine();

    //            Console.Write("Description: ");
    //            description = Console.ReadLine();

    //            Console.Write("Weight: ");
    //            weight = Convert.ToDecimal(Console.ReadLine());

    //            Console.Write("Delivery Fee: ");
    //            deliveryFee = Convert.ToDecimal(Console.ReadLine());

    //            Console.Write("Extra Fee: ");
    //            decimal extraFee = Convert.ToDecimal(Console.ReadLine());

    //            DeliveryAddress expressAddress =
    //                new DeliveryAddress("Unknown", "Unknown", 0);

    //            ExpressShipment expressShipment =
    //                new ExpressShipment(
    //                    trackingCode,
    //                    description,
    //                    weight,
    //                    deliveryFee,
    //                    expressAddress,
    //                    extraFee);

    //            if (center.AddShipment(expressShipment))
    //                Console.WriteLine("Shipment Added Successfully.");

    //            Console.WriteLine();

    //            Console.WriteLine("Enter International Shipment Data");

    //            Console.Write("Tracking Code: ");
    //            trackingCode = Console.ReadLine();

    //            Console.Write("Description: ");
    //            description = Console.ReadLine();

    //            Console.Write("Weight: ");
    //            weight = Convert.ToDecimal(Console.ReadLine());

    //            Console.Write("Delivery Fee: ");
    //            deliveryFee = Convert.ToDecimal(Console.ReadLine());

    //            Console.Write("Destination Country: ");
    //            string destinationCountry = Console.ReadLine();

    //            Console.Write("Customs Fee: ");
    //            decimal customsFee = Convert.ToDecimal(Console.ReadLine());

    //            DeliveryAddress internationalAddress =
    //                new DeliveryAddress("Unknown", "Unknown", 0);

    //            InternationalShipment internationalShipment =
    //                new InternationalShipment(
    //                    trackingCode,
    //                    description,
    //                    weight,
    //                    deliveryFee,
    //                    internationalAddress,
    //                    destinationCountry,
    //                    customsFee);

    //            if (center.AddShipment(internationalShipment))
    //                Console.WriteLine("Shipment Added Successfully.");

    //            Console.WriteLine();

    //            Console.WriteLine("All Shipments");

    //            center.PrintAllShipments();

    //            Console.WriteLine();

    //            DeliveryHelper.PrintShipmentDetails(standardShipment);
    //            Console.WriteLine();

    //            DeliveryHelper.PrintShipmentDetails(expressShipment);
    //            Console.WriteLine();

    //            DeliveryHelper.PrintShipmentDetails(internationalShipment);
    //            Console.WriteLine();

    //            Console.WriteLine($"Original Weight: {standardShipment.Weight} KG");

    //            standardShipment.UpdateWeight(5);

    //            Console.WriteLine(
    //                $"After UpdateWeight(5): {standardShipment.Weight} KG");

    //            standardShipment.UpdateWeight(5, 0.5m);

    //            Console.WriteLine(
    //                $"After UpdateWeight(5, 0.5): {standardShipment.Weight} KG");

    //            Console.WriteLine();

    //            Shipment[] shipments =
    //            {
    //            standardShipment,
    //            expressShipment,
    //            internationalShipment
    //        };

    //            foreach (Shipment shipment in shipments)
    //            {
    //                shipment.PrintShipment();
    //                Console.WriteLine();
    //            }

    //            CompletedShipment completedShipment =
    //                new CompletedShipment(
    //                    "SH004",
    //                    "Completed Package",
    //                    4,
    //                    70,
    //                    new DeliveryAddress("Cairo", "Main Street", 10));

    //            completedShipment.PrintShipment();

    //            Console.WriteLine();

    //            PriorityInternationalShipment priorityShipment =
    //                new PriorityInternationalShipment(
    //                    "SH005",
    //                    "Priority Package",
    //                    6,
    //                    150,
    //                    new DeliveryAddress("Cairo", "Main Street", 10),
    //                    "France",
    //                    120);

    //            priorityShipment.GenerateCustomsReport();

    //            Console.WriteLine();

    //            Console.Write("Enter Tracking Code to Search: ");
    //            string searchCode = Console.ReadLine();

    //            Shipment result = center[searchCode];

    //            if (result != null)
    //            {
    //                Console.WriteLine("Shipment Found:");
    //                result.PrintShipment();
    //            }
    //            else
    //            {
    //                Console.WriteLine("Shipment not found.");
    //            }

    //            Console.WriteLine();

    //            Console.Write("Enter Tracking Code to Remove: ");
    //            string removeCode = Console.ReadLine();

    //            if (center.RemoveShipment(removeCode))
    //                Console.WriteLine("Shipment Removed Successfully.");
    //            else
    //                Console.WriteLine("Shipment not found.");

    //            Console.WriteLine();

    //            Console.WriteLine("Remaining Shipments");
    //            center.PrintAllShipments();
    //        }
    //    }

    //}
            #endregion
