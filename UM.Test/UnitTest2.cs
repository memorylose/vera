using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UM.BusinessLogic;

namespace UM.Test
{
    [TestClass]
    public class LoginText1
    {
        [TestMethod]
        public void TestMethod2()
        {
            UserRegisterBusiness useReg = new UserRegisterBusiness();
            string username = "VeraJiang";
            string password = "123";

            string result = useReg.LoginValidation(username, password);
            Assert.AreEqual("", result);
        }
    }
}
