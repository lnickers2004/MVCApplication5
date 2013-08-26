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
// Module:       UserProfileTest.cs
// Description:  Tests for the User Profile class in the Mvc Application 5 assembly.
//  
// Date:       Author:           Comments:
// 8/26/2013 12:32 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5Test
{

    /// <summary>
    /// Tests for the User Profile Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for User Profile")]
    public class UserProfileTest
    {
        #region Class Variables
        private UserProfile _userProfile;
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
            //New instance of User Profile
            _userProfile = new UserProfile();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _userProfile or delete this line
        }
        #endregion

        #region Property Tests

        /// <summary>
        /// User Id Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UserIdTest()
        {
            int expected = 123;
            _userProfile.UserId = expected;
            Assert.AreEqual(expected, _userProfile.UserId, "MvcApplication5.UserProfile.UserId property test failed");
        }

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
            _userProfile.UserName = expected;
            Assert.AreEqual(expected, _userProfile.UserName, "MvcApplication5.UserProfile.UserName property test failed");
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
