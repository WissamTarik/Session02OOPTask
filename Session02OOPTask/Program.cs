namespace Session02OOPTask
{
    internal class Program
    {
        #region Video04 Polymorphism methods overloading 
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static double Sum(double x, double y)
        {
            return x + y;
        }
        static double Sum(int x, double y)
        {
            return x + y;
        }
        #endregion
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
            #region Video02 Inheritance
            //Inheritance
            //X==>Y
            //Parent parent = new Parent(1,2);
            //Console.WriteLine(parent);
            //parent.Fun01();
            //parent.Fun02();
            //Child child = new Child(1, 2, 3);
            //Console.WriteLine(child);
            //child.Fun01();
            //child.Fun02();
            #endregion
            #region Video03 Polymorphism overview
            //3.Polymorphism
            //3.1 Polymorphism methods (functions) overloading
            //3.2 Polymorphism methods (functions) overriding

            #endregion
            #region Video04 Polymorphism overloading methods
            //3.1 Polymorphism methods (functions) overloading:
            //There are more than one function in the same scope[class-struct] with the same NAME
            //but with different signature(count-type-order) parameters

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(1.2, 2.4));
            //Console.WriteLine(Sum(1,2,3));
            //Console.WriteLine(Sum(1,2.3));



            #endregion
            #region Video05 Polymorphism overriding methods
            //3.2 Polymorphism  methods (functions) overriding
            //There are more than one functions [in different class] these funtions have
            //the same NAME and SIGNATURE but with different behavior
            //it happened in Inheritance
            //TypeB typeB = new TypeB() { A=12,B=13} ;
            //typeB.Fun01();
            //typeB.Fun02();
            #endregion

            #region Video06 what is binding
            /*
             Whats binding?
            --Is a reference from parent refer to an object of child
            --child is a parent
              TypeB is a TypeA
             */
            //TypeA Ref=new TypeB()  ;

            //Ref.Fun01();//static binded method
            //Ref.Fun02();//dynamic binded method

            #endregion
            #region Video07 Not binding
            //Reference from parent refer to object from child
            //TypeA typeA = new TypeA();//Not binding
            //TypeA typeA = new TypeB();// Binding

            ////TypeB Ref = new TypeA();
            ////Child is a parent
            ////TypeB is a TypeA
            ////Dog is a Animal 
            ////Animal is a (Animal)Dog
            //TypeA Ref=new TypeA();
            //Ref = new TypeB();
            //TypeB typeB = (TypeB)Ref;//Not binding

            #endregion
        }
    }
}
