namespace ConsoleApplication2
{
    public class secure // Ensure this class is public
    {
        private readonly payment _payment;

        public secure(payment payment) // Constructor that takes a payment instance
        {
            _payment = payment;
        }

        public void button() // Method in lowercase
        {
            _payment.continuepayment(); // Call the method in lowercase
        }
    }
}
