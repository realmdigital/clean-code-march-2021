namespace CleanCode._3.WrapPrimitives
{
    
    // RATING: EVALUATE
    public class AsPerUsual
    {
        public void Main()
        {
            var emailAddress = "realmdigital.co.za";
            Login(emailAddress);
            SendEmail(emailAddress);
        }

        
        private void Login(string emailAddress)
        {
            // probably need to validate the email address
            // userClient.Login(emailAddress) //this now fails
        }
        private void SendEmail(string recipientEmailAddress)
        {
            // do a bunch of stuff to prepare the email
            // probably need to validate the email address too
            // emailClient.Send(recipientEmailAddress, data) //this now fails
        }
        
        
    }
}