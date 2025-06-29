using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_ProjectilePhysicComp : UActorCompBaseCS
{
	private BUC_ProjectilePhysicData ProjectilePhysicData;

	private BUC_ProjectileBasicData ProjectileBasicData;

	public override void OnAttach()
	{
		ProjectilePhysicData = RequireWritableData<BUC_ProjectilePhysicData>();
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		base.BUSEventCollection.Evt_OnProjectileIDChanged += new Del_Void_Int(OnProjectileIDChanged);
		base.BUSEventCollection.Evt_SetObjectActorPhysics += new Del_SetObjectActorPhysics(OnSetPhysics);
		base.BUSEventCollection.Evt_ObjectActorDisablePhysics += new Del_Void(OnDisablePhysics);
		base.BUSEventCollection.Evt_EnableBulletCollision += new Del_EnableBulletCollision(OnEnableCollisionChanel);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnBulletDead);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		UProjectileMovementComponent projectileMovement = (Owner as BGUProjectileBaseActor).GetProjectileMovement();
		if (projectileMovement != null)
		{
			ProjectilePhysicData.OriGravityScale = projectileMovement.ProjectileGravityScale;
		}
		OnDisablePhysics();
	}

	public override void OnBeginPlay()
	{
		if (GSGameplayCVar.CVar_ShowProjectileCheckComp.GetValueInGameThread() > 0)
		{
			BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
			USceneComponent uSceneComponent;
			switch (ProjectileBasicData.CheckShapeType)
			{
			default:
				return;
			case EProjectileCheckShapeType.BoxShape:
				uSceneComponent = bGUProjectileBaseActor.GetBoxCollisionComp();
				break;
			case EProjectileCheckShapeType.SphereShape:
				uSceneComponent = bGUProjectileBaseActor.GetSphereCollisionComp();
				break;
			case EProjectileCheckShapeType.CapsuleShape:
				uSceneComponent = bGUProjectileBaseActor.GetCapsuleCollisionComp();
				break;
			case EProjectileCheckShapeType.CustomShape:
				uSceneComponent = bGUProjectileBaseActor.GetCustomCollisionComp();
				break;
			case EProjectileCheckShapeType.SceneItem:
				return;
			}
			if (uSceneComponent != null)
			{
				uSceneComponent.SetHiddenInGame(NewHidden: false);
			}
		}
	}

	public void OnSetPhysics(float GravityScale, bool RotationFollowsVelocity, bool ShouldBounce, bool bSimulate = false)
	{
		UProjectileMovementComponent componentByClass = GetOwner().GetComponentByClass<UProjectileMovementComponent>();
		if (componentByClass != null)
		{
			componentByClass.ProjectileGravityScale = GravityScale;
			componentByClass.RotationFollowsVelocity = RotationFollowsVelocity;
			componentByClass.ShouldBounce = ShouldBounce;
		}
		UStaticMeshComponent staticMesh = (GetOwner() as BGUProjectileBaseActor).GetStaticMesh();
		if (staticMesh != null)
		{
			staticMesh.SetSimulatePhysics(bSimulate);
		}
	}

	public void OnDisablePhysics()
	{
		UProjectileMovementComponent projectileMovement = (Owner as BGUProjectileBaseActor).GetProjectileMovement();
		if (projectileMovement != null)
		{
			projectileMovement.ProjectileGravityScale = 0f;
			projectileMovement.RotationFollowsVelocity = false;
			projectileMovement.ShouldBounce = false;
		}
	}

	private void OnEnableCollisionChanel(bool Enable, List<int> ChanelIDList)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		UStaticMeshComponent componentByClass = owner.GetComponentByClass<UStaticMeshComponent>();
		if (componentByClass == null)
		{
			return;
		}
		if (Enable)
		{
			foreach (int ChanelID in ChanelIDList)
			{
				componentByClass.SetCollisionResponseToChannel((ECollisionChannel)ChanelID, ECollisionResponseType.ECR_Block);
			}
			return;
		}
		foreach (int ChanelID2 in ChanelIDList)
		{
			componentByClass.SetCollisionResponseToChannel((ECollisionChannel)ChanelID2, ECollisionResponseType.ECR_Ignore);
		}
	}

	private void OnBulletDead(EBGUBulletDestroyReason Reason)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		if (!bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			OnDisablePhysics();
			bGUProjectileBaseActor.SetActorEnableCollision(bNewActorEnableCollision: false);
		}
	}

	private void CloseCheckCompCollision()
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		if (!bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			bGUProjectileBaseActor.GetBoxCollisionComp()?.SetCollisionProfileName(B1GlobalFNames.NoCollision);
			bGUProjectileBaseActor.GetSphereCollisionComp()?.SetCollisionProfileName(B1GlobalFNames.NoCollision);
			bGUProjectileBaseActor.GetCapsuleCollisionComp()?.SetCollisionProfileName(B1GlobalFNames.NoCollision);
			bGUProjectileBaseActor.GetCustomCollisionComp()?.SetCollisionProfileName(B1GlobalFNames.NoCollision);
		}
	}

	private void OnProjectileIDChanged(int ProjectileID)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			return;
		}
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(ProjectileID);
		if (projectileMoveDesc == null)
		{
			return;
		}
		FName none = FName.None;
		switch (BGU_DataUtil.GetActorType(bGUProjectileBaseActor))
		{
		case BGU_ActorType.Bullet:
			none = ProjectilePhysicData.Default_ProfileName_Bullet;
			break;
		case BGU_ActorType.MagicField:
		{
			none = ProjectilePhysicData.Default_ProfileName_MagicField;
			IBUC_MFOverlapData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MFOverlapData, BUC_MFOverlapData>(Owner);
			if (readOnlyData != null && readOnlyData.OverlapType == EMagicFieldOverlapType.NegativeOverlap)
			{
				none = B1GlobalFNames.MFNegativeOverlap;
			}
			break;
		}
		default:
			return;
		}
		switch (projectileMoveDesc.ProjectileMoveModeType)
		{
		case EBulletOrMagicFieldMoveModeType.PhysicsSimulatingMode:
			none = B1GlobalFNames.PhysicalBullet;
			bGUProjectileBaseActor.GetStaticMesh().SetCollisionProfileName(none);
			if (projectileMoveDesc.ProjectileMoveModeYoNParam.Count >= 2 && projectileMoveDesc.ProjectileMoveModeYoNParam[1] == EGSYesNo.Yes)
			{
				bGUProjectileBaseActor.GetStaticMesh().SetCollisionResponseToChannel(ECollisionChannel.ECC_PhysicsBody, ECollisionResponseType.ECR_Ignore);
			}
			CloseCheckCompCollision();
			return;
		case EBulletOrMagicFieldMoveModeType.RealPhysicsMode:
			none = B1GlobalFNames.PhysicalBullet;
			bGUProjectileBaseActor.GetStaticMesh().SetCollisionProfileName(none);
			bGUProjectileBaseActor.GetStaticMesh().SetSimulatePhysics(bSimulate: true);
			CloseCheckCompCollision();
			return;
		}
		EProjectileCheckShapeType checkShapeType = ProjectileBasicData.CheckShapeType;
		UPrimitiveComponent uPrimitiveComponent = null;
		switch (checkShapeType)
		{
		case EProjectileCheckShapeType.BoxShape:
			uPrimitiveComponent = bGUProjectileBaseActor.GetBoxCollisionComp();
			break;
		case EProjectileCheckShapeType.CapsuleShape:
			uPrimitiveComponent = bGUProjectileBaseActor.GetCapsuleCollisionComp();
			break;
		case EProjectileCheckShapeType.CustomShape:
			uPrimitiveComponent = bGUProjectileBaseActor.GetCustomCollisionComp();
			break;
		case EProjectileCheckShapeType.SphereShape:
			uPrimitiveComponent = bGUProjectileBaseActor.GetSphereCollisionComp();
			break;
		}
		if (uPrimitiveComponent != null)
		{
			SetCollisionProfileName(uPrimitiveComponent, none);
		}
	}

	private void SetCollisionProfileName(UPrimitiveComponent Comp, FName NewProfileName)
	{
		if (Comp.GetCollisionProfileName() != NewProfileName)
		{
			Comp.SetCollisionProfileName(NewProfileName);
		}
	}
}
