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
// 8/26/2013 1:03 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5.Tests.Models
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

        #region Property Tests

        /// <summary>
        /// Provider Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ProviderTest()
        {
            ExternalLogin externalLogin = new ExternalLogin(); //Trial Mode
            //ExternalLogin externalLogin = new ExternalLogin("place user name here", "place license key here"); //License Mode

            externalLogin.Provider = "test";
        }

        /// <summary>
        /// Provider Display Name Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ProviderDisplayNameTest()
        {
            ExternalLogin externalLogin = new ExternalLogin(); //Trial Mode
            //ExternalLogin externalLogin = new ExternalLogin("place user name here", "place license key here"); //License Mode

            externalLogin.ProviderDisplayName = "test";
        }

        /// <summary>
        /// Provider User Id Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ProviderUserIdTest()
        {
            ExternalLogin externalLogin = new ExternalLogin(); //Trial Mode
            //ExternalLogin externalLogin = new ExternalLogin("place user name here", "place license key here"); //License Mode

            externalLogin.ProviderUserId = "test";
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
