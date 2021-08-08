
#include <iostream>
using namespace std;

void printSubArray(int* arr,int length){//Prefix approch  Time compllexity O(n^2)

//Prifix Sum
int prifixArr[length]={0};
prifixArr[0]=arr[0];
for(int i=1;i<length;i++)
{

prifixArr[i] = prifixArr[i-1] + arr[i];

}



int largestNumber=0 , temp=0;

    for(int i=0;i<length;i++){

        for(int j=i+1;j<length;j++){

           temp= i>0 ? prifixArr[j]-prifixArr[i-1] : prifixArr[j];

            if(largestNumber<temp)
            {
                largestNumber=temp;
            }

             
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

