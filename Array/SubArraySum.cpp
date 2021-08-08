
#include <iostream>
using namespace std;

void printSubArray(int* arr,int length){//BruteForce approch

int largestNumber=0 , temp=0;
    for(int i=0;i<length;i++){
        for(int j=i+1;j<length;j++){
            temp=0;
            //cout<<arr[i]<<","<<arr[j]<<endl;
              cout<<"[ ";
            for(int k=i;k<j;k++){
                cout<<arr[k]<<" ";
                temp +=arr[k];
            }
            if(largestNumber<temp){
                largestNumber=temp;
            }
             cout<<"]"<<endl;
        }
        cout<<endl;
    }
    cout<<"Largest Number is "<<largestNumber;
}

int main() {
	int arr[] ={-2,3,4,-1,5,-12,6,1,3}; 
    printSubArray(arr,9);
   
	return 0;
}

