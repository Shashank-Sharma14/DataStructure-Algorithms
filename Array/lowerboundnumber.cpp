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
   

    if (A[s] > Val && s==0) {

        return A[e - 1];// when all elements are greater than Val

    }
   else {

        return A[e];

    }

    

}
int main() {
    // your code goes here
    vector<int> arr = { 1,3,4,5,8,9 };
    int lowerBoundNumber;
    cin >> lowerBoundNumber;

    cout << lowerBound(arr, lowerBoundNumber);

    return 0;
}
