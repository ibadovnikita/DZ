int num,r,sum=0,t;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
{
for(t=num;num!=0;num=num/10)
{
r=num % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} Палиндром");
else
Console.Write($"{t} не палиндромом.");
} else
Console.Write("Это не пятизначное число! ");
