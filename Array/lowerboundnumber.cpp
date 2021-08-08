#include <iostream>
#include <vector>
using namespace std;

int lowerBound(vector<int> A, int Val) {

    // your code goes here

    int s = 0;

    int e = A.size() - 1;


    while (s <= e) {

        int mid = (s + e) / 2;

        if (A[mid] == Val) {

            return A[mid];

        }

        else if (A[mid] < Val) {

            s = mid + 1;

        }

        else {

            e = mid - 1;

        }

    }
//    cout << A[s] << " , " << A[e];

    if (A[e] > Val) {

        return A[e - 1];

    }

    else if (Val > A[e]) {

        return A[e];

    }

    else {

        return -1;

    }

}
int main() {
	// your code goes here
   vector<int> arr={1,3,4,5,8,9};
   int lowerBoundNumber;
   cin>>lowerBoundNumber;

   cout << lowerBound(arr, lowerBoundNumber);

	return 0;
}


