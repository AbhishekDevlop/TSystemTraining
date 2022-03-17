using System;


namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            try 
            {
               string name = u1.UserName(null) ;
                Console.WriteLine("Name of User is "+name);
            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Resources Closed:");
            }
        }
    }
}
