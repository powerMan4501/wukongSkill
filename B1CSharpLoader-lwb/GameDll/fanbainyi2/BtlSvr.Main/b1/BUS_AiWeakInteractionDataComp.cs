using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AiWeakInteractionDataComp")]
internal class BUS_AiWeakInteractionDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_TickRateData>();
		CreateDataClass<b1.BUC_AiWeakInteractData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_AiWeakInteractionDataComp");
	}

	static BUS_AiWeakInteractionDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_AiWeakInteractionDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_AiWeakInteractionDataComp));
	}
}
