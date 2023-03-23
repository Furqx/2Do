using _2Do.CS.com.Nicholas._2Do.domain.entities;
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace _2Do.CS.com.Nicholas._2Do.model
{
    public class DBContext //: IDisposable
    {
		private const string databaseName = "2Do.db";

		public static SQLiteAsyncConnection db;

		public DBContext(/*string dbPath = null*/)
		{
			//db = new SQLiteAsyncConnection(dbPath ?? GetDatabasePath());
		}

		public static async Task Init()
		{
			if (db != null)
				return;

			string dbPath = Path.Combine(FileSystem.AppDataDirectory, databaseName);
			Log.Info("------------------------------------- DB_PATH ----------------------------", dbPath);

			db = new SQLiteAsyncConnection(dbPath);

			await db.CreateTableAsync<Todo>();
		}

		public void Dispose()
		{
			db.CloseAsync();
		}

		/*private string GetDatabasePath()
		{
			var dbPath = FileSystem.AppDataDirectory;
			Log.Info("------------------------------------- DB_PATH ----------------------------", dbPath);
			return Path.Combine(dbPath, databaseName);
		}*/
	}
}