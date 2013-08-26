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
// 8/26/2013 1:03 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5.Tests.Models
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
            RegisterModel registerModel = new RegisterModel(); //Trial Mode
            //RegisterModel registerModel = new RegisterModel("place user name here", "place license key here"); //License Mode

            registerModel.UserName = "test";
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
            RegisterModel registerModel = new RegisterModel(); //Trial Mode
            //RegisterModel registerModel = new RegisterModel("place user name here", "place license key here"); //License Mode

            registerModel.Password = "test";
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
            RegisterModel registerModel = new RegisterModel(); //Trial Mode
            //RegisterModel registerModel = new RegisterModel("place user name here", "place license key here"); //License Mode

            registerModel.ConfirmPassword = "test";
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
