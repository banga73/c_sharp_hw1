Console.WriteLine("Input number " );
int num1 = int.Parse(Console.ReadLine());
int N = 2;
while (N < (num1 - 1)){
	Console.Write($"{N}, ");
	N = N + 2;};
Console.Write(N);