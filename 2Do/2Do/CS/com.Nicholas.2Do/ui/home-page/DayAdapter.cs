using _2Do.CS.com.Nicholas._2Do.domain.entities;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace _2Do.CS.com.Nicholas._2Do.ui.home_page
{
    #region ViewHolder
    public class DayViewHolder : RecyclerView.ViewHolder
    {
    public TextView Month { get; private set; }
    public TextView Day { get; private set; }
    public RecyclerView Rv{ get; private set; }

    public DayViewHolder(View itemView, Action<int> onClickListener, Action<int> onLongClickListener)
        : base(itemView)
    {
        Month = itemView.FindViewById<TextView>(Resource.Id.tvMonth);
        Day = itemView.FindViewById<TextView>(Resource.Id.tvToday);
        Rv = itemView.FindViewById<RecyclerView>(Resource.Id.rvSimpleTasks);

        itemView.Click += (sender, e) => onClickListener(AdapterPosition);
        itemView.LongClick += (sender, e) => onLongClickListener(AdapterPosition);
    }
}
    #endregion

    #region Adapter
    public class DayAdapter : RecyclerView.Adapter
    {
        public event EventHandler<Day> ItemClick;
        public event EventHandler<Day> ItemLongClick;

        private Activity Activity { get; set; }
        private HomePresenter Presenter { get; set; }
        private List<Day> days = new List<Day>();


        public DayAdapter(Activity activity, HomePresenter presenter)
        {
            this.Activity = activity;
            this.Presenter = presenter;
            //this.days = await presenter.LoadDays();
            Init();

            // update UI if collection changes
            /*this.Presenter.Days.CollectionChanged += (sender, args) =>
            {
                this.Activity.RunOnUiThread(NotifyDataSetChanged);
            };*/
        }

        private async void Init()
        {
            this.days = await Presenter.LoadDays();
        }

        private void OnClick(int position) => ItemClick?.Invoke(this, Presenter.Days[position]);
        private void OnLongClick(int position) => ItemLongClick?.Invoke(this, Presenter.Days[position]);

        public override int ItemCount => days.Count;        

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).
                                          Inflate(Resource.Layout.activity_main_rv, parent, false);

            DayViewHolder item = new DayViewHolder(view, OnClick, OnLongClick);
            return item;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            DayViewHolder vh = holder as DayViewHolder;

            Day day = days[position];
            vh.Month.Text = day.DateTime.ToString("MMMM");
            vh.Day.Text = day.WeekDayDate(day.DateTime);
        }
    }
    #endregion
}