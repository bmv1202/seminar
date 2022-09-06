// Напишите программу, каторая на вход принимает два числа и выдает какое большее, а какое меньшее

        {
            Console.WriteLine("Вводим 2 числа и узнаем какое из них больше");
            int a, b;
            Console.WriteLine("Вводим первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводим второе число - ");
            b = Convert.ToInt32(Console.ReadLine());

            bool Chto0 = a > b;
            bool Chto1 = a == b;
            bool Chto2 = a < b;

            if (Chto0)
            {
                Console.WriteLine($"Число {a} больше чем {b}");
            }
            else if (Chto1)
            {
                Console.WriteLine($"Числа {a} и {b} равны");
            }
            else
            {
                Console.WriteLine($"Число {b} больше чем {a}");
            }}
