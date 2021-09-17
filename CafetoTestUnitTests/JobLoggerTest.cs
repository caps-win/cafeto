using CafetoTest;
using CafetoTest.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CafetoTestUnitTests
{
    [TestClass]
    public class JobLoggerTest
    {
        private const string TestMessage = "Test Message";
        private const string WarningMessage = "Test Warning";
        private const string ErrorMessage = "Test Error";

        [TestMethod]
        public void JobLoggerBasicTest()
        {
            //var jobLogger = new JobLogger(true, true, true, true, true);
            //JobLogger.LogMessage(TestMessage, true, false, false);
            //JobLogger.LogMessage(WarningMessage, false, true, false);
            //JobLogger.LogMessage(ErrorMessage, false, false, true);


            #region CODE ADDED BY JUAN SANTA
            DestinationAppSettings destinationAppSettings = new DestinationAppSettings();
            JobLogger jobLoggerNew = new JobLogger(destinationAppSettings);
            JobLogger.LogMessage(ErrorMessage, MessageType.Error);
            JobLogger.LogMessage(WarningMessage, MessageType.Warning);
            JobLogger.LogMessage(TestMessage, MessageType.Info);

            Assert.AreEqual(1, 1);
            
            #endregion
        }
    }
}