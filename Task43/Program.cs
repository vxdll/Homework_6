/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1
 y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.*/

Console.WriteLine ("Введите значение k1: ");
float yk1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение b1: ");
float yb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение k2: ");
float yk2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение b2: ");
float yb2 = Convert.ToInt32(Console.ReadLine());

if (yk1 == yk2 & yb1 == yb2){
    Console.WriteLine("При указанных k1, b1 и k2, b2 прямые будут совпадать!");
} else if (yk1 == yk2 )
{
    Console.WriteLine("При указанных k1 и k2 прямые не будут иметь точек пересечения, прямые параллельны!");
} else {
    // Нахождения ОХ точки пересечения:
    float ox = (yb2 - yb1) / (yk1 - yk2);
    // Нахождения ОY точки пересечения:
    float oy = (yk1 * yb2 - yk2 * yb1) / (yk1 - yk2);
    Console.WriteLine($"Точка пересечения имеет координату -> ({ox}, {oy})");
}
