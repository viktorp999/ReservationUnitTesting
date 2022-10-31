using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reservation.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            Reservation reservation = new Reservation();

            bool result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_ReservationMadeByUser_ReturnTrue()
        {
            Reservation reservation = new Reservation();
            User user = new User { IsAdmin = false };
            reservation.MadeBy = user;

            bool result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_ReservationNotMadeByUserOrUserIsNotAdmin_ReturnFalse()
        {
            Reservation reservation = new Reservation();
            
            bool result = reservation.CanBeCancelledBy(new User {IsAdmin = false});

            Assert.IsFalse(result);
        }
    }
}
