using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorDataComp")]
public class BUS_SeqHelperActorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUS_SeqHelperActorData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SeqHelperActorDataComp");
	}

	static BUS_SeqHelperActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SeqHelperActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SeqHelperActorDataComp));
	}
}
