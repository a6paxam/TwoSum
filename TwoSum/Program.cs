using TwoSum.Logic;

class Program
{
    public static void Main(string[] args)
    {
        var twoSum = new TwoSum.Logic.Operations();
        var numbers = new[] { 2, 7, 11, 15};
        var result  = twoSum.TwoSum(numbers, 9);
        Console.WriteLine($"{result[0]} {result[1]}");
    }
}