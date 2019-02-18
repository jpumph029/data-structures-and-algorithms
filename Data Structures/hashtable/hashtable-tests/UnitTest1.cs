using hashtable.Classes;
using System;
using Xunit;

namespace hashtable_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Addworks()
        {
            Hashtable<string, string> hash = new Hashtable<string, string>(5);
            hash.Add("1", "first 1");
            Assert.True(hash.Contains("1"));
        }
        [Fact]
        public void CanRetrieveValueFromKey()
        {
            Hashtable<string, string> hash = new Hashtable<string, string>(5);
            hash.Add("1", "first 1");
            string one = hash.Get("1");
            Assert.Equal(one, hash.Get("1"));
        }
        [Fact]
        public void ReturnsNullForKeysThatDontExist()
        {
            Hashtable<string, string> has = new Hashtable<string, string>(5);
            has.Add("1", "first 1");
            Assert.Null(has.Get("2"));
        }
    }
}
