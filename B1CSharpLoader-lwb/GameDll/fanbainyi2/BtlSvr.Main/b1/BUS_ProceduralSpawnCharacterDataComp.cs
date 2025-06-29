using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProceduralSpawnCharacterDataComp")]
public class BUS_ProceduralSpawnCharacterDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_ProceduralSpawnCharacterData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProceduralSpawnCharacterDataComp");
	}

	static BUS_ProceduralSpawnCharacterDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProceduralSpawnCharacterDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProceduralSpawnCharacterDataComp));
	}
}
