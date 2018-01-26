using System.Collections.Generic;
using DUBETLibrary.Calculators;
using DUBETLibrary.Models;
using DUBETLibrary.SportEvent;
using HtmlAgilityPack;

namespace DUBETLibrary.Loader
{
    public class EventPatameters
    {
    }

    public class SerieAEventLoader : IDataOwner<IEnumerable<FootballEvent>, FootballEventParams>
    {
        private IDataOwner<IEnumerable<FootballEventMainInfo>, FootballEventParams> _matchesDataOwner;
        private IDataOwner<FootballOdds, FootballEventMainInfo> _oddsDataOwner;
        private IDataOwner<FootballStats, FootballEventMainInfo> _statsDataOwner;

        public SerieAEventLoader(IDataOwner<IEnumerable<FootballEvent>, FootballEventParams> dataOwner)
        {
        }

        public SerieAEventLoader(IDataOwner<IEnumerable<FootballEventMainInfo>, FootballEventParams> matchesDataOwner, 
            IDataOwner<FootballOdds, FootballEventMainInfo> oddsDataOwner, 
            IDataOwner<FootballStats, FootballEventMainInfo> statsDataOwner)
        {
            _matchesDataOwner = matchesDataOwner;
            _oddsDataOwner = oddsDataOwner;
            _statsDataOwner = statsDataOwner;
        }

        public bool AreParamsAcceptable(FootballEventParams parameters)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<FootballEvent> GetData(FootballEventParams parameters)
        {
            //todo: to refactor
            var loadedEvents = _matchesDataOwner.GetData(parameters);
            //some stuff
            return loadedEvents;
        }
    }

    public interface IDataOwner<T, D>
    {
        T GetData(D parameters);
        bool AreParamsAcceptable(D parameters);

    }

    public class SerieAMainInfoLoader : IDataOwner<IEnumerable<FootballEventMainInfo>, FootballEventParams>
    {
        public bool AreParamsAcceptable(FootballEventParams parameters)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<FootballEventMainInfo> GetData(FootballEventParams parameters)
        {
            var url = "http://html-agility-pack.net/";
            var web = new HtmlWeb();
            var doc = web.Load(url);
        }
    }

    //exapmle of class that implement nterface for extracting data from thw web
    //public class BetFairLoader : IDataOwner<>
    //{

    //}

}