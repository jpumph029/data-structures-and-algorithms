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
            Hashtable<string, string> hash = new Hashtable<string, string>(5);
            hash.Add("1", "first 1");
            Assert.Null(hash.Get("2"));
        }
        [Fact]
        public void HandelsCollisions()
        {
            Hashtable<string, string> hash = new Hashtable<string, string>(1);
            hash.Add("1", "first 1");
            hash.Add("2", "first 2");
            int result = hash.Hash("1");
            int result1 = hash.Hash("2");
            Assert.Equal(result, result1);
        }
        [Fact]
        public void CollisionGet()
        {
            Hashtable<string, string> hash = new Hashtable<string, string>(1);
            hash.Add("1", "first 1");
            hash.Add("2", "first 2");
            Assert.True(hash.Contains("2"));
        }
        [Fact]
        public void CanHashKey()
        {
            Hashtable<string, string> hash = new Hashtable<string, string>(2);
            hash.Add("1", "first 1");
            hash.Add("2", "first 2");
            int result = hash.Hash("1");
            int result1 = hash.Hash("2");
            Assert.True(hash.Contains("2"));
        }
    }
}
