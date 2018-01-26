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
    public class DataOwnerTest
    {
        private readonly SerieAEventLoader _sut;
        private readonly Moq.Mock<IDataOwner<IEnumerable<FootballEventMainInfo>, FootballEventParams>> _matchesDataOwner;
        private readonly Moq.Mock<IDataOwner<FootballOdds, FootballEventMainInfo>> _oddsDataOwner;
        private readonly Moq.Mock<IDataOwner<FootballStats, FootballEventMainInfo>> _statsDataOwner;

        public DataOwnerTest()
        {
            _matchesDataOwner = new Moq.Mock<IDataOwner<IEnumerable<FootballEventMainInfo>, FootballEventParams>>();
            _oddsDataOwner = new Moq.Mock<IDataOwner<FootballOdds, FootballEventMainInfo>>();
            _statsDataOwner = new Moq.Mock<IDataOwner<FootballStats, FootballEventMainInfo>>();
            _sut = new SerieAEventLoader(_matchesDataOwner,_oddsDataOwner,_statsDataOwner);
        }

        [Fact]
        public void Should_return_some_matches_with_odds()
        {
            var expected = new List<FootballEvent>()
            {
                new FootballEvent()
                {
                    
                }
            };

            var eventParameters = new FootballEventParams()
            {

            };

            var eventList = _sut.GetData(eventParameters);

            Assert.Equal(expected, eventList);
        }

        //[Fact]



    }
}
