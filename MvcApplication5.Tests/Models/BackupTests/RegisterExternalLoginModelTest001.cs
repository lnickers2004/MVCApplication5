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
// Module:       RegisterExternalLoginModelTest.cs
// Description:  Tests for the Register External Login Model class in the Mvc Application 5 assembly.
//  
// Date:       Author:           Comments:
// 8/26/2013 12:32 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5Test
{

    /// <summary>
    /// Tests for the Register External Login Model Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Register External Login Model")]
    public class RegisterExternalLoginModelTest
    {
        #region Class Variables
        private RegisterExternalLoginModel _registerExternalLoginModel;
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
            //New instance of Register External Login Model
            _registerExternalLoginModel = new RegisterExternalLoginModel();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _registerExternalLoginModel or delete this line
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
            _registerExternalLoginModel.UserName = expected;
            Assert.AreEqual(expected, _registerExternalLoginModel.UserName, "MvcApplication5.RegisterExternalLoginModel.UserName property test failed");
        }

        /// <summary>
        /// External Login Data Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ExternalLoginDataTest()
        {
            string expected = "test";
            _registerExternalLoginModel.ExternalLoginData = expected;
            Assert.AreEqual(expected, _registerExternalLoginModel.ExternalLoginData, "MvcApplication5.RegisterExternalLoginModel.ExternalLoginData property test failed");
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
