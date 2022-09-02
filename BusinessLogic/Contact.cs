using System;

namespace BusinessLogic
{
    public class Contact
    {
        private static readonly DateTime MinBirthdayDate = new DateTime(1910, 1, 1);
        private DateTime birthday;

        public Contact()
        {
        }

        public string Name { get; set; }
        public DateTime Birthday { 
            get => birthday; 
            set {
                if (value <= MinBirthdayDate)
                {
                    throw new ArgumentException($"Birthday must be after {MinBirthdayDate}");
                }
                birthday = value;
            } 
        }
    }
}