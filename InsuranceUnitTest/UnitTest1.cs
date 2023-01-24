using MarkelInternationAssignment.Controllers;
using MarkelInternationAssignment;
using MarkelInternationAssignment.Interface;
using MarkelInternationAssignment.Model;

namespace InsuranceUnitTest
{
    public class Tests
    {
        private ClaimsController _controller;
        [SetUp]
        public void Setup()
        {
            _controller = new ClaimsController(null, new UnitTestData());
            
        }

        [Test]
        public void Test1()
        {
            var Result = _controller.Get(1);         
            
            Assert.AreEqual("unittestucr", Result.First().UCR);
        }
    }
}