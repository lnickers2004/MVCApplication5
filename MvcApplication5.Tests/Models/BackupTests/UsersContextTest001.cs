#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MvcApplication5.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2013 (c) by Carnival Cruise Lines All Rights Reserved.
//  
// Project:      Models
// Module:       UsersContextTest.cs
// Description:  Tests for the Users Context class in the Mvc Application 5 assembly.
//  
// Date:       Author:           Comments:
// 8/26/2013 12:32 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5.ModelsTest
{

    /// <summary>
    /// Tests for the Users Context Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Users Context")]
    public class UsersContextTest
    {
        #region Class Variables
        private UsersContext _usersContext;
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
            //New instance of Users Context
            _usersContext = new UsersContext();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _usersContext or delete this line
        }
        #endregion

        #region Property Tests

        /// <summary>
        /// User Profiles Property Test
        /// Documentation:  
        /// Property Type:  DbSet&lt;UserProfile&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        //[Ignore("Please Implement")]
        public void UserProfilesTest()
        {
            DbSet<UserProfile> expected = null; //new DbSet<UserProfile>();
            _usersContext.UserProfiles = expected;
            Assert.AreEqual(expected, _usersContext.UserProfiles, "MvcApplication5.Models.UsersContext.UserProfiles property test failed");
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
