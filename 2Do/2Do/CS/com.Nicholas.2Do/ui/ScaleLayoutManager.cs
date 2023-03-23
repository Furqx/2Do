using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2Do.CS.com.Nicholas._2Do.ui.home_page
{
    public class ScaleLayoutManager : LinearLayoutManager
    {
        LinearLayoutManager linearLayoutManager { get; set; }

        public ScaleLayoutManager(Context context) : base(context){}

        public ScaleLayoutManager(Context context, int orientation, bool reverselayout) : base(context, orientation, reverselayout){}

        public override bool CheckLayoutParams(RecyclerView.LayoutParams lp)
        {
            return base.CheckLayoutParams(lp);
        }

        public override void OnLayoutCompleted(RecyclerView.State state)
        {
            base.OnLayoutCompleted(state);
            ScaleMiddleItem();
        }

        public override int ScrollHorizontallyBy(int dx, RecyclerView.Recycler recycler, RecyclerView.State state)
        {
            int scrolled = base.ScrollHorizontallyBy(dx, recycler, state);
            if (Orientation == RecyclerView.Horizontal)
            {
                ScaleMiddleItem();
                return scrolled;
            }
            else
            {
                return 0;
            }
        }

        public override int ScrollVerticallyBy(int dx, RecyclerView.Recycler recycler, RecyclerView.State state)
        {
            int scrolled = base.ScrollVerticallyBy(dx, recycler, state);
            if (Orientation == RecyclerView.Vertical)
            {
                ScaleMiddleItem();
                return scrolled;
            }
            else
            {
                return 0;
            }
        }

        private void ScaleMiddleItem()
        {
            float mid = Width / 2.0f;
            float d1 = 0.9f * mid;

            for (int i = 0; i < ChildCount; i++)
            {
                View child = GetChildAt(i);
                float childMid = (GetDecoratedRight(child) + GetDecoratedLeft(child)) / 2.0f;
                float d = Math.Min(d1, Math.Abs(mid - childMid));
                float scale = 1f - 0.15f * d / d1;
                child.ScaleX= scale;
                child.ScaleY = scale;

            }
        }
    }
}