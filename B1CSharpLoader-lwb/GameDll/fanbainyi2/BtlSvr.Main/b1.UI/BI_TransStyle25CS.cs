using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransStyle25CS")]
public class BI_TransStyle25CS : BI_TransStyleStickCS
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TransStyle25CS");
	}

	static BI_TransStyle25CS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransStyle25CS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransStyle25CS));
	}
}
