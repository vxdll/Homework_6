//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// * Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.WriteLine ("Введите длину стороны AB: ");
int ab = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите длину стороны BC: ");
int bc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите длину стороны AC: ");
int ac = Convert.ToInt32(Console.ReadLine());

if ( ac < ab + bc){
    if ( ab < ac + bc){
        if (bc < ac + ab){
            Console.WriteLine($"Треугольник ABC, где АВ = {ab}, BC = {bc}, AC = {ac} -> существует! ");
        } else{
            Console.WriteLine("Треугольник с заданными сторонами не существует!");
        }
        
    } else{
        Console.WriteLine("Треугольник с заданными сторонами не существует!");
    }
} else{
    Console.WriteLine("Треугольник с заданными сторонами не существует!");
}