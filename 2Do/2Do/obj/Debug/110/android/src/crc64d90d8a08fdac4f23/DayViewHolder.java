package crc64d90d8a08fdac4f23;


public class DayViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("_2Do.CS.com.Nicholas._2Do.ui.home_page.DayViewHolder, 2Do", DayViewHolder.class, __md_methods);
	}


	public DayViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == DayViewHolder.class)
			mono.android.TypeManager.Activate ("_2Do.CS.com.Nicholas._2Do.ui.home_page.DayViewHolder, 2Do", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
