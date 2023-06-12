// See https://aka.ms/new-console-template for more information
int[] nums = { 2, 7, 11, 15};
int target = 9;
int[] answer = twoSum(nums, target);
Console.WriteLine($"[{answer[0]}, {answer[1]}]");

int[] twoSum(int[] nums, int target)
{
    Dictionary<int, int> needNum = new Dictionary<int, int>();
    int[] answer = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        if (needNum.TryGetValue(nums[i], out answer[0]))
        {
            answer[1] = i;
            break;
        }
        else
        {
            needNum.Add(target - nums[i], i);
        }
    }
    return answer;
}