using System;
using System.Collections.Generic;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BGUDataComp")]
public class BUS_BGUDataComp : BUS_BGUDataCompBase, IActorGSReplicateableDataComp
{
	private List<b1.RepDataCache> ReplicationBytesCacheBeforeBeginPlay = new List<b1.RepDataCache>();

	private static bool LateECSBeginPlay_IsValid;

	private static IntPtr LateECSBeginPlay_FunctionAddress;

	private static int LateECSBeginPlay_ParamsSize;

	protected BGUCharacterCS OwnerAsChr => GetOwner() as BGUCharacterCS;

	public int DeltaDeSerilize(IntPtr ConnectionPtr, NativeList<byte> Data)
	{
		if (LateBeginPlayFinish)
		{
			return BUS_EventCollectionCS.Get(GetOwner()).Evt_DoReplicateData.Invoke(ConnectionPtr, Data.ToArray());
		}
		ReplicationBytesCacheBeforeBeginPlay.Add(new b1.RepDataCache
		{
			ConnectionPtr = ConnectionPtr,
			Data = Data.ToArray()
		});
		return 0;
	}

	public int DeltaSerilize(IntPtr ConnectionPtr, int OldVersion, NativeList<byte> Data)
	{
		BUS_EventCollectionCS.Get(GetOwner()).Evt_CollectReplicateData.Invoke(ConnectionPtr, OldVersion, out var bytes);
		Data.CopyFrom(bytes);
		return BGWGameInstanceCS.sGlobalReplicateVersionAlloc;
	}

	[USharpPath("/Script/b1-Managed.BUS_BGUDataComp:LateECSBeginPlay")]
	protected override void LateECSBeginPlay_Implementation()
	{
		base.LateECSBeginPlay_Implementation();
		foreach (b1.RepDataCache item in ReplicationBytesCacheBeforeBeginPlay)
		{
			BUS_EventCollectionCS.Get(GetOwner()).Evt_DoReplicateData.Invoke(item.ConnectionPtr, item.Data);
		}
		ReplicationBytesCacheBeforeBeginPlay.Clear();
	}

