using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BPS_PlayerStateDataCompB1")]
public class BPS_PlayerStateDataCompB1 : BUS_ActorBaseDataComp, IActorGSReplicateableDataComp
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
			return BPS_EventCollectionCS.Get(GetOwner() as ABGPPlayerState).Evt_BPS_DoReplicateData.Invoke(ConnectionPtr, Data.ToArray());
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
		BPS_EventCollectionCS.Get(GetOwner() as ABGPPlayerState).Evt_BPS_CollectReplicateData.Invoke(ConnectionPtr, OldVersion, out var bytes);
		Data.CopyFrom(bytes);
		return BGWGameInstanceCS.sGlobalReplicateVersionAlloc;
	}

	[USharpPath("/Script/b1-Managed.BPS_PlayerStateDataCompB1:PreECSBeginPlay")]
	protected override void PreECSBeginPlay_Implementation()
	{
		BPS_RepStateInitHelper.InitNetRole(Entity, BGUFuncLibReplication.GetActorNetRole(GetOwner()));
		base.PreECSBeginPlay_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BPS_PlayerStateDataCompB1:LateECSBeginPlay")]
	protected override void LateECSBeginPlay_Implementation()
	{
		base.LateECSBeginPlay_Implementation();
		foreach (b1.RepDataCache item in ReplicationBytesCacheBeforeBeginPlay)
		{
			BPS_EventCollectionCS.Get(GetOwner() as APlayerState).Evt_BPS_DoReplicateData.Invoke(item.ConnectionPtr, item.Data);
		}
		ReplicationBytesCacheBeforeBeginPlay.Clear();
	}

	protected override void InitOnNewInCSImpl()
	{
		CreateDataClass<BPC_PlayerStateTestData>();
		CreateDataClass<BPC_RoleBaseData>();
		CreateDataClass<BPC_PlayerCameraData>();
		CreateDataClass<BPC_TransData>();
		CreateDataClass<BPC_PlayerTagData>();
		CreateDataClass<BPC_PlayerAttrData>();
		CreateDataClass<BPC_AutoTestData>();
		CreateDataClass<BPC_PlayerInteractData>();
		CreateDataClass<BPC_PlayerPerformData>();
		CreateDataClass<BPC_FoliageCameraFadeData>();
		CreateDataClass<BPC_MapSymbolData>();
		CreateDataClass<BPC_TransactionData>();
		CreateDataClass<BPC_MapAreaData>();
		base.InitOnNewInCSImpl();
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_PlayerStateDataCompB1:PreECSBeginPlay")]
	private static void PreECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_PlayerStateDataCompB1 bPS_PlayerStateDataCompB = GCHelper.Find<BPS_PlayerStateDataCompB1>(obj);
		bPS_PlayerStateDataCompB.PreECSBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_PlayerStateDataCompB1:LateECSBeginPlay")]
	private static void LateECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_PlayerStateDataCompB1 bPS_PlayerStateDataCompB = GCHelper.Find<BPS_PlayerStateDataCompB1>(obj);
		bPS_PlayerStateDataCompB.LateECSBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BPS_PlayerStateDataCompB1");
		PreECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreECSBeginPlay");
		PreECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(PreECSBeginPlay_FunctionAddress);
		PreECSBeginPlay_IsValid = PreECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_PlayerStateDataCompB1:PreECSBeginPlay", PreECSBeginPlay_IsValid);
		LateECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LateECSBeginPlay");
		LateECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(LateECSBeginPlay_FunctionAddress);
		LateECSBeginPlay_IsValid = LateECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_PlayerStateDataCompB1:LateECSBeginPlay", LateECSBeginPlay_IsValid);
	}

	static BPS_PlayerStateDataCompB1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BPS_PlayerStateDataCompB1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BPS_PlayerStateDataCompB1));
	}
}
