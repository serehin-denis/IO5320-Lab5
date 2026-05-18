namespace lab5;

public class Salad
{
    private List<Vegetable> _ingredients = new List<Vegetable>();

    public void AddVegetable(Vegetable veg)
    {
        if (veg == null)
        {
            throw new ArgumentNullException(nameof(veg), "овоч не може бути порожнім");
        }
        _ingredients.Add(veg);
    }

    public float TotalCalories()
    {
        return _ingredients.Sum(veg => veg.GetCalories());
    }

    public void Sort()
    {
        _ingredients = _ingredients.OrderBy(veg => veg.Weight).ToList();
    }

    public List<Vegetable> FindByCalories(int min, int max)
    {
        var result = new List<Vegetable>();
        if (min > max || min < 0)
        {
            throw new ArgumentException("Некоректний діапазон");
        }
        foreach (var veg in _ingredients)
        {
            if(veg.Calories >= min && veg.Calories <= max)
            {
                result.Add(veg);
            }
        }
        return result;
    }

    public void PrintIngredients()
    {
        foreach (var veg in _ingredients)
        {
            Console.WriteLine(veg);
        }
    }
}