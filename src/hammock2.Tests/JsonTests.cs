﻿using System;
using NUnit.Framework;

namespace hammock2.Tests
{
    [TestFixture]
    public class JsonTests
    {
        [Test]
        public void Can_serialize_dynamic_instance()
        {
            var dog = new { Name = "Spot" };
            var json = Json.Serialize(dog);
            
            Assert.IsNotNull(json);
            Console.WriteLine(json);
        }

        [Test]
        public void Can_deserialize_dynamic_instance()
        {
            var dog = new { Name = "Spot" };
            var json = Json.Serialize(dog);
            var deserialized = Json.Deserialize(json);

            Assert.IsNotNull(deserialized);
            Assert.AreEqual(dog.Name, deserialized.Name);
        }
    }
}