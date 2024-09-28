

List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

int target = 1;

Console.WriteLine(BinarySearch(nums,target));




static int BinarySearch(List<int> nums,int target)
{
    int left = 0;
    int right = nums.Count - 1;
    while (left<=right)
    {
        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }
        else if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else
        {

            right = mid - 1;
        }
    }
        return -1;
    
}