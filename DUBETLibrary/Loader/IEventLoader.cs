using System.Collections.Generic;
using DUBETLibrary.Models;
using DUBETLibrary.SportEvent;

namespace DUBETLibrary.Loader
{
    public interface IEventLoader
    {
        IEnumerable<Models.SportEvent> GetEvents(EventPatameters @params);
    }

    public class EventPatameters
    {
    }

    public class EventLoader : IEventLoader
    {
        private readonly IEnumerable<IDataOwner> _dataOwners;

        public EventLoader(IEnumerable<IDataOwner> dataOwners)
        {
            _dataOwners = dataOwners;
        }

        public IEnumerable<Models.SportEvent> GetEvents(EventPatameters parameters)
        {
            //todo: to refactor
            foreach (var dataOwner in _dataOwners)
            {
                if (dataOwner.AreParamsAcceptable(parameters))
                    return dataOwner.GetEvents(parameters);
            }

            return new List<Models.SportEvent>();
        }
    }

    public interface IDataOwner
    {
        IEnumerable<Models.SportEvent> GetEvents(EventPatameters parameters);
        bool AreParamsAcceptable(EventPatameters parameters);

    }

    //exapmle of class that implement nterface for extracting data from thw web
    public class BetFairLoader : IDataOwner
    {
        public IEnumerable<Models.SportEvent> GetEvents(EventPatameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public bool AreParamsAcceptable(EventPatameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }

    //exapmle of class that implement nterface for extracting data from thw web
    public class WikipediaWebSiteLoader : IDataOwner
    {
        public IEnumerable<Models.SportEvent> GetEvents(EventPatameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public bool AreParamsAcceptable(EventPatameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}