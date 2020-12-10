using System;
using MainController._2_nd_lb_classes;
using MainController._2_nd_lb_classes.Point_and_Figure;

namespace MainController
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] examples = { "Adress", "Rectangle", "Book", "Point and Figure", "User", "Converter", "Employee", "Invoice" };
            while (true)
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Перечень заданий");
                for (int i = 0; i < examples.Length; i++)
                    Console.WriteLine((i + 1) + ". " + examples[i]);
                Console.WriteLine(new string('-', 30));
                Console.Write("Введите номер задания: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(new string('-', 30));
                switch (n)
                {
                    case 1:
                        #region 1-е Задание
                        Adress MyAdress = new Adress(93105, "Ukraine", "Mykolaiv", "Soviet", 35, 25);
                        MyAdress.ShowInfo();
                        #endregion
                        break;
                    case 2:
                        #region 2-е Задание
                        Rectangle MyRectangle = new Rectangle(3488.466, 15.12);

                        Console.WriteLine($"Perimeter: {MyRectangle.Perimeter}");
                        Console.WriteLine($"Area: {MyRectangle.Area}");
                        #endregion
                        break;
                    case 3:
                        #region 3-е Задание
                        Book MyBook = new Book(
                            new Title("Язык программирования C++. Лекции и упражнения"),
                            new Author("Стивен Прата"),
                            new Content("Руководство по программированию"));

                        MyBook.Show();
                        #endregion
                        break;
                    case 4:
                        #region 4-е Задание
                        Figure figure = new Figure(
                            new Point(3, 5, "A"),
                            new Point(5, 2, "B"),
                            new Point(21, 32, "C"),
                            new Point(48, 177, "D"),
                            new Point(-498, 174, "E"));
                        figure.Perimeter();
                        #endregion
                        break;
                    case 5:
                        #region 5-е Задание
                        User MyUser = new User("User1234", "Yuri", "Olegovich", 18, "21.10.2020");
                        MyUser.ShowInfo();
                        #endregion
                        break;
                    case 6:
                        #region 6-е Задание
                        Converter converter = new Converter(10, 10, 10, 28);
                        converter.ValueConverter();
                        #endregion
                        break;
                    case 7:
                        #region 7-е Задание
                        Employee employee = new Employee("Владимир", "Резнов");
                        employee.GetInfo();
                        #endregion
                        break;
                    case 8:
                        #region 8-е Задание
                        Invoice invoice = new Invoice(16847, "Yuri", "IBM");
                        invoice.Price();
                        #endregion
                        break;
                    default:
                        Console.WriteLine("Введите другую цифру");
                        return;
                }
                Console.WriteLine(new string('-', 30));
                Console.Write(
                    $"Для продолжения нажмите ENTER\n" +
                    $"Для выхода введите -Q или -q \n--> ");
                string quit = Console.ReadLine();
                if (quit == "Q" || quit == "q")
                    break;
            }

        }
    }
}
