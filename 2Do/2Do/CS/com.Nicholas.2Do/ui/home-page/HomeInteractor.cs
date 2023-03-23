using _2Do.CS.com.Nicholas._2Do.domain.entities;
using _2Do.CS.com.Nicholas._2Do.domain.interactors;
using _2Do.CS.com.Nicholas._2Do.model;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Do.CS.com.Nicholas._2Do.ui.home_page
{
    public class HomeInteractor
    {
        //private IData Model { get; set; }
        private List<Day> Days { get; set; }

        public HomeInteractor(/*IData model*/){}

        /*public async Task<ObservableCollection<Todo>> GetAllDays()
        {
            List<Todo> list = await Data.GetAllTodoAsync();

            //List<today> list = await Model.GetTodoAsync();
            ObservableCollection<Todo> collection = new ObservableCollection<Todo>(list);
            return collection;
        }*/

        public async Task<List<Day>> LoadDays()
        {
            List<Day> list = await Data.LoadDays();
            return list;
        }
    }
}