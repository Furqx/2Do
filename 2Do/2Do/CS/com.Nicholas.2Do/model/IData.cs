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

namespace _2Do.CS.com.Nicholas._2Do.domain.interactors
{
    public interface IData
    {
        Task AddTodoAsync(Day day);
        Task DeleteTodoAsync(Day day);
        Task UpdateTodoAsync(Day day);
        Task<Day> GetTodoAsync(int id);
        Task<List<Day>> GetTodoAsync();
        //Task GenerateMockDaysAsync(List<today> days);
        List<Day> LoadDays();
    }
}