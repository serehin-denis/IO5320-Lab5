namespace lab5
{
    class Program
    {
        private static void Main()
        {
            var mySalad = new Salad();
            
            mySalad.AddVegetable(new RootVeg("Морква", 50, 40));
            mySalad.AddVegetable(new FruitVeg("Помідор", 45, 19));
            mySalad.AddVegetable(new LeafyVeg("Капуста", 70, 25));
            
            Console.WriteLine("Склад салату:");
            mySalad.PrintIngredients();

            Console.WriteLine($"\nЗагальна калорійсніть салату: {mySalad.TotalCalories()}");
            
            Console.WriteLine("\nСортування овочів по вазі:");
            mySalad.Sort();
            mySalad.PrintIngredients();

            Console.WriteLine("\nПошук калорій в заданому діапазоні: ");
            var findResult = mySalad.FindByCalories(19, 30);
            if (findResult.Count > 0)
            {
                foreach (var veg in findResult)
                {
                    Console.WriteLine(veg);
                }
            }
            else
            {
                Console.WriteLine("Нічого не знайдено");
            }
        }
    }
}