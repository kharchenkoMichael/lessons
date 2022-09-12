//int[] array = { 1, 2, 3, 1 };
//int value = 4;


//int[] GetSum(int[] array, int value)
//{
//    int[] result = new int[2];
//    for(int i = 0; i < array.Length; i++)   
//    {
//     int temp = 
//    }
//    return result;
//}

int FibonachiLoop(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }

    int result = 0;
    int prev1 = 1, prev2 = 0;
    for (int i = 2; i < n; i++)
    {
        result = prev2 + prev1;
        prev2 = prev1;
        prev1 = result;
    }

    return result;
}








