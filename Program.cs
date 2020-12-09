using System;
using System.Threading;

namespace ConsoleApp10
{
    public enum partners : int
    {
        
        YaroslavBershcky=1,
        IgorChermashencev,
        AndreySvechnikov,
        IgorNikolaev,
        KonstantinBorisov,
        IvanSachenko,
        YuriyBuryakov,
        RomanKuzmin,
        AlexeyPimenov,
        ArtemMakhmutov,
        YuriyAbdullaev,
        DjamalOmarov,
        AndreyNoName,
        AntonNoName,
        IlyaZhenin,
        DmitryNoName,
        SergeyKrivov,
        AlexeyShurygin,
        DaniilIvanov,
        GlebDavydov

    }

    abstract class CommonInfo
    {
        protected string name, surname;
        protected int number;
        protected double raiting;

        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public double Biography { get { return raiting; } }
        public int Number { set { number = value; } }

    }

    class Partner : CommonInfo
    {
        public Partner()
        {
            Console.WriteLine("Введите номер:");
            this.number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case (int)partners.YaroslavBershcky:
                    this.name = "Ярослав";
                    this.surname = "Бершацкий";
                    this.raiting = 7;

                    break;
                case (int)partners.IgorChermashencev:
                    this.name = "Игорь";
                    this.surname = "Чермашенцев";
                    this.raiting = 3;
                    break;

                case (int)partners.AndreySvechnikov:
                    this.name = "Андрей";
                    this.surname = "Свечников";
                    this.raiting = 7;
                    break;

                case (int)partners.IgorNikolaev:
                    this.name = "Игорь";
                    this.surname = "Николаев";
                    this.raiting = 5;
                    break;

                case (int)partners.KonstantinBorisov:
                    this.name = "Константин";
                    this.surname = "Борисов";
                    this.raiting = 7;
                    break;

                case (int)partners.IvanSachenko:
                    this.name = "Иван";
                    this.surname = "Сащенко";
                    this.raiting = 2;
                    break;

                case (int)partners.YuriyBuryakov:
                    this.name = "Юрий";
                    this.surname = "Буряков";
                    this.raiting = 8;
                    break;
                case (int)partners.RomanKuzmin:
                    this.name = "Роман";
                    this.surname = "Кузьмин";
                    this.raiting = 1;
                    break;

                case (int)partners.AlexeyPimenov:
                    this.name = "Алексей";
                    this.surname = "Пименов";
                    this.raiting = 8;
                    break;

                case (int)partners.ArtemMakhmutov:
                    this.name = "Артем";
                    this.surname = "Махмутов";
                    this.raiting = 3;
                    break;

                case (int)partners.YuriyAbdullaev:
                    this.name = "Юрий";
                    this.surname = "Абдуллаев";
                    this.raiting = 6;
                    break;

                case (int)partners.DjamalOmarov:
                    this.name = "Джамал";
                    this.surname = "Омаров";
                    this.raiting = 8;
                    break;

                case (int)partners.AndreyNoName:
                    this.name = "Андрей";
                    this.surname = "Неизвестно";
                    this.raiting = 8;
                    break;

                case (int)partners.AntonNoName:
                    this.name = "Антон";
                    this.surname = "Неизвестно";
                    this.raiting = 6;
                    break;

                case (int)partners.IlyaZhenin:
                    this.name = "Илья";
                    this.surname = "Женин";
                    this.raiting = 10;
                    break;

                case (int)partners.DmitryNoName:
                    this.name = "Дмитрий";
                    this.surname = "Неизвестно";
                    this.raiting = 6;
                    break;

                case (int)partners.SergeyKrivov:
                    this.name = "Сергей";
                    this.surname = "Кривов";
                    this.raiting = 6;
                    break;

                case (int)partners.AlexeyShurygin:
                    this.name = "Алексей";
                    this.surname = "Шурыгин";
                    this.raiting = 9;
                    break;

                case (int)partners.DaniilIvanov:
                    this.name = "Даниил";
                    this.surname = "Иванов";
                    this.raiting = 8;
                    break;

                case (int)partners.GlebDavydov:
                    this.name = "Глеб";
                    this.surname = "Давыдов";
                    this.raiting = 10;
                    break;
                default:
                    Console.WriteLine("Введенное значение неверно");
                    break;

            }
        }

        public void ShowInfo()
        {

            Console.WriteLine("Партнер  № {0} - {1} {2}, рейтинг - {3}", number, name, surname, raiting);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Partner partner = new Partner();
            partner.ShowInfo();

        }
    }
}
