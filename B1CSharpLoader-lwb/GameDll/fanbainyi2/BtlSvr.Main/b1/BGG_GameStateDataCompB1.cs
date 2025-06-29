using System;
using System.Collections.Generic;
using b1.GameState.Data;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGG_GameStateDataCompB1")]
public class BGG_GameStateDataCompB1 : BUS_ActorBaseDataComp, IActorGSReplicateableDataComp
{
	private List<b1.RepDataCache> ReplicationBytesCacheBeforeBeginPlay = new List<b1.RepDataCache>();

	private static bool PreECSBeginPlay_IsValid;

	private static IntPtr PreECSBeginPlay_FunctionAddress;

	private static int PreECSBeginPlay_ParamsSize;

	private static bool LateECSBeginPlay_IsValid;

	private static IntPtr LateECSBeginPlay_FunctionAddress;

	private static int LateECSBeginPlay_ParamsSize;

	public int DeltaDeSerilize(IntPtr ConnectionPtr, NativeList<byte> Data)
	{
		if (LateBeginPlayFinish)
		{
			return BGS_EventCollectionCS.Get(GetOwner()).Evt_BGS_DoReplicateData.Invoke(ConnectionPtr, Data.ToArray());
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
		BGS_EventCollectionCS.Get(GetOwner()).Evt_BGS_CollectReplicateData.Invoke(ConnectionPtr, OldVersion, out var bytes);
		Data.CopyFrom(bytes);
		return BGWGameInstanceCS.sGlobalReplicateVersionAlloc;
	}

	[USharpPath("/Script/b1-Managed.BGG_GameStateDataCompB1:PreECSBeginPlay")]
	protected override void PreECSBeginPlay_Implementation()
	{
		BGS_RepStateInitHelper.InitNetRole(Entity, BGUFuncLibReplication.GetActorNetRole(GetOwner()));
		base.PreECSBeginPlay_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGG_GameStateDataCompB1:LateECSBeginPlay")]
	protected override void LateECSBeginPlay_Implementation()
	{
		base.LateECSBeginPlay_Implementation();
		foreach (b1.RepDataCache item in ReplicationBytesCacheBeforeBeginPlay)
		{
			BGS_EventCollectionCS.Get(GetOwner()).Evt_BGS_DoReplicateData.Invoke(item.ConnectionPtr, item.Data);
		}
		ReplicationBytesCacheBeforeBeginPlay.Clear();
	}

	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BGC_UnrealGameplayData>().Init(GetOwner() as AGameState);
		CreateDataClass<BGC_GameStateTestData>();
		CreateDataClass<BGC_QuestData>();
		CreateDataClass<BGC_LevelBattleData>();
		CreateDataClass<BGC_LevelAuthorityData>();
		CreateDataClass<BGC_OSSCollectionData>();
		CreateDataClass<BGC_PredictionKeyData>();
		CreateDataClass<BGC_GlobalBattleStateData>();
		CreateDataClass<BGC_SimpleOverlapMgrData>();
		CreateDataClass<BGC_AudioData>();
		CreateDataClass<BGC_RandomEventData>();
		CreateDataClass<BGC_BossTraceData>();
		CreateDataClass<BGC_TamerData>();
		CreateDataClass<BGC_StreamingLevelControlData>();
		CreateDataClass<BGC_FollowPartnerMgrData>();
		CreateDataClass<BGC_GroupAIMgrData>();
		CreateDataClass<BGC_AssociationUnitData>();
		CreateDataClass<BGC_OnlineChallengeData>();
		CreateDataClass<BGC_CollectionGroupData>();
		CreateDataClass<BGC_CircusControlData>();
		CreateDataClass<BGC_MovieData>();
		CreateDataClass<BGC_DebugTargetMgrData>();
		CreateDataClass<BGC_RenderTargetData>();
		CreateDataClass<BGC_CamShakeData>();
		CreateDataClass<BGC_SpiderNavigationData>();
		CreateDataClass<BGC_SceneInactiveObjectMgrData>();
		CreateDataClass<BGC_TeamRelationData>();
		CreateDataClass<BGC_RuntimeMeshActorsMgrData>();
		CreateDataClass<BGC_UnitPatrolGroupMgrData>();
		CreateDataClass<BGC_GameBgmMgrData>();
		CreateDataClass<BGC_DynamicGameObjectData>();
		CreateDataClass<BGC_LevelActorData>();
		CreateDataClass<BGC_AiConversationMgrData>();
		CreateDataClass<BGC_BuffDispMgrData>();
		CreateDataClass<BGC_OnlineAssistData>();
		CreateDataClass<BGC_LocalFluid2DMgrData>();
		CreateDataClass<BGC_TransEffectData>();
		CreateDataClass<BGC_FoliageInteractSoundMgrData>();
		CreateDataClass<BGC_OnlineTeammateData>();
		CreateDataClass<BGC_SummonData>();
		CreateDataClass<BGC_SkillPreviewMgrData>();
		CreateDataClass<BGC_PigsyStoryData>();
		CreateDataClass<BGC_PlayerGuideData>();
		CreateDataClass<BGC_PlayerDeathData>();
		CreateDataClass<BGC_TaskCollectionMgrData>();
		CreateDataClass<BGC_SpawnWaveGroupMgrData>();
		CreateDataClass<BGC_SoulItemData>();
		CreateDataClass<BGC_NeutralAnimalSpawnMgrData>();
		CreateDataClass<BGC_BattleFieldPerformanceOptData>();
		CreateDataClass<BGC_FieldData>();
		CreateDataClass<BGC_AnimationSyncData>();
		CreateDataClass<BGC_WeaponManagerData>();
		CreateDataClass<BGC_GroupLeisureSyncData>();
		CreateDataClass<BGC_EnvMgrData>();
		CreateDataClass<BGC_MessageDistributionCenterData>();
		CreateDataClass<BGC_GlobalAIMgrData>();
		CreateDataClass<BGC_LocalPlayerSharedData>();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameStateDataCompB1:PreECSBeginPlay")]
	private static void PreECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameStateDataCompB1 bGG_GameStateDataCompB = GCHelper.Find<BGG_GameStateDataCompB1>(obj);
		bGG_GameStateDataCompB.PreECSBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameStateDataCompB1:LateECSBeginPlay")]
	private static void LateECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameStateDataCompB1 bGG_GameStateDataCompB = GCHelper.Find<BGG_GameStateDataCompB1>(obj);
		bGG_GameStateDataCompB.LateECSBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGG_GameStateDataCompB1");
		PreECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreECSBeginPlay");
		PreECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(PreECSBeginPlay_FunctionAddress);
		PreECSBeginPlay_IsValid = PreECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameStateDataCompB1:PreECSBeginPlay", PreECSBeginPlay_IsValid);
		LateECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LateECSBeginPlay");
		LateECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(LateECSBeginPlay_FunctionAddress);
		LateECSBeginPlay_IsValid = LateECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameStateDataCompB1:LateECSBeginPlay", LateECSBeginPlay_IsValid);
	}

	static BGG_GameStateDataCompB1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGG_GameStateDataCompB1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGG_GameStateDataCompB1));
	}
}
