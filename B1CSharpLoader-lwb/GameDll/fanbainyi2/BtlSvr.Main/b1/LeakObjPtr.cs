using System;

namespace b1;

public class LeakObjPtr
{
	private WeakReference<object> Ptr;

	private string ObjType;

	private string ObjName;

	public object Obj;

	public LeakObjPtr(object InPtr, bool IsCacheObj)
	{
		Ptr = new WeakReference<object>(InPtr);
		ObjType = InPtr.GetType().FullName;
		ObjName = InPtr.ToString();
		if (IsCacheObj)
		{
			Obj = InPtr;
		}
	}
}
