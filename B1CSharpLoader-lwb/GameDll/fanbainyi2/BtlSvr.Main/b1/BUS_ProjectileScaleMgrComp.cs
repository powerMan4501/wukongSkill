using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProjectileScaleMgrComp : UActorCompBaseCS
{
	private BUC_ProjectileScaleMgrData ProjectileScaleMgrData;

	private BUC_ProjectileBasicData ProjectileBasicData;

	private IBUC_MasterData MasterData;

	public override void OnAttach()
	{
		ProjectileScaleMgrData = RequireWritableData<BUC_ProjectileScaleMgrData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		ProjectileBasicData.OnProjectileIDChg += SetProjectileScaleMgrData;
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnProjectileDead);
	}

	private void SetProjectileScaleMgrData(int OldID, int NewID)
	{
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(NewID, MasterData.GetMasterActor());
		if (projectileCommDesc == null)
		{
			return;
		}
		ProjectileScaleMgrData.ScaleCurveXAxisType = projectileCommDesc.ScaleCurveXAxisType;
		ProjectileScaleMgrData.ScaleCurveYAxisType = projectileCommDesc.ScaleCurveYAxisType;
		if (projectileCommDesc.ScaleCurveXAxisType == EProjectileScaleCurveXAxisType.Time)
		{
			ProjectileScaleMgrData.ProjectileScaleAge = 0f;
		}
		else
		{
			ProjectileScaleMgrData.ProjectileScaleAge = -1f;
		}
		string projectileScaleCurvePath = projectileCommDesc.ProjectileScaleCurvePath;
		if (!string.IsNullOrEmpty(projectileScaleCurvePath))
		{
			ProjectileScaleMgrData.ScaleCurve = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UCurveVector>(projectileScaleCurvePath, ELoadResourceType.SyncLoadAndCache);
		}
		string projectileInnerRadiusCurvePath = projectileCommDesc.ProjectileInnerRadiusCurvePath;
		if (!string.IsNullOrEmpty(projectileInnerRadiusCurvePath))
		{
			ProjectileScaleMgrData.InnerRadiusCurve = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UCurveFloat>(projectileInnerRadiusCurvePath, ELoadResourceType.SyncLoadAndCache);
		}
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		ProjectileScaleMgrData.OriProjectileScale_Actor = bGUProjectileBaseActor.GetActorScale3D();
		if (!bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			switch (ProjectileBasicData.CheckShapeType)
			{
			case EProjectileCheckShapeType.BoxShape:
			{
				UBoxComponent boxCollisionComp = bGUProjectileBaseActor.GetBoxCollisionComp();
				ProjectileScaleMgrData.OriProjectileScale_Comp = boxCollisionComp.RelativeScale3D;
				ProjectileScaleMgrData.OriProjectileRadius = boxCollisionComp.GetScaledBoxExtent().X;
				break;
			}
			case EProjectileCheckShapeType.CapsuleShape:
			{
				UCapsuleComponent capsuleCollisionComp = bGUProjectileBaseActor.GetCapsuleCollisionComp();
				ProjectileScaleMgrData.OriProjectileScale_Comp = capsuleCollisionComp.RelativeScale3D;
				ProjectileScaleMgrData.OriProjectileRadius = capsuleCollisionComp.GetScaledCapsuleRadius();
				break;
			}
			case EProjectileCheckShapeType.SphereShape:
			{
				USphereComponent sphereCollisionComp = bGUProjectileBaseActor.GetSphereCollisionComp();
				ProjectileScaleMgrData.OriProjectileScale_Comp = sphereCollisionComp.RelativeScale3D;
				ProjectileScaleMgrData.OriProjectileRadius = sphereCollisionComp.GetScaledSphereRadius();
				break;
			}
			case EProjectileCheckShapeType.CustomShape:
			{
				UStaticMeshComponent customCollisionComp = bGUProjectileBaseActor.GetCustomCollisionComp();
				ProjectileScaleMgrData.OriProjectileScale_Comp = customCollisionComp.RelativeScale3D;
				ProjectileScaleMgrData.OriProjectileRadius = customCollisionComp.StaticMesh.GetBoundingBox().GetExtent().X;
				break;
			}
			case EProjectileCheckShapeType.SceneItem:
				break;
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		OnTickProjectileScaleAge(DeltaTime);
		OnTickScaleValue();
	}

	private void OnTickProjectileScaleAge(float DeltaTime)
	{
		if (ProjectileScaleMgrData.ProjectileScaleAge >= 0f)
		{
			ProjectileScaleMgrData.ProjectileScaleAge += DeltaTime;
		}
	}

	private void OnTickScaleValue()
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor.IsNullOrDestroyed() || ProjectileScaleMgrData.ScaleCurveXAxisType == EProjectileScaleCurveXAxisType.None || ProjectileScaleMgrData.ScaleCurve.IsNullOrDestroyed())
		{
			return;
		}
		float inTime = 0f;
		switch (ProjectileScaleMgrData.ScaleCurveXAxisType)
		{
		case EProjectileScaleCurveXAxisType.Time:
			inTime = ProjectileScaleMgrData.ProjectileScaleAge;
			break;
		case EProjectileScaleCurveXAxisType.DistWithMaster:
		{
			if (MasterData == null)
			{
				return;
			}
			AActor masterActor = MasterData.GetMasterActor();
			if (masterActor.IsNullOrDestroyed())
			{
				return;
			}
			inTime = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUProjectileBaseActor), BGUFuncLibActorTransformCS.BGUGetActorLocation(masterActor));
			break;
		}
		}
		FVector fVector = ProjectileScaleMgrData.ScaleCurve.GetVectorValue(inTime);
		if (ProjectileScaleMgrData.ScaleCurveYAxisType == EProjectileScaleCurveYAxisType.Radius)
		{
			fVector = new FVector(fVector.X / 50f, fVector.X / 50f, 1.0);
		}
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(bGUProjectileBaseActor.GetProjectileID(), MasterData.GetMasterActor());
		if (projectileCommDesc == null)
		{
			return;
		}
		UPrimitiveComponent uPrimitiveComponent = null;
		switch (ProjectileBasicData.CheckShapeType)
		{
		default:
			return;
		case EProjectileCheckShapeType.BoxShape:
			uPrimitiveComponent = bGUProjectileBaseActor.GetBoxCollisionComp();
			break;
		case EProjectileCheckShapeType.CapsuleShape:
			uPrimitiveComponent = bGUProjectileBaseActor.GetCapsuleCollisionComp();
			break;
		case EProjectileCheckShapeType.SphereShape:
			uPrimitiveComponent = bGUProjectileBaseActor.GetSphereCollisionComp();
			break;
		case EProjectileCheckShapeType.CustomShape:
			uPrimitiveComponent = bGUProjectileBaseActor.GetCustomCollisionComp();
			break;
		case EProjectileCheckShapeType.SceneItem:
			return;
		}
		bool flag = false;
		if (!ProjectileScaleMgrData.InnerRadiusCurve.IsNullOrDestroyed())
		{
			ProjectileScaleMgrData.InnerRadiusCurveValue = ProjectileScaleMgrData.InnerRadiusCurve.GetFloatValue(inTime);
			base.BUSEventCollection.Evt_OnUpdateBulletRingFX.Invoke(ProjectileScaleMgrData.InnerRadiusCurveValue, fVector.X * ProjectileScaleMgrData.OriProjectileRadius);
			flag = true;
		}
		if (uPrimitiveComponent != null && flag && !uPrimitiveComponent.HiddenInGame)
		{
			USystemLibrary.DrawDebugCylinder(bGUProjectileBaseActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUProjectileBaseActor), BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUProjectileBaseActor) + FVector.UpVector * ProjectileScaleMgrData.InnerRadiusCurveValue, ProjectileScaleMgrData.InnerRadiusCurveValue, 128, FLinearColor.Red, 0.2f, 2f);
		}
		if (projectileCommDesc.ScaleOnlyApplyToCheck == EGSYesNo.Yes)
		{
			if (!(uPrimitiveComponent != null))
			{
				return;
			}
			uPrimitiveComponent.SetRelativeScale3D(ProjectileScaleMgrData.OriProjectileScale_Comp * fVector);
			USceneComponent childComponent = uPrimitiveComponent.GetChildComponent(0);
			if (childComponent != null)
			{
				if (ProjectileScaleMgrData.OriInnerBlockCompScale == FVector.OneVector)
				{
					ProjectileScaleMgrData.OriInnerBlockCompScale = childComponent.RelativeScale3D;
				}
				FVector worldScale3D = ProjectileScaleMgrData.InnerRadiusCurveValue / 50f * ProjectileScaleMgrData.OriInnerBlockCompScale;
				childComponent.SetWorldScale3D(worldScale3D);
			}
		}
		else
		{
			FTransform newTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUProjectileBaseActor);
			newTransform.SetScale3D(ProjectileScaleMgrData.OriProjectileScale_Actor * fVector);
			BGUFuncLibActorTransformCS.BGUSetActorTransform(bGUProjectileBaseActor, newTransform, bSweep: false, bTeleport: false);
		}
	}

	private void OnProjectileDead(EBGUBulletDestroyReason Reason)
	{
	}
}
