using System.Text.RegularExpressions;

namespace Formularz1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public bool IsValidAge()
        {
            return Age >= 0 && Age <= 120;
        }

        public bool IsValidEmail()
        {
            return Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public bool IsValidPhoneNumber()
        {
            return Regex.IsMatch(PhoneNumber, @"^[0-9]{10}$");
        }

        public bool IsValidPostalCode()
        {
            return Regex.IsMatch(PostalCode, @"^[0-9]{5}$");
        }
    }
}
