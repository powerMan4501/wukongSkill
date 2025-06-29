using System;
using b1.ECS;
using b1.Plugins.GSReplaySystem;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibReplication")]
public class BGUFuncLibReplication : UBlueprintFunctionLibrary
{
	private static bool GetActorNetRole_IsValid;

	private static IntPtr GetActorNetRole_FunctionAddress;

	private static int GetActorNetRole_ParamsSize;

	private static bool GetActorNetRole_Owner_IsValid;

	private static int GetActorNetRole_Owner_Offset;

	private static bool GetActorNetRole_ReturnValue_IsValid;

	private static int GetActorNetRole_ReturnValue_Offset;

	public static uint GetNetGUIDByEntity(Entity Entity)
	{
		if (Entity.IsNull() || ECSExtension.ToActor(Entity) == null)
		{
			return 0u;
		}
		return BGW_NativeFuncs.GSRep_GetGUIDByActor(ECSExtension.ToActor(Entity).Address);
	}

	public static Entity GetEntityByNetGUID(uint GUID, IntPtr Connection)
	{
		if (GUID != 0)
		{
			AActor aActor = GCHelper.FindRef(BGW_NativeFuncs.GSRep_GetActorForGUID(Connection, GUID))?.Managed as AActor;
			if (aActor != null)
			{
				return ECSExtension.ToEntity(aActor);
			}
		}
		return Entity.Null;
	}

	public static uint GetNetGUIDByEntitySharedRef(EntitySharedRef EntitySharedRef)
	{
		if (EntitySharedRefFuncLib.IsNull(EntitySharedRef) || EntitySharedRefFuncLib.Actor(EntitySharedRef) == null)
		{
			return 0u;
		}
		return BGW_NativeFuncs.GSRep_GetGUIDByActor(EntitySharedRefFuncLib.Actor(EntitySharedRef).Address);
	}

	public static EntitySharedRef GetEntitySharedRefByNetGUID(uint GUID, IntPtr Connection)
	{
		if (GUID != 0)
		{
			AActor aActor = GCHelper.FindRef(BGW_NativeFuncs.GSRep_GetActorForGUID(Connection, GUID))?.Managed as AActor;
			if (aActor != null)
			{
				return new EntitySharedRef(aActor);
			}
		}
		return new EntitySharedRef(null);
	}

	public static Entity GetEntityFromNetGUID(UObject WorldContext, uint GUID)
	{
		if (WorldContext != null)
		{
			AActor aActor = GCHelper.FindRef(BGW_NativeFuncs.GSRep_GetActorFromGUID(WorldContext.Address, GUID))?.Managed as AActor;
			if (aActor != null)
			{
				return ECSExtension.ToEntity(aActor);
			}
		}
		return Entity.Null;
	}

	public static FUnitLockTargetInfo GetLockTargetInfoForRPC(UnitLockTargetInfo TargetInfo)
	{
		return new FUnitLockTargetInfo
		{
			LockTargetEntity = GetNetGUIDByEntity(TargetInfo.LockTargetEntity),
			LockTargetWayType = TargetInfo.LockTargetWayType,
			LockTargetType = TargetInfo.LockTargetType,
			LockTargetSceneCompName = TargetInfo.LockTargetSceneCompName,
			LockTargetSkeletonSocketName = TargetInfo.LockTargetSkeletonSocketName,
			LockPointLocation = TargetInfo.LockPointLocation,
			SourceType = TargetInfo.SourceType
		};
	}