	protected override void InitOnNewInCSImpl()
	{
		AddDataObjInCS(base.mUBUC_AIComponent);
		AddDataObjInCS(base.mUBUC_ACharacterComponent);
		if (ECSWorld != null)
		{
			ECSWorld.SetObject(Entity, base.mUBUC_AIComponent);
			ECSWorld.SetObject(Entity, base.mUBUC_ACharacterComponent);
		}
		BGUCharacterCS ownerAsChr = OwnerAsChr;
		int actorNetRole = BGUFuncLibReplication.GetActorNetRole(ownerAsChr);
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
		CreateDataClass<BUC_ABPAdvancedMonsterLocomotionData>();
		CreateDataClass<BUC_ABPGlideMoveData>();
		CreateDataClass<BUC_ABPAimOffsetData>();
		CreateDataClass<BUC_ABPWeaponAimData>();
		CreateDataClass<BUC_ABPWheelMoveData>();
		CreateDataClass<BUC_ABPSpecialMoveData>();
		CreateDataClass<BUC_ABPParkourMoveData>();
		CreateDataClass<BUC_ABPAMMatryoshkaData>();
		CreateDataClass<BUC_ABPMonsterLocomotionData>();
		CreateDataClass<BUC_ABPAttackOffsetData>();
		CreateDataClass<BUC_ABPSlowIKData>();
		CreateDataClass<BUC_ABPHelperData>();
		CreateDataClass<BUC_ABPQuadrupedLocomotionData>();
		CreateDataClass<BUC_ABPSplineMoveData>();
		CreateDataClass<BUC_ABPCloudLocomotionData>();
		CreateDataClass<BUC_ABPSpeicalAdditiveData>();
		BUC_AttrContainer bUC_AttrContainer = CreateDataClass<BUC_AttrContainer>();
		bUC_AttrContainer.Init();
		bUC_AttrContainer.Owner = ownerAsChr;
		CreateDataClass<BUC_UnitStateData>().Init(actorNetRole);
		CreateDataClass<BUC_SimpleStateData>().Init(actorNetRole);
		CreateDataClass<BUC_DashWallData>();
		CreateDataClass<BUC_ConfigInfoData>();
		CreateDataClass<BUC_GuidData>();
		CreateDataClass<BUC_WeaponManagerData>();
		CreateDataClass<b1.BUC_AbnormalHandleData>();
		CreateDataClass<BUC_MasterData>();
		CreateDataClass<b1.BUC_ComboCacheData>();
		CreateDataClass<b1.BUC_ComboWindowData>();
		CreateDataClass<BUC_QTEData>();
		CreateDataClass<BUC_MovementData>();
		CreateDataClass<BUC_BuffData>();
		CreateDataClass<BUC_ArmorData>();
		CreateDataClass<BUC_UnitBeAttackedFequenceData>();
		CreateDataClass<BUC_UnitHitVEffectData>();
		CreateDataClass<b1.BUC_WaterSplashData>();
		CreateDataClass<BUC_ActionRequestData>();
		CreateDataClass<BUC_MovementModes>();
		CreateDataClass<BUC_SweepCheckHitData>();
		CreateDataClass<BUC_AIData>();
		CreateDataClass<BUC_FlyMoveToData>();
		CreateDataClass<BUC_MandatoryAITaskData>();
		CreateDataClass<BUC_SkillInstsData>();
		CreateDataClass<BUC_BeAttackData>();
		CreateDataClass<BUC_StaminaData>();
		CreateDataClass<BUC_BirthData>();
		CreateDataClass<BUC_ActorInitData>();
		CreateDataClass<BUC_PlayerInputConfigData>();
		CreateDataClass<BUC_PlayerInputActionData>();
		CreateDataClass<BUC_PatrolData>();
		CreateDataClass<BUC_LifeSavingData>();
		CreateDataClass<b1.BUC_DistanceCheckData>();
		CreateDataClass<b1.BUC_BoneData>();
		CreateDataClass<BUC_WakeUpData>();
		CreateDataClass<b1.BUC_AnimMgrData>();
		CreateDataClass<BUC_SceneItemData>();
		CreateDataClass<b1.BUC_ProjectileCtrData>();
		CreateDataClass<BUC_UnitDebugData>();
		CreateDataClass<BUC_ChargeSkillData>();
		CreateDataClass<BUC_CharacterModularData>();
		CreateDataClass<BUC_EquipData>();
		CreateDataClass<b1.BUC_EnvironmentData>();
		CreateDataClass<BUC_CollisionHitMoveData>();
		CreateDataClass<BUC_PlayerTransData>();
		CreateDataClass<BUC_DispMgrData>();
		CreateDataClass<BUC_RollData>();
		CreateDataClass<BUC_CharacterMaterialData>();
		CreateDataClass<BUC_TickRateData>();
		CreateDataClass<BUC_PhysicBlendData>();
		CreateDataClass<b1.BUC_JumpData>();
		CreateDataClass<BUC_FallingData>();
		CreateDataClass<b1.BUC_MatMgrData>();
		CreateDataClass<BUC_VFXMgrData>();
		CreateDataClass<BUC_ControllerData>();
		CreateDataClass<BUC_AKMgrData>();
		CreateDataClass<BUC_DecalMgrData>();
		CreateDataClass<BUC_SkillMappingData>();
		CreateDataClass<b1.BUC_HairMgrData>();
		CreateDataClass<b1.BUC_CustomTimeDilationData>();
		CreateDataClass<b1.BUC_SummonBehaviorData>();
		CreateDataClass<BUC_HeroSwitchData>();
		CreateDataClass<b1.BUC_TriggerEffectData>();
		CreateDataClass<BUC_PartnerData>();
		CreateDataClass<BUC_PointSetsData>();
		CreateDataClass<BUC_FootStepData>();
		CreateDataClass<BUC_GroupAIData>();
		CreateDataClass<BUC_BattleBGMData>();
		CreateDataClass<BUC_IntimidateData>();
		CreateDataClass<BUC_EnvironmentInteractionMgrData>();
		CreateDataClass<b1.BUC_GlideMoveData>();
		CreateDataClass<BUC_ModularCtrlData>();
		CreateDataClass<b1.BUC_PhysAnimData>();
		CreateDataClass<b1.BUC_MovePhysicsTransformData>();
		CreateDataClass<b1.BUC_FXDetachData>();
		CreateDataClass<b1.BUC_InteractInfoCollectionData>();
		CreateDataClass<BUC_PartMgrData>();
		CreateDataClass<b1.BUC_CliffFallData>();
		CreateDataClass<BUC_DeadData>();
		CreateDataClass<BUC_BeAttackPerformData>();
		CreateDataClass<BUC_SkillSelectHelperData>();
		CreateDataClass<b1.BUC_PlayerSelectUnitData>();
		CreateDataClass<BUC_SkillInputAssistData>();
		CreateDataClass<BUC_SeqCameraData>();
		CreateDataClass<b1.BUC_SmartCastSkillData>();
		CreateDataClass<BUC_CollisionProfileMgrData>();
		CreateDataClass<b1.BUC_ParkourMoveData>();
		CreateDataClass<b1.BUC_PhysicalMoveData>();
		CreateDataClass<b1.BUC_SplineFlyMoveData>();
		CreateDataClass<b1.BUC_RelativeFloatMoveData>();
		CreateDataClass<BUC_AbnormalStateData>();
		CreateDataClass<BUC_AbnormalStateHandlers>();
		CreateDataClass<BUC_PotentialEnergyData>();
		CreateDataClass<BUC_PlayerRestData>();
		CreateDataClass<BUC_ComboGraphData>();
		CreateDataClass<b1.BUC_ImpactActionData>();
		CreateDataClass<BUC_SpecialBoneListData>();
		CreateDataClass<BUC_PostProcessMatData>();
		CreateDataClass<b1.BUC_MagicFieldParamData>();
		CreateDataClass<b1.BUC_HardMoveData>();
		CreateDataClass<BUC_ActorTransformInfoData>();
		CreateDataClass<BUC_FsmData>();
		CreateDataClass<BUC_BarSockData>();
		CreateDataClass<BUC_BehaviorGraphData>();
		CreateDataClass<BUC_UnitHatredData>();
		CreateDataClass<BUC_UnitHatredCacheData>();
		CreateDataClass<BUC_FallDyingData>();
		CreateDataClass<BUC_ScarData>();
		CreateDataClass<BUC_PassiveSkillData>();
		CreateDataClass<BUC_PerformerData>();
		CreateDataClass<BUC_AiConversationData>();
		CreateDataClass<BUC_AiConversationBlackboard>();
		CreateDataClass<BUC_CheckData>();
		CreateDataClass<BUC_BTCheckData>();
		CreateDataClass<BUC_PropMgrData>();
		CreateDataClass<BUC_CastImmobilizeData>();
		CreateDataClass<BUC_BeImmobilizedData>();
		CreateDataClass<BUC_BattleStateData>();
		CreateDataClass<BUC_IronBodyData>();
		CreateDataClass<BUC_SealingSpellData>();
		CreateDataClass<BUC_MagicallyChangeData>();
		CreateDataClass<b1.BUC_RootMotionFollowData>();
		CreateDataClass<BUC_AnimationSyncHostData>();
		CreateDataClass<BUC_AnimationSyncGuestData>();
		CreateDataClass<BUC_MontageSectionCtrlData>();
		CreateDataClass<BUC_RenderTargetMgrData>();
		CreateDataClass<BUC_FlowGeneralData>();
		CreateDataClass<BUC_PreciseDodgeData>();
		CreateDataClass<BUC_LandingData>();
		CreateDataClass<BUC_PhantomRushData>();
		CreateDataClass<BUC_TargetInfoData>();
		CreateDataClass<BUC_UnitFightTriggerData>();
		CreateDataClass<BUC_PlayerItemData>();
		CreateDataClass<BUC_UnitItemData>();
		CreateDataClass<BUC_TalentData>();
		CreateDataClass<BUC_EquipFaBaoData>();
		CreateDataClass<BUC_FlyCtrlData>();
		CreateDataClass<BUC_OSSCollectData>();
		CreateDataClass<BUC_PlayerSpellConfData>();
		CreateDataClass<BUC_BattleAICooperativeData>();
		CreateDataClass<BUC_AiInteractData>();
		CreateDataClass<BUC_InteractData>();
		CreateDataClass<BUC_SuperArmorLevelMappingData>();
		CreateDataClass<b1.BUC_ProceduralEnvInteractionTriggerData>();
		CreateDataClass<BUC_NPCShowData>();
		CreateDataClass<BUC_NPCConfigInfoData>();
		CreateDataClass<BUC_NPCAnimData>();
		CreateDataClass<BUC_UnitDestructibleManagerData>();
		CreateDataClass<BUC_ManualSplineMoveData>();
		CreateDataClass<BUC_AINodeData>();
		CreateDataClass<BUC_AnimNotifyAndStateData>();
		CreateDataClass<BUC_DumperTruckData>();
		CreateDataClass<BUC_UIControlData>();
		CreateDataClass<BUC_TimeScaleData>();
		CreateDataClass<BUC_GlobalFXData>();
		CreateDataClass<BUC_SimpleJumpData>();
		CreateDataClass<BUC_MagicSpellInfoData>();
		CreateDataClass<BUC_PartyRoomControlData>();
		CreateDataClass<BUC_UnitBarInfoData>();
		CreateDataClass<BUC_MontageSyncData>();
		CreateDataClass<BUC_TurretControlData>();
		CreateDataClass<BUC_TransEnergyData>();
		CreateDataClass<BUC_TransGuideData>();
		CreateDataClass<BUC_GMSystemData>();
		CreateDataClass<BUC_SpiderSilkEntangleData>();
		CreateDataClass<b1.BUC_FollowPartnerData>();
		CreateDataClass<BUC_PointLightMangerData>();
		CreateDataClass<BUC_AttachedNiagaraMgrData>();
		CreateDataClass<BUC_DetonateData>();
		CreateDataClass<BUC_TransitionPhaseData>();
		CreateDataClass<b1.BUC_FoliageInteractSoundData>();
		CreateDataClass<BUC_PigsyStoryData>();
		CreateDataClass<b1.BUC_PlayerInteractCricketData>();
		CreateDataClass<b1.BUC_HatchData>();
		CreateDataClass<BUC_BuffDispData>();
		CreateDataClass<BUC_AITransformModifyBySplineData>();
		CreateDataClass<BUC_BossControlData>();
		CreateDataClass<BUC_StateLibData>();
		CreateDataClass<BUC_EnvironmentMaskData>();
		CreateDataClass<BUC_FacialAnimData>();
		CreateDataClass<BUC_DispLibDBCBaseData>();
		CreateDataClass<BUC_DispLibDBCQueueData>();
		CreateDataClass<BUC_DispLibWEFMRequestsQueueData>();
		CreateDataClass<BUC_DispLibUnitRendererBaseData>();
		CreateDataClass<BUC_DispLibSetUnitMaterialsParamsRequestsQueueData>();
		CreateDataClass<BUC_VigourDropperData>();
		CreateDataClass<BUC_JumpToPositionData>();
		if (DebugConfig.DebugWidget)
		{
			CreateDataClass<BUC_DebugInfoData>();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_BGUDataComp:LateECSBeginPlay")]
	private static void LateECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_BGUDataComp bUS_BGUDataComp = GCHelper.Find<BUS_BGUDataComp>(obj);
		bUS_BGUDataComp.LateECSBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_BGUDataComp");
		LateECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LateECSBeginPlay");
		LateECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(LateECSBeginPlay_FunctionAddress);
		LateECSBeginPlay_IsValid = LateECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_BGUDataComp:LateECSBeginPlay", LateECSBeginPlay_IsValid);
	}

	static BUS_BGUDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BGUDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BGUDataComp));
	}
}
