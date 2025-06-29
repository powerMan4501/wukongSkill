using System;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_QuestDataComp")]
public class BUS_QuestDataComp : BUS_ActorBaseDataComp
{
	private BUC_QuestOverlapData OverlapData;

	private BUC_QuestDynamicObstacleData DynamicObstacleData;

	private BUC_QuestCovertTimerOverlapData QuestCovertTimerOverlapData;

	private BUC_QuestSpawnWaveData SpawnWaveData;

	private static bool QuestActorType_IsValid;

	private static int QuestActorType_Offset;

	private static FFieldAddress QuestActorType_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_QuestDataComp:QuestActorType")]
	public EQuestActorType QuestActorType
	{
		get
		{
			CheckDestroyed();
			if (!QuestActorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_QuestDataComp:QuestActorType");
				return EQuestActorType.None;
			}
			return EnumMarshaler<EQuestActorType>.FromNative(IntPtr.Add(base.Address, QuestActorType_Offset), 0, QuestActorType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!QuestActorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_QuestDataComp:QuestActorType");
			}
			else
			{
				EnumMarshaler<EQuestActorType>.ToNative(IntPtr.Add(base.Address, QuestActorType_Offset), 0, QuestActorType_PropertyAddress.Address, value);
			}
		}
	}

	private BGU_QuestActor OwnerAsQuestActor => GetOwner() as BGU_QuestActor;

	protected override void InitOnNewInCSImpl()
	{
		QuestActorType = OwnerAsQuestActor.QuestActorType;
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_QuestGeneralData>();
		switch (QuestActorType)
		{
		case EQuestActorType.Overlap:
			OverlapData = CreateDataClass<BUC_QuestOverlapData>();
			OverlapDataConvert();
			break;
		case EQuestActorType.DynamicObstacle:
			DynamicObstacleData = CreateDataClass<BUC_QuestDynamicObstacleData>();
			DynamicObstacleDataConvert();
			break;
		case EQuestActorType.Checker:
			CreateDataClass<BUC_QuestCheckerData>();
			break;
		case EQuestActorType.CovertTimer:
			QuestCovertTimerOverlapData = CreateDataClass<BUC_QuestCovertTimerOverlapData>();
			CovertTimerDataConvert();
			break;
		case EQuestActorType.PlayerChecker:
			CreateDataClass<BUC_QuestPlayerCheckerData>();
			break;
		case EQuestActorType.SpawnWaves:
			SpawnWaveData = CreateDataClass<BUC_QuestSpawnWaveData>();
			SpawnWavesDataConvert();
			break;
		case EQuestActorType.BirthDecideArea:
			OverlapData = CreateDataClass<BUC_QuestOverlapData>();
			BirthDecideAreaDataConvert();
			break;
		case EQuestActorType.Spawn:
		case EQuestActorType.HLMQuest:
			break;
		case EQuestActorType.None:
			break;
		}
	}

	private void OverlapDataConvert()
	{
		OverlapData.bAutoEnableOverlap = OwnerAsQuestActor.bAutoEnableOverlap;
		BUC_QuestOverlapData overlapData = OverlapData;
		overlapData.BeginOverlapAction = (Del_CollisionBeginOverlap)Delegate.Combine(overlapData.BeginOverlapAction, new Del_CollisionBeginOverlap(OwnerAsQuestActor.OnCollisionBeginOverlap));
		BUC_QuestOverlapData overlapData2 = OverlapData;
		overlapData2.EndOverlapAction = (Del_CollisionEndOverlap)Delegate.Combine(overlapData2.EndOverlapAction, new Del_CollisionEndOverlap(OwnerAsQuestActor.OnCollisionEndOverlap));
	}

