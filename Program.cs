/* Objective of the program:
 1.In this program we will learn about what is a property,how to declare a property,how to use a get and set in a property.
    What is a property?
    Property is a member of a class.It has a get and a set accessor.
    A get accessor returns a property value, and a set accessor assigns a new value. The value keyword represents the value of a property.
     Syntax::
     <acces_modifier> <return_type> <property_name>  
       {
          get
           { return
           }
            set
             {
             }
           }

 2.We have used two classes here-Person class and Startup class
     1.Person Class-We have private fields like name,email,password, and dob.
                    We have declared properties.
     2.StartUp Class- Here, we are validating input data in methods like GetDOB,GetEmail,GetPassword.All these methods are called in Person Creation                  method.This Person Creation method is called in the StartUp method and the names are stored in a list.
 
 */
new OOP_Ramya.StartUp();

