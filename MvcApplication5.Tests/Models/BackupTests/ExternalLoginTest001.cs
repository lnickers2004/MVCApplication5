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
// Module:       ExternalLoginTest.cs
// Description:  Tests for the External Login class in the Mvc Application 5 assembly.
//  
// Date:       Author:           Comments:
// 8/26/2013 12:32 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5Test
{

    /// <summary>
    /// Tests for the External Login Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for External Login")]
    public class ExternalLoginTest
    {
        #region Class Variables
        private ExternalLogin _externalLogin;
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
            //New instance of External Login
            _externalLogin = new ExternalLogin();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _externalLogin or delete this line
        }
        #endregion

        #region Property Tests

        /// <summary>
        /// Provider Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        //[Ignore("Please Implement")]
        public void ProviderTest()
        {
            string expected = "test";
            _externalLogin.Provider = expected;
            Assert.AreEqual(expected, _externalLogin.Provider, "MvcApplication5.ExternalLogin.Provider property test failed");
        }

        /// <summary>
        /// Provider Display Name Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        //[Ignore("Please Implement")]
        public void ProviderDisplayNameTest()
        {
            string expected = "test";
            _externalLogin.ProviderDisplayName = expected;
            Assert.AreEqual(expected, _externalLogin.ProviderDisplayName, "MvcApplication5.ExternalLogin.ProviderDisplayName property test failed");
        }

        /// <summary>
        /// Provider User Id Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        //[Ignore("Please Implement")]
        public void ProviderUserIdTest()
        {
            string expected = "test";
            _externalLogin.ProviderUserId = expected;
            Assert.AreEqual(expected, _externalLogin.ProviderUserId, "MvcApplication5.ExternalLogin.ProviderUserId property test failed");
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
