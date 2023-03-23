using _2Do.CS.com.Nicholas._2Do.domain.entities;
using _2Do.CS.com.Nicholas._2Do.ui.home_page;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2Do.CS.com.Nicholas._2Do.ui.selected_day
{
    [Activity(Label = "SelectedDayActivity", Theme = /*"@style/Theme.AppCompat.Dialog"*/"@style/AppTheme.Translucent.Black")]
    public class SelectedDayActivity : AppCompatActivity
    {
        Context context = Android.App.Application.Context;

        private SelectedDayAdapter adapter;
        private SelectedDayPresenter presenter;
        private LinearLayoutManager layoutManager;
        
        private Day day;

        //LinearLayout linearLayout;

        private TextView month;
        private TextView today;
        private TextView amount;
        private ImageButton btnSort;
        private ImageButton btnAdd;
        private RecyclerView rv;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_selected_day);            

            day = JsonConvert.DeserializeObject<Day>(Intent.GetStringExtra("day"));
            for (int i = 0; i < 5; i++)
            {
                day.Todos.Add(new Todo(day.DateTime, "title "+i, i+":"+i*10, false));
            }

            presenter = new SelectedDayPresenter(day);

            month = FindViewById<TextView>(Resource.Id.tvMonthSelected);
            today = FindViewById<TextView>(Resource.Id.tvTodaySelected);
            amount = FindViewById<TextView>(Resource.Id.tvAmount);
            btnSort = FindViewById<ImageButton>(Resource.Id.btnSort);
            btnAdd = FindViewById<ImageButton>(Resource.Id.btnAdd);
            rv = FindViewById<RecyclerView>(Resource.Id.rvTasks);
            //linearLayout = FindViewById<LinearLayout>(Resource.Id.llTest);

            rv.HasFixedSize = true;
            layoutManager = new LinearLayoutManager(context, LinearLayoutManager.Vertical, false);
            rv.SetLayoutManager(layoutManager);
            rv.SetAdapter(adapter = new SelectedDayAdapter(presenter, this, day));

            DisplayDay(day);

            adapter.ItemClick += OnItemClick;
            adapter.ItemLongClick += OnItemLongClick;

            btnSort.Click += delegate
            {
                //sort
            };

            btnAdd.Click += delegate
            { 
                //presenter.
            };

            //Fonctionne mais il faut inverser la zone de clic
            /*linearLayout.Click -= delegate
            {
                Finish();
            };*/           

        }

        //Checkbox method
        private async void OnItemClick(object sender, Todo todo)
        {
            //await presenter.CheckTodo(todo);
            todo.Done = true;
        }

        //Edit method
        private void OnItemLongClick(object sender, Todo todo)
        {
            
        }

        //Add I18N !!!!!!!
        public void DisplayDay(Day day)
        {
            string month = day.DateTime.ToString("MMMM");
            string today = day.WeekDayDate(day.DateTime);
            string amount = "You have " + day.Todos.Count + " tasks 2Do";

            this.month.Text = month;
            this.today.Text = today;
            this.amount.Text = amount;
        }

    }
}