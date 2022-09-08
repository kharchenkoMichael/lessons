int[] arrays = { 1, 2, 3, 2, 3 };
int ellement = 5;

int[] result = new int[arrays.Length + 1];
for (int i =0; i < arrays.Length; i++)
{
    result[i] = arrays[i];
}



result[result.Length - 1] = ellement;





for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}