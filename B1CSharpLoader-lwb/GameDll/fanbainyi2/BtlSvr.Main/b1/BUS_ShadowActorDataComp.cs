using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ShadowActorDataComp")]
public class BUS_ShadowActorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_ShadowPoseableData>();
		CreateDataClass<BUC_CharacterModularData>();
		CreateDataClass<BUC_EquipData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ShadowActorDataComp");
	}

	static BUS_ShadowActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ShadowActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ShadowActorDataComp));
	}
}
