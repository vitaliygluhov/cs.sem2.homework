
//---------------------------------------------------------------------------------------------------------------------------
// Метод заскладывает число по цифрам в массив
/*
void VGNumToArray(int Input, int[] Arr)
{
    int Count = 0;
    for (int Temp = Input; Temp > 0; Count++)
        Temp = Temp / 10;

    for (int Index = 10, ArrCount = 0; Index <= Math.Pow(10, Count); Index *= 10, ArrCount++)
        Arr[ArrCount] = Input % (Index) / (Index / 10);
}*/
//---------------------------------------------------------------------------------------------------------------------------
// Метод выводит форматированный результат.
void ShowResultMsg(string msg)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Результат: ");
    Console.ResetColor();
    Console.WriteLine($" {msg} \r\n");
}

//---------------------------------------------------------------------------------------------------------------------------
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void VGTask10(int InputNumber, int NumIndex) // вводимое число,  номер цифры из числа (1 ... N). Возвращает значение цифры
{
    int Count = 0;
    for (int Temp = InputNumber; Temp > 0; Count++)
        Temp = Temp / 10;
    int[] Arr = new int[Count];
    for (int Index = 10, ArrCount = 0; Index <= Math.Pow(10, Count); Index *= 10, ArrCount++)
        Arr[ArrCount] = InputNumber % Index / (Index / 10);
    ShowResultMsg($"Введено число {InputNumber}. {NumIndex}-я цифра соответствует значению {Arr[Arr.Length - NumIndex]}");
}
//---------------------------------------------------------------------------------------------------------------------------
//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void VGTask13(int InputNumber, int NumIndex) // вводимое число,  номер цифры из числа (1 ... N). Проверяет на наличие искомой. Возвращает значение цифры, либо -1 в случае ошибки
{
    int Count = 0;
    for (int Temp = InputNumber; Temp > 0; Count++)
        Temp = Temp / 10;
    int[] Arr = new int[Count];
    for (int Index = 10, ArrCount = 0; Index <= Math.Pow(10, Count); Index *= 10, ArrCount++)
        Arr[ArrCount] = InputNumber % Index / (Index / 10);
    if (Arr.Length - NumIndex >= 0)
        ShowResultMsg($"Введено число {InputNumber}. {NumIndex}-я цифра соответствует значению {Arr[Arr.Length - NumIndex]}.");
    else ShowResultMsg($"Введено число {InputNumber}. {NumIndex}-й по счету цифры нет в этом числе.");
}
//---------------------------------------------------------------------------------------------------------------------------
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void VGTask15(int InputNumber) // вводимое число. Выводит в консоль является ли день недели выходным.
{
    if (InputNumber == 6 || InputNumber == 7)
        ShowResultMsg($"День недели под номером {InputNumber} это выходной день.");
    else ShowResultMsg($"День недели под номером {InputNumber} - рабочий день.");
}
//---------------------------------------------------------------------------------------------------------------------------
//--------------------------------    ДОПОЛНИТЕЛЬНЫЕ    ---------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
//Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.
void VGAdditionalTask1(int SideA, int SideB, int SideC) // Выводит в консоль является ли треугольник равнобедренный
{
    if (SideA == SideB || SideB == SideC || SideA == SideC)
        ShowResultMsg($"Треугольник со сторонами {SideA}, {SideB}, {SideC} - равнобедренный");
    else ShowResultMsg($"Треугольник со сторонами {SideA}, {SideB}, {SideC} - Не равнобедренный");
}
//---------------------------------------------------------------------------------------------------------------------------
//Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.
void VGAdditionalTask2(int Day, int Month, int Year)//   Выводит в консоль возраст в полных годах
{
    int YYYY = 2022, MM = 06, DD = 1;
    int Age = YYYY - Year;
    if (MM < Month)
        Age--;
    if (MM == Month)
        if (DD < Day)
            Age--;
    ShowResultMsg($"Возраст человека родившегося {Day}.{Month}.{Year} на момент 1.06.2022 составляет {Age} полных лет");
}

//---------------------------------------------------------------------------------------------------------------------------
//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.
void VGAdditionalTask3(double Deposit, double Rate, int TermInMonths) // Возвращает размер депозита
{
    double DepositCalc = Deposit;
    for (int MonthsIndex = 0; MonthsIndex < TermInMonths; MonthsIndex++)
        DepositCalc *= (1 + (Rate / 100));
    ShowResultMsg($"Вложенная сумма {Deposit} руб. с процентной ставкой {Rate}% через {TermInMonths} месяцев составит {Math.Round(DepositCalc, 2, MidpointRounding.AwayFromZero)} руб.");
}
//---------------------------------------------------------------------------------------------------------------------------
//Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.
void VGAdditionalTask4(int InputNumber)
{
    int Count = 0;

    for (int Temp = InputNumber; Temp > 0; Count++)
        Temp = Temp / 10;
    int[] Arr = new int[Count];
    for (int Index = 10, ArrCount = 0; Index <= Math.Pow(10, Count); Index *= 10, ArrCount++)
        Arr[ArrCount] = InputNumber % (Index) / (Index / 10); // массив заполненяется значениями из натурального числа

    int Min = Arr[0], Max = Arr[0];
    int MinIndex = 0, MaxIndex = 0;
    for (int Index = 0; Index < Count; Index++)
    {
        if (Arr[Index] > Max)
        {
            Max = Arr[Index];
            MaxIndex = Index;
        }
        if (Arr[Index] < Min)
        {
            Min = Arr[Index];
            MinIndex = Index;
        }
    }
    if (MaxIndex > MinIndex)
        ShowResultMsg($"Левее расположено максимальное. Это цифра {Max}.");// - максимальное 
    else ShowResultMsg($"Левее расположено минимальное. Это цифра {Min}."); //  - минимальное 
}
//---------------------------------------------------------------------------------------------------------------------------
// переменные меню
string[] TaskKey = new string[]{"1",
                                "2",
                                "3",
                                "4",
                                "5",
                                "6",
                                "7"
                                };
