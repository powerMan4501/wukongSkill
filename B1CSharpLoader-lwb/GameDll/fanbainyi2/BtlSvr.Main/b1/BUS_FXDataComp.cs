using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_FXDataComp")]
public class BUS_FXDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_FXActorBaseData>();
		CreateDataClass<BUC_FXActorLifeData>();
		CreateDataClass<BUC_RenderTargetMgrData>();
		CreateDataClass<BUC_FXActorAudioData>();
		CreateDataClass<b1.BUC_DestructibleData>();
		CreateDataClass<BUC_TickRateData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_FXDataComp");
	}

	static BUS_FXDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_FXDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_FXDataComp));
	}
}
