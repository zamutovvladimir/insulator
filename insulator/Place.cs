using System;
using insulator.CommonLibrary;

namespace insulator
{
    namespace Place
    {
        public class NumberOfBuildingOrApartment
        {
            private Availability isLetterInNumber = Availability.Absent;
            private uint number;
            private char letter;

            private Availability IsLetterInNumber
            {
                get
                {
                    return isLetterInNumber;
                }
                set
                {
                    if (isLetterInNumber != value)
                    {
                        isLetterInNumber = value;
                    }
                }
            }
            public uint Number
            {
                get
                {
                    return number;
                }
                set
                {
                    if (value == 0)
                    {
                        number = default;
                        letter = default;
                        IsLetterInNumber = Availability.Absent;
                    }
                    else
                    {
                        number = value;
                    }
                }
            }
            public char Letter
            {
                get
                {
                    return letter;
                }
                set // НУЖНА ПРОВЕРКА, ЧТО ЭТО НЕ СИМВОЛЫ ОТЛИЧНЫЕ ОТ БУКВ.
                {
                    if (this.Number != 0)
                    {
                        letter = value;
                        this.IsLetterInNumber = Availability.Present;
                    }
                }
            }

            public NumberOfBuildingOrApartment()
            {
            }
            public NumberOfBuildingOrApartment(uint number) : this()
            {
                this.Number = number;
            }
            public NumberOfBuildingOrApartment(uint number, char letter) : this(number)
            {
                this.Letter = letter;
            }
        }
        public class Address
        {
            private NumberOfBuildingOrApartment buildingNumber;
            private NumberOfBuildingOrApartment apartmentNumber;

            public NumberOfBuildingOrApartment BuildingNumber
            {
                get
                {
                    return buildingNumber;
                }
                set
                {
                    buildingNumber = value;
                }
            }
            public NumberOfBuildingOrApartment ApartmentNumber
            {
                get
                {
                    return apartmentNumber;
                }
                set
                {

                    apartmentNumber = value;
                }
            }

            public string PostIndex { get; set; }
            public string Country { get; set; }
            public string Region { get; set; }
            public string Locality { get; set; }
            public string Street { get; set; }
        }
        public class DetentionPlace
        {
            public Address Address { get; set; }
        }
        public class WorkPlace
        {
            public Address Address { get; set; }
            public String Name { get; set; }
        }
    }
}