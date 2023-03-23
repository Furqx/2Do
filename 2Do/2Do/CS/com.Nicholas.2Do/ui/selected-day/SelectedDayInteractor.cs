using _2Do.CS.com.Nicholas._2Do.domain.entities;
using _2Do.CS.com.Nicholas._2Do.model;
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
    public class SelectedDayInteractor
    {
        public SelectedDayInteractor() { }

        public async Task CheckTodo(Todo todo)
        {
            await Data.UpdateTodoAsync(todo);
        }
    }
}