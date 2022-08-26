using System;
namespace OOP_Ramya
{
    internal class Person
    {
        //Private fields, can be accessed only in this class ,cannot be used outside Person Class
        private string? name;
        private DateTime? dob;
        private string? email;
        private string? password;
        #region Properties Declaration
        //Public properties returns the value(thru the get) and value is checked and manipulated (in the set)
        //thru the private fields declared above.

        //check the name is valid (not null)
        public string? Name
        {
            get { return name; }// private variable name used here
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Name cannot be empty.Try inputting person name again...");
                    name = null;
                }
                else name = value;
            }
        }

        //Check if the DOB is not null
        public DateTime? DoB
        {
            get { return dob; }//private variable dob is used here
            set
            {
                if (value < DateTime.Now) dob = value;
                else
                {
                    Console.WriteLine("DOB cannot be empty.Try inputting the DOB again...");
                    dob = null;
                }
            }
        }

        //Check if the Email has @ and . (mandatory fields)
        public string? Email
        {
            get { return email; }// private variable email is used here
            set
            {
                if (value != null && value.Contains("@") && value.Contains(".")) email = value;
                else Console.WriteLine("Email should have @ and  '.' ");
            }
        }

        //Check if the password is longer than 6 characters, not null,should have small and capital letters and contains a number
        public string? Password
        {
            get { return password; }// private variable password is used here
            set
            {
                if (value != null && value.Length > 6 && value.Any(char.IsUpper) && value.Any(char.IsLower) && value.Any(char.IsDigit) && !value.Contains(" ")) password = value;
                else Console.WriteLine("Invalid password(should have more than 6 characters long,must have a number,small letters and capital letters");
            }
        }

        // Age calculator
        public int Age
        {
            get
            {
                if (DoB != null)
                {
                    DateTime today = DateTime.Today;
                    int age = today.Year - ((DateTime)DoB).Year;
                    if (today < new DateTime(today.Year, ((DateTime)DoB).Month, ((DateTime)DoB).Day)) age--;
                    return age;
                }
                else return 0;

            }
        }

        #endregion
    }
}