	public static UnitLockTargetInfo GetLockTargetInfoFromRPC(FUnitLockTargetInfo TargetInfo, UObject WorldContext)
	{
		return new UnitLockTargetInfo
		{
			LockTargetEntity = GetEntityFromNetGUID(WorldContext, TargetInfo.LockTargetEntity),
			LockTargetWayType = TargetInfo.LockTargetWayType,
			LockTargetType = TargetInfo.LockTargetType,
			LockTargetSceneCompName = TargetInfo.LockTargetSceneCompName,
			LockTargetSkeletonSocketName = TargetInfo.LockTargetSkeletonSocketName,
			LockPointLocation = TargetInfo.LockPointLocation,
			SourceType = TargetInfo.SourceType
		};
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Actor")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibReplication:GetActorNetRole")]
	public static int GetActorNetRole(AActor Owner)
	{
		if (Owner.IsNullOrDestroyed())
		{
			return 0;
		}
		UWorld world = Owner.World;
		bool flag = world.IsServer();
		int num = ((!flag) ? 1 : 2);
		bool flag2 = UGSE_EngineFuncLib.IsDedicateServer(world);
		bool flag3 = UGSE_EngineFuncLib.IsListenServer(world);
		bool flag4 = UGSReplayFuncLib.IsPlayingReplay(Owner);
		if (UGSE_EngineFuncLib.IsStandAlone(world))
		{
			num |= 0x1000;
		}
		num = (flag2 ? (num | 0x100) : (num | 1));
		if (flag3)
		{
			num |= 0x200;
		}
		APlayerController aPlayerController = Owner as APlayerController;
		APlayerState aPlayerState = Owner as APlayerState;
		if (aPlayerState != null)
		{
			aPlayerController = aPlayerState.GetPlayerController();
		}
		if (aPlayerController != null)
		{
			num = ((!aPlayerController.IsLocalController()) ? (num | 0x400) : (num | 0x10));
		}
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		if (aBGUCharacter != null)
		{
			bool flag5 = aBGUCharacter.IsLocallyControlled();
			bool num2 = BGUFunctionLibraryCS.IsRemoteControlPawn(aBGUCharacter);
			if (flag5)
			{
				num |= 0x10;
			}
			if (num2)
			{
				num |= 0x400;
			}
		}
		switch (Owner.GetLocalRole())
		{
		case ENetRole.ROLE_AutonomousProxy:
			num |= 0x20;
			break;
		case ENetRole.ROLE_SimulatedProxy:
			num |= 0x40;
			break;
		case ENetRole.ROLE_Authority:
			num |= 0x80;
			break;
		}
		if (flag2 || flag3)
		{
			num |= 4;
		}
		if (!flag)
		{
			num |= 8;
		}
		if (flag4)
		{
			num |= 0x800;
		}
		return num;
	}

	public static void GetActorCellPartitionFilter(AActor Owner, out int UnitFilter, out int TeamFilter)
	{
		UnitFilter = 0;
		TeamFilter = 0;
		if (!(Owner is BGUCharacterCS))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS.IsPlayerControlled())
		{
			UnitFilter |= 1;
		}
		BUC_ConfigInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ConfigInfoData>(bGUCharacterCS);
		if (readOnlyData == null)
		{
			return;
		}
		int resID = readOnlyData.ResID;
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(resID);
		if (unitCommDesc == null)
		{
			return;
		}
		int num = unitCommDesc.TeamID;
		if (num == 99)
		{
			num = 32;
		}
		if (num > 32)
		{
			throw new Exception($"TeamID:{num} Error ResID:{resID}");
		}
		TeamFilter = 1 << num - 1;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(bGUCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc == null)
		{
			return;
		}
		switch (unitBattleInfoExtendDesc.BloodBarType)
		{
		case EBGUBloodBarType.BossBar:
			UnitFilter |= 2;
			return;
		case EBGUBloodBarType.EliteBar:
			UnitFilter |= 4;
			return;
		}
		if ((UnitFilter & 1) == 0)
		{
			UnitFilter |= 8;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibReplication:GetActorNetRole")]
	private static void GetActorNetRole__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GetActorNetRole_Owner_Offset));
		int actorNetRole = GetActorNetRole(owner);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetActorNetRole_ReturnValue_Offset), actorNetRole);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibReplication");
		GetActorNetRole_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorNetRole");
		GetActorNetRole_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorNetRole_FunctionAddress);
		GetActorNetRole_Owner_Offset = NativeReflection.GetPropertyOffset(GetActorNetRole_FunctionAddress, "Owner");
		GetActorNetRole_Owner_IsValid = NativeReflection.ValidatePropertyClass(GetActorNetRole_FunctionAddress, "Owner", Classes.FObjectProperty);
		GetActorNetRole_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorNetRole_FunctionAddress, "ReturnValue");
		GetActorNetRole_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorNetRole_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetActorNetRole_IsValid = GetActorNetRole_FunctionAddress != IntPtr.Zero && GetActorNetRole_Owner_IsValid && GetActorNetRole_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibReplication:GetActorNetRole", GetActorNetRole_IsValid);
	}

	static BGUFuncLibReplication()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibReplication)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibReplication));
	}
}
