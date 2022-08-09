Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = N * (-1);
while (N > 0 && M <= N)
{
	Console.Write(M +" ");
	M++;
}
while (N<=0 && N <=M)
{
	Console.Write(N + " ");
	N++;
}
