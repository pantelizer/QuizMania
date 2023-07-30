using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace ANDROID.QUIZ
{
    [Activity(Label = "GameActivity", Theme = "@style/AppTheme")]
    internal class FinalScoreScreen : AppCompatActivity
    {
        private Button MainMenu;
        private Button PlayAgain;
        public static string FinalScore;
        private TextView Score;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.scorescreen);

            MainMenu = FindViewById<Button>(Resource.Id.mainmenu);
            PlayAgain = FindViewById<Button>(Resource.Id.playagain);
            Score = FindViewById<TextView>(Resource.Id.finalscore);

            //το απο κάτω μας επιστρέφει στην αρχική οθόνη
            MainMenu.Click += (o, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                intent.AddFlags(ActivityFlags.ClearTask);
                intent.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            };

            //το απο κάτω μας επιστρέφει στη οθόνη που επιλέγουμε παινχίδι
            PlayAgain.Click += (o, e) =>
            {
                var intent2 = new Intent(this, typeof(ChoiceMenuActivity));
                Intent.AddFlags(ActivityFlags.ClearTask);
                Intent.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent2);
            };





            Score.Text = FinalScore;
        }
        //αυτο δεν μας επιτρέπει να πατήσουμε το πίσω κουμπί όταν είμαστε στο end screen
        public override void OnBackPressed()
        {
           
        }


    }
}