#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int result(vector<int>&A)
{
	sort(A.begin(), A.end());
	for (int i = 0; i < A.size(); i++)
	{
		if (i % 2) 
		{
			if (A[i] != A[i+1])
			{
				return A[i];
			}
		}
	}	
}

int solution(vector<int> &A) {
	int n;

	int max = 1000000;
	int max1 = 1000000000;

		cin >> n;

		if (n % 2)
			n = n;
		else
			n = n + 1;

	//vector <int> A;
	for (int i = 0; i < n;)
	{
		unsigned x;
		cin >> x;
		if (x < max1)
		{
			A.push_back(x);
			i++;
		}
	}
	result(A);
}
