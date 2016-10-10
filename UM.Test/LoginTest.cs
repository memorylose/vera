using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UM.BusinessLogic;

namespace UM.Test
{
    /// <summary>
    /// Summary description for LoginTest
    /// </summary>
    [TestClass]
    public class LoginTest
    {
        UserRegisterBusiness userReg = new UserRegisterBusiness();
        public LoginTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestLoginValidationWithUsernameEmpty()
        {

            string username = "";
            string password = "";

            string validateResult = userReg.LoginValidation(username, password);
            Assert.AreEqual("User name is empty.", validateResult);
        }

        public void TestLoginValidationWithPasswordEmpty()
        {

            string username = "VeraJiang";
            string password = "";

            string result = userReg.LoginValidation(username, password);
            Assert.AreEqual("Password is empty.", result);
        }

        public void TestLoginValidationWithUsernameandPassword()
        {

            string username = "VeraJiang";
            string password = "123";

            string result = userReg.LoginValidation(username, password);
            Assert.AreEqual("", result);
        }

        public void TestLoginValidationWithPassword()
        {

            string username = "";
            string password = "123";

            string validateResult = userReg.LoginValidation(username, password);
            Assert.AreEqual("User name is empty.", validateResult);
        }
    }
}
