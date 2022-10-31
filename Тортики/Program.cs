namespace Тортики
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\Users\\edlit\\OneDrive\\Рабочий стол\\chek.txt";
            if (File.Exists(file))
            {
                while (true)
                {
                    Console.WriteLine("Кондитерская 'Сладкая мечта'. Заказ: ");
                    int p = 1;
                    int a = 0;
                    string[] chek = Zakaz(p);
                    File.AppendAllText(file, "\n" + "Итог: " + chek[0] + "\n");
                    File.AppendAllText(file, chek[1] + "Спасибо за заказ. Ждём вас снова!" + "\n -----------------------------------\n");
                    Console.WriteLine("Ваш заказ находится в файле чек. Списибо за покупку. \nЕсли желаете сделать ещё заказ нажмите на любую кнопку");
                    ConsoleKeyInfo s = Console.ReadKey();
                    Console.Clear();
                }
            }
            else { File.Create(file);  }
        }
        static string[] Zakaz(int p)
        {
            cake menu = new cake();
            int b = 0;
            Console.SetCursorPosition(0, p);
            Console.WriteLine("->");
            int cenai = 0;
            string chek = "Ваш заказ: \n";
            int cenada = 0;
            while (b == 0)
            {
                
                string[] itog = menu.Menu(cenai, chek, cenada);
                string itogsl = itog[0];
                int itogcena = Convert.ToInt32(itog[1]);
                if (itogcena != 123)
                {
                    if (itogsl != "")
                    {
                        chek = chek + itogsl + "\n";
                    }
                    cenada = cenada + itogcena;
                }
                else { b++; }
            }
            string cenadaStr = Convert.ToString(cenada);
            string[] itogok = new string[] { cenadaStr, chek };
            return itogok;
        }

    }
}
