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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Do.CS.com.Nicholas._2Do.ui.selected_day
{
    #region ViewHolder
    public class DayViewHolder : RecyclerView.ViewHolder
    {
        public TextView TitleTask { get; private set; }
        public TextView DeadlineTask { get; private set; }
        public ImageView Checkbox { get; private set; }

        public DayViewHolder(View itemView, Action<int> onClickListener, Action<int> onLongClickListener)
            : base(itemView)
        {
            TitleTask = itemView.FindViewById<TextView>(Resource.Id.tvTitleTask);
            DeadlineTask = itemView.FindViewById<TextView>(Resource.Id.tvDeadlineTask);
            Checkbox = itemView.FindViewById<ImageView>(Resource.Id.ivCheckbox);
            
            itemView.Click += (sender, e) => onClickListener(AdapterPosition);
            itemView.LongClick += (sender, e) => onLongClickListener(AdapterPosition);
        }
    }
    #endregion

    #region Adapter
    public class SelectedDayAdapter : RecyclerView.Adapter
    {
        public event EventHandler<Todo> ItemClick;
        public event EventHandler<Todo> ItemLongClick;

        private Activity Activity { get; set; }
        private SelectedDayPresenter Presenter { get; set; }
        private Day Today { get; set; }
        private List<Todo> Todos { get; set; } = new List<Todo>();


       /* public SelectedDayAdapter(Activity activity, SelectedDayPresenter presenter)
        {
            this.Activity = activity;
            this.Presenter = presenter;
            //this.days = await presenter.LoadDays();
            Init();

            // update UI if collection changes
            /*this.Presenter.Days.CollectionChanged += (sender, args) =>
            {
                this.Activity.RunOnUiThread(NotifyDataSetChanged);
            };
        }*/

        public SelectedDayAdapter(SelectedDayPresenter presenter, Activity activity, Day day)
        {
            this.Presenter = presenter;
            this.Activity = activity;
            this.Today = day;
            this.Todos = day.Todos;
            Init();
            // update UI if collection changes
            /*this.Presenter.Days.CollectionChanged += (sender, args) =>
            {
                this.Activity.RunOnUiThread(NotifyDataSetChanged);
            };*/
        }

        private void Init()
        {
            this.Todos = Today.Todos;
        }

        private void OnClick(int position) => ItemClick?.Invoke(this, Todos[position]);
        private void OnLongClick(int position) => ItemLongClick?.Invoke(this, /*Presenter.Day.*/Todos[position]);

        public override int ItemCount => /*Presenter.Day.*/Todos.Count;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).
                                          Inflate(Resource.Layout.activity_selected_day_rv, parent, false);

            DayViewHolder item = new DayViewHolder(view, OnClick, OnLongClick);
            return item;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            DayViewHolder vh = holder as DayViewHolder;

            Todo todo = Todos[position];
            vh.TitleTask.Text = todo.Title;
            vh.DeadlineTask.Text = todo.HourMinDeadline;

            if (todo.Done == true)
            {
                vh.Checkbox.SetBackgroundResource(Resource.Drawable.checkbox_checked);
            }
            /*else
            {
                vh.Checkbox.SetBackgroundResource(Resource.Drawable.checkbox_checked);
            }*/
        }
    }
    #endregion
}