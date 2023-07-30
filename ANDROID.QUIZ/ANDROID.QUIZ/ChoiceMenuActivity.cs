using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace ANDROID.QUIZ
{
    [Activity(Label = "ChoiceMenuActivity", Theme = "@style/AppTheme")]
    internal class ChoiceMenuActivity : AppCompatActivity
    {
        
        //οι μεταβλητές στις οποίες έχουμε βάλει τα id
        private Button Technology;
        private Button Nature;

        //oncreate είναι η μέθοδος που πραγματοποιείται όταν καλείται για πρώτη φορά το αντίστοιχο activity
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.choicemenuactivity);

            // εδω βρίσκουμε το id του κουμπιού NATURE και TECHNOLOGY (και τα βάζουμε σε μεταβλητές που τα δηλώνουμε πάνω απο την oncreate)
            Nature = FindViewById<Button>(Resource.Id.nature);
            Technology = FindViewById<Button>(Resource.Id.technology);

            //'οταν πατιέται το κουμπί NATURE μας στέλνει στο GameActivity όπου τρέχει ο κώδικας για τις ερωτήσεις
            Nature.Click += (e, o) =>
            {
                GameActivity.QuestionChoice = QuestionChoice.Nature;
                var intent1 = new Intent(this, typeof(GameActivity));
                intent1.AddFlags(ActivityFlags.ClearTask);
                intent1.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent1);
            };

            //'οταν πατιέται το κουμπί TECHNOLOGY μας στέλνει στο GameActivity όπου τρέχει ο κώδικας για τις ερωτήσεις
            Technology.Click += (e, o) =>
            {
                GameActivity.QuestionChoice = QuestionChoice.Technology;
                var intent = new Intent(this, typeof(GameActivity));
                intent.AddFlags(ActivityFlags.ClearTask);
                intent.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            };
        }

        
    }
}