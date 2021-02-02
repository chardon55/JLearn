using JLearn.Models;
using JLearn.Services;

namespace JLearn.ViewModels
{
    public sealed class DatePronModel : BaseViewModel
    {
        public DatePronModel()
        {
            Title = "Date Pronunciation";

            Shuffle();
        }

        public DateQuestion CurrentQuestion { get; private set; }

        public DateQuestion.Answer Answer => CurrentQuestion.TheAnswer;

        private static readonly DateQuestionGenerator generator = new DateQuestionGenerator();

        public void Shuffle()
        {
            CurrentQuestion = generator.Generate();
        }
    }
}
