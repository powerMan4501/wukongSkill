using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataComp")]
public class BUS_ProceduralMapGeneratorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_ProceduralMapGeneratorData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataComp");
	}

	static BUS_ProceduralMapGeneratorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProceduralMapGeneratorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProceduralMapGeneratorDataComp));
	}
}
