﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proggasoft.Utility;
using Ninject;
using Moq;
using Ninject.MockingKernel.Moq;

namespace ShopMaker.Membership.Tests
{
    [TestClass]
    public class AddressTest : BaseTest
    {
        public AddressTest()
        {
            _kernel.Bind<IAddress>().To<Address>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Zipcode_SetEmptyZipcode_ThrowsException()
        {
            // prepare
            string invalidZipcode = string.Empty;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.Zipcode = invalidZipcode;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Zipcode_SetNullZipcode_ThrowsException()
        {
            // prepare
            string invalidZipcode = null;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.Zipcode = invalidZipcode;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StateOrPrvince_SetNullStateOrPrvince_ThrowsException()
        {
            // prepare
            string invalidStateOrPrvince = null;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.StateOrProvince = invalidStateOrPrvince;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StateOrPrvince_SetEmptyStateOrPrvince_ThrowsException()
        {
            // prepare
            string invalidStateOrPrvince = string.Empty;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.StateOrProvince = invalidStateOrPrvince;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Country_SetNullCountry_ThrowsException()
        {
            // prepare
            string invalidCountry = null;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.Country = invalidCountry;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Country_SetEmptyCountry_ThrowsException()
        {
            // prepare
            string invalidCountry = String.Empty;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.Country = invalidCountry;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void City_SetEmptyCity_ThrowsException()
        {
            // prepare
            string invalidCity = String.Empty;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.City = invalidCity;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void City_SetNullCity_ThrowsException()
        {
            // prepare
            string invalidCity = null;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.City = invalidCity;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddressLine2_SetNullAddressLine2_ThrowsException()
        {
            // prepare
            string invalidAddressLine2 = null;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.AddressLine2 = invalidAddressLine2;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddressLine2_SetEmptyAddressLine2_ThrowsException()
        {
            // prepare
            string invalidAddressLine2 = String.Empty;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.AddressLine2 = invalidAddressLine2;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddressLine1_SetNullAddressLine1_ThrowsException()
        {
            // prepare
            string invalidAddressLine1 = null;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.AddressLine1 = invalidAddressLine1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddressLine1_SetEmptyAddressLine1_ThrowsException()
        {
            // prepare
            string invalidAddressLine1 = String.Empty;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.AddressLine1 = invalidAddressLine1;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ID_SetEmptyID_ThrowsException()
        {
            // prepare
            Guid invalidID = Guid.Empty;
            IAddress address = _kernel.Get<IAddress>();

            // act
            address.ID = invalidID;
        }

        [TestMethod]
        public void Zipcode_GetZipcode_ReturnsNotNullZipcode()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string zipcode = address.Zipcode;

            // assert
            Assert.IsNotNull(zipcode);
        }

        [TestMethod]
        public void Zipcode_GetZipcode_ReturnsNonEmptyZipcode()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string zipcode = address.Zipcode;

            // assert
            Assert.AreNotEqual(string.Empty, zipcode);
        }

        [TestMethod]
        public void StateOrProvince_GetStateOrProvince_ReturnsNotNullStateOrProvince()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string stateOrPrvince = address.StateOrProvince;

            // assert
            Assert.IsNotNull(stateOrPrvince);
        }

        [TestMethod]
        public void StateOrProvince_GetStateOrProvince_ReturnsNonEmptyStateOrProvince()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string stateOrProvince = address.StateOrProvince;

            // assert
            Assert.AreNotEqual(string.Empty, stateOrProvince);
        }

        [TestMethod]
        public void Country_GetCountry_ReturnsNotNullCountry()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string country = address.Country;

            // assert
            Assert.IsNotNull(country);
        }

        [TestMethod]
        public void Country_GetCountry_ReturnsNonEmptyCountry()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string country = address.Country;

            // assert
            Assert.AreNotEqual(string.Empty, country);
        }

        [TestMethod]
        public void City_GetCity_ReturnsNotNullCity()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string city = address.City;

            // assert
            Assert.IsNotNull(city);
        }

        [TestMethod]
        public void City_GetCity_ReturnsNonEmptyCity()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string city = address.City;

            // assert
            Assert.AreNotEqual(string.Empty, city);
        }

        [TestMethod]
        public void AddressLine2_GetAddressLine2_ReturnsNotNullAddressLine2()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string addressLine2 = address.AddressLine2;

            // assert
            Assert.IsNotNull(addressLine2);
        }

        [TestMethod]
        public void AddressLine2_GetAddressLine2_ReturnsNonEmptyAddressLine2()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string addressLine2 = address.AddressLine2;

            // assert
            Assert.AreNotEqual(string.Empty, addressLine2);
        }

        [TestMethod]
        public void AddressLine1_GetAddressLine1_ReturnsNotNullAddressLine1()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string addressLine1 = address.AddressLine1;

            // assert
            Assert.IsNotNull(addressLine1);
        }

        [TestMethod]
        public void AddressLine1_GetAddressLine1_ReturnsNonEmptyAddressLine1()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            string addressLine1 = address.AddressLine1;

            // assert
            Assert.AreNotEqual(string.Empty, addressLine1);
        }

        [TestMethod]
        public void ID_GetID_ReturnsNonEmptyID()
        {
            // prepare
            IAddress address = _kernel.Get<IAddress>();

            // act
            Guid id = address.ID;

            // assert
            Assert.AreNotEqual(Guid.Empty, id);
        }
    }
}
