using JLearn.Resources;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JLearn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePronPage : ContentPage
    {
        public DatePronPage()
        {
            InitializeComponent();
            LoadQuestion();
        }

        public enum State
        {
            READY,
            SHOW_QUESTION,
            SHOW_ANSWER
        }

        public State CurrentState { get; private set; } = State.READY;

        private void LoadQuestion()
        {
            AnswerLabel.IsVisible = false;
            CurrentModel.Shuffle();
            CurrentState = State.SHOW_QUESTION;
            ActionButton.Text = Strings.ShowAnswer;
            DateLabel.Text = CurrentModel.CurrentQuestion.ToString();
            AnswerLabel.Text = CurrentModel.Answer.ToString();
        }

        private void LoadAnswer()
        {
            AnswerLabel.IsVisible = true;
            CurrentState = State.SHOW_ANSWER;
            ActionButton.Text = Strings.Next;
        }

        private void ActionButton_Clicked(object sender, EventArgs e)
        {
            switch (CurrentState)
            {
                case State.READY:
                case State.SHOW_ANSWER:
                    LoadQuestion();
                    break;

                case State.SHOW_QUESTION:
                    LoadAnswer();
                    break;

                default:
                    break;
            }
        }
    }
}