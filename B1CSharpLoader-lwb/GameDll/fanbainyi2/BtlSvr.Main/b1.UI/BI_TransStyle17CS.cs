using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransStyle17CS")]
public class BI_TransStyle17CS : BI_TransStyleCS
{
	protected override void ToState2()
	{
		SwitchToState("StB");
		StateAdd();
	}

	protected override void ToState3()
	{
		SwitchToState("StB");
		StateAdd();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TransStyle17CS");
	}

	static BI_TransStyle17CS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransStyle17CS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransStyle17CS));
	}
}
