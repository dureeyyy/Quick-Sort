using System;

class Program {
  public static void Main (string[] args) {

    int[] myArray = {15, 7, 23, 11, 5, 19, 3, 14, 10, 8, 17, 4, 13, 2, 20, 1, 6, 9, 16, 12};

    quicksort(myArray, 0, myArray.Length - 1);

    for (int i = 0; i < myArray.Length; i++){
      Console.Write(myArray[i] + " ");
    }

    
  }
  public static void quicksort(int[] myArray, int start, int end){

    if (end <= start){
      return;
    }
    
    int pivot = pivotArray(myArray, start, end);
    quicksort(myArray, start, pivot - 1);
    quicksort(myArray, pivot + 1, end);      
    
  }

  public static int pivotArray(int[] myArray, int start, int end){

    int pivot = myArray[end];
    int i = start - 1;
    int temp = 0;

    for (int j = start; j < end; j++){
      if (myArray[j] <= pivot){
        i++;
        temp = myArray[i];
        myArray[i] = myArray[j];
        myArray[j] = temp;
      } 
    }

    i++;
    temp = myArray[i];
    myArray[i] = myArray[end];
    myArray[end] = temp;
    
    return i;
  }

}