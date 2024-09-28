


List<int> numbers = new List<int> { 12,11,10,9,8,7,6,5,4,3,2,1 };

int n = 8;
Console.WriteLine(BinarySearch(numbers,n));




static int BinarySearch(List<int> numbers, int target)
{
    int left = 0;
    int right = numbers.Count - 1;
    while (left <= right)
    {
        int mid = left + (right - left)/2;
        if (numbers[mid] == target)
        {
            return mid;
        }
        else if (numbers[mid] > target)
        {
            right = mid - 1;
        }
        else
        {
            left = mid + 1;
        }
    }
    return -1;
}





