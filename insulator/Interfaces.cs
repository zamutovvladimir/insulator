using System.Collections.Generic;
using insulator.CommonLibrary;
using insulator.Person;
using insulator.Place;

namespace insulator
{
    namespace Interfaces
    {
        interface IPersonInfo
        {
            public FullName FullName { get; set; }
            public Birthday Birthday { get; set; }
        }
        interface IDetainedPersonInfo
        {
            public MaritalStatus MaritalStatus { get; set; }
            public List<Telephone> Telephones { get; set; }
            public string Photo { get; set; }
            public List<string> AdditionalInfo { get; set; }
            public Address Address { get; set; }
        }

        interface IPlaceOfWorkInfo
        {
            public string Position { get; set; }
            public WorkPlace PlaceOfWork { get; set; }
        }
        interface IDetentionInfo
        {
            public List<Detention> ListOfDetentions { get; set; }
        }
    }
}