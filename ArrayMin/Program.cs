int[] nums = { 15, 26, 31, 54, 21, 85, 45, 52, 1, 3, 6, 784 };
int min = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] < min)
    {
        min = nums[i];
    }
}
Console.WriteLine(min);