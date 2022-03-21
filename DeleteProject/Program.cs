List<int> nums = new List<int>() { 4, 5, 6, 23, 435, 12, 234, 2, 324, 23, 5, 2, 34, 293, 2393 };

List<int> GetPageList(int page, int pageSize, List<int> list)
{
    return list.GetRange(pageSize * (page - 1), page * pageSize);
}

foreach (int num in GetPageList(2,4,nums))
    Console.Write($"{num}\t");
Console.WriteLine();
Console.WriteLine(Math.Ceiling(2.1));

var step1 = Convert.ToDecimal(nums.Count / 4);
Console.WriteLine($"step1: {step1}");
var step2 = Math.Ceiling(step1);
Console.WriteLine($"step2: {step2}");
var step3 = Convert.ToInt32(step2);
Console.WriteLine($"step3: {step3}");
Console.WriteLine(nums.Count / 4);

