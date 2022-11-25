// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] FillCoord(){

    double[] arr = new double[3];
        Console.Write("X: ");
        arr[0] = double.Parse(Console.ReadLine());

        Console.Write("Y: ");
        arr[1] = double.Parse(Console.ReadLine());

        Console.Write("Z: ");
        arr[2] = double.Parse(Console.ReadLine());

    return arr;
}

double distance(double[] pointA, double[] pointB){

    double dist = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + 
                            Math.Pow(pointA[1] - pointB[1], 2) + 
                            Math.Pow(pointA[2] - pointB[2], 2));

    return dist;
}

Console.Clear();

Console.WriteLine("Введите координаты точки А");
double[] pointA = FillCoord();
Console.WriteLine();

Console.WriteLine("Введите координаты точки B");
double[] pointB = FillCoord();
Console.WriteLine();

//Console.WriteLine(String.Join(", ", pointA));
//Console.WriteLine(String.Join(", ", pointB));

Console.WriteLine($"Расстояние - {Math.Round(distance(pointA, pointB),2)}");
Console.WriteLine();