using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGU_ObjActorUtil
{
	public static AActor GetBaseActor(AActor EffectCaster, AActor ProjectileSpawner, ProjectileBaseType BaseType, AActor EffectTarget = null, AActor EffectRootCaster = null)
	{
		AActor result = null;
		switch (BaseType)
		{
		case ProjectileBaseType.ProjectileSpawner:
			result = ProjectileSpawner;
			break;
		case ProjectileBaseType.EffectCaster:
			result = EffectCaster;
			break;
		case ProjectileBaseType.EffectRootCaster:
			result = EffectRootCaster;
			break;
		case ProjectileBaseType.EffectTarget:
			result = EffectTarget;
			break;
		case ProjectileBaseType.CurTarget_ProjectileSpawner:
			result = BGUFunctionLibraryCS.BGUGetTarget(ProjectileSpawner);
			break;
		case ProjectileBaseType.UseSkillBaseTarget:
			if (!ProjectileSpawner.IsNullOrDestroyed())
			{
				UnitLockTargetInfo unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetSkillBaseTargetInfo(ProjectileSpawner);
				if (unitLockTargetInfo != null && unitLockTargetInfo.LockTargetActor != null)
				{
					result = unitLockTargetInfo.LockTargetActor;
				}
			}
			break;
		case ProjectileBaseType.SceneItemCached:
		{
			BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(ProjectileSpawner);
			if (readOnlyData != null && readOnlyData.SceneItemCatch != null)
			{
				result = readOnlyData.SceneItemCatch;
			}
			break;
		}
		case ProjectileBaseType.LocalPlayer:
		{
			IBGC_LocalPlayerSharedData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>(ProjectileSpawner);
			if (gameStateReadonlyData != null)
			{
				result = gameStateReadonlyData.FirstLocalPlayerPawn;
			}
			break;
		}
		}
		return result;
	}

	public static FTransform GetSocketOrCompTransform(bool UseSocket, AActor Owner, FName SocketName, out USceneComponent SocketOwnerComp)
	{
		SocketOwnerComp = null;
		if (Owner == null)
		{
			return FTransform.Identity;
		}
		bool flag = false;
		FTransform result = FTransform.Default;
		if (UseSocket)
		{
			USkeletalMeshComponent uSkeletalMeshComponent = null;
			if (Owner is ACharacter)
			{
				uSkeletalMeshComponent = (Owner as ACharacter).Mesh;
			}
			else
			{
				List<UActorComponent> componentsByClass = Owner.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
				if (componentsByClass.Count == 1)
				{
					uSkeletalMeshComponent = componentsByClass[0] as USkeletalMeshComponent;
				}
				else
				{
					foreach (UActorComponent item in componentsByClass)
					{
						if (item.ComponentHasTag(B1GlobalFNames.master))
						{
							uSkeletalMeshComponent = item as USkeletalMeshComponent;
							break;
						}
					}
				}
			}
			if (uSkeletalMeshComponent != null)
			{
				bool flag2 = uSkeletalMeshComponent.DoesSocketExist(SocketName);
				if (flag2)
				{
					SocketOwnerComp = uSkeletalMeshComponent;
					result = uSkeletalMeshComponent.GetSocketTransform(SocketName);
					flag = true;
				}
				else
				{
					uSkeletalMeshComponent.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
					foreach (USceneComponent item2 in Children)
					{
						USkeletalMeshComponent uSkeletalMeshComponent2 = item2 as USkeletalMeshComponent;
						if (uSkeletalMeshComponent2 != null)
						{
							flag2 = uSkeletalMeshComponent2.DoesSocketExist(SocketName);
							if (flag2)
							{
								SocketOwnerComp = uSkeletalMeshComponent2;
								result = uSkeletalMeshComponent2.GetSocketTransform(SocketName);
								flag = true;
								break;
							}
						}
					}
				}
				if (!flag2)
				{
					SocketOwnerComp = uSkeletalMeshComponent;
					result = BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner);
					flag = true;
				}
			}
		}
		else if (SocketName != FName.None)
		{
			USceneComponent uSceneComponent = new USceneComponent();
			Owner.GetComponentsByClass(UClass.GetClass<USceneComponent>());
			uSceneComponent = BGUFunctionLibraryCS.TryGetComponentByFName(Owner, SocketName) as USceneComponent;
			if (uSceneComponent != null)
			{
				SocketOwnerComp = uSceneComponent;
				result = BGUFuncLibActorTransformCS.BGUGetWorldTransform(uSceneComponent);
				flag = true;
			}
		}
		if (!flag)
		{
			result = BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner);
		}
		return result;
	}

	public static FTransform GetSocketTransform(ACharacter Target, FName SpawnPointName)
	{
		FTransform identity = FTransform.Identity;
		if (Target.IsNullOrDestroyed())
		{
			return identity;
		}
		return Target.Mesh.GetSocketTransform(SpawnPointName);
	}

	public static void CreateSweepCheckShapeAndRot(BGUProjectileBaseActor ProjectileActor, EProjectileCheckShapeType SweepCheckType, out FGSSweepCheckShapeInfo SweepCheckShapeInfo, out FTransform CurTransform)
	{
		SweepCheckShapeInfo = default(FGSSweepCheckShapeInfo);
		switch (SweepCheckType)
		{
		case EProjectileCheckShapeType.SphereShape:
		{
			SweepCheckShapeInfo.SweepCheckShapeType = EGSSweepCheckShapeType.SphereShape;
			USphereComponent sphereCollisionComp = ProjectileActor.GetSphereCollisionComp();
			if (sphereCollisionComp != null)
			{
				SweepCheckShapeInfo.ShapeParamFloat = sphereCollisionComp.GetScaledSphereRadius();
				CurTransform = BGUFuncLibActorTransformCS.BGUGetWorldTransform(ProjectileActor.GetSphereCollisionComp());
			}
			else
			{
				CurTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(ProjectileActor);
			}
			SweepCheckShapeInfo.ShapeParamVector = FVector.ZeroVector;
			break;
		}
		case EProjectileCheckShapeType.BoxShape:
		case EProjectileCheckShapeType.SceneItem:
		{
			SweepCheckShapeInfo.SweepCheckShapeType = EGSSweepCheckShapeType.BoxShape;
			SweepCheckShapeInfo.ShapeParamFloat = 0f;
			UBoxComponent boxCollisionComp = ProjectileActor.GetBoxCollisionComp();
			if (boxCollisionComp != null)
			{
				SweepCheckShapeInfo.ShapeParamVector = boxCollisionComp.GetScaledBoxExtent();
				CurTransform = BGUFuncLibActorTransformCS.BGUGetWorldTransform(boxCollisionComp);
			}
			else
			{
				CurTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(ProjectileActor);
			}
			break;
		}
		case EProjectileCheckShapeType.CapsuleShape:
		{
			SweepCheckShapeInfo.SweepCheckShapeType = EGSSweepCheckShapeType.CapsuleShape;
			SweepCheckShapeInfo.ShapeParamFloat = 0f;
			UCapsuleComponent capsuleCollisionComp = ProjectileActor.GetCapsuleCollisionComp();
			if (capsuleCollisionComp != null)
			{
				capsuleCollisionComp.GetScaledCapsuleSize(out var OutRadius, out var OutHalfHeight);
				SweepCheckShapeInfo.ShapeParamVector = new FVector(OutRadius, OutRadius, OutHalfHeight);
				CurTransform = BGUFuncLibActorTransformCS.BGUGetWorldTransform(ProjectileActor.GetCapsuleCollisionComp());
			}
			else
			{
				CurTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(ProjectileActor);
			}
			break;
		}
		case EProjectileCheckShapeType.CustomShape:
		{
			SweepCheckShapeInfo.SweepCheckShapeType = EGSSweepCheckShapeType.Zero;
			SweepCheckShapeInfo.ShapeParamFloat = 0f;
			SweepCheckShapeInfo.ShapeParamVector = FVector.ZeroVector;
			UStaticMeshComponent customCollisionComp = ProjectileActor.GetCustomCollisionComp();
			if (customCollisionComp != null)
			{
				CurTransform = BGUFuncLibActorTransformCS.BGUGetWorldTransform(customCollisionComp);
			}
			else
			{
				CurTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(ProjectileActor);
			}
			break;
		}
		default:
			SweepCheckShapeInfo.SweepCheckShapeType = EGSSweepCheckShapeType.Zero;
			SweepCheckShapeInfo.ShapeParamFloat = 0f;
			SweepCheckShapeInfo.ShapeParamVector = FVector.ZeroVector;
			CurTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(ProjectileActor);
			break;
		}
	}

	public static bool IsBaseActorExist(ProjectileBaseStruct BaseInfo, AActor EffectCaster, AActor ProjectileSpawner, AActor EffectTarget = null, AActor EffectRootCaster = null)
	{
		return !GetBaseActor(EffectCaster, ProjectileSpawner, BaseInfo.BaseType).IsNullOrDestroyed();
	}

	public static USkeletalMeshComponent GetSocketBelongToSKComp(ACharacter OwnerCharacter, FName SocketName)
	{
		if (OwnerCharacter == null)
		{
			return null;
		}
		USkeletalMeshComponent result = OwnerCharacter.Mesh;
		if (SocketName != FName.None && !OwnerCharacter.Mesh.DoesSocketExist(SocketName))
		{
			foreach (UActorComponent item in OwnerCharacter.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
			{
				if (!(item == OwnerCharacter.Mesh))
				{
					USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
					if (uSkeletalMeshComponent.DoesSocketExist(SocketName))
					{
						result = uSkeletalMeshComponent;
						break;
					}
				}
			}
		}
		return result;
	}
}
