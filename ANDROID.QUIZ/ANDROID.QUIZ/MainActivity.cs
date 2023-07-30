using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace ANDROID.QUIZ
{
    [Activity(Label = "QUIZMANIA", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
       
        private Button PlayButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            //με την εντολή setcontentview προβάλουμε ποια οθόνη θέλουμε απο το UI μας 
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

         

            PlayButton = FindViewById<Button>(Resource.Id.play);

            //πατώντας αυτο το κουμπί πάμε στην οθόνη της επιλογής ερωτήσεων
            PlayButton.Click += (e, o) =>
            {
                var intent1 = new Intent(this, typeof(ChoiceMenuActivity));
                StartActivity(intent1);
            };
        }

      


      

    }
}