string[] TaskName = new string[]{"Задача 10",
                                "Задача 13",
                                "Задача 15",
                                "Задача 1",
                                "Задача 2",
                                "Задача 3",
                                "Задача 4"
                                };
string[] TaskDescription = new string[]{"Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.",
                                       "Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.",
                                        "Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным",
                                        "Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.",
                                        "На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.",
                                        "Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1,5% от имеющейся суммы. Определить размер депозита через n месяцев.",
                                        "Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная."
                                };
string[] TaskNote = new string[]{"Введите трехзначное число: ",
                                "Введите число: ",
                                "Введите цифру обозначающую день недели: ",
                                "Введите значения сторон треугольника разделенные пробелами: ",
                                "Введите дату рождения через пробелы (dd mm yyyy): ",
                                "Введите сумму депозита, процентную ставку, и расчетный срок в месяцах через пробелы (пример 1000 1.5 48): ",
                                "Укажите натуральное число: "
                                };

void TaskExecute(int ItemIndex, string[] Arguments)
{
    // Console.WriteLine("debag point 0"); // DEBAG
    switch (ItemIndex)
    {
        case 0:
            VGTask10(Convert.ToInt32(Arguments[0]), 2);
            break;
        case 1:
            VGTask13(Convert.ToInt32(Arguments[0]), 3);
            break;
        case 2:
            VGTask15(Convert.ToInt32(Arguments[0]));
            break;
        case 3:
            VGAdditionalTask1(Convert.ToInt32(Arguments[0]),Convert.ToInt32(Arguments[1]),Convert.ToInt32(Arguments[2]));
            break;
        case 4:
            VGAdditionalTask2(Convert.ToInt32(Arguments[0]),Convert.ToInt32(Arguments[1]),Convert.ToInt32(Arguments[2]));
            break;
        case 5:
           VGAdditionalTask3(Convert.ToDouble(Arguments[0]),Convert.ToDouble(Arguments[1]),Convert.ToInt32(Arguments[2]));
            break;
        case 6:
            VGAdditionalTask4(Convert.ToInt32(Arguments[0]));
            break;
    }
}




// методы оболочки
void MenuItem(string Key, string InemName, string InemDescription)// вывод элементов меню
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(Key);
    Console.ResetColor();
    Console.WriteLine($" - {InemName}: {InemDescription}");
}
void MenuSysItem(string Key, string InemName) // вывод системных пунктов  меню
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(Key);
    Console.ResetColor();
    Console.WriteLine($" - {InemName}");
}
void ShowMainMenu() // отрисовка меню
{
    Console.Clear();
    for (int i = 0; i < TaskKey.Length; i++)
    {
        MenuItem(TaskKey[i], TaskName[i], TaskDescription[i]);
    }
    MenuSysItem("q", "Выход из программы");
    Console.Write("Введите выбраный пункт меню: ");
}

// сообщения
void ShowErrorMsg(string msg)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(msg);
    Console.ResetColor();
}

// отрисовка заданий 
void ShowTask(int ItemIndex)
{

    bool TaskActive = true; // Состояние задачи. если true, значит активна, и будет выполнятся пока состояние не изменится на false
    while (TaskActive) // повторяет задание пока  пользователь выбирает повторить
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(TaskName[ItemIndex]);
        Console.ResetColor();
        Console.WriteLine(TaskDescription[ItemIndex]);
        Console.Write(TaskNote[ItemIndex]);

        string InputText = Console.ReadLine(); // ввод пользовательских данных
        string[] InputWords = InputText.Split(" "); // парсинг введенного текста. раскладываем строку на слова
        TaskExecute(ItemIndex, InputWords);// вызывается выполнение задачи
        //tmp


        // Exit Dialog
        bool ExitDialogActive = true;
        while (ExitDialogActive) // удерживает пользователя в меню выхода пока не будет выбран один из предусмотренных пунктов.
        {
            Console.WriteLine("Выберите действие");
            MenuSysItem("r", "Повторить выполнение задания");
            MenuSysItem("m", "Вернуться в главное меню");
            MenuSysItem("q", "Завершить программу");
            Console.Write("Введите выбраный пункт: ");

            string SlectItem = Console.ReadLine().ToLower();
            if (SlectItem == "r")
            {
                TaskActive = true;
                ExitDialogActive = false;
            }
            else if (SlectItem == "m")
            {
                TaskActive = false;
                ExitDialogActive = false;
                ShowMainMenu();
            }
            else if (SlectItem == "q")
            {
                Console.Clear();
                System.Environment.Exit(0);
            }
        }
    }

}
//======================================================================================================================
ShowMainMenu(); // выводим главное меню
while (true) // выполняется пока пользователь не завершит программу 
{
    string SlectItem = Console.ReadLine(); // обработка выбора меню
    SlectItem = SlectItem.ToLower();

    if (SlectItem != "q")
    {
        int SlectItemInt; //проверка  - является ли введенное значение числом
        if (int.TryParse(SlectItem, out SlectItemInt) == true && SlectItemInt <= TaskKey.Length && SlectItemInt > 0)
        {
            ShowTask(SlectItemInt - 1); // вызываем страницу задания
        }
        else
        {
            ShowErrorMsg("Введен неверный пункт меню. попробуйте еще раз: ");
        }
    }
    else
    {
        Console.Clear();
        System.Environment.Exit(0);
    }
}
