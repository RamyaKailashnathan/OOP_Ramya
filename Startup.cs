using System;
namespace OOP_Ramya
{
    internal class StartUp
    {
        public List<Person> People = new();
        public StartUp()
        {
            while (true)
            {
                //CreatePerson method creates a new Person with name, dob,email and password and output is stored to p_list
                Person p_list = CreatePerson();
                //p is added to our people list
                People.Add(p_list);
                // after adding to the list,show the all the names in the list=p_list
                foreach (Person person in People)
                {
                    Console.WriteLine($"Person Name: {person.Name}");
                }
            }
        }
        // Person creation-Methods for GetName,GetDob,GetEmail and GetPassword are called here.
        private Person CreatePerson()
        {
            //Creates a new instance of a Person object.
            Person person = new();
            //We get input thru the methods(GetName,GetDoB,GetEmail and GetPassword
            //The values are added to the private fields mentioned in the properties in the Person.
            //Checking if the name is not null
            GetName(person);
            Console.WriteLine("Hello " + person.Name);
            //Calculates the date of birth and the age of the person
            GetDoB(person);
            Console.WriteLine($"You were born on : {person.DoB} and you are {person.Age} years old.");
            GetEmail(person);
            Console.WriteLine("Your email id is : " + person.Email);
            GetPassword(person);
            Console.WriteLine("Your secret password is: " + person.Password);
            return person;
        }
        #region Methods for person creation
        //Asks the user to enter the name and checks if the name entered is not null
        private void GetName(Person person)
        {
            //Checking if the name is not null
            do
            {
                Console.Write("Enter the name: ");
                person.Name = Console.ReadLine();
            }
            while (person.Name == null);
        }

        //Calculates the date of birth and checks if the age is not null
        private void GetDoB(Person person)
        {
            do
            {
                Console.Write("Enter the date of birth(dd/mm/yyyy) format: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dt)) person.DoB = dt;
                else person.DoB = null;
            }
            while (person.DoB == null);
        }

        //Check if the entered email id is not null
        private void GetEmail(Person person)
        {
            do
            {
                Console.Write("Enter email id: ");
                person.Email = Console.ReadLine();
            }
            while (person.Email == null);
        }

        // Check if the password is not null
        private void GetPassword(Person person)
        {
            do
            {
                Console.Write("Enter your secret password: ");
                person.Password = Console.ReadLine();
            }
            while (person.Password == null);
        }
        #endregion
    }
}



