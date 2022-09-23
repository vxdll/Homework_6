//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
Console.WriteLine("Начните ввод чисел, для остановки ввода используйте слово 'stop': ");
string? input = string.Empty;
int count = 0;
int num;

while (true){
    input = Console.ReadLine();
    if(input != "stop" ){
        num = Convert.ToInt32(input);
        if (num > 0){
            count = count + 1;
        }
    } else if (input == "stop"){
        Console.WriteLine($"Чисел больше 0 -> {count}");
        break;
    }
}
