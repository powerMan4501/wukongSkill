using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUPerformerControlDataComp")]
public class BGUPerformerControlDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_PerformerControlData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUPerformerControlDataComp");
	}

	static BGUPerformerControlDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPerformerControlDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUPerformerControlDataComp));
	}
}
