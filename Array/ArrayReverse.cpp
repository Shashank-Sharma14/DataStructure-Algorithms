
#include <iostream>
using namespace std;

int main() {
	int arr[] ={10,20,30,40,50,60}; //Time Complexity = O(n)
    int start=0,end=5;
    while(start<end){
        swap(arr[start],arr[end]);
        start++;
        end--;
    }
    for(int i=0;i<6;i++){
        cout<<arr[i]<<" ";
    }
	return 0;
}
