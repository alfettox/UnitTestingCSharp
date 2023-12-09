namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin)  //scenario 1 or execution path
            {
                return true;        
            } 
            else if (MadeBy == user) //scenario 2 or execution path
            {
                return true;
            }
            else return false; //scenario 3 or execution path,
                               //other person cancelling another user reservation
        }

        public Reservation(User user)
        {
            this.MadeBy = user;
        }

        public Reservation()
        {

        }


    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}