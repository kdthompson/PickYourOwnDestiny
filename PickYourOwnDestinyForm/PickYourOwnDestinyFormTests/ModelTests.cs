using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PickYourOwnDestiny.Entities;

namespace PickYourOwnDestinyFormTests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void CharacterModelExists()
        {
            Character c = new Character();
            
            Assert.AreEqual("PickYourOwnDestiny.Entities.Character", c.GetType().ToString());    
        }

        [TestMethod]
        public void CharacterModelHasNonNullProperties()
        {
            Character c = new Character();

            Assert.IsTrue(c.Name != null);
            Assert.IsTrue(c.CharacterRace != null);
            Assert.IsTrue(c.CharacterClass != null);
        }

        [TestMethod]
        public void SaveClassExists()
        {

        }
    }
}
