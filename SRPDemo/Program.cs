namespace SRPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            //Ask for person information
            Person person = PersonDataCapture.Capture();

            //check for valid detail
            bool isPersonValid = PersonValidator.Validate(person);

            if (isPersonValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            //create person
            AccountGenerator.CreateAccount(person);

            StandardMessages.EndApplication();
        }
    }
}
