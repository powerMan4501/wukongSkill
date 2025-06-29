using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGU_UnrealWorldUtil
{
	private static FVector ZeroVec = default(FVector);

	private static FRotator ZeroRot = FRotator.ZeroRotator;

	public static T SpawnActorAndECSBeginPlay<T>(UWorld World) where T : AActor
	{
		T val = World.SpawnActor<T>(ref ZeroVec, ref ZeroRot);
		if (val is IECSWorldObj)
		{
			BGW_ECSWorld.Get(val).BeginPlayEntity((val as IECSWorldObj).ECSEntity);
		}
		return val;
	}

	public static T SpawnActor<T>(UWorld World) where T : AActor
	{
		return World.SpawnActor<T>(ref ZeroVec, ref ZeroRot);
	}

	public static AActor SpawnActor(UWorld World, UClass Cls)
	{
		return World.SpawnActor(Cls, ref ZeroVec, ref ZeroRot);
	}

	public static AActor SpawnActorAndECSBeginPlay(UWorld World, UClass Cls)
	{
		AActor aActor = World.SpawnActor(Cls, ref ZeroVec, ref ZeroRot);
		if (aActor is IECSWorldObj)
		{
			BGW_ECSWorld.Get(aActor).BeginPlayEntity((aActor as IECSWorldObj).ECSEntity);
		}
		return aActor;
	}

	public static AActor SpawnActorAndECSBeginPlay(UWorld World, UClass Cls, in FVector Location, in FRotator Rotation)
	{
		FVector location = Location;
		FRotator rotation = Rotation;
		AActor aActor = World.SpawnActor(Cls, ref location, ref rotation);
		if (aActor is IECSWorldObj)
		{
			BGW_ECSWorld.Get(aActor).BeginPlayEntity((aActor as IECSWorldObj).ECSEntity);
		}
		return aActor;
	}

	public static AActor SpawnActorAndECSBeginPlay(UWorld World, UClass Cls, ref FVector Location, ref FRotator Rotation, ref FActorSpawnParameters parameters)
	{
		FVector location = Location;
		FRotator rotation = Rotation;
		AActor aActor = World.SpawnActor(Cls, ref location, ref rotation, ref parameters);
		if (aActor is IECSWorldObj)
		{
			BGW_ECSWorld.Get(aActor).BeginPlayEntity((aActor as IECSWorldObj).ECSEntity);
		}
		return aActor;
	}

	public static string RequestSpawnUnit(UWorld World, TSubclassOf<BUTamerActor> TamerClass, in FTransform InTransform, AActor TriggerSpawnActor, FUnitSpawnInfo InSpawnInfo = null)
	{
		if (World == null || TamerClass.Value == null)
		{
			return null;
		}
		if (BGWGameInstanceCS.TickingGameInstNetMode(World) == EGameInstNetMode.Client)
		{
			if (TriggerSpawnActor.IsNullOrDestroyed())
			{
				return null;
			}
			return BPS_EventCollectionCS.GetLocal(TriggerSpawnActor).Evt_BPS_ClientInternalReqSpawnDynamicTamer.Invoke(TamerClass, InTransform, InSpawnInfo, TriggerSpawnActor);
		}
		BUTamerActor bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(World, TamerClass.Value, InTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
		if (bUTamerActor == null)
		{
			return null;
		}
		bUTamerActor.MarkAsSpawnedTamer(InSpawnInfo);
		UBGUFunctionLibrary.BGUFinishSpawningActor(bUTamerActor, InTransform);
		return bUTamerActor.GetFinalGuid();
	}

	public static string RequestSpawnServant(UWorld World, TSubclassOf<BUTamerActor> TamerClass, in FTransform InTransform, FServantReq InServantReq, bool SafeClampToLand = false)
	{
		if (World == null || TamerClass.Value == null)
		{
			return null;
		}
		if (BGWGameInstanceCS.TickingGameInstNetMode(World) == EGameInstNetMode.Client)
		{
			return null;
		}
		BUTamerActor bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(World, TamerClass.Value, InTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
		if (bUTamerActor == null)
		{
			return null;
		}
		if (SafeClampToLand)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bUTamerActor);
			float scaledCapsuleHalfHeight = bUTamerActor.CapsuleComponent.GetScaledCapsuleHalfHeight();
			float scaledCapsuleRadius = bUTamerActor.CapsuleComponent.GetScaledCapsuleRadius();
			FVector start = fVector + FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
			FVector end = fVector - FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
			List<AActor> list = new List<AActor>();
			list.Add(bUTamerActor);
			if (USystemLibrary.CapsuleTraceSingleByProfile(World, start, end, scaledCapsuleRadius, scaledCapsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, list, EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 3f))
			{
				FVector newLocation = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in OutHit.ImpactPoint) + FVector.UpVector * scaledCapsuleHalfHeight;
				BGUFuncLibActorTransformCS.BGUSetActorLocation(bUTamerActor, newLocation, bSweep: false, bTeleport: false);
			}
		}
		bUTamerActor.MarkAsServant();
		InServantReq.ServantTamerGuid = bUTamerActor.GetFinalGuid();
		BPS_EventCollectionCS.GetLocal(World).Evt_SendServantReq.Invoke(InServantReq);
		if (B1Global.GIsBossRushMode)
		{
			IBIC_BossRushBattleData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushBattleData, BIC_BossRushBattleData>(World);
			if (gameInstanceReadonlyData != null && gameInstanceReadonlyData.ServantPropertyOverrideList.TryGetValue(InServantReq.SummonID, out var value))
			{
				bUTamerActor.ApplyServantPropertyOverride(value);
			}
		}
		UBGUFunctionLibrary.BGUFinishSpawningActor(bUTamerActor, InTransform);
		return InServantReq.ServantTamerGuid;
	}

	public static string RequestSpawnCollectionUnitByGuid(UWorld World, TSubclassOf<BUTamerActor> TamerClass, in FTransform InTransform, AActor TriggerSpawnActor, FUnitSpawnInfo InSpawnInfo = null, string Guid = null)
	{
		if (World == null || TamerClass.Value == null)
		{
			return null;
		}
		if (BGWGameInstanceCS.TickingGameInstNetMode(World) == EGameInstNetMode.Client)
		{
			if (TriggerSpawnActor.IsNullOrDestroyed())
			{
				return null;
			}
			return BPS_EventCollectionCS.GetLocal(TriggerSpawnActor).Evt_BPS_ClientInternalReqSpawnDynamicTamer.Invoke(TamerClass, InTransform, InSpawnInfo, TriggerSpawnActor);
		}
		BUTamerActor bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(World, TamerClass.Value, InTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
		if (bUTamerActor == null)
		{
			return null;
		}
		if (Guid != null)
		{
			bUTamerActor.GetComponentByClass<BUS_GuidComp>().UnitRandomGuid = Guid;
		}
		UBGUFunctionLibrary.BGUFinishSpawningActor(bUTamerActor, InTransform);
		return bUTamerActor.GetFinalGuid();
	}

	public static BUTamerActor BeginSpawnUnitDeferred(UWorld World, TSubclassOf<BUTamerActor> TamerClass, in FTransform InTransform, FUnitSpawnInfo InSpawnInfo = null)
	{
		if (BGWGameInstanceCS.TickingGameInstNetMode(World) != EGameInstNetMode.StandAlone)
		{
			throw new Exception("BeginSpawnUnitDeferred Only Can Use In StandAlone Mode");
		}
		if (World == null || TamerClass.Value == null)
		{
			return null;
		}
		BUTamerActor bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(World, TamerClass.Value, InTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
		if (bUTamerActor == null)
		{
			return null;
		}
		bUTamerActor.MarkAsSpawnedTamer(InSpawnInfo);
		return bUTamerActor;
	}

	public static string FinishSpawnUnitDeferred(BUTamerActor TamerActor, FTransform InTransform)
	{
		if (BGWGameInstanceCS.TickingGameInstNetMode(TamerActor) != EGameInstNetMode.StandAlone)
		{
			throw new Exception("BeginSpawnUnitDeferred Only Can Use In StandAlone Mode");
		}
		if (TamerActor == null)
		{
			return null;
		}
		UBGUFunctionLibrary.BGUFinishSpawningActor(TamerActor, InTransform);
		return TamerActor.GetFinalGuid();
	}

	public static void RequestDestroyUnit(UObject InWorldContext, string InUnitGuid)
	{
		BGS_EventCollectionCS.Get(InWorldContext)?.Evt_RequestDestroyUnit.Invoke(InUnitGuid);
	}

	public static void DestroyActor(AActor Actor)
	{
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(Actor);
		if (bGW_ECSWorld != null)
		{
			bGW_ECSWorld.DestroyActor(Actor);
		}
		else
		{
			Actor.DestroyActor();
		}
	}

	public static UWorld GetActorStreamingLevelWorld(AActor Actor)
	{
		ULevel uLevel = Actor.GetOuter() as ULevel;
		if (uLevel == null)
		{
			return null;
		}
		return uLevel.GetOuter() as UWorld;
	}

	public static string GetActorWorldPackageName(AActor Actor)
	{
		ULevel uLevel = Actor.GetOuter() as ULevel;
		if (uLevel == null)
		{
			return "";
		}
		UWorld uWorld = uLevel.GetOuter() as UWorld;
		if (uWorld == null)
		{
			return "";
		}
		UPackage uPackage = uWorld.GetOuter() as UPackage;
		if (uPackage == null)
		{
			return "";
		}
		return uPackage.GetPathName();
	}

	public static UWorld FindWorldByPackageName(string PackageName, UObject PackageOuter)
	{
		UPackage uPackage = UObject.FindPackage(PackageOuter, PackageName);
		if (uPackage == null)
		{
			return null;
		}
		return UBGWFunctionLibrary.BGWFindWorldInPackage(uPackage);
	}

	public static List<APlayerController> GetAllPlayerControllers(UWorld WorldContext)
	{
		int numPlayerControllers = UGameplayStatics.GetNumPlayerControllers(WorldContext);
		List<APlayerController> list = new List<APlayerController>();
		for (int i = 0; i < numPlayerControllers; i++)
		{
			list.Add(UGameplayStatics.GetPlayerController(WorldContext, i));
		}
		return list;
	}

	public static List<APlayerState> GetAllPlayerState(UObject WorldContext)
	{
		List<APlayerState> list = new List<APlayerState>();
		int numPlayerStates = UGameplayStatics.GetNumPlayerStates(WorldContext);
		for (int i = 0; i < numPlayerStates; i++)
		{
			list.Add(UGameplayStatics.GetPlayerState(WorldContext, i));
		}
		return list;
	}

	public static List<BGUCharacterCS> GetAllPlayerActors(UObject WorldContext)
	{
		List<BGUCharacterCS> list = new List<BGUCharacterCS>();
		int numPlayerStates = UGameplayStatics.GetNumPlayerStates(WorldContext);
		for (int i = 0; i < numPlayerStates; i++)
		{
			APlayerState playerState = UGameplayStatics.GetPlayerState(WorldContext, i);
			if (playerState != null && playerState.GetPawn() is BGUCharacterCS item)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static AActor GetNearestPlayerActor(UObject WorldContext, FVector QuerierLoc)
	{
		AActor result = null;
		float num = -1f;
		foreach (BGUCharacterCS allPlayerActor in GetAllPlayerActors(WorldContext))
		{
			if (allPlayerActor != null)
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(allPlayerActor);
				float num2 = FVector.Dist2D(QuerierLoc, v);
				if (num == -1f || num > num2)
				{
					num = num2;
					result = allPlayerActor;
				}
			}
		}
		return result;
	}

	public static AActor GetNearestPlayerActor(AActor OwnerActor)
	{
		List<BGUCharacterCS> allPlayerActors = GetAllPlayerActors(OwnerActor);
		if (allPlayerActors.Count == 1)
		{
			return allPlayerActors[0];
		}
		float num = float.MaxValue;
		AActor result = null;
		foreach (BGUCharacterCS item in allPlayerActors)
		{
			float distanceTo = item.GetDistanceTo(OwnerActor);
			if (distanceTo < num)
			{
				num = distanceTo;
				result = item;
			}
		}
		return result;
	}
}
