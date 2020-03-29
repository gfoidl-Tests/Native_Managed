#include "math.h"
//-----------------------------------------------------------------------------
int add(const int a, const int b)
{
    return a + b;
}
//-----------------------------------------------------------------------------
int sum(const int* arr, const int len)
{
    int res = 0;

    for (int i = 0; i < len; ++i)
    {
        res += arr[i];
    }

    return res;
}
