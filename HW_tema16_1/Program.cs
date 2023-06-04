//создаем 2мерный массив размером 3х3

Random random = new Random(); //добавляем рандом для возможности дальнейшего
                              //заполнения масиива случайными числами

int[,] arr = new int[3, 3];

for (int i = 0; i < arr.GetLength(0); i++) //цикл для заполнения массива случайными элементами
{
    for(int j=0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(0, 21); //от 0 до 20 по условию

        Console.Write(arr[i, j]+"\t"); //вывод массива на экран
    }
    Console.WriteLine();
}

int rows=0, cols=0;

while (true) //создаем цикл
{
    Console.WriteLine("Введите координаты элемента, который вы хотите заменить.");

    Console.Write("Строка: ");

    rows = int.Parse(Console.ReadLine()); //для строки

    Console.Write("Колонка: ");

    cols = int.Parse(Console.ReadLine()); //для колонки

    if (rows > 3 || cols > 3) Console.WriteLine("Недопустимые значения координат! Повторите ввод!"); //проверка условия
                                                                                                    //чтобы не выйти за пределы памяти
    else //если наши координаты прошли проверку, то мы переходим в цикл, где будет осиществлена
    //замена элемента массива на необходимы пользователю.
    {
        Console.Write("На какое значение Вы хотите заменить? Введите число: ");

        int number = int.Parse(Console.ReadLine()); //запись элемента, на который будем менять

        for (int i = 0; i < arr.GetLength(0); i++) 
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[rows - 1, cols - 1] = number; //введеный пользователем элемент заменяется по указанным пользователем координатам

                Console.Write(arr[i, j] + "\t"); //вывод массива на экран
            }
            Console.WriteLine();
        }
        break; //при выполнении обрываем.
    }
}

