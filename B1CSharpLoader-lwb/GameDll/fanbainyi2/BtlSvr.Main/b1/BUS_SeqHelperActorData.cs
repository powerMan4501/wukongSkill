using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorData")]
public class BUS_SeqHelperActorData : UObject
{
	public string SeqBroadCastTag;

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SeqHelperActorData");
	}

	static BUS_SeqHelperActorData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SeqHelperActorData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SeqHelperActorData));
	}
}
