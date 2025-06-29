using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransStyle23CS")]
public class BI_TransStyle23CS : BI_TransStyleCS
{
	protected override void ToState2()
	{
		SwitchToState("StB");
		StateAdd();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TransStyle23CS");
	}

	static BI_TransStyle23CS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransStyle23CS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransStyle23CS));
	}
}
