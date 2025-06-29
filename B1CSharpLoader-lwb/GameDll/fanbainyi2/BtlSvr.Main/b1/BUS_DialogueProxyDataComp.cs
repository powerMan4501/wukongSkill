using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DialogueProxyDataComp")]
public class BUS_DialogueProxyDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_AKMgrData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DialogueProxyDataComp");
	}

	static BUS_DialogueProxyDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DialogueProxyDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DialogueProxyDataComp));
	}
}
