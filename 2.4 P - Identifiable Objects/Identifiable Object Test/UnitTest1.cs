using NUnit.Framework;
using NUnit.Framework.Internal;
using SwinAdventure;


namespace IdentifiableObjectTest
{
    public class IdentifiableObjectTest
    {
            IdentifiableObject id;
            IdentifiableObject emptyId;

        [SetUp]
        public void Setup()
        {
            id = new IdentifiableObject (new string[] { "bob", "fred" });
            emptyId = new IdentifiableObject ( new string[] { });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.True(id.AreYou("bob"));
            Assert.True(id.AreYou("fred"));
        }
        [Test]
        public void TestNotAreYou()
        {
            Assert.False(id.AreYou("wilma"));
            Assert.False(id.AreYou("boby"));
        }
        [Test]
        public void TestCaseSensitive()
        {
            Assert.True(id.AreYou("BoB"));
            Assert.True(id.AreYou("fReD"));
        }
        [Test]
        public void TestFirstID()
        {
            Assert.True(id.FirstId == "bob");
        }
        [Test]
        public void TestFirstIdWithNoIds()
        {
            Assert.True(emptyId.FirstId ==  "");
        }
        [Test]
        public void TestAddId()
        {
            id.AddIdentifier("wilma");
            Assert.True(id.AreYou("fred"));
            Assert.True(id.AreYou("bob"));
            Assert.True(id.AreYou("wilma"));
        }
    }
}