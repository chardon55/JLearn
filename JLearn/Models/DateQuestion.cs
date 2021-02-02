namespace JLearn.Models
{
    public class DateQuestion
    {
        //public string Year { get; set; }

        public string Month { get; set; }

        public string Day { get; set; }

        public Answer TheAnswer { get; set; }

        public class Answer
        {
            public string Month { get; set; }
            public string Day { get; set; }

            public override string ToString() => $"{Month} {Day}";
        }

        public override string ToString() => $"{Month}{Day}";
    }
}
