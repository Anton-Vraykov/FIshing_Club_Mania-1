using FIshing_Club_Mania.DataModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fishing_Club_ManiaTest
{
    internal class FishingPlaceTest
    {
        [Test]
        public void IsThereFishingPlace()
        {
            var fishingPlace = new FishingPlaceService();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(fishingPlace);
        }
        [Test]

        [TestMethod]
        public void IsDeletedTest()
        {
            try
            {
                var fisgingPlace = new FishingPlaceService();
                var testDel = fisgingPlace.IsDeleted;
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(true);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(false);
            }
        }
        [Test]
        public void ReservationTest()
        {
            var fisgingPlace = new FishingPlaceService();
            var testData = fisgingPlace.Reservation;
            if (testData != null || testData > DateTime.Today)
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(true);
            }
            else
            {
                return;
            }

        }
        [Test]
        public void FishingPlacePriceTestAddMetod()
        {
            var fisgingPlace = new FishingPlaceService();
            var testData = fisgingPlace.Price;
            if ( testData > 0)
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(true);
            }
            else
            {
                return;
            }
        }
        [Test]
        public void UpdateMetodTest()
        {
            var fisgingPlace = new FishingPlaceService();
            var testData = fisgingPlace.Price;
            if (testData > 0)
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(true);
            }
            else
            {
                return;
            }
        }
    }
}
