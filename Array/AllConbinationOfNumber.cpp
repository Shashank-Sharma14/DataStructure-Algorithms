
#include <iostream>
using namespace std;

void printAllPair(int* arr,int length){
    for(int i=0;i<length;i++){
        for(int j=i+1;j<length;j++){
            cout<<arr[i]<<","<<arr[j]<<endl;
        }
        cout<<endl;
    }
}

int main() {
	int arr[] ={10,20,30,40,50,60}; 
    printAllPair(arr,6);
   
	return 0;
}

