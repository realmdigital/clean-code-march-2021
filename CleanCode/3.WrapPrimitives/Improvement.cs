namespace CleanCode._3.WrapPrimitives
{
    public class Improvement : IRunnable
    {
        public void Run()
        {
            /*
            var emailAddress = new EmailAddress("realmdigital.co.za"); // will error
            var emailAddress = new EmailAddress(""); // will error
            var emailAddress = new EmailAddress(); // would not compile
            */
           
            var emailAddress = new EmailAddress("sgordon@realmdigital.co.za");

            Login(emailAddress);
            SendEmail(emailAddress);
        }
        
        private void Login(EmailAddress emailAddress)
        {
            // recipientEmailAddress is guaranteed to hold an email address
            // userClient.Login(emailAddress.Value)
        }

        private void SendEmail(EmailAddress recipientEmailAddress)
        {
            // this is quite useful now. recipientEmailAddress is guaranteed to hold an email address
            // do a bunch of stuff to prepare the email
            // emailClient.Send(recipientEmailAddress.Value)
        }

        private record EmailAddress
        {
            public string Value { get; }

            public EmailAddress(string emailAddress)
            {
                Validate(emailAddress);
                Value = emailAddress;
            }

            private void Validate(string emailAddress)
            {
                // do some email validation and if it fails throw an error
            }
        }
    }
}