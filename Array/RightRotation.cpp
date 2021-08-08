void reversed(vector<int> &a, int start, int end) {
    while (start < end) {
        int temp = a[end];
        a[end] = a[start];
        a[start] = temp;

        start++;
        end--;
    }
}

   vector<int> kRotate(vector<int> &a, int k) {

    int start = 0, end = a.size();
    reversed(a, start, end - k - 1);
    reversed(a, end - k, end - 1);
    reversed(a, start, end - 1);

    return a;
   }

int main() {
     vector <int> arr = { 1,2,3,4,5};
     kRotate(arr, 1);
     for (int a : arr) {
         cout << a<< endl;
     }
}
