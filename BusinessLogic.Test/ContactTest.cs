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
            Contact contact = new Contact();

            //Act
            contact.Name = "Pepe";

            //Assert
            Assert.AreEqual("Pepe", contact.Name, "Name should be Pepe");
        }
    }
}
