using Formularz1;
using System;
using System.Windows;
using Formularz1;

namespace UserForm
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var person = new Person
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Age = int.TryParse(AgeTextBox.Text, out int age) ? age : 0,
                Street = StreetTextBox.Text,
                City = CityTextBox.Text,
                PostalCode = PostalCodeTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                Email = EmailTextBox.Text
            };

            if (ValidatePerson(person))
            {
                MessageBox.Show("Data submitted successfully!");
            }
            else
            {
                MessageBox.Show("Please correct the errors in the form.");
            }
        }

        private bool ValidatePerson(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName) ||
                string.IsNullOrWhiteSpace(person.LastName) ||
                !person.IsValidAge() ||
                !person.IsValidEmail() ||
                !person.IsValidPhoneNumber() ||
                !person.IsValidPostalCode())
            {
                return false;
            }
            return true;
        }
    }
}
