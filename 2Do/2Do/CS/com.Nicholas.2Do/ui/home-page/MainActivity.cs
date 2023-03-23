using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using Android.Widget;
using System.Globalization;
using AndroidX.RecyclerView.Widget;
using _2Do.CS.com.Nicholas._2Do.ui.home_page;
using _2Do.CS.com.Nicholas._2Do.domain.entities;
using Android.Content;
using _2Do.CS.com.Nicholas._2Do.ui.selected_day;
using Newtonsoft.Json;

namespace _2Do
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Context context = Android.App.Application.Context;

        private DayAdapter adapter;
        private HomePresenter presenter;
        private LinearLayoutManager layoutManager;

        private TextView textView;
        private ImageButton btnList;
        private CalendarView calendarView;
        private RecyclerView rv;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);            
            Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen); //Fullscreen Mode

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            presenter = new HomePresenter();

            textView = FindViewById<TextView>(Resource.Id.etTemporaire);
            btnList = FindViewById<ImageButton>(Resource.Id.btnList);
            calendarView = FindViewById<CalendarView>(Resource.Id.cvDate);
            rv = FindViewById<RecyclerView>(Resource.Id.rvTasksHorizontal);

            rv.HasFixedSize = true;
            //layoutManager = new LinearLayoutManager(context, LinearLayoutManager.Horizontal, false);
            layoutManager = new ScaleLayoutManager(context, LinearLayoutManager.Horizontal, false);
            rv.SetLayoutManager(layoutManager);
            rv.SetAdapter(adapter = new DayAdapter(this, presenter));

            adapter.ItemClick += OnItemClick;

            //bouton de test pour le moment, affichera tous les todos dans le futur
            btnList.Click += delegate
            {
                DateTime dateTime = DateTime.Now;
                Console.WriteLine(dateTime);
                textView.Text = dateTime.ToString("dddd d", CultureInfo.InvariantCulture);

                var date = calendarView.Date;                

            };

        }        

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void OnDateChange(object sender, CalendarView.DateChangeEventArgs args)
        { 
            //presenter.DateChange(sender, args);
        }

        private void OnItemClick(object sender, Day day)
        {
            Intent intent = new Intent(this, typeof(SelectedDayActivity));
            intent.PutExtra("day", JsonConvert.SerializeObject(day));
            StartActivity(intent);
            //StartActivity(typeof(SelectedDayActivity));
        }

        public void GoToAll2DoView()
        {
            //StartActivity(typeof());
        }

        /*
        private void TestEditText(object sender, EventArgs eventArgs) //method displaying today's date
        {
            DateTime dateTime = DateTime.Now;
                textView.Text = dateTime.ToString("dddd d", CultureInfo.InvariantCulture);

                var date = calendarView.Date;                
        }*/
    }
}
