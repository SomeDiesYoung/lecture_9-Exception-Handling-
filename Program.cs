using System.ComponentModel.DataAnnotations;
using System.Numerics;
namespace Validation_Methods
{
    internal partial class Program
    {
        static void Main()
        {

            //product class
            try
            {

                Product product = new Product(15, -51, "Salmon", "SS-SuperSea", -4);
                product.Validate();
                Console.WriteLine("Product is Created");
            }
            catch(ValidationException e) {
                Console.WriteLine(e.Message);
            }

            //metodebi
            try
            {
                Ensure.IsPositive(5);
                Ensure.IsPositive(-62.64m);

            }
            catch (ValidationException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Ensure.IsNegative(55);
                Ensure.IsNegative(-5);
            }
            catch (ValidationException e)
            {
                Console.WriteLine(e.Message);

            }

            try
            {
                Ensure.IsGreaterThan(62.03, 62.11);
            }
            catch (ValidationException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Ensure.IsGreaterThanOrEqual(52, 56);
            }
            catch (ValidationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        public class Product
        {
            public int Id { get; set; }

            public double Price { get; set; }
            public string Name { get; set; }
            public string Manufacturer { get; set; }
            public float Rating { get; set; }

            public Product(int id, double price, string name, string manufacturer, float rating)
            {
                Id = id;
                Price = price;
                Name = name;
                Manufacturer = manufacturer;
                Rating = rating;
            }

            public void Validate()
            {
                if (Id <= 0)
                {
                    throw new ValidationException("Id must be positive integer number");
                }

                if (Price <= 0)
                {
                    throw new ValidationException("Price must be positive number");
                }
                if (Name == null)
                {
                    throw new ValidationException("name can`t be null");
                }
                if (Manufacturer == null) { throw new ValidationException("name can`t be null"); }
                if (Rating <= 0 || Rating > 5)
                {
                    throw new ValidationException("Rating must be in range [0,5]");
                }
            }
        }
    }
}

