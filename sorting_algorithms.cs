using System;
using System.Windows.Forms;
public class BubbleSort 
{
    public Form1() 
    {
        InitializeComponent();
    }
    private void Button1Click(object sender, EventArgs e) 
    {
        int[] numbers = { 15, 3, 77, 14, 1, 25 };

        Sort(numbers);

        string sortedArray = string.Join(", ", numbers);
        MessageBox.Show("Sortowanie babelkowe, posortowana tablica: " + sortedArray);
    }
    private void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++) {
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
}


public class InsertionSort 
{
    public Form2() 
    {
        InitializeComponent();
    }
    private void Button2Click(object sender, EventArgs e) 
    {
        int[] numbers = { 15, 3, 77, 14, 1, 25 };

        Sort(numbers, numbers.Length);

        string sortedArray = string.Join(", ", numbers);
        MessageBox.Show("Sortowanie przez wstawianie, posortowana tablica: " + sortedArray);
    }
    public void Sort(int[] array, int length) 
    {
        for (int i = 1; i < length; i++) 
        {
            var key = array[i];
            var flag = 0;
            for (int j = i - 1; j >= 0 && flag != 1;) 
            {
                if (key < array[j]) {

                    array[j + 1] = array[j];
                    j--;
                    array[j + 1] = key;
                }
                else flag = 1;
            }
        }
    }
}

public class MergeSort
{ 
    public static void Main(string[] args)
    {
		int[] numbers = { 8, 3, 7, 5, 2, 1, 4 };
		MS(numbers, numbers[0], numbers[numbers.Length]);
	}

	public void MS(int[] arr, int leftIdx, int rightIdx) 
	{
		if (leftIdx < rightIdx)
		{
			int middleIdx = (leftIdx + rightIdx) / 2;
			MS(arr, leftIdx, middleIdx);
			MS(arr, middleIdx + 1, rightIdx);
			Merge(arr, leftIdx, middleIdx, rightIdx);
		}
	}

	public void Merge(int[] arr, int leftIdx, int middleIdx, int rightIdx)
	{

	}
}

public class QuickSort 
{
    public Form3() 
    {
        InitializeComponent();
    }
    private void Button3Click(object sender, EventArgs e) 
    {
        int[] numbers = { 15, 3, 77, 14, 1, 25 };

        Sort(numbers, 0, numbers.Length - 1);

        string sortedArray = string.Join(", ", numbers);
        MessageBox.Show("Sortowanie szybkie, posortowana tablica: " + sortedArray);
    }
    private void Sort(int[] array, int leftIndex, int rightIndex) 
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j) {
            while (array[i] < pivot) 
            {
                i++;
            }
            
            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j) 
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }
        
        if (leftIndex < j) 
        {
            Sort(array, leftIndex, j);
        }
        if (i < rightIndex) 
        {
            Sort(array, i, rightIndex);
        }
    }
}