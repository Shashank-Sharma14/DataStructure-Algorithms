
#include <iostream>
using namespace std;

int BinarySearch(int arr[] , int length, int searchElemant){
    int start=0;
    int end=length-1;
  
  while(start<=end){
      int mid=(start+end)/2;
         
         if(searchElemant==arr[mid]){
             return mid;
         }
         else if(searchElemant>arr[mid]){
             start=mid+1;
         }
         else {
             end=mid-1;
         }
    }   
  return -1;

}

int main() {
	// your code goes here
	int arr[] ={10,20,30,40,50,60},element,result;   // Time Complexity O(log n)
	cin>>element;
	result=BinarySearch(arr,6,element);
	if(result!=-1){
		cout<< "Element is present at index "<<result+1<<"\n";
	}
	else{
		cout<< "Element not found";
	}
	return 0;
}
