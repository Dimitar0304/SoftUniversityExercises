

int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

var result = SumArray(arr,0);
Console.WriteLine(result);

int SumArray(int[] arr,int index)
{
    if (index == arr.Length)
    {
        return 0;
    }

    return arr[index]+SumArray(arr,index+1);
}