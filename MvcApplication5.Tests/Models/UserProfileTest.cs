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
// 8/26/2013 1:03 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5.Tests.Models
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
            UserProfile userProfile = new UserProfile(); //Trial Mode
            //UserProfile userProfile = new UserProfile("place user name here", "place license key here"); //License Mode

            userProfile.UserId = 123;
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
            UserProfile userProfile = new UserProfile(); //Trial Mode
            //UserProfile userProfile = new UserProfile("place user name here", "place license key here"); //License Mode

            userProfile.UserName = "test";
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
