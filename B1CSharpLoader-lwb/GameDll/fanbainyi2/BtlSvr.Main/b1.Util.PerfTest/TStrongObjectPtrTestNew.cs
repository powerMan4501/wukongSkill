using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

public class TStrongObjectPtrTestNew : UObject
{
	public TStrongObjectPtr<UObject> A = new TStrongObjectPtr<UObject>();

	public List<TStrongObjectPtr<UObject>> B = new List<TStrongObjectPtr<UObject>>();

	public void Test()
	{
		A.Set(UObject.NewObject<UObject>());
		A.Get().MarkPendingKill();
		A.Set(null);
		B.Add(A);
	}
}
