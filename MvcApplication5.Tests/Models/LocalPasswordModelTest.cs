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
// 8/26/2013 1:03 AM  lnickers     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace MvcApplication5.Tests.Models
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
            LocalPasswordModel localPasswordModel = new LocalPasswordModel(); //Trial Mode
            //LocalPasswordModel localPasswordModel = new LocalPasswordModel("place user name here", "place license key here"); //License Mode

            localPasswordModel.OldPassword = "test";
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
            LocalPasswordModel localPasswordModel = new LocalPasswordModel(); //Trial Mode
            //LocalPasswordModel localPasswordModel = new LocalPasswordModel("place user name here", "place license key here"); //License Mode

            localPasswordModel.NewPassword = "test";
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
            LocalPasswordModel localPasswordModel = new LocalPasswordModel(); //Trial Mode
            //LocalPasswordModel localPasswordModel = new LocalPasswordModel("place user name here", "place license key here"); //License Mode

            localPasswordModel.ConfirmPassword = "test";
        }

        #endregion

        #region Method Tests

// No methods were found. No tests are generated for methods.

        #endregion

    }
}
