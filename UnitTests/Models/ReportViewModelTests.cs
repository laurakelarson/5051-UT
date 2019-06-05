using System;
using HW1c.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange
            // Act
            var result = new ReportViewModel();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
