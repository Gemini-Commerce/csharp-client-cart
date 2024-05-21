/*
 * Cart Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using cart.Model;
using cart.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace cart.Test.Model
{
    /// <summary>
    ///  Class for testing CartRemoveCouponsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CartRemoveCouponsRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CartRemoveCouponsRequest
        //private CartRemoveCouponsRequest instance;

        public CartRemoveCouponsRequestTests()
        {
            // TODO uncomment below to create an instance of CartRemoveCouponsRequest
            //instance = new CartRemoveCouponsRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CartRemoveCouponsRequest
        /// </summary>
        [Fact]
        public void CartRemoveCouponsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" CartRemoveCouponsRequest
            //Assert.IsType<CartRemoveCouponsRequest>(instance);
        }

        /// <summary>
        /// Test the property 'TenantId'
        /// </summary>
        [Fact]
        public void TenantIdTest()
        {
            // TODO unit test for the property 'TenantId'
        }

        /// <summary>
        /// Test the property 'CartId'
        /// </summary>
        [Fact]
        public void CartIdTest()
        {
            // TODO unit test for the property 'CartId'
        }

        /// <summary>
        /// Test the property 'CouponCodes'
        /// </summary>
        [Fact]
        public void CouponCodesTest()
        {
            // TODO unit test for the property 'CouponCodes'
        }
    }
}