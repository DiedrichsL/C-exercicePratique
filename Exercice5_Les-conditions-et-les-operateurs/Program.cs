using System.ComponentModel.Design;

int num1, num2, num3 = 0;

Console.WriteLine("Saisis 3 nombres entier");
num1= int.Parse(Console.ReadLine());
num2= int.Parse(Console.ReadLine());
num3= int.Parse(Console.ReadLine());

if (num1 >= num2 && num1 >=num3)
{
    Console.WriteLine(num1);
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine(num3);
}
