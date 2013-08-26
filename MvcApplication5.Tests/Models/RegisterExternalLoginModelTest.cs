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
// 8/26/2013 1:03 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5.Tests.Models
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
            RegisterExternalLoginModel registerExternalLoginModel = new RegisterExternalLoginModel(); //Trial Mode
            //RegisterExternalLoginModel registerExternalLoginModel = new RegisterExternalLoginModel("place user name here", "place license key here"); //License Mode

            registerExternalLoginModel.UserName = "test";
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
            RegisterExternalLoginModel registerExternalLoginModel = new RegisterExternalLoginModel(); //Trial Mode
            //RegisterExternalLoginModel registerExternalLoginModel = new RegisterExternalLoginModel("place user name here", "place license key here"); //License Mode

            registerExternalLoginModel.ExternalLoginData = "test";
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
