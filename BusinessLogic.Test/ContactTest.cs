using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
