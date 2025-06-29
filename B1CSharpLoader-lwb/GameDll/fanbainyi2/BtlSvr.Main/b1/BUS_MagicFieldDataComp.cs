using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_MagicFieldDataComp")]
public class BUS_MagicFieldDataComp : BUS_ProjectileBaseDataComp
{
	private BUC_ObjActorCompsData ObjActorCompsData;

	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_BuffData>();
		CreateDataClass<BUC_MFNegativeOverlapData>();
		CreateDataClass<BUC_MFOverlapData>();
		CreateDataClass<BUC_RenderTargetMgrData>();
		CreateDataClass<b1.BUC_MatMgrData>();
		CreateDataClass<b1.BUC_MFDirectionData>();
		CreateDataClass<BUC_MFEffectData>();
		CreateDataClass<BUC_MFDispData>();
		CreateDataClass<BUC_BuffDispData>();
		if (BasicData != null)
		{
			BasicData.ActorType = BGU_ActorType.MagicField;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_MagicFieldDataComp");
	}

	static BUS_MagicFieldDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_MagicFieldDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_MagicFieldDataComp));
	}
}
