using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace OOP
{
    //Создать класс игрока, с полями, содержащими информацию
    //об игроке и методом, который выводит информацию на экран.
    //В классе обязательно должен быть конструктор.

    //class Character
    //{
    //    private float healthCharacter = 100f;
    //    private float armorBar = 100f;
    //    private float damageCharacter = 10f;
    //    private float speedMove = 20f;
    //    private string namePerson = "Dark";

    //    public void showInfo()
    //    {
    //        Console.WriteLine($"Здоровье - {healthCharacter}");
    //        Console.WriteLine($"Броня - {armorBar}");
    //        Console.WriteLine($"Урон - {damageCharacter}");
    //        Console.WriteLine($"Скорость - {speedMove}");
    //        Console.WriteLine($"Имя - {namePerson}");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Character character = new Character();
    //        character.showInfo();
    //    }
    //}
    //------------------------------------------------------------------------


    // Работа со свойствами
    //Создать класс игрока, у которого есть поля с его положением в x, y.
    //Создать класс отрисовщик, с методом, который отрисует игрока.
    //Попрактиковаться в работе со свойствами.

    class CharacteOne
    {
        //    private int xPosition = 2;
        //    private int yPosition = 4;
        //    public int ReturnPositionX { get { return xPosition; } set { xPosition = value; } }
        //    public int ReturnPositionY { get { return yPosition; } set { yPosition = value; } }
        //}

        //class PositionPlayer
        //{
        //    public static CharacteOne characteOne = new CharacteOne();
        //    public static int ReturnPositionX { get { return characteOne.ReturnPositionX; } }
        //    public static int ReturnPositionY { get { return characteOne.ReturnPositionY; } }

        //    private static void Rendering()
        //    {
        //        characteOne.ReturnPositionX = ReturnPositionX;
        //        characteOne.ReturnPositionY = ReturnPositionY;
        //        int[,] mapArray = new int[10, 10];

        //        while (true)
        //        {
        //            Console.Clear();
        //            for (int i = 0; i < mapArray.GetLength(0); i++)
        //            {
        //                for (int j = 0; j < mapArray.GetLength(1); j++)
        //                {
        //                    Console.Write(mapArray[i, j] + " ");
        //                }
        //                Console.WriteLine();
        //            }

        //            Console.SetCursorPosition(ReturnPositionX, ReturnPositionY);
        //            Console.WriteLine("$");
        //            Thread.Sleep(1000);
        //        }
        //    }

        //    private static void Main(string[] args)
        //    {
        //        Rendering();
        //    }
    }

    //База данных игроков
    //Реализовать базу данных игроков и методы для работы с ней.
    //У игрока может быть уникальный номер, ник, уровень, флаг – забанен ли он(флаг - bool).
    //Реализовать возможность добавления игрока, бана игрока по уникальный номеру,
    //разбана игрока по уникальный номеру и удаление игрока.
    //Создание самой БД не требуется, задание выполняется инструментами, которые вы уже изучили в рамках курса.
    //Но нужен класс, который содержит игроков и её можно назвать "База данных".

    class DataBase
    {
        static void Main(string[] args)
        {
            int levelPlayer = 0;
            int minLevelPlayer = 1;
            int maxLevelPlayer = 100;
            int newIndex = 0;
            int specialNumber = 0;
            int specialNumberMin = 111111;
            int specialNumberMax = 999999;

            bool blockUser = false;

            string blockUserComand = "блокировать";
            string exitProgram = "выход";

            DataPerson(newIndex, specialNumber, specialNumberMin, specialNumberMax, blockUser,
                levelPlayer, minLevelPlayer, maxLevelPlayer, blockUserComand, exitProgram);
        }

        static void DataPerson(int newIndex, int specialNumber, int specialNumberMin, int specialNumberMax,
            bool blockUser, int levelPlayer, int minLevelPlayer, int maxLevelPlayer,
            string blockUserComand, string exitProgram)
        {
            Console.WriteLine("Введите количество игроков:");
            string playerMany = Console.ReadLine().ToLower();
            if (int.TryParse(playerMany, out int howMuchPlayer))
                Console.WriteLine("Введите 'Выход' для выхода из системы.");
            Console.WriteLine("Введите 'Блокировать'. Выберите игрока для блокировки по индивидуальному номеру.");
            Console.WriteLine("Введите свой Ник:");
            while (true)
            {
                LinkedList<int> listNumber = new LinkedList<int>();
                int[] inputUserArray = new int[howMuchPlayer];
                Random random = new Random();
                string arrayName = Console.ReadLine().ToLower();

                if (arrayName == exitProgram)
                {
                    Console.WriteLine("Выход из программы. Ожидайте...");
                    Thread.Sleep(1000);
                    break;
                }

                else if (arrayName == blockUserComand)
                {
                    Console.WriteLine(listNumber.Count);
                }

                else
                {
                    specialNumber = random.Next(specialNumberMin, specialNumberMax);
                    levelPlayer = random.Next(minLevelPlayer, maxLevelPlayer);
                    Console.WriteLine($"Ник: {arrayName}. Индивидуальный номер: {specialNumber}. Статус блокировки: {blockUser}. Уровень игрока {levelPlayer}");
                    listNumber.AddLast(specialNumber);
                }
            }
        }
    }
}