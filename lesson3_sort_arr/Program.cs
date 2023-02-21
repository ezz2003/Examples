
void SortArr(int[] ar)
{
  for (int i = 0; i < ar.Length - 1; i++)
  {
    int minIndex = i;
    for (int j = i + 1; j < ar.Length; j++)
    {
      if (ar[j] < ar[minIndex])
      {
        minIndex = j;
      }
    }
    (ar[i], ar[minIndex]) = (ar[minIndex], ar[i]);
  }
  PrintArr(ar);
}

void PrintArr(int[] num)
{
  Console.WriteLine();
  for (int i = 0; i < num.Length; i++)
  {
    Console.Write($"{num[i]} ");
  }
  Console.WriteLine();
}

int[] arr = { 4, 2, 6, 7, 9, 5, 3, 1, 8, 0 };
PrintArr(arr);
SortArr(arr);