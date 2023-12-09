using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Interfaces;       // INSTALL NUNIT PACKAGE AND ADAPTER
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //[TestClass]  //Attribute
    //public class ReservationTests
    //{


        //[TestMethod]    //Attribute
        ////public void CanBeCancelledBy_Scenario_ExpectedBehavior()
        //public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()  //scenario 1
        //{
        //    // Triple AAA = Arrange, Act, Assert

        //    //Arrange
        //    var reservation = new Reservation();


        //    //Act
        //    var result = reservation.CanBeCancelledBy(new User
        //    {

        //        IsAdmin = true
        //    });

        //    //Assert
        //    Assert.AreEqual(true, result);


        //}

        //[TestMethod]
        //public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        //{
        //    var user = new User();
        //    var reservation = new Reservation(user);
        //    var result = reservation.CanBeCancelledBy(new User{IsAdmin = true});
        //    Assert.IsTrue(result);
        //}

        //[TestMethod]
        //public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        //{
        //    Reservation reservation = new Reservation();
        //    var result = reservation.CanBeCancelledBy(new User());
        //    Assert.IsFalse(result);
        //}
   
    
    //}

    [TestFixture]
    public class ReservationTestsNUnit
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrueNUnit()  
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User
            {IsAdmin = true});
            Assert.That(result, Is.True);


        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrueNUnit()
        {
            var user = new User();
            var reservation = new Reservation(user);
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalseNUnit()
        {
            Reservation reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User());
            Assert.That(result == false);
        }
    }

}
//}
