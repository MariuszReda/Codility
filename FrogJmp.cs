#include <iostream>
#include<math.h>
int solution(int X, int Y, int D) {
    double i;
    i = (double)(Y - X) / D;
    return ceil(i);
}