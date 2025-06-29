using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BPS_PlayerControllerDataCompB1")]
public class BPS_PlayerControllerDataCompB1 : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BPC_PlayerControllerTestData>();
		CreateDataClass<BPC_PlayerRoleData>();
		CreateDataClass<BPC_RebirthPointData>();
		CreateDataClass<BPC_PredictionKeyServerStateData>();
		CreateDataClass<BPC_SyncTamerDataServer>();
		CreateDataClass<BPC_SyncTamerDataClient>();
		CreateDataClass<BPC_BattleMainInfoData>();
		CreateDataClass<b1.BPC_PostProcessMatData>();
		CreateDataClass<BPC_InputData>();
		CreateDataClass<BPC_ListenerMgrData>();
		CreateDataClass<BPC_MultiTargetProjectileCtrData>();
		CreateDataClass<BPC_GeoInfoData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BPS_PlayerControllerDataCompB1");
	}

	static BPS_PlayerControllerDataCompB1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BPS_PlayerControllerDataCompB1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BPS_PlayerControllerDataCompB1));
	}
}
