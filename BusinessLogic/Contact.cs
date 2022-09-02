using System;

namespace BusinessLogic
{
    public class Contact
    {
        private DateTime birthday;

        public Contact()
        {
        }

        public string Name { get; set; }
        public DateTime Birthday { 
            get => birthday; 
            set { 
                if (value <= new DateTime(1910, 1, 1))
                {
                    throw new ArgumentException($"Birthday must be after {new DateTime(1910, 1, 1)}");
                }
                birthday = value;
            } 
        }
    }
}