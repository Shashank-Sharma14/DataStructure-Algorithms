
#include <iostream>
using namespace std;

int linearSearch(int arr[] , int length, int searchElemant){
     
  for(int i=0;i<length;i++){
	  if(arr[i]==searchElemant){
		  return i;
	  }
}
  return -1;

}

int main() {
	// your code goes here
	int arr[] ={1,2,3,4,6,5},element,result;   // O(n)time complexity 
	cin>>element;
	result=linearSearch(arr,6,element);
	if(result!=-1){
		cout<< "Element is present at index "<<result +1<<"\n";
	}
	else{
		cout<< "Element not found";
	}
	return 0;
}
