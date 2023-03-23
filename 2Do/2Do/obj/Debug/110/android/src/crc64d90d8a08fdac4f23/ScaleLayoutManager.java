package crc64d90d8a08fdac4f23;


public class ScaleLayoutManager
	extends androidx.recyclerview.widget.LinearLayoutManager
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_checkLayoutParams:(Landroidx/recyclerview/widget/RecyclerView$LayoutParams;)Z:GetCheckLayoutParams_Landroidx_recyclerview_widget_RecyclerView_LayoutParams_Handler\n" +
			"n_onLayoutCompleted:(Landroidx/recyclerview/widget/RecyclerView$State;)V:GetOnLayoutCompleted_Landroidx_recyclerview_widget_RecyclerView_State_Handler\n" +
			"n_scrollHorizontallyBy:(ILandroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I:GetScrollHorizontallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler\n" +
			"n_scrollVerticallyBy:(ILandroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I:GetScrollVerticallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler\n" +
			"";
		mono.android.Runtime.register ("_2Do.CS.com.Nicholas._2Do.ui.home_page.ScaleLayoutManager, 2Do", ScaleLayoutManager.class, __md_methods);
	}


	public ScaleLayoutManager (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ScaleLayoutManager.class)
			mono.android.TypeManager.Activate ("_2Do.CS.com.Nicholas._2Do.ui.home_page.ScaleLayoutManager, 2Do", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public ScaleLayoutManager (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == ScaleLayoutManager.class)
			mono.android.TypeManager.Activate ("_2Do.CS.com.Nicholas._2Do.ui.home_page.ScaleLayoutManager, 2Do", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public ScaleLayoutManager (android.content.Context p0, int p1, boolean p2)
	{
		super (p0, p1, p2);
		if (getClass () == ScaleLayoutManager.class)
			mono.android.TypeManager.Activate ("_2Do.CS.com.Nicholas._2Do.ui.home_page.ScaleLayoutManager, 2Do", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean checkLayoutParams (androidx.recyclerview.widget.RecyclerView.LayoutParams p0)
	{
		return n_checkLayoutParams (p0);
	}

	private native boolean n_checkLayoutParams (androidx.recyclerview.widget.RecyclerView.LayoutParams p0);


	public void onLayoutCompleted (androidx.recyclerview.widget.RecyclerView.State p0)
	{
		n_onLayoutCompleted (p0);
	}

	private native void n_onLayoutCompleted (androidx.recyclerview.widget.RecyclerView.State p0);


	public int scrollHorizontallyBy (int p0, androidx.recyclerview.widget.RecyclerView.Recycler p1, androidx.recyclerview.widget.RecyclerView.State p2)
	{
		return n_scrollHorizontallyBy (p0, p1, p2);
	}

	private native int n_scrollHorizontallyBy (int p0, androidx.recyclerview.widget.RecyclerView.Recycler p1, androidx.recyclerview.widget.RecyclerView.State p2);


	public int scrollVerticallyBy (int p0, androidx.recyclerview.widget.RecyclerView.Recycler p1, androidx.recyclerview.widget.RecyclerView.State p2)
	{
		return n_scrollVerticallyBy (p0, p1, p2);
	}

	private native int n_scrollVerticallyBy (int p0, androidx.recyclerview.widget.RecyclerView.Recycler p1, androidx.recyclerview.widget.RecyclerView.State p2);

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