	private void BirthDecideAreaDataConvert()
	{
		OverlapData.bAutoEnableOverlap = true;
		BUC_QuestOverlapData overlapData = OverlapData;
		overlapData.BeginOverlapAction = (Del_CollisionBeginOverlap)Delegate.Combine(overlapData.BeginOverlapAction, new Del_CollisionBeginOverlap(OwnerAsQuestActor.OnCollisionBeginOverlap));
		BUC_QuestOverlapData overlapData2 = OverlapData;
		overlapData2.EndOverlapAction = (Del_CollisionEndOverlap)Delegate.Combine(overlapData2.EndOverlapAction, new Del_CollisionEndOverlap(OwnerAsQuestActor.OnCollisionEndOverlap));
		OverlapData.BirthPointID = OwnerAsQuestActor.AssignBirthPointID;
	}

	private void DynamicObstacleDataConvert()
	{
		DynamicObstacleData.bAutoEnable = OwnerAsQuestActor.bAutoEnableDynamicObstacle;
		DynamicObstacleData.PerformID = OwnerAsQuestActor.PerformID;
		DynamicObstacleData.bEnableDebug = OwnerAsQuestActor.bEnableDynamicObstacleCollisionDebug;
		BUC_QuestDynamicObstacleData dynamicObstacleData = DynamicObstacleData;
		dynamicObstacleData.Evt_EnableDynamicObstacle = (Del_Void)Delegate.Combine(dynamicObstacleData.Evt_EnableDynamicObstacle, new Del_Void(OwnerAsQuestActor.OnEnableDynamicObstacle));
		BUC_QuestDynamicObstacleData dynamicObstacleData2 = DynamicObstacleData;
		dynamicObstacleData2.Evt_DisableDynamicObstacle = (Del_Void)Delegate.Combine(dynamicObstacleData2.Evt_DisableDynamicObstacle, new Del_Void(OwnerAsQuestActor.OnDisableDynamicObstacle));
	}

	private void CovertTimerDataConvert()
	{
		QuestCovertTimerOverlapData.InBox_Remaining = OwnerAsQuestActor.Timer_InArea;
		QuestCovertTimerOverlapData.OutBox_Remaining = OwnerAsQuestActor.Timer_OutArea;
	}

	public void SpawnWavesDataConvert()
	{
		SpawnWaveData.bRecoverToNoSpawn = OwnerAsQuestActor.bRecoverToNoSpawn;
		SpawnWaveData.SpawnWaveGroupID = OwnerAsQuestActor.SpawnWaveGroupID;
		SpawnWaveData.SpawnWaveGlobleGroupCD = OwnerAsQuestActor.SpawnWaveGlobleGroupCD;
		SpawnWaveData.EnsureBornPosCanNavToPlayer = OwnerAsQuestActor.EnsureBornPosCanNavToPlayer;
		SpawnWaveData.SpawnWaveType = OwnerAsQuestActor.SpawnWaveType;
		SpawnWaveData.WaveStopActionType = OwnerAsQuestActor.WaveStopActionType;
		SpawnWaveData.FirstWaveStartCondition = new FCompositeCondition_SpawnWaveStartForData(OwnerAsQuestActor.FirstWaveStartCondition);
		switch (SpawnWaveData.SpawnWaveType)
		{
		case ESpawnWaveType.SpawnSequence:
			SpawnWaveData.Waves.Clear();
			{
				foreach (FSpawnWaveConfig wave in OwnerAsQuestActor.Waves)
				{
					SpawnWaveData.Waves.Add(new FSpawnWaveConfigForData(wave));
				}
				break;
			}
		case ESpawnWaveType.SpawnInfinite:
			SpawnWaveData.SpawnWaveConfig_Infinite = new FSpawnWaveConfigForData_Infinite(OwnerAsQuestActor.InfiniteWave);
			break;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_QuestDataComp");
		NativeReflection.GetPropertyRef(ref QuestActorType_PropertyAddress, unrealStruct, "QuestActorType");
		QuestActorType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "QuestActorType");
		QuestActorType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "QuestActorType", Classes.FEnumProperty);
	}

	static BUS_QuestDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_QuestDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_QuestDataComp));
	}
}
