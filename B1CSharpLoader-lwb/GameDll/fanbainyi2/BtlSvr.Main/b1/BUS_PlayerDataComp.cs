using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_PlayerDataComp")]
public class BUS_PlayerDataComp : BUS_BGUDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_TouchWallFeedbackData>();
		CreateDataClass<BUC_CloudMoveData>();
		CreateDataClass<BUC_PlayerCameraData>();
		CreateDataClass<BUC_PoleDrinkData>();
		CreateDataClass<BUC_QiTianDaShengData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_PlayerDataComp");
	}

	static BUS_PlayerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_PlayerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_PlayerDataComp));
	}
}
