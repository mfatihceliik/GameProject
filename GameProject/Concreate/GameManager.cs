using GameProject.Entities;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class GameManager : IGameServices
    {
        public void Sell(IPerson person, Game game)
        {
            if(person.Wallet >= game.Price)
            {
                Console.WriteLine(person.FirstName + ", " + game.GameName + " Adlı oyunu satın aldı !");
            }
            else
            {
                Console.WriteLine("Bakiyeniz yetersiz. Satın Almak için "+ (game.Price - person.Wallet) + " TL daha yükleyiniz.");
            }
        }

        public void Campaing(IPerson person, List<Game> games)
        {
            Console.WriteLine("Bu Fırsat Kaçmaz !");
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName + " : " + (game.Price / 1.3) + " TL"); 
            }
        }

        public void SpecialCampaign(IPerson person, Game game)
        {
            Console.WriteLine("Sana Özel ! "+game.GameName + " Oyunu "+ game.Price + " TL' den, sana özel " + (game.Price / 1.8) + " TL' ye düştü !");
        }

        public void DeletedCampaing(IPerson person, List<Game> games)
        {
            games.Clear();
            Console.WriteLine("Geçerli Kampanya Bulunmamaktadır.");
        }

        public void CampaingnUpdate(IPerson person, List<Game> games)
        {
            Console.WriteLine("Kampanya Değişti, yeni kampanya fiyatları :");
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName + " Oyunu " + game.Price +
                    " TL' den, sana özel " + (game.Price / 1.7) + " TL' ye düştü !");
            }
        }
    }
}
