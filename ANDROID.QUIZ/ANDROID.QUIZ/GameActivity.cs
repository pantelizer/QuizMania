using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using QUIZ.core;
using QUIZ.core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ANDROID.QUIZ
{
    public enum QuestionChoice
    {
        Nature,
        Technology
    }

    [Activity(Label = "GameActivity", Theme = "@style/AppTheme")]
    public class GameActivity : AppCompatActivity
    {
        //σε αυτες τις μεταβλητές κάνουμε assign τα κουμπιά
        private TextView ScreenQuestion;
        private Button Answer1;
        private Button Answer2;
        private Button Answer3;
        private int CurentScore = 0;
        public string ScoreScreen = "0/0";
        private int TotalScore = 0;
        private int CurentQuestion = 0;

        private TextView Score;

        private List<QuizQuestion> questions = new List<QuizQuestion>();

        public static QuestionChoice QuestionChoice { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.game);

            //εδώ βάζουμε τα ids των κουμπιών στις μεταβλητές
            ScreenQuestion = FindViewById<TextView>(Resource.Id.questions);
            Answer1 = FindViewById<Button>(Resource.Id.answer1);
            Answer2 = FindViewById<Button>(Resource.Id.answer2);
            Answer3 = FindViewById<Button>(Resource.Id.answer3);
            Score = FindViewById<TextView>(Resource.Id.score);

            var random = new Random();

            for (int i = 0; i < 15; i++)
            {
                if (QuestionChoice == QuestionChoice.Nature)
                {
                    var index = random.Next(Questions.NatureQuestions.Count);

                    questions.Add(Questions.NatureQuestions[index]);

                    Questions.NatureQuestions.RemoveAt(index);
                }
                else
                {
                    var index = random.Next(Questions.TechnologyQuestions.Count);

                    questions.Add(Questions.TechnologyQuestions[index]);

                    Questions.TechnologyQuestions.RemoveAt(index);
                }
            }

            if (QuestionChoice == QuestionChoice.Nature)
            {
                foreach (var item in questions)
                {
                    Questions.NatureQuestions.Add(item);
                }
            }
            else if (QuestionChoice == QuestionChoice.Technology)
            {
                foreach (var item in questions)
                {
                    Questions.TechnologyQuestions.Add(item);
                }
            }

            Score.Text = ScoreScreen;

            ShowQuestion();

            Answer1.Click += AnswerClick;
            Answer2.Click += AnswerClick;
            Answer3.Click += AnswerClick;
        }

        private async void AnswerClick(object sender, EventArgs e)
        {
            Answer1.Enabled = false;
            Answer2.Enabled = false;
            Answer3.Enabled = false;

            var button = (Button)sender;
            var CorrectColor = Color.Green;
            //εδώ φτιάχνουμε μια if για να αλλάζουμε χρώμα στο κουμπί όποτε είναι σωστό ή λάθος
            if (button.Text == questions[CurentQuestion].CorrectAnswer)
            {
                CurentScore++;
                TotalScore++;

                button.SetBackgroundColor(CorrectColor);
            }
            else
            {
                TotalScore++;
                button.SetBackgroundColor(Color.Red);

                if (Answer1.Text == questions[CurentQuestion].CorrectAnswer)
                {
                    Answer1.SetBackgroundColor(CorrectColor);
                }
                else if (Answer2.Text == questions[CurentQuestion].CorrectAnswer)
                {
                    Answer2.SetBackgroundColor(CorrectColor);
                }
                else
                {
                    Answer3.SetBackgroundColor(CorrectColor);
                }
            }
            await Task.Delay(2000);

            Answer1.Enabled = true;
            Answer2.Enabled = true;
            Answer3.Enabled = true;

            CurentQuestion++;

            ScoreScreen = CurentScore.ToString() + "/" + TotalScore.ToString();
            Score.Text = ScoreScreen;
            ShowQuestion();
        }

        public void ShowQuestion()
        {
            if (CurentQuestion == 15)
            {
                FinalScoreScreen.FinalScore = ScoreScreen;
                Intent intent = new Intent(this, typeof(FinalScoreScreen));
                intent.AddFlags(ActivityFlags.ClearTask);
                intent.AddFlags(ActivityFlags.NewTask);

                StartActivity(intent);
                return;
            }
            /*απο εδω και κάτω κάνουμε μια if για να πάρουμε 6 περιπτώσεις στις οποίες θα μας βάζει τα κουμπιά σε random θέσεις
             * επιπλέον εδώ καθορίζουμε ποιο κουμπί θα πάρει ποιο στοιχίο(δηλαδή το answer1,answer2 ή το correctanswer)
             * επιπλέον πιο κάτω καθορίζουμε ποιο χρώμα θα έχουν τα κουμπιά έτσι ώστε όταν τα κάνουμε πράσινα ή κόκκινα να γυρνάνε στη κανονική
             * τους μορφή(χρώμα) όταν προβάλλεται η επόμενη ερώτηση
             */
            ScreenQuestion.Text = questions[CurentQuestion].Question;
            var random1 = new Random();
            var index = random1.Next(5);

            if (index == 0)
            {
                Answer1.Text = questions[CurentQuestion].Answer1;
                Answer2.Text = questions[CurentQuestion].Answer2;
                Answer3.Text = questions[CurentQuestion].CorrectAnswer;
            }
            else if (index == 1)
            {
                Answer2.Text = questions[CurentQuestion].Answer1;
                Answer1.Text = questions[CurentQuestion].Answer2;
                Answer3.Text = questions[CurentQuestion].CorrectAnswer;
            }
            else if (index == 2)
            {
                Answer1.Text = questions[CurentQuestion].Answer1;
                Answer3.Text = questions[CurentQuestion].Answer2;
                Answer2.Text = questions[CurentQuestion].CorrectAnswer;
            }
            else if(index == 3)
            {

                Answer3.Text = questions[CurentQuestion].Answer1;
                Answer2.Text = questions[CurentQuestion].Answer2;
                Answer1.Text = questions[CurentQuestion].CorrectAnswer;
            }
            else if(index == 4)
            {
                Answer3.Text = questions[CurentQuestion].Answer1;
                Answer1.Text = questions[CurentQuestion].Answer2;
                Answer2.Text = questions[CurentQuestion].CorrectAnswer;
            }
            else if (index == 5)
            {
                Answer2.Text = questions[CurentQuestion].Answer1;
                Answer3.Text = questions[CurentQuestion].Answer2;
                Answer1.Text = questions[CurentQuestion].CorrectAnswer;
            }


            Answer1.SetBackgroundColor(Color.DarkBlue);
            Answer2.SetBackgroundColor(Color.DarkBlue);
            Answer3.SetBackgroundColor(Color.DarkBlue);
        }

        public override void OnBackPressed()
        {

        }

    }
}