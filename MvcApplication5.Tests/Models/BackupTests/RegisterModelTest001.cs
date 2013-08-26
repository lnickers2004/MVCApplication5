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
// Module:       RegisterModelTest.cs
// Description:  Tests for the Register Model class in the Mvc Application 5 assembly.
//  
// Date:       Author:           Comments:
// 8/26/2013 12:32 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5Test
{

    /// <summary>
    /// Tests for the Register Model Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Register Model")]
    public class RegisterModelTest
    {
        #region Class Variables
        private RegisterModel _registerModel;
        #endregion

        #region Setup/Teardown

        /// <summary>
        /// Code that is run once for a suite of tests
        /// </summary>
        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {

        }

        /// <summary>
        /// Code that is run once after a suite of tests has finished executing
        /// </summary>
        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {

        }

        /// <summary>
        /// Code that is run before each test
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            //New instance of Register Model
            _registerModel = new RegisterModel();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _registerModel or delete this line
        }
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
            string expected = "test";
            _registerModel.UserName = expected;
            Assert.AreEqual(expected, _registerModel.UserName, "MvcApplication5.RegisterModel.UserName property test failed");
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
            string expected = "test";
            _registerModel.Password = expected;
            Assert.AreEqual(expected, _registerModel.Password, "MvcApplication5.RegisterModel.Password property test failed");
        }

        /// <summary>
        /// Confirm Password Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ConfirmPasswordTest()
        {
            string expected = "test";
            _registerModel.ConfirmPassword = expected;
            Assert.AreEqual(expected, _registerModel.ConfirmPassword, "MvcApplication5.RegisterModel.ConfirmPassword property test failed");
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
