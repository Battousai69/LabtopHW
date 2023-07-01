//Задача23
/*System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i <= n; i++)
{
    System.Console.WriteLine(i*i*i);
}*/

//Задача19
/*int Polindrom (int num1, int num2, int num3, int num4, int num5)
{
    if(num1 == num5 && num2 == num4)
    {
        System.Console.WriteLine("Данное число является полиндроном");
    }
    else
    {
        System.Console.WriteLine("Данное число не является полиндроном");
    }
    return 0;
}
System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int num1 = (a/10000) % 10;
int num2 = (a/1000) % 10;
int num3 = (a/100) % 10;
int num4 = (a/10) % 10;
int num5 = a % 10;
System.Console.WriteLine(Polindrom( num1,  num2, num3,  num4, num5));*/

//Задача21
/*double d (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
System.Console.WriteLine("Введите x1");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите x2");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите y1");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите y2");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите z1");
double z1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите z2");
double z2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine(d(x1, y1, z1, x2, y2, z2));*/


//Задача25
/*int SqA ( int a, int B )
{
    int A = a;
    for (int i = 1; i < B; i ++)
    {
        a = a * A;
    }
    return a;
}
System.Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SqA(A, B));*/


//Задача27
/*int Sum (int a)
{
    int sum = 0;
    do
    {
        int num = a % 10;
        a = a / 10;
        sum = sum + num;  
    } while (a > 0);

    return sum;
}
System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Сумма чисел равна");
System.Console.WriteLine(Sum(a));*/

//Задача29
/*int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for( int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for ( int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Укажите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение массива");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение");
int maxValue = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateArray(size, minValue, maxValue));*/

//Задача 34
/*int[] CreateArray(int size)
{
    int[] array = new int[size];
    for( int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = 0;
    for ( int i = 0; i < array.Length; i++)
    {
        {
            System.Console.Write(array[i] + " ");
        }
        if(array[i] % 2 == 0)
        {
            count++;
        }
    
    }
    System.Console.WriteLine($"Колличество четных чисел в массиве {count}");
}

System.Console.WriteLine("Укажите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateArray(size));*/

//Задача36
/*int[] CreateArray(int size)
{
    int[] array = new int[size];
    for( int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    int sum = 0;
    for ( int i = 0; i < array.Length; ++i )
    {
        {
            System.Console.Write(array[i] + " ");
        }
    if(array[i] % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    System.Console.WriteLine($"Сумма не четных членов массива равна {sum}");
}

System.Console.WriteLine("Укажите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateArray(size));*/

//Задача 38
/*double[] CreateArray(int size)
{
    double[] array = new double[size];
    for( int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000))/100;
    }
    return array;
}

void PrintArray(double[] array)
{
    double max = Int32.MinValue;
    double min = Int32.MaxValue;
    for ( int i = 0; i < array.Length; i++)
    {
            {
                System.Console.WriteLine(array[i] + " ");
            }
        if (array[i] > max)
            {
                max = array[i];
            }
        if (array[i] < min)
            {
                min = array[i];
            }   
     
    }
    System.Console.WriteLine($"Разница между = {(max - min), 2} ");
}

System.Console.WriteLine("Укажите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateArray(size));*/