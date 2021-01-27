using GameDemo;
using GameDemo1.Abstract;
using GameDemo1.Concrete;
using System;

namespace GameDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamersManager gamersManager = new SimulationGamersManager();
            gamersManager.Add(new Gamers {YearOfBirth= 2002, FirstName="Beyza", LastName ="Işık" , NationalityId="12505638524"});
           
            Gamers gamer2 = new Gamers();
            gamer2.FirstName = "Ömer Faruk";
            gamer2.LastName = "Işık";
            gamer2.NationalityId = "15256945858";
            gamer2.YearOfBirth= 2004;
            gamer2.GameType = "OnlineGame";

            BaseGamersManager gamer = new OnlineGamersManager();
            gamer.Add(gamer2);
            gamer.Delete(gamer2);
           
            Gamers gamers = new Gamers();

            Games game1 = new Games();
            game1.Id = 1;
            game1.Name = "RocketLeage";
            game1.GameType = "OnlineGame";
            game1.Cost ="28";
            game1.NewCost =" 14";
            game1.Percent = "%50";

            Games game2 = new Games();
            game2.Id = 2;
            game2.Name = "Formula1";
            game2.GameType = "SimülationGame";
            game2.Cost ="50";
            game2.NewCost = "43";
            game2.Percent = "%14";

            Games game3 = new Games();
            game3.Id = 1;
            game3.Name = "WorldOfWarcraft";
            game3.GameType = "OnlineGame";
            game3.Cost = "136";
            game3.NewCost = "102";
            game3.Percent = "%25";

            Games game4 = new Games();
            game4.Id = 2;
            game4.Name = "FootballManager";
            game4.GameType = "SimülationGame";
            game4.Cost ="165";
            game4.NewCost = "132";
            game4.Percent = "%20";

            Campaigns campaigns1 = new Campaigns();
            campaigns1.Name = "%10 ' DEN BAŞLAYAN İNDİRİLER";

            Console.WriteLine("Küçük Ekim Ayı İndirimi  " + campaigns1.Name);

            Games[] games = new Games[] {game1,game2,game3 };
            foreach (var game in games)
            {
                Console.WriteLine("\n Oyunun Adı :"  + game.Name + "\n Oyunun Türü :" + game.GameType + "\n Oyunun Fiyatı :" + game.Cost + "\n Oyunun indirimli Fiyatı :"
                    + game.NewCost + "\n İndirim yüzdesi :" + game.Percent);
            }



        }

    }
}
