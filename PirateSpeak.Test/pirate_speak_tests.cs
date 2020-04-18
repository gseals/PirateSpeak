using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace PirateSpeak.Test
{
    public class pirate_speak_tests
    {
        [Fact]
        public void ortsp_test()
        {
            // Arrange - set up context for what will come in our test
            var jumble = "ortsp";
            var unjumbledWords = new List<string>() {"sport", "parrot", "ports", "matey"};
            List<string> expectedResult = new List<string> {"sport", "ports"};

            var pirateInputs = new PirateSpeakInputs();

            // Act
            var actualResult = pirateInputs.PirateInputs(jumble, unjumbledWords);

            // Assert - typically use an assertion library. x-unit comes built in with one
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
