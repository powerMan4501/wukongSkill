using System;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CutDeathDataComp")]
internal class BUS_CutDeathDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateData<b1.BUC_CutDeathData>();
		CreateDataClass<BUC_DispLibDBCBaseData>().Init(GetOwner().GetRootComponent(), DispLibDBCActorGroup.BattleUnit);
		CreateDataClass<BUC_DispLibDBCQueueData>().Init();
		BUC_DispLibUnitRendererBaseData bUC_DispLibUnitRendererBaseData = CreateDataClass<BUC_DispLibUnitRendererBaseData>();
		USkeletalMeshComponent componentByClass = GetOwner().GetComponentByClass<USkeletalMeshComponent>();
		bUC_DispLibUnitRendererBaseData.Init(0f, 0, componentByClass);
		CreateDataClass<BUC_DispLibUnitArtFresnelRequestsQueueData>().Init(bUC_DispLibUnitRendererBaseData);
		CreateDataClass<BUC_DispLibSetUnitMaterialsParamsRequestsQueueData>().Init(bUC_DispLibUnitRendererBaseData);
		CreateDataClass<BUC_DispLibDBCBaseData>().Init(componentByClass, DispLibDBCActorGroup.BattleUnit);
		CreateDataClass<BUC_DispLibDBCQueueData>().Init();
		CreateDataClass<BUC_ABPEventCollection>();
		CreateDataClass<BUC_ABPBasicData>();
		CreateDataClass<BUC_ABPBGUCharacterData>();
		CreateDataClass<BUC_ABPCharacterData>();
		CreateDataClass<BUC_ABPCommonSettingData>();
		CreateDataClass<BUC_ABPMotionMatchingData>();
		CreateDataClass<BUC_ABPPatrolData>();
		CreateDataClass<BUC_ABPNPCAnimData>();
		CreateDataClass<BUC_ABPJogData>();
		CreateDataClass<BUC_ABPJumpV2Data>();
		CreateDataClass<BUC_ABPCommonLocomotionData>();
		CreateDataClass<BUC_ABPFootIKData>();
		CreateDataClass<BUC_ABPSpineIKData>();
		CreateDataClass<BUC_ABPAttackIKData>();
		CreateDataClass<BUC_ABPHeadAimingData>();
		CreateDataClass<BUC_ABPUpperBodyAimingData>();
		CreateDataClass<BUC_ABPMMFixedData>();
		CreateDataClass<BUC_ABPBodyBlendData>();
		CreateDataClass<BUC_ABPFlyControlData>();
		CreateDataClass<BUC_ABPPoseSnapshotData>();
		CreateDataClass<BUC_ABPPlayerLocomotionData>();
		CreateDataClass<BUC_ABPGlideMoveData>();
		CreateDataClass<BUC_ABPWheelMoveData>();
		CreateDataClass<BUC_ABPAimOffsetData>();
		CreateDataClass<BUC_ABPSpecialMoveData>();
		CreateDataClass<BUC_ABPParkourMoveData>();
		CreateDataClass<BUC_ABPAMMatryoshkaData>();
		CreateDataClass<BUC_ABPMonsterLocomotionData>();
		CreateDataClass<BUC_ABPAttackOffsetData>();
		CreateDataClass<BUC_ABPHelperData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_CutDeathDataComp");
	}

	static BUS_CutDeathDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_CutDeathDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_CutDeathDataComp));
	}
}
