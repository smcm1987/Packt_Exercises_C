namespace CallStackExceptionHandlingLib
{
    public class Calculator
    {
        public static void Gamma()
        {
            WriteLine("In Gamma");
            Delta();
        }

        public static void Delta()
        {
            WriteLine("In Delta");
            File.OpenText("Bad File Path");
        }

        
        
        
    }
}