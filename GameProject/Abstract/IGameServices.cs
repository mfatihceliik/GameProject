using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interfaces
{
    public interface IGameServices
    {
        void Sell(IPerson person, Game game);
        void Campaing(IPerson person, List<Game> games);
        void SpecialCampaign(IPerson person, Game game);
        void DeletedCampaing(IPerson person, List<Game> games);
        void CampaingnUpdate(IPerson person, List<Game> games);
    }
}
