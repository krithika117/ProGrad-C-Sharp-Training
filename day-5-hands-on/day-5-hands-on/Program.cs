namespace day_5_hands_on
{
    class Program 
    {

        //private static void Method1() {
        //    Console.WriteLine("No Parameters");
        //}
        //private static void Method1(string s) {
        //    Console.WriteLine("1 Parameter = " + s);
        //}
        static void Main(string[] args)
        {
            //Program p = new Program();
            //Method1();
            //Method1("krithika");
            Marks marks = new Marks(547, 6);

            Student student = new Student("Krithika", 20, 5028, 5, marks);
        }
    }


}