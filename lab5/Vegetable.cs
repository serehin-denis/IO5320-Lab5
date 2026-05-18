namespace lab5;

public abstract class Vegetable
{
    public string Name { get; }
    public float Weight { get; }
    public float Calories { get; }

    public Vegetable(string name, float weight, float calories)
    {
        if (weight < 0 || calories < 0)
        {
            throw new ArgumentException("Вага і калорійність мають бути більше 0");
        }
        Name = name;
        Weight = weight;
        Calories = calories;
    }
    
    public float GetCalories()
    {
        return (Weight/100)*Calories;
    }

    public override string ToString()
    {
        return $"{Name}, {Weight}г, {Calories}ккал";
    }
}