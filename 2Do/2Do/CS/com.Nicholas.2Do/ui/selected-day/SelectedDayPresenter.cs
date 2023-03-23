using _2Do.CS.com.Nicholas._2Do.domain.entities;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Do.CS.com.Nicholas._2Do.ui.selected_day
{
    public class SelectedDayPresenter : BasePresenter
    {
        private SelectedDayInteractor interactor;
        public Day Day { get; private set; }

        public SelectedDayPresenter(Day day)
        {
            this.Day = day;
            interactor = new SelectedDayInteractor();
        }

        /*public async Task<ObservableCollection<today>> GetAllDays()
        {
            return this.Days = await interactor.GetAllDays();
        }*/

        public async Task CheckTodo(Todo todo)
        {
            await interactor.CheckTodo(todo);
        }

        /*public async Task<List<Day>> LoadDays()
        {
            List<Day> list = await interactor.LoadDays();
            this.Days = new ObservableCollection<Day>(list);
            return list;
        }*/
    }
}