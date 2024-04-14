// See https://aka.ms/new-console-template for more information
// C#  Control Flow

// Challenge 1
TimeSpan currentTime = DateTime.Now.TimeOfDay;
Console.WriteLine(currentTime.Hours);

if (currentTime.Hours > 11 && currentTime.Hours < 14)
{
    Console.WriteLine("Time For Lunch");
}

// Challenge 2
for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
}

// Bonus
int x = 5;
while (x > 0)
{
    Console.WriteLine(x);
    x--;
}

// C# Arrays

// Challenge 1
string[] daysOfWeek = {"Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
for (int i = 0; i < daysOfWeek.Length; i++)
{
    Console.WriteLine($"{daysOfWeek[i]}");
}

// Challenge 2 
int[] nums = {23, 34, 56, 67, 78, 89, 90 };

//int cul = nums.Sum();
//Console.WriteLine(cul);

int sum = 0;
for (int i = 0;i < nums.Length; i++) {
    sum = sum + nums[i]; 
}
Console.WriteLine(sum);


// Bonus 

int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

for (int i = 0; i <3; i++)
{
    for (int j = 0; j <3; j++)
    {
        Console.Write(numbers[i, j] + " ");
    }
    Console.WriteLine();
}