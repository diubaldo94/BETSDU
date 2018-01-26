using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUBETLibrary;
using DUBETLibrary.Calculators;
using DUBETLibrary.Loader;
using DUBETLibrary.Models;
using Xunit;

namespace DUBETLibraryTest
{
    public class EventCalculatorTest
    {
        private readonly FootballEventCalculator _sut;

        public EventCalculatorTest()
        {
            _sut = new FootballEventCalculator();
        }
        

        //should have more methods that tests if the evaluations work fine
        [Fact]
        public void Should_return_order_list_of_events_by_betting_valuabilty()
        {
            var firstEvent = new FootballEvent()
            {
                
            };
            var secondEvent = new FootballEvent()
            {
                
            };
            var inputList = new List<FootballEvent>()
            {
                firstEvent, secondEvent
            };
            var footbaalParams = new FootballEventParams()
            {

            };
            var expected = new Dictionary<EvaluationModel, FootballEvent>();
            {
                { }
            }
            var actualDictionary = _sut.Calculate(inputList, footbaalParams);
            Assert.Equal(actualDictionary, expected);
        }


    }
}
