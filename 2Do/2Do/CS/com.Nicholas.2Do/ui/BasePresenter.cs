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
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace _2Do.CS.com.Nicholas._2Do.ui
{
    public abstract class BasePresenter : INotifyPropertyChanged
    {

        //public readonly IData model;

        public BasePresenter(/*IData model = null*/)
        {
            //this.model = new MockDB();
            //this.model = new Data();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}