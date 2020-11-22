using System;
using insulator.Person;
using insulator.Place;

namespace insulator
{
    public class Detention
    {
        public DateTime DetentionDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public FullName WhoDetained { get; set; }
        public FullName WhoDelivered { get; set; }
        public FullName WhoReleased { get; set; }
        public DetentionPlace PlaceOfDetention { get; set; }
        public uint AmountChargedForMaintenance { get; set; }
        public uint AmountPaidForMaintenance { get; set; }
    }
}