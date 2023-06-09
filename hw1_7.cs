Console.WriteLine("Input three-dight number " );
int num1 = int.Parse(Console.ReadLine());
if (num1 > 999 || num1 < 100) {
	Console.Write("It's not the wight format");}
else {
	int C = num1 % 10;
	Console.Write($"The last dight is {C}");}