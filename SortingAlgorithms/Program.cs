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

    // Tri par insertion.
    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    // Tri fusion (Merge Sort).
    public static void MergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);
            Merge(arr, l, m, r);
        }
    }

    private static void Merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;
        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];

        i = 0;
        j = 0;
        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    // Tri rapide (Quicksort).
    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;
        return i + 1;
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

        int[] arr3 = { 12, 11, 13, 5, 6 };
        Console.WriteLine("\nTri par insertion:");
        PrintArray(arr3);
        InsertionSort(arr3);
        PrintArray(arr3);

        int[] arr5 = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("\nTri fusion:");
        PrintArray(arr5);
        MergeSort(arr5, 0, arr5.Length - 1);
        PrintArray(arr5);

        int[] arr4 = { 10, 7, 8, 9, 1, 5 };
        Console.WriteLine("\nTri rapide:");
        PrintArray(arr4);
        QuickSort(arr4, 0, arr4.Length - 1);
        PrintArray(arr4);
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