
#include <iostream>
using namespace std;

void printSubArray(int* arr,int length){//Kadane.s approch  Time compllexity O(n)




int largestNumber=0 , temp=0;

    for(int i=0;i<length;i++)
   {
         temp=arr[i]+temp;


            if(largestNumber<temp)
            {
                largestNumber=temp;
            }
			
			  if(temp<0)
           {
               temp=0;
           } // Importent because of negative secnario
    }

    cout<<"Largest Number is "<<largestNumber;
}

int main() {

	int arr[] ={-2,3,4,-1,5,-12,6,1,3}; 
    printSubArray(arr,9);
   
	return 0;
}

