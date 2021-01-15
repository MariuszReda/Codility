/*An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.

Your goal is to find that missing element.

Write a function:

int solution(vector<int> &A);

that, given an array A, returns the value of the missing element.

For example, given array A such that:

  A[0] = 2
  A[1] = 3
  A[2] = 1
  A[3] = 5
the function should return 4, as it is the missing element.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..100,000];
the elements of A are all distinct;
each element of array A is an integer within the range [1..(N + 1)].
*/
    
#include <algorithm>
int solution(vector<int> &A) {
    sort(A.begin(), A.end());
    int j = 1;
    for (auto i : A)
        if (i == j)
            j++;
    return j;
}

#include <algorithm>
int solution(vector<int> &A) {
sort(A.begin(), A.end());
    int j = A[0];
    for (int i = 0; i < A.size(); ++i)
    {
        if(A[i] != j)
        {
            j = A[i];
            return j -1;
        }
        j++;
    }
    return 0;
 }   
