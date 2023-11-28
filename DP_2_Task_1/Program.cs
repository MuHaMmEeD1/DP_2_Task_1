

using DP_2_Task_1;

namespace Task1
{

    class Program
    {


        static void Main(string[] args)
        {

            CarBuilder builder = new CarBuilder();

            builder.setEngine("engine").setGPS();

            Director director = new Director();

            Car car = director.makeSports(builder).getResult();

            Console.WriteLine(car.Engine);
            Console.WriteLine(car.GPS);
            Console.WriteLine(car.Seats);
            Console.WriteLine(car.TripComputer);
        }
    }





}







