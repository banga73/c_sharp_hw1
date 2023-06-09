Console.WriteLine("Input number 1" );
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input number 2" );
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Input number 3" );
int num3 = int.Parse(Console.ReadLine());
if (num1 >= num2){
	if (num1 >= num3) {Console.Write(num1);}
	else {Console.Write(num3);};}
else {
	if (num2 >= num3) {Console.Write(num2);}
	else  {Console.Write(num3);};}