
namespace Тортики
{
    internal class cake
    {
        public string[] Menu(int cenai, string chek, int cenada)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Кондитерская 'Сладкая мечта'. Заказ: ");
            string cena = "0";
            int cen = 9;
            Console.SetCursorPosition(0, cen);
            Console.WriteLine(cenada);
            Console.SetCursorPosition(0, cen - 1);
            Console.WriteLine("----------------------");
            Console.SetCursorPosition(0, cen+1);
            string b = Texti();
            int p = 1;
            int d = Strelki(p, b, cenai, chek, cenada, cen);
            Console.Clear();
            string cenaci = "";
            if (d == 1)
            {
                b = Forma();
                p = 1;
                cen = 7;
                int ce =Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();
                
                if (ce == 1)
                {
                    cenaci = "Круглый - 200; ";
                    cena = "200";
                    
                }
                if (ce == 2)
                {
                    cenaci = "Квадратный - 300; ";
                    cena = "300";
                }
                if (ce == 3)
                {
                    cenaci = "Прямоугольный - 400; ";
                    cena = "400";
                }
                if (ce == 4)
                {
                    cenaci = "Сердце - 500; ";
                    cena = "500";
                }
                if (ce == 5)
                {
                    cenaci = "Единорог - 600; ";
                    cena = "600";
                }
            }
            if (d == 2)
            {
                b = Razmer();
                p = 1;
                cen = 6;
                int ce = Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();

                if (ce == 1)
                {
                    cenaci = "Маленький (10 см) - 100; ";
                    cena = "100";

                }
                if (ce == 2)
                {
                    cenaci = "Средний (15 см) - 200; ";
                    cena = "200";
                }
                if (ce == 3)
                {
                    cenaci = "Большой (20 см) - 300; ";
                    cena = "300";
                }
                if (ce == 4)
                {
                    cenaci = "Огромный (30 см) - 400; ";
                    cena = "400";
                }
            }
            if (d == 3)
            {
                b = Vkus();
                p = 1;
                cen = 7;
                int ce = Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();
                int cenak = 0;
                if (ce == 1)
                {
                    cenaci = "Молочный - 100 ";
                    cenak = 100;

                }
                if (ce == 2)
                {
                    cenaci = "Шоколадный - 200 ";
                    cenak = 200;
                }
                if (ce == 3)
                {
                    cenaci = "Клубничный - 300 ";
                    cenak = 300;
                }
                if (ce == 4)
                {
                    cenaci = "Фруктовый - 400 ";
                    cenak = 400;
                }
                if (ce == 5)
                {
                    cenaci = "Желе - 50 ";
                    cenak = 50;
                }
                b = Korji();
                cen = cen - 1;
                int kurs = Strelki(p, b, cenai, chek, cenada, cen);
                if (kurs == 1)
                {
                    cenaci = cenaci + "* 1;";
                    cena = Convert.ToString(cenak * 1);
                }
                if (kurs == 2)
                {
                    cenaci = cenaci + "* 2;";
                    cena = Convert.ToString(cenak * 2);
                }
                if (kurs == 3)
                {
                    cenaci = cenaci + "* 3;";
                    cena = Convert.ToString(cenak * 3);
                }
                if (kurs == 4)
                {
                    cenaci = cenaci + "* 4;";
                    cena = Convert.ToString(cenak * 4);
                }
                Console.Clear();
            }
            if (d == 4)
            {
                b = Glazur();
                p = 1;
                cen = 6;
                int ce = Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();

                if (ce == 1)
                {
                    cenaci = "Молочная глазурь - 100; ";
                    cena = "100";

                }
                if (ce == 2)
                {
                    cenaci = "Шоколадная глазурь - 100; ";
                    cena = "100";
                }
                if (ce == 3)
                {
                    cenaci = "Клубничная глазурь - 100; ";
                    cena = "100";
                }
                if (ce == 4)
                {
                    cenaci = "Цветная глазурь - 50; ";
                    cena = "50";
                }
            }
            if (d == 5)
            {
                b = Posipka();
                p = 1;
                cen = 6;
                int ce = Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();

                if (ce == 1)
                {
                    cenaci = "Радужная - 20; ";
                    cena = "20";

                }
                if (ce == 2)
                {
                    cenaci = "Фигурная - 50; ";
                    cena = "50";
                }
                if (ce == 3)
                {
                    cenaci = "Шарики - 50; ";
                    cena = "50";
                }
                if (ce == 4)
                {
                    cenaci = "Блестящая - 100; ";
                    cena = "100";
                }
            }
            if (d == 6)
            {
                b = Decor();
                p = 1;
                cen = 10;
                int ce = Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();

                if (ce == 1)
                {
                    cenaci = "Фигурка единорога - 200; ";
                    cena = "200";

                }
                if (ce == 2)
                {
                    cenaci = "Фигурка собаки - 200; ";
                    cena = "200";
                }
                if (ce == 3)
                {
                    cenaci = "Фигурка сердечка - 200; ";
                    cena = "200";
                }
                if (ce == 4)
                {
                    cenaci = "Иная фигурка на заказ - 350; ";
                    cena = "350";
                }
                if (ce == 5)
                {
                    cenaci = "Надпись шоколадом - 100; ";
                    cena = "100";
                }
                if (ce == 6)
                {
                    cenaci = "Ягоды - 50; ";
                    cena = "50";
                }
                if (ce == 7)
                {
                    cenaci = "Ягоды в желе - 150; ";
                    cena = "150";
                }
                if (ce == 8)
                {
                    cenaci = "Печать на торте - 100; ";
                    cena = "100";
                }
            
            }
            if (d == 7)
            {
                cena = "123";
                cenaci = "";
            }
            string[] cenac = new string[] { cenaci, cena };
            return cenac;

        }
        private string Texti()
        {
            
            Console.SetCursorPosition(2, 1);
            return "Форма коржа \n  Размер коржа  \n  Вкус коржа  \n  Глазурь \n  Посыпка  \n  Декор \n  Закончить заказ";
        }
        private string Forma()
        {
            Console.SetCursorPosition(0, 0);
            return "Круг - 200 \n  Квадрат - 300  \n  Прямоугольник - 400  \n  Сердце - 500  \n  Единорог - 600";
        }
        private string Razmer()
        {
            Console.SetCursorPosition(0, 0);
            return "Маленький (10 см) - 100 \n  Средний (15 см) - 200  \n  Большой (20 см) - 300  \n  Огромный (30 см) - 400";
        }
        private string Vkus()
        {
            Console.SetCursorPosition(0, 0);
            return "Молочный - 100 \n  Шоколадный - 200  \n  Клубничный - 300  \n  Фруктовый - 400  \n  Желе - 50";
        }
        private string Korji()
        {
            return "1 корж - прежняя цена \n  2 коржа - *2  \n  3 коржа - *3  \n  4 коржа - *4";
        }
        private string Glazur()
        {
            Console.SetCursorPosition(0, 0);
            return "Молочная глазурь - 100 \n  Шоколадная глазурь - 100  \n  Клубничная глазурь - 100  \n  Цветная глазурь - 50";
        }
        private string Posipka()
        {
            Console.SetCursorPosition(0, 0);
            return "Радужная - 20 \n  Фигурная - 50  \n  Шарики - 50  \n  Блестящая - 100";
        }
        private string Decor()
        {
            Console.SetCursorPosition(0, 0);
            return "Фигурка единорога - 200 \n  Фигурка собаки - 200  \n  Фигурка сердечка - 200 \n  Иная фигурка на заказ - 350  \n  Надпись шоколадом - 100 \n  Ягоды - 50 \n  Ягоды в желе - 150 \n  Печать на торте - 100";
        }

        public int Strelki(int p, string b, int cenai, string chek, int cenada, int cen)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Кондитерская 'Сладкая мечта'. Заказ: ");
            int pi = 1;
            Console.SetCursorPosition(2, 1);
            Console.WriteLine(b);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            Console.SetCursorPosition(0, cen + 1);
            Console.WriteLine(chek);
            Console.SetCursorPosition(0, cen);
            Console.WriteLine("Цена: "+cenada);
            Console.SetCursorPosition(0, cen - 1);
            Console.WriteLine("----------------------");
            while (pi == 1)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    p = p - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    p = p + 1;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    pi = 0;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    pi = 0;
                    p = 100;
                }
                if (p < 1)
                {
                    p = 1;
                }
                Console.SetCursorPosition(2, 1);
                Console.WriteLine(b);
                Console.SetCursorPosition(0, p);
                Console.WriteLine("->");
                Console.SetCursorPosition(0, cen + 1);
                Console.WriteLine(chek);
                Console.SetCursorPosition(0, cen);
                Console.WriteLine("Цена: " + cenada);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Кондитерская 'Сладкая мечта'. Заказ: ");
                Console.SetCursorPosition(0, cen - 1);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine(p);
            return p;
        }
    }
}
