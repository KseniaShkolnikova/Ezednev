namespace Ежеднеы
{
    using System.ComponentModel;
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo khop = Console.ReadKey();
                if (khop.Key == ConsoleKey.LeftArrow || khop.Key == ConsoleKey.RightArrow)
                {
                    vrema();
                }
                else if (khop.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine(""+"Пока");
                    Environment.Exit(0);
                }
            }
        }
        public static void pervoe()
        {
            Nysno pervoe = new Nysno();
            pervoe.nazvanie = "Пойти погулять с подругой";
            pervoe.data = "23.10.2023";
            pervoe.opicdnie = "Погулять с Машей в 19 часов";
            Console.WriteLine(pervoe.nazvanie);
            Console.WriteLine(pervoe.data);
            Console.WriteLine(pervoe.opicdnie);
            ConsoleKeyInfo knopka = Console.ReadKey();
            if (knopka.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                vrema();
            }
            else if (knopka.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void vtoroe()
        {
            Nysno vtoroe = new Nysno();
            vtoroe.nazvanie = "Сходить в орговый центр";
            vtoroe.data = "23.10.2023";
            vtoroe.opicdnie = "Купить в торговом центре: шампунь, расческа, резинка";
            Console.WriteLine(vtoroe.nazvanie);
            Console.WriteLine(vtoroe.data);
            Console.WriteLine(vtoroe.opicdnie);
            ConsoleKeyInfo knopka = Console.ReadKey();
            if (knopka.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                vrema();
            }
            else if (knopka.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void tretia()
        {
            Nysno tretia = new Nysno();
            tretia.nazvanie = "Сдача практической";
            tretia.data = "13.10.2023";
            tretia.opicdnie = "Нужно сдать практическую по какому-нибудт предметну, желательно";
            Console.WriteLine(tretia.nazvanie);
            Console.WriteLine(tretia.data);
            Console.WriteLine(tretia.opicdnie);
            ConsoleKeyInfo knopka = Console.ReadKey();
            if (knopka.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                vrema();
            }
            else if (knopka.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void pat()
        {
            Nysno pat = new Nysno();
            pat.nazvanie = "Театр";
            pat.data = "13.10.2023";
            pat.opicdnie = "Нужно купить билеты и сходить в театр на 'Маленького принца'";
            Console.WriteLine(pat.nazvanie);
            Console.WriteLine(pat.data);
            Console.WriteLine(pat.opicdnie);
            ConsoleKeyInfo knopka = Console.ReadKey();
            if (knopka.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                vrema();
            }
            else if (knopka.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void chet()
        {
            Nysno chet = new Nysno();
            chet.nazvanie = "Выспаться";
            chet.data = "01.01.2024";
            chet.opicdnie = "Забей на праздники, лучше всего поспи";
            Console.WriteLine(chet.nazvanie);
            Console.WriteLine(chet.data);
            Console.WriteLine(chet.opicdnie);
            ConsoleKeyInfo knopka = Console.ReadKey();
            if (knopka.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                vrema();
            }
            else if (knopka.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void vrema()
        {
            DateTime a = new DateTime(2023, 10, 23);
            DateTime c = new DateTime(2023, 10, 13);
            DateTime f = new DateTime(2024, 01, 01);
            DateTime d = DateTime.Now;
            Console.WriteLine("Выбрана дата : " + d.ToString("d"));
            while (true)
            {
                ConsoleKeyInfo knopka = Console.ReadKey();
                Console.Clear();
                if (knopka.Key == ConsoleKey.RightArrow)
                {
                    d = d.AddDays(+1);
                    Console.WriteLine("Выбрана дата : " + d.ToString("d"));
                    if (d.Date == a.Date)
                    {
                        Console.WriteLine("  1.Пойти погулять с подругой");
                        Console.WriteLine("  2.Сходить в торговый центр");
                        ConsoleKeyInfo knopk = Console.ReadKey();
                        if (knopk.Key == ConsoleKey.UpArrow || knopk.Key == ConsoleKey.DownArrow)
                        {
                            strelka();
                        }

                    }
                    if (d.Date == c.Date)
                    {
                        Console.WriteLine("  1.Сдача практической");
                        Console.WriteLine("  2.Театр");
                        ConsoleKeyInfo knopk = Console.ReadKey();
                        if (knopk.Key == ConsoleKey.UpArrow || knopk.Key == ConsoleKey.DownArrow)
                        {
                            strelka1();
                        }

                    }
                    if (d.Date == f.Date)
                    {
                        Console.WriteLine("  1.Выспаться");
                        ConsoleKeyInfo knopk = Console.ReadKey();
                        if (knopk.Key == ConsoleKey.UpArrow || knopk.Key == ConsoleKey.DownArrow)
                        {
                            strelka2();
                        }

                    }
                }
                else if (knopka.Key == ConsoleKey.LeftArrow)
                {
                   
                    d = d.AddDays(-1);
                    Console.WriteLine("Выбрана дата : " + d.ToString("d"));
                    if (d.Date == a.Date)
                    {
                        Console.WriteLine("  1.Пойти погулять с подругой");
                        Console.WriteLine("  2.Сходить в торговый центр");
                        ConsoleKeyInfo knopk = Console.ReadKey();
                        if (knopk.Key == ConsoleKey.UpArrow || knopk.Key == ConsoleKey.DownArrow)
                        {
                            strelka();
                        }

                    }
                    if (d.Date == c.Date)
                    {
                        Console.WriteLine("  1.Сдача практической");
                        Console.WriteLine("  2.Театр");
                        ConsoleKeyInfo knopk = Console.ReadKey();
                        if (knopk.Key == ConsoleKey.UpArrow || knopk.Key == ConsoleKey.DownArrow)
                        {
                            strelka1();
                        }

                    }
                    if (d.Date == f.Date)
                    {
                        Console.WriteLine("  1.Выспаться");
                        ConsoleKeyInfo knopk = Console.ReadKey();
                        if (knopk.Key == ConsoleKey.UpArrow || knopk.Key == ConsoleKey.DownArrow)
                        {
                            strelka2();
                        }

                    }
                }
                else if (knopka.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            } 


        }
        static void strelka()
        {
            int position = 1;
            ConsoleKeyInfo knopka = Console.ReadKey();
            while (knopka.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (knopka.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == 0)
                    {
                        position = 2;
                    }
                }
                else if (knopka.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == 3)
                    {
                        position = 1;
                    }
                }
                else if (knopka.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                knopka = Console.ReadKey();
            }
            Console.Clear();
            if (position == 1)
            {
                pervoe();
            }
            else if (position == 2)
            {
                vtoroe();
            }
        }
        static void strelka1()
        {
            int position = 1;
            ConsoleKeyInfo knopka = Console.ReadKey();
            while (knopka.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (knopka.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == 0)
                    {
                        position = 2;
                    }
                }
                else if (knopka.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == 3)
                    {
                        position = 1;
                    }
                }
                else if (knopka.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                knopka = Console.ReadKey();

            }
            Console.Clear();
            if (position == 1)
            {
                tretia();
            }
            else if (position == 2)
            {
                pat();
            }
        }
        static void strelka2()
        {
            int position = 1;
            ConsoleKeyInfo knopka = Console.ReadKey();
            while (knopka.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (knopka.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == 0)
                    {
                        position = 1;
                    }
                }
                else if (knopka.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == 2)
                    {
                        position = 1;
                    }
                }
                else if (knopka.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                knopka = Console.ReadKey();

            }
            Console.Clear();
            if (position == 1)
            {
                chet();
            }

        }
    }
}
