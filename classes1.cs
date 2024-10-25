using System;
using System.Windows.Forms;

namespace SortingAlgorithms {
    public class BubbleSort {
        public Form1() {
            InitializeComponent();
        }
        private void Button1Click(object sender, EventArgs e) {
            int[] numbers = { 15, 3, 77, 14, 1, 25 };

            Sort(numbers);

            string sortedArray = string.Join(", ", numbers);
            MessageBox.Show("Sortowanie babelkowe, posortowana tablica: " + sortedArray);
        }
        private void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (arr[j] > arr[j + 1]) {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }


    public class InsertionSort {
        public Form2() {
            InitializeComponent();
        }
        private void Button2Click(object sender, EventArgs e) {
            int[] numbers = { 15, 3, 77, 14, 1, 25 };

            Sort(numbers, numbers.Length);

            string sortedArray = string.Join(", ", numbers);
            MessageBox.Show("Sortowanie przez wstawianie, posortowana tablica: " + sortedArray);
        }
        public void Sort(int[] array, int length) {
            for (int i = 1; i < length; i++) {
                var key = array[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;) {
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
}