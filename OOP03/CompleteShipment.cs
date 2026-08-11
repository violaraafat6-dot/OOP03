using OOP03;
using System;
using System.Collections.Generic;
using System.Text;

#region completeshipment

namespace OOP03
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}


#endregion
