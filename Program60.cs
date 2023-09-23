// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
//
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


    int[,,] threeDimArray = new int[2, 2, 2];
    bool[] usedNumbers = new bool[100]; // Для отслеживания использованных чисел

        Random rand = new Random();

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    int number;

                    do
                    {
                        number = rand.Next(10, 100); // Генерируем двузначное число
                    } while (usedNumbers[number]);

                    usedNumbers[number] = true;
                    threeDimArray[i, j, k] = number;

                    Console.Write($"{number}({i},{j},{k}) ");
                }
                Console.WriteLine(); // Переход к следующей строке
            }
            Console.WriteLine(); // Пустая строка между блоками
        }
        


    