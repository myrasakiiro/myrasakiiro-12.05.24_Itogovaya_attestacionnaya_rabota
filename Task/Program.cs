// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []




void Main(string[] args)
    {
        // Примеры тестовых данных
        string[][] tests = new string[][] {
            new string[] {"Hello", "2", "world", ":-)"},
            new string[] {"1234", "1567", "-2", "computer science"},
            new string[] {"Russia", "Denmark", "Kazan"}
        };

        // Обработка тестовых данных и вывод результатов
        foreach (string[] test in tests)
        {
            string[] result = FilterShortStrings(test);
            Console.WriteLine("Исходный массив: [" + string.Join(", ", test) + "]");
            Console.WriteLine("Новый массив: [" + string.Join(", ", result) + "]\n");
        }
    }
    string[] FilterShortStrings(string[] strings)
    {
        int count = 0;
        // Подсчитываем количество строк, удовлетворяющих условию
        foreach (string str in strings)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] result = new string[count];
        int index = 0;
        // Заполняем новый массив строками, удовлетворяющими условию
        foreach (string str in strings)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
    Main();