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
// Module:       LocalPasswordModelTest.cs
// Description:  Tests for the Local Password Model class in the Mvc Application 5 assembly.
//  
// Date:       Author:           Comments:
// 8/26/2013 12:32 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5Test
{

    /// <summary>
    /// Tests for the Local Password Model Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Local Password Model")]
    public class LocalPasswordModelTest
    {
        #region Class Variables
        private LocalPasswordModel _localPasswordModel;
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
            //New instance of Local Password Model
            _localPasswordModel = new LocalPasswordModel();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _localPasswordModel or delete this line
        }
        #endregion

        #region Property Tests

        /// <summary>
        /// Old Password Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void OldPasswordTest()
        {
            string expected = "test";
            _localPasswordModel.OldPassword = expected;
            Assert.AreEqual(expected, _localPasswordModel.OldPassword, "MvcApplication5.LocalPasswordModel.OldPassword property test failed");
        }

        /// <summary>
        /// New Password Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void NewPasswordTest()
        {
            string expected = "test";
            _localPasswordModel.NewPassword = expected;
            Assert.AreEqual(expected, _localPasswordModel.NewPassword, "MvcApplication5.LocalPasswordModel.NewPassword property test failed");
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
            _localPasswordModel.ConfirmPassword = expected;
            Assert.AreEqual(expected, _localPasswordModel.ConfirmPassword, "MvcApplication5.LocalPasswordModel.ConfirmPassword property test failed");
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
