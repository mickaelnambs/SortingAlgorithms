public class Program
{
    // Tri à bulles.
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Tri à bulles:");
        PrintArray(arr1);
        BubbleSort(arr1);
        PrintArray(arr1);
    }

    private static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}