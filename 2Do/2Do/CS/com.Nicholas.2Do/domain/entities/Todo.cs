using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2Do.CS.com.Nicholas._2Do.domain.entities
{
    public class Todo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Title { get; set; }
        public string HourMinDeadline { get; set; }
        public bool Done { get; set; } = false;

        public Todo() { this.Id = 0; }

        public Todo(DateTime dateTime, string title, string deadline, bool done)
        {
            this.Id = 0;
            this.DateTime = dateTime;
            this.Title = title;
            this.HourMinDeadline = deadline;
            this.Done = done;
        }
    }
}