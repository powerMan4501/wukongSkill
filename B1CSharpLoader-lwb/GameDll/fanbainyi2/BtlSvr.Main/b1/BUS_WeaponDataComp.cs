using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_WeaponDataComp")]
public class BUS_WeaponDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_WeaponCommData>();
		CreateDataClass<BUC_FlowGeneralData>();
		CreateDataClass<BUC_PropMgrData>();
		CreateDataClass<BUC_MasterData>();
		if (BasicData != null)
		{
			BasicData.ActorType = BGU_ActorType.Weapon;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_WeaponDataComp");
	}

	static BUS_WeaponDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_WeaponDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_WeaponDataComp));
	}
}
