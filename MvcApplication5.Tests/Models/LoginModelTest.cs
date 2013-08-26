#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MvcApplication5;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using MvcApplication5.Models;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2013 (c) by Carnival Cruise Lines All Rights Reserved.
//  
// Project:      
// Module:       LoginModelTest.cs
// Description:  Tests for the Login Model class in the Mvc Application 5 assembly.
//  
// Date:       Author:           Comments:
// 8/26/2013 1:03 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5.Tests.Models
{

    /// <summary>
    /// Tests for the Login Model Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Login Model")]
    public class LoginModelTest
    {
        #region Class Variables
        private LoginModel _loginModel;
        #endregion

        #region Property Tests

        /// <summary>
        /// User Name Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UserNameTest()
        {
            LoginModel loginModel = new LoginModel(); //Trial Mode
            //LoginModel loginModel = new LoginModel("place user name here", "place license key here"); //License Mode

            loginModel.UserName = "test";
        }

        /// <summary>
        /// Password Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void PasswordTest()
        {
            LoginModel loginModel = new LoginModel(); //Trial Mode
            //LoginModel loginModel = new LoginModel("place user name here", "place license key here"); //License Mode

            loginModel.Password = "test";
        }

        /// <summary>
        /// Remember Me Property Test
        /// Documentation:  
        /// Property Type:  bool
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void RememberMeTest()
        {
            LoginModel loginModel = new LoginModel(); //Trial Mode
            //LoginModel loginModel = new LoginModel("place user name here", "place license key here"); //License Mode

            loginModel.RememberMe = true;
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
