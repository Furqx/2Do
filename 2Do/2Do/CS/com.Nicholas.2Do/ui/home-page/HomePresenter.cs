using _2Do.CS.com.Nicholas._2Do.domain.entities;
using _2Do.CS.com.Nicholas._2Do.domain.interactors;
using _2Do.CS.com.Nicholas._2Do.model;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
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
    public class HomePresenter : BasePresenter//, IDisposable
    {

        private HomeInteractor interactor;
        public ObservableCollection<Day> Days { get; private set; }
        //public List<today> DaysList { get; set; }

        public HomePresenter()
        {
            interactor = new HomeInteractor(/*model*/);
        }

        /*public async Task<ObservableCollection<today>> GetAllDays()
        {
            return this.Days = await interactor.GetAllDays();
        }*/



        public async Task<List<Day>> LoadDays()
        {
            List<Day> list = await interactor.LoadDays();
            this.Days = new ObservableCollection<Day>(list);
            return list;
        }
    }
}