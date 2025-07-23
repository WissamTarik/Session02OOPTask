namespace TaskAccess_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Protected:
        Accessible in child class even its in different project but not accessible
        in non-child class in same or different project
     */
            // Parent parent=new Parent();
            ////parent.Func01();Invalid
            //Child02 child02=new Child02();
            //child02.Func01();//Invalid


            /*Internal protected:
                  Accessible in child class in same or different projected and in non child 
                  class in the same project but not accessible in non-child class in different
                  project
             */
            // Parent parent=new Parent();
            //parent.Func02();//Invalid
            //See NonChild01


            /*Private Protected:
                Only accessible in child class in the same project 
             */
        }
    }
}
