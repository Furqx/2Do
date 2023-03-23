using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Do.CS.com.Nicholas._2Do.domain.entities
{
    public class Day
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public List<Todo> Todos { get; set; } = new List<Todo>();

        public Day() { this.Id = 0; }

        public Day(DateTime dateTime)
        {
            this.Id = 0;
            this.DateTime = dateTime;
        }

        public Day(DateTime dateTime, List<Todo> todos)
        {
            this.Id = 0;
            this.DateTime = dateTime;
            this.Todos = todos;
        }

        public Day(DateTime dateTime, Task<List<Todo>> todos)
        {
            this.Id = 0;
            this.DateTime = dateTime;
            this.Todos = todos.Result;
        }

        public string WeekDayDate(DateTime dateTime)
        {
            Console.WriteLine(dateTime+"================");
            return dateTime.ToString("dddd d", CultureInfo.InvariantCulture);
        }
    }
}