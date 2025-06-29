using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_NarratorDataComp")]
public class BUS_NarratorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_AKMgrData>();
		CreateDataClass<BUC_AiConversationData>();
		CreateDataClass<BUC_AiConversationBlackboard>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_NarratorDataComp");
	}

	static BUS_NarratorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_NarratorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_NarratorDataComp));
	}
}
