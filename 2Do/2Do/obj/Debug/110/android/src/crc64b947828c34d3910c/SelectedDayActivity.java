package crc64b947828c34d3910c;


public class SelectedDayActivity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("_2Do.CS.com.Nicholas._2Do.ui.selected_day.SelectedDayActivity, 2Do", SelectedDayActivity.class, __md_methods);
	}


	public SelectedDayActivity ()
	{
		super ();
		if (getClass () == SelectedDayActivity.class)
			mono.android.TypeManager.Activate ("_2Do.CS.com.Nicholas._2Do.ui.selected_day.SelectedDayActivity, 2Do", "", this, new java.lang.Object[] {  });
	}


	public SelectedDayActivity (int p0)
	{
		super (p0);
		if (getClass () == SelectedDayActivity.class)
			mono.android.TypeManager.Activate ("_2Do.CS.com.Nicholas._2Do.ui.selected_day.SelectedDayActivity, 2Do", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
