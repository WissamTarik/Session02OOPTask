namespace Task_Access_Modifers_Library
{
    public class ParentTask
    {
        public int X { get; set; }
        protected void Func01()
        {
            Console.WriteLine("I'm protected function");
        }
        internal protected void Func02()
        {
            Console.WriteLine("I'm internal protected function");
        }
        private protected void Func03()
        {
            Console.WriteLine("I'm private protected function");
        }
    }
}
