using Xunit;
using FluentAssertions;

namespace StrykerDemo.Tests
{
    public class ScoreCategoriserTests
    {
        [Theory]
        [InlineData(-2, Rating.OutOfBounds)]
        [InlineData(2, Rating.ReallyBad)]
        [InlineData(4, Rating.FairlyBad)]
        [InlineData(6, Rating.FairlyGood)]
        [InlineData(8, Rating.ReallyGood)]
        [InlineData(10, Rating.Perfect)]
        [InlineData(20, Rating.OutOfBounds)]
        public void When_Categorise_ThenMapRatingToResult(int rating, string expectedCategorisation)
        {
            var scoreCategoriser = new ScoreCategoriser();

            string result = scoreCategoriser.Categorise(rating);

            result.Should().Be(expectedCategorisation);
        }
    }
}
