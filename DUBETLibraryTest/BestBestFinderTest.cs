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
    public class BestBetsFinderTest
    {
        private readonly EventLoader _sut;
        private readonly IEnumerable<IDataOwner> _dataOwners; 

        public BestBetsFinderTest()
        {
            _dataOwners = new List<IDataOwner>()
            {
                new Mock<IDataOwner>()
                {
                    
                },
                new Mock<IDataOwner>()
                {

                },

            };
            _sut = new EventLoader(_dataOwners);
        }

        [Fact]
        public void Should_return_some_matches_with_odds()
        {
            var expected = new List<SportEvent>()
            {
                new SportEvent()
                {
                    
                }
            };

            var eventParameters = new EventParameters()
            {

            };

            var eventList = _sut.GetEvents(eventParameters);

            Assert.Equal(expected, eventList);
        }

        [Fact]



    }
}
