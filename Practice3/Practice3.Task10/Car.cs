
namespace Practice3.Task10
{
    public class Car
    {
        private string brandCar;

        public string BrandCar
        {
            get => brandCar;
            set => brandCar = value;
        }
        public static void PrintBrandCar(Car car)
        {
            Console.WriteLine($"Brand: {car.brandCar}");
        }
    }
}
