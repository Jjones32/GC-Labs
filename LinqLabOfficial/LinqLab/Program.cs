int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

//Find the Minimum Value

var minVal = nums.Min();
Console.WriteLine($"The minimum value is: {minVal}.");

//Find the Maximum Value

var maxVal = nums.Max();
Console.WriteLine($"The maximum value is: {maxVal}.");

//Find the Maximum value less than 10,000

var maxValLessThan = nums.Max();
Console.WriteLine($"The maximum value that is also less than 10,000 is: {maxValLessThan}");

//Find all the values between 10 and 100

var rangeOfNums = nums.Where(x => x >= 10 && x <= 100);
Console.WriteLine($"The value(s) between 10 and 100 are: {String.Join(",", rangeOfNums)}");

// Find all the values between 100,000 and 999,999 *inclusive*

var highRangeOfNums = nums.Where(x => x >= 100000 && x <= 999999);
Console.WriteLine($"The Value(s) between 100,000 and 999,999 are: {String.Join(",", highRangeOfNums)}");

//Count all the numbers

var count = nums.Count();
Console.WriteLine($"There are {count} values in total");