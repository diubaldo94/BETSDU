using System.Collections.Generic;
using System.Linq;
using DUBETLibrary.Loader;
using DUBETLibrary.Models;

namespace DUBETLibrary.Calculators
{
    public interface IBetCalculator<T, in TD> where T: Models.SportEvent where TD: EventPatameters
    {
        Dictionary<EvaluationModel, T> Calculate(IEnumerable<T> events, TD parameters);
    }

    public class FootballEventCalculator: IBetCalculator<FootballEvent, FootballEventParams>
    {
        public FootballEventCalculator()
        {
            
        }
        public Dictionary<EvaluationModel, FootballEvent> Calculate(IEnumerable<FootballEvent> events, FootballEventParams parameters)
        {
            var eventDictionary = events.ToDictionary(ev => new EvaluationModel(), ev => ev);
            //todo: choose a design pattern to make an evaluation of the matches and the related order
            //this will be the core of the program
            return eventDictionary;
        }
    }
    
    public class EvaluationModel
    {
    }

    public class FootballEventParams : EventPatameters
    {
    }

    public class FootballEvent : Models.SportEvent
    {
    }
}