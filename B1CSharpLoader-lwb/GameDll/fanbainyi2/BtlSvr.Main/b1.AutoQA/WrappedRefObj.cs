using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class WrappedRefObj
{
	public string ObjName;

	private UObject Obj;

	private List<WrappedRefObj> ParentRefChainObjs;

	public WrappedRefObj(string InObjName, UObject InObj)
	{
		ObjName = InObjName;
		Obj = InObj;
		ParentRefChainObjs = null;
	}

	public void AddParentRefChainObj(string InObjName, UObject InObj)
	{
		if (ParentRefChainObjs == null)
		{
			ParentRefChainObjs = new List<WrappedRefObj>();
		}
		ParentRefChainObjs.Add(new WrappedRefObj(InObjName, InObj));
	}
}
