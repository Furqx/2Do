using _2Do.CS.com.Nicholas._2Do.domain.entities;
using _2Do.CS.com.Nicholas._2Do.domain.interactors;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace _2Do.CS.com.Nicholas._2Do.model
{
	public static class Data //: IData
	{
		static SQLiteAsyncConnection db;

		/*public Data()
		{
			using (var conn = new DBContext())
			{
				// create table if not exist
				conn.db.CreateTableAsync<Todo>();
			}
		}

		public Data(string dbPath)
		{
			this.dbPath = dbPath;

			using (var conn = new DBContext(dbPath))
			{
				// create table if not exist
				conn.db.CreateTableAsync<today>();
			}
		}*/

		static async Task Init()
		{
			if (db != null)
            {
				Console.WriteLine("bd existente ------------------------------------");
				return;
			}

			var dbPath = Path.Combine(FileSystem.AppDataDirectory, "2Do.db");
			Log.Info("------------------------------------- DB_PATH ----------------------------", dbPath);

			db = new SQLiteAsyncConnection(dbPath);
			Console.WriteLine("coucou ##################################");
			await db.CreateTableAsync<Todo>();
			Console.WriteLine("db created ##################################");
		}

		public static async Task AddTodoAsync(Todo todo)
		{
			/*await*/ Init();						
			await db.InsertAsync(todo).ConfigureAwait(false);			
		}

		public static async Task UpdateTodoAsync(Todo todo)
		{
			/*await*/
			Init();
			await db.UpdateAsync(todo).ConfigureAwait(false);			
		}

		public static async Task DeleteTodoAsync(Todo todo)
		{
			/*await*/
			Init();
			await db.DeleteAsync(todo).ConfigureAwait(false);			
		}

		public static async Task<Todo> GetTodoAsync(int id)
		{
			/*await*/
			Init();
			Console.WriteLine("se rend ici ##################################");
			return await db.Table<Todo>().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);			
		}

		/*public static async Task<List<Todo>> GetTodoByDateAsync(DateTime dateTime, List<Todo> todos)
		{
			await Init();
			return await db.Table<Todo>().OrderByDescending(x => x.DateTime == dateTime).ToListAsync().ConfigureAwait(false);
		}*/

		public static async Task<List<Todo>> GetAllTodoAsync()
		{
			await Init();
			Console.WriteLine("se rend ici ??????????????????????????");
			return await db.Table<Todo>().OrderByDescending(x => x.DateTime).ToListAsync().ConfigureAwait(false);				
		}

		//Load les 30 jours avant/après la date courante avec leur todo respectif
		public static async Task<List<Day>> LoadDays()
		{
			List<Day> daysList = new List<Day>();
			List<Todo> todoList = await GetAllTodoAsync();

			Console.WriteLine("Todolist size :::::::::::::::::::::::: " + todoList.Count);
			for (int i = 0; i < todoList.Count; i++)
			{
				Console.WriteLine("todolist : " + todoList[i].Title);
			}

			foreach (DateTime day in EachDay(DateTime.Today.AddMonths(-1), DateTime.Today.AddMonths(+1)))
			{
				//List<Todo> todoList = await GetTodoByDateAsync(day);//empeche l'ouverture de l'app
				//daysList.Add(new today(day, todoList));				
				daysList.Add(new Day(day));
				Console.WriteLine("se rend ici &&&&&&&&&&&&&&&&&&&&&&");
			}
			
			foreach (Day dayFromList in daysList)
			{
				foreach (Todo todo in todoList)
				{
					if (dayFromList.DateTime == todo.DateTime)
					{
						dayFromList.Todos.Add(todo);
					}
				}				
			}			

			return daysList;
		}

		//Retourne tous les jours dans un intervalle
		public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
		{
			for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
				yield return day;
		}
	}
}