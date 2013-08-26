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
// 8/26/2013 1:03 AM  lnickers     Module created.
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

        #region Property Tests

        /// <summary>
        /// User Profiles Property Test
        /// Documentation:  
        /// Property Type:  DbSet&lt;UserProfile&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UserProfilesTest()
        {
            UsersContext usersContext = new UsersContext(); //Trial Mode
            //UsersContext usersContext = new UsersContext("place user name here", "place license key here"); //License Mode

            usersContext.UserProfiles = null; // new DbSet<UserProfile>();
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
