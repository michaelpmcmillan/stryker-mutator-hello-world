namespace StrykerDemo
{
    public class ScoreCategoriser
    {
        public string Categorise(int ratingScore)
        {
            if(ratingScore < 0) return Rating.OutOfBounds;
            if(ratingScore < 3) return Rating.ReallyBad;
            if(ratingScore < 5) return Rating.FairlyBad;
            if(ratingScore < 7) return Rating.FairlyGood;
            if(ratingScore <= 9) return Rating.ReallyGood;
            if(ratingScore == 10) return Rating.Perfect;

            return Rating.OutOfBounds;
        }
    }
}
