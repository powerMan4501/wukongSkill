using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransStyle19CS")]
public class BI_TransStyle19CS : BI_TransStyleStickCS
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TransStyle19CS");
	}

	static BI_TransStyle19CS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransStyle19CS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransStyle19CS));
	}
}
