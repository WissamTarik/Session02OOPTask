namespace Session02OOPTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Video00 Revision
            //Struct:is a Value stored in STACK
            // What can be created in struct?
            //1.Events
            //2.Methods
            //3.Attributes
            //4.Property
            //Constructor : has no return type and its name is the name of class or struct

            //OOP:Is a paradigm for writing code
            //4.Pillers of OOP:
            /*
             1.Encapsulation
             2.Inheritance
             3.Polymorphism
             4.Abstraction
             */
            //Encapsulation:Separate data from its usage
            //Class type:Is reference type stored in HEAP


            #endregion
            #region Video01 Class Vs Struct
            /*Struct
             1.Is a value type stored in STACK
             2.Only create object in STACK
             3.Support encapsulation-Polymorphism (Doesn't support Inheritance and abstraction)
             4.new keyword select the constructor
             5.Default constructor initialize the attributes with default values
             6.life time of struct object is less than class because the object of struct stored in stack frame  
             7.Access modifer can be used in struct:Private-Internal-Public
             8.Used with small and simple data

             */
            /*Class
             1.Is a reference type stored in HEAP
             2.Create a reference in stack refer to object in HEAP
             3.Support the 4 pillars of OOP (Encapsulation-Inheritance-Polymorphism-Abstraction)
             4. new keyword create the object
             5.Default constructor create nothing
             6. life time of class object is larger than struct(removed by garbage collectoe)
             7.Access modifier can be used in class all of them(Private-Internal-Public-Protected-Protected internal-Private protected)
             8.Used with large and complex data

             */
            #endregion
        }
    }
}
