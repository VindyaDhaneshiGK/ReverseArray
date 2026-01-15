// See https://aka.ms/new-console-template for more information

int[] ReverseArray(int[] nums)
{
    int left = 0, right = nums.Length - 1;
    if (nums == null || nums.Length == 0)
    {
        throw new ArgumentException("Input array cannot be null or empty");
    }
    else
    {
        while (left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }
        return nums;
    }
}
int[] result= new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Before Change Array is:");
Console.WriteLine("");
foreach (int num in result)
{
    Console.Write(num + ",");
}
Console.WriteLine("");
result = ReverseArray(result);
Console.WriteLine("After Reverse Array is:");
Console.WriteLine("");
foreach (int num in result)
{
    Console.Write(num + ",");
}
Console.ReadLine();

// Output: Reverse Array is:5,4,3,2,1

