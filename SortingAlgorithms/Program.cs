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

    // Tri par sélection.
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i+ 1; j < n; j++)
                if (arr[j] < arr[minIdx]) 
                    minIdx = j;

            int temp = arr[minIdx];
            arr[minIdx] = arr[i];
            arr[i] = temp;
        }
    }

    public static void Main(string[] args)
    {
        int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Tri à bulles:");
        PrintArray(arr1);
        BubbleSort(arr1);
        PrintArray(arr1);

        int[] arr2 = { 64, 25, 12, 22, 11 };
        Console.WriteLine("\nTri par sélection:");
        PrintArray(arr2);
        SelectionSort(arr2);
        PrintArray(arr2);
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