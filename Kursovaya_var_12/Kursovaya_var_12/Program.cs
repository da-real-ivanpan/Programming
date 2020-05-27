using System;
using System.Collections;

namespace Kursovaya_var_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Клуб любителів туризму.");
            //Створюємо країни та міста
            Country Greece1 = new Country("Греція", "Афіни");//History
            Country Greece2 = new Country("Греція", "Маратос");//Camping
            Country Ukraine1 = new Country("Україна", "Копачів");//Camping
            Country Ukraine2 = new Country("Україна", "Кирилівка");//Sea
            Country Turkey1 = new Country("Турція", "Анталія");//Sea
            Country Turkey2 = new Country("Турція", "Аланія");//Sea
            Country Turkey3 = new Country("Турція", "Сіде");//History
            Country Egypt1 = new Country("Єгипет", "Хургада");//Sea
            Country Egypt2 = new Country("Єгипет", "Каїр");//History
            Country America1 = new Country("Америка", "Флорида");//Sea

            Tours[] Choices = new Tours[5];
            //Створюємо тури
            //Tours TourA1CG1 = new Tours("Histour", Greece1, "Історія", 5, 9);
            Choices[0] = new Tours("Histour", Greece1, "History", 5, 9);
            //Tours TourA1CT1 = new Tours("Histour", Turkey1, "Історія", 2, 11);
            Choices[1] = new Tours("LifeToure", Ukraine1, "Camping", 4, 10);
            Choices[2] = new Tours("FlyBoy", Turkey1, "Sea", 3, 10);
            Choices[3] = new Tours("FlyBoy", Egypt2, "Sea", 3, 10);
            Choices[4] = new Tours("Histoure", Turkey3, "History", 1, 12);

            Console.Write("Який вид туру ви бажаєте? ");
            string UserType = Console.ReadLine();
            Console.Write("З якого місяця ви плануєте подорож? ");
            int UserStart= Convert.ToInt32(Console.ReadLine());
            Console.Write("До якого місяця ви плануєте подорож? ");
            int UserEnd = Convert.ToInt32(Console.ReadLine());
            Stack correct_tours = new Stack();
            for (int i = 0; i<Choices.Length; i++)
            {
                if (UserType == Choices[i].type && UserStart >= Choices[i].MonthSt && UserEnd <= Choices[i].MonthEnd)
                {
                    int check = 0;
                    foreach (Tours element in correct_tours)
                    {
                        if(element== Choices[i])
                        {
                            check = 1;
                            break;
                        }
                    }
                    if (check != 1)
                        correct_tours.Push(Choices[i]);
                }
            }
            Stack correct_agencies = new Stack();
            foreach (Tours element in correct_tours)
            {
                int check = 0;
                foreach (string name in correct_agencies)
                {
                    if (element.AgencyName == name)
                    {
                        check = 1;
                        break;
                    }
                }
                if (check != 1)
                    correct_agencies.Push(element.AgencyName);
            }

            Stack Final = new Stack();
            int Count = 0;
            Console.WriteLine("Варіанти, які можуть Вас задовільнити:");
            foreach (string element in correct_agencies)
            {
                Console.WriteLine("Варіанти від агентства " + element);
                foreach(Tours tour in correct_tours)
                {
                    if (tour.AgencyName == element)
                    {
                        Count++;
                        Final.Push(tour);
                        Console.WriteLine(Count + ". Тур у " + tour.cityName + ", " + tour.counName + " від " + tour.MonthSt + " і до " + tour.MonthEnd);
                    }
                }
            }
            Console.Write("Ivan, please, write which to choose? Input '0' to cancel everything. ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0)
                Console.WriteLine("OK, you win, bye-bye!");
            else
            {
                //Make into function
                //int Length = Final.Count;
                //for (int i = 0; i < Math.Abs(Count - input); i++)
                //    Final.Pop();
                //Tours FT = Final.Pop();
                int temp = 0;
                Tours FT = null;
                foreach (Tours element in Final)
                {
                    if (temp != Final.Count - input)
                        temp++;
                    else
                    {
                        FT = element;
                        break;
                    }
                }
                Console.WriteLine("Ви обрали тур від агентства " + FT.AgencyName + " на тематику " + FT.type + " у " + FT.cityName + ", " + FT.counName + " від " + FT.MonthSt + " і до " + FT.MonthEnd);
            }
        }
    }
}
