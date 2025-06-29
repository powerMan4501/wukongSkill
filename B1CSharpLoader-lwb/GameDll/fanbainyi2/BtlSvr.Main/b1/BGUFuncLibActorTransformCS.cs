using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGUFuncLibActorTransformCS
{
	private static bool EnableMergeSetOrGetInfo = true;

	public static void BGUSetActorTransform(this AActor NeedSetInfoActor, FTransform NewTransform, bool bSweep, bool bTeleport, bool NeedReturnHitResult = false, bool bForceUpdate = false)
	{
		if (NeedSetInfoActor.IsNullFastCheck())
		{
			return;
		}
		if (EnableMergeSetOrGetInfo && ECSExtension.IsECSActor(NeedSetInfoActor) && !NeedReturnHitResult)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NeedSetInfoActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetActorTransform.Invoke(NewTransform, bSweep, bTeleport);
				if (bForceUpdate)
				{
					bUS_GSEventCollection.Evt_ActorForceUpdateTransform.Invoke();
				}
				return;
			}
		}
		ActorFuncLib.SetActorTransformSimple(NeedSetInfoActor.Address, NewTransform, bSweep, bTeleport ? 1 : 0);
	}

	public static bool BGUGetCharacterHasBlockConfig(this AActor NeedGetInfoActor)
	{
		IBUC_ArmorData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ArmorData, BUC_ArmorData>(NeedGetInfoActor);
		if (readOnlyData != null)
		{
			readOnlyData.GetCurrentBlockInfoConfig(out var _NowUseBlockInfoConfig);
			return _NowUseBlockInfoConfig != null;
		}
		return false;
	}

	public static void BGUSetActorLocation(this AActor NeedSetInfoActor, FVector NewLocation, bool bSweep, bool bTeleport, out FHitResult HitResult, bool NeedReturnHitResult = false, bool bForceUpdate = false)
	{
		HitResult = default(FHitResult);
		if (NeedSetInfoActor.IsNullFastCheck())
		{
			return;
		}
		if (EnableMergeSetOrGetInfo && ECSExtension.IsECSActor(NeedSetInfoActor) && !NeedReturnHitResult)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NeedSetInfoActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetActorLocation.Invoke(NewLocation, bSweep, bTeleport);
				if (bForceUpdate)
				{
					bUS_GSEventCollection.Evt_ActorForceUpdateTransform.Invoke();
				}
				return;
			}
		}
		NeedSetInfoActor.SetActorLocation(NewLocation, bSweep, out HitResult, bTeleport);
	}

	public static void BGUSetActorLocation(this AActor NeedSetInfoActor, FVector NewLocation, bool bSweep, bool bTeleport, bool NeedReturnHitResult = false, bool bForceUpdate = false)
	{
		if (NeedSetInfoActor.IsNullFastCheck())
		{
			return;
		}
		if (EnableMergeSetOrGetInfo && ECSExtension.IsECSActor(NeedSetInfoActor) && !NeedReturnHitResult)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NeedSetInfoActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetActorLocation.Invoke(NewLocation, bSweep, bTeleport);
				if (bForceUpdate)
				{
					bUS_GSEventCollection.Evt_ActorForceUpdateTransform.Invoke();
				}
				return;
			}
		}
		ActorFuncLib.SetActorLocationSimple(NeedSetInfoActor.Address, NewLocation, bSweep, bTeleport ? 1 : 0);
	}

	public static void BGUSetActorRotation(this AActor NeedSetInfoActor, FRotator NewRotation, bool bTeleportPhysics, bool bImmediateUpdate = false, bool bForceUpdate = false)
	{
		if (NeedSetInfoActor.IsNullFastCheck())
		{
			return;
		}
		if (EnableMergeSetOrGetInfo && ECSExtension.IsECSActor(NeedSetInfoActor) && !bImmediateUpdate)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NeedSetInfoActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetActorRotation.Invoke(NewRotation, bTeleportPhysics);
				if (bForceUpdate)
				{
					bUS_GSEventCollection.Evt_ActorForceUpdateTransform.Invoke();
				}
				return;
			}
		}
		ActorFuncLib.SetActorRotationSimple(NeedSetInfoActor.Address, NewRotation, bTeleportPhysics ? 1 : 0);
	}

	public static void BGUSetActorLocationAndRotation(this AActor NeedSetInfoActor, FVector NewLocation, FRotator NewRotation, bool bSweep, bool bTeleport, bool NeedReturnHitResult = false, bool bForceUpdate = false)
	{
		if (NeedSetInfoActor.IsNullFastCheck())
		{
			return;
		}
		if (EnableMergeSetOrGetInfo && ECSExtension.IsECSActor(NeedSetInfoActor) && !NeedReturnHitResult)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NeedSetInfoActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetActorLocationAndRotation.Invoke(NewLocation, NewRotation, bSweep, bTeleport);
				if (bForceUpdate)
				{
					bUS_GSEventCollection.Evt_ActorForceUpdateTransform.Invoke();
				}
				return;
			}
		}
		ActorFuncLib.SetActorLocationAndRotationSimple(NeedSetInfoActor.Address, NewLocation, NewRotation, bSweep, bTeleport ? 1 : 0);
	}

	public static FTransform BGUGetActorTransform(this AActor NeedGetInfoActor)
	{
		if (NeedGetInfoActor.IsNullFastCheck())
		{
			return FTransform.Default;
		}
		if (EnableMergeSetOrGetInfo && ECSExtension.IsECSActor(NeedGetInfoActor))
		{
			IBUC_ActorTransformInfoData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>(NeedGetInfoActor);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.GetNextUpdateTransform(out var OutTransform))
			{
				return OutTransform;
			}
		}
		ActorFuncLib.GetActorTransformSimple(NeedGetInfoActor.Address, out var OutTrans);
		return OutTrans;
	}

	public static FVector BGUGetActorLocation(this AActor NeedGetInfoActor)
	{
		if (NeedGetInfoActor.IsNullFastCheck())
		{
			return FVector.ZeroVector;
		}
		if (EnableMergeSetOrGetInfo && ECSExtension.IsECSActor(NeedGetInfoActor))
		{
			IBUC_ActorTransformInfoData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>(NeedGetInfoActor);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.GetNextUpdateLocation(out var OutLocation))
			{
				return OutLocation;
			}
		}
		ActorFuncLib.GetActorLocationSimple(NeedGetInfoActor.Address, out var OutPos);
		return OutPos;
	}

	public static FVector BGUGetActorForwardVector(this AActor NeedGetInfoActor)
	{
		if (NeedGetInfoActor.IsNullFastCheck())
		{
			return FVector.ZeroVector;
		}
		return BGUGetActorTransform(NeedGetInfoActor).GetUnitAxis(EAxis.X);
	}

	public static FVector BGUGetActorRightVector(this AActor NeedGetInfoActor)
	{
		if (NeedGetInfoActor.IsNullFastCheck())
		{
			return FVector.ZeroVector;
		}
		return BGUGetActorTransform(NeedGetInfoActor).GetUnitAxis(EAxis.Y);
	}

	public static FVector BGUGetActorUpVector(this AActor NeedGetInfoActor)
	{
		if (NeedGetInfoActor.IsNullFastCheck())
		{
			return FVector.ZeroVector;
		}
		return BGUGetActorTransform(NeedGetInfoActor).GetUnitAxis(EAxis.Z);
	}

	public static FRotator BGUGetActorRotation(this AActor NeedGetInfoActor)
	{
		if (NeedGetInfoActor.IsNullFastCheck())
		{
			return FRotator.ZeroRotator;
		}
		if (ECSExtension.IsECSActor(NeedGetInfoActor) && EnableMergeSetOrGetInfo)
		{
			IBUC_ActorTransformInfoData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>(NeedGetInfoActor);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.GetNextUpdateRotation(out var OutRotator))
			{
				return OutRotator;
			}
		}
		ActorFuncLib.GetActorRotationSimple(NeedGetInfoActor.Address, out var OutRot);
		return OutRot;
	}

	public static void BGUAddActorWorldOffset(this AActor NeedSetInfoActor, FVector AdditveOffset, bool bSweep, bool bTeleport)
	{
		if (!(NeedSetInfoActor == null))
		{
			FVector newLocation = BGUGetActorLocation(NeedSetInfoActor) + AdditveOffset;
			BGUSetActorLocation(NeedSetInfoActor, newLocation, bSweep, bTeleport);
		}
	}

	public static FTransform BGUGetWorldTransform(this USceneComponent SceneComponent)
	{
		if (SceneComponent.IsNullFastCheck())
		{
			return FTransform.Default;
		}
		ActorFuncLib.GetWorldTransformFast(SceneComponent.Address, out var Trans);
		return Trans;
	}

	public static FVector BGUGetVelocity(this AActor NeedGetInfoActor)
	{
		ActorFuncLib.GetVelocity(NeedGetInfoActor.Address, out var OutVelocity);
		return OutVelocity;
	}

	public static AActor BGUGetAttachParentActor(this AActor NeedGetInfoActor)
	{
		if (NeedGetInfoActor == null)
		{
			return null;
		}
		if (NeedGetInfoActor is BGUProjectileBaseActor)
		{
			return (NeedGetInfoActor as BGUProjectileBaseActor).GetAttachParentActorCached();
		}
		return NeedGetInfoActor.GetAttachParentActor();
	}

	public static void BGUAttachToActor(this AActor ChildActor, AActor AttachParentActor, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies = false)
	{
		if (!ChildActor.IsNullOrDestroyed())
		{
			if (ChildActor is BGUProjectileBaseActor)
			{
				(ChildActor as BGUProjectileBaseActor).ProjectileAttachToActor(AttachParentActor, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
			}
			else
			{
				ChildActor.AttachToActor(AttachParentActor, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
			}
		}
	}

	public static void BGUAttachToComp(this AActor ChildActor, USceneComponent AttachComp, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies = false)
	{
		if (!ChildActor.IsNullOrDestroyed())
		{
			if (ChildActor is BGUProjectileBaseActor)
			{
				(ChildActor as BGUProjectileBaseActor).ProjectileAttachToComp(AttachComp, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
			}
			else
			{
				ChildActor.AttachToComponent(AttachComp, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
			}
		}
	}

	public static void BGUDetachFromActor(this AActor ChildActor, EDetachmentRule LocationRule = EDetachmentRule.KeepRelative, EDetachmentRule RotationRule = EDetachmentRule.KeepRelative, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative)
	{
		if (!ChildActor.IsNullOrDestroyed())
		{
			if (ChildActor is BGUProjectileBaseActor)
			{
				(ChildActor as BGUProjectileBaseActor).ProjectileDetachFromActor(LocationRule, RotationRule, ScaleRule);
			}
			else
			{
				ChildActor.DetachFromActor(LocationRule, RotationRule, ScaleRule);
			}
		}
	}

	public static bool BGUGetActorHasAuthority(this AActor Actor)
	{
		if (Actor == null)
		{
			return false;
		}
		ActorFuncLib.GetActorHasAuthority(Actor.Address, out var OutHasAuthority);
		return OutHasAuthority;
	}
}
