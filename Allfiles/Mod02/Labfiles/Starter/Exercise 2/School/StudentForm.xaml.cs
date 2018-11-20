using System;
using System.Windows;

namespace School
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        #region Predefined code

        public StudentForm()
        {
            InitializeComponent();
        }

        #endregion

        // If the user clicks OK to save the Student details, validate the information that the user has provided
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            DateTime value;
            // TODO: Exercise 2: Task 2a: Check that the user has provided a first name
            //if (this.firstName.Text.Length.Equals(0)) { }
            if (string.IsNullOrWhiteSpace(this.firstName.Text)) { MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error); return; }

            // TODO: Exercise 2: Task 2b: Check that the user has provided a last name
            if (string.IsNullOrWhiteSpace(this.lastName.Text)) { MessageBox.Show("The student must have a last name", "Error", MessageBoxButton.OK, MessageBoxImage.Error); return; }

            // TODO: Exercise 2: Task 3a: Check that the user has entered a valid date for the date of birth
            if (!DateTime.TryParse(this.dateOfBirth.Text, out value)) { MessageBox.Show("The date of birth must be a valid date", "Error", MessageBoxButton.OK, MessageBoxImage.Error); return; }

            // TODO: Exercise 2: Task 3b: Verify that the student is at least 5 years old
            TimeSpan age = DateTime.Now.Subtract(value);
            if (age.Days / 365 < 5) { MessageBox.Show("The student must be at least 5 years old", "Error", MessageBoxButton.OK, MessageBoxImage.Error); return; }
            
            // Indicate that the data is valid
                this.DialogResult = true;
            
        }
    }
}
