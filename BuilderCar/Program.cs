// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace BuilderCar
{
    public class program
    {
        public static void Main(string[])
        { 
            car car = new car().CarBuilder().
                Id(12).Brand("xyz").Color("blue")
        }
}

