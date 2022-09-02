using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLogic.Test
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void NewContactTest()
        {
            var contact = new Contact();
            Assert.IsNotNull(contact);
        }

        [TestMethod]
        public void SetContactNameTest()
        {
            //Arrange
            string aName = "Pepe";
            Contact contact = new Contact();

            //Act
            contact.Name = aName;

            //Assert
            Assert.AreEqual(aName, contact.Name, $"Name should be {aName}");
        }

        [TestMethod]
        public void SetBirthdayTest()
        {
            //Arrange
            DateTime birthday = new DateTime(1997, 10, 7);
            var contact = new Contact();

            //Act
            contact.Birthday = birthday;

            //Assert
            Assert.AreEqual(birthday, contact.Birthday, $"Birthday should be {birthday}");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooOldBirthdayTest()
        {
            //Arrange
            DateTime limit = new DateTime(1900, 1, 1);
            var contact = new Contact();

            //Act
            contact.Birthday = limit;

        }
    }
}
