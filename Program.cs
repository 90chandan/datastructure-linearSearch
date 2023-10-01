// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Linear Search algoright");

//array of elements
int[] arr  = {10,50,30,70,80,60,20,90,40};

//linear search
int searchElement = 20;
int indexWithLinearSearch = Search.LinearSearch(arr,searchElement);

if(indexWithLinearSearch != -1)
    Console.WriteLine($"Index/Postion of element {searchElement}in given array is with LinearSearch: {indexWithLinearSearch}");
else
    Console.WriteLine("Element is not present in given array");


public class Search{
    //linear serach
    public static int LinearSearch(int[] arr, int x){
        var len = arr.Length;
        for(int i =0; i < len;i++){
            if(arr[i] == x){
                return i;
            }
        }
        return -1;
    }
}