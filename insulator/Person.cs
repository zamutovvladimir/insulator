using System;
using insulator.CommonLibrary;
using insulator.Interfaces;

namespace insulator
{
    namespace Person
    {
        public class FullName
        {
            private string surname;
            private string name;
            private string patronymic;

            public string Surname { get => surname; set => surname = value; }
            public string Name { get => name; set => name = value; }
            public string Patronymic { get => patronymic; set => patronymic = value; }

            public FullName(string surname, string name)
            {
                this.Surname = surname;
                this.Name = name;
                this.Patronymic = null;
            }
            public FullName(string surname, string name, string patronymic)
                : this(surname, name)
            {
                this.Patronymic = patronymic;
            }
        }
        public class Birthday
        {
            private DateTime bornDate;
            private readonly byte age;

            public DateTime BornDate
            {
                get { return bornDate; }
                set { bornDate = value; }
            }
            public byte Age
            {
                get
                {
                    return (byte)(DateTime.Now.Year - bornDate.Year);
                }
            }

            public Birthday(DateTime bornDate)
            {
                this.BornDate = bornDate;
            }
            public Birthday(byte day, byte month, byte year)
                : this(bornDate: new DateTime(day: day, month: month, year: year))
            {
                this.BornDate = new DateTime(day: day, month: month, year: year);
            }
        }

        public abstract class Person : IPersonInfo
        {
            public FullName FullName { get; set; }
            public Birthday Birthday { get; set; }

            public Person(FullName fullName)
            {
                this.FullName = fullName;
            }
            public Person(FullName fullName, Birthday birthday)
                : this(fullName)
            {
                this.Birthday = birthday;
            }
        }

        public class Detained : Person
        {
            public MaritalStatus MaritalStatus { get; set; }
            public Detained(FullName fullName) : base(fullName)
            {
            }
            public Detained(FullName fullName, Birthday birthday) : base(fullName, birthday)
            {
            }
        }
    }
}