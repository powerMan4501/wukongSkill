using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProjectileBaseDataComp")]
public class BUS_ProjectileBaseDataComp : BUS_ActorBaseDataComp, IActorGSReplicateableDataComp
{
	private BUC_ObjActorCompsData ObjActorCompsData;

	private List<b1.RepDataCache> ReplicationBytesCacheBeforeBeginPlay = new List<b1.RepDataCache>();

	private static bool LateECSBeginPlay_IsValid;

	private static IntPtr LateECSBeginPlay_FunctionAddress;

	private static int LateECSBeginPlay_ParamsSize;

	public int DeltaDeSerilize(IntPtr ConnectionPtr, NativeList<byte> Data)
	{
		if (LateBeginPlayFinish)
		{
			return BUS_EventCollectionCS.Get(BGUGetOwner()).Evt_DoReplicateData.Invoke(ConnectionPtr, Data.ToArray());
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
		BUS_EventCollectionCS.Get(BGUGetOwner()).Evt_CollectReplicateData.Invoke(ConnectionPtr, OldVersion, out var bytes);
		Data.CopyFrom(bytes);
		return BGWGameInstanceCS.sGlobalReplicateVersionAlloc;
	}

	[USharpPath("/Script/b1-Managed.BUS_ProjectileBaseDataComp:LateECSBeginPlay")]
	protected override void LateECSBeginPlay_Implementation()
	{
		base.LateECSBeginPlay_Implementation();
		foreach (b1.RepDataCache item in ReplicationBytesCacheBeforeBeginPlay)
		{
			BUS_EventCollectionCS.Get(BGUGetOwner()).Evt_DoReplicateData.Invoke(item.ConnectionPtr, item.Data);
		}
		ReplicationBytesCacheBeforeBeginPlay.Clear();
	}

	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		ObjActorCompsData = CreateDataClass<BUC_ObjActorCompsData>();
		CreateDataClass<BUC_TickRateData>();
		CreateDataClass<BUC_ProjectileBasicData>();
		CreateDataClass<BUC_MasterData>();
		CreateDataClass<BUC_ObjActorMovementData>();
		CreateDataClass<BUC_BulletEffectData>();
		CreateDataClass<BUC_ProjectilePhysicData>();
		CreateDataClass<BUC_ProjectileLifeData>();
		CreateDataClass<BUC_BulletMatMergeData>();
		CreateDataClass<BUC_AKMgrData>();
		CreateDataClass<b1.BUC_TriggerEffectData>();
		CreateDataClass<BUC_SweepCheckHitData>();
		CreateDataClass<BUC_ProjectileScaleMgrData>();
		CreateDataClass<b1.BUC_ProjectileDispInteractData>();
		CreateDataClass<BUC_ProjectileAudioData>();
		CreateDataClass<BUC_ProjectileLaserData>();
		CreateDataClass<BUC_DestructibleDestroyEffectTriggerData>();
		CreateDataClass<b1.BUC_ProceduralEnvInteractionTriggerData>();
		CreateDataClass<BUC_BulletHitInfoData>();
		CreateDataClass<BUC_ProjectileSimpleMoveData>();
		CreateDataClass<BUC_BulletSweepReactionData>();
		CreateDataClass<BUC_BulletDispData>();
		CreateDataClass<BUC_ProjectileWindBrokenAudioData>();
		InitWithProjectileBaseActor(BGUGetOwner() as BGUProjectileBaseActor);
	}

	public void InitWithProjectileBaseActor(BGUProjectileBaseActor ProjectileBaseActor)
	{
		ObjActorCompsData.InitWithObjActor(ProjectileBaseActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ProjectileBaseDataComp:LateECSBeginPlay")]
	private static void LateECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ProjectileBaseDataComp bUS_ProjectileBaseDataComp = GCHelper.Find<BUS_ProjectileBaseDataComp>(obj);
		bUS_ProjectileBaseDataComp.LateECSBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProjectileBaseDataComp");
		LateECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LateECSBeginPlay");
		LateECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(LateECSBeginPlay_FunctionAddress);
		LateECSBeginPlay_IsValid = LateECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ProjectileBaseDataComp:LateECSBeginPlay", LateECSBeginPlay_IsValid);
	}

	static BUS_ProjectileBaseDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProjectileBaseDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProjectileBaseDataComp));
	}
}
