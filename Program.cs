// See https://aka.ms/new-console-template for more information

int[] ReverseArray(int[] nums)
{
    int left = 0, right = nums.Length - 1;
    if (nums == null || nums.Length == 0)
    {
       throw new ArgumentException("Input array cannot be null or empty");
    }
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
int[] result;
result = ReverseArray(new int[] { 1, 2, 3, 4, 5 });
Console.WriteLine("Reverse Array is:"+result);
Console.ReadLine();

// Output: Reverse Array is:5,4,3,2,1

