
namespace Reservation
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if(user.IsAdmin || MadeBy == user)
            {
                return true;
            }

            return false;
        }
    }
}
