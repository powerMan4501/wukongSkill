using b1.EventDelDefine;
using b1.GameState.Data;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_WeaponCommComp : UActorCompBaseCS
{
	private BUC_WeaponCommData WeaponCommData;

	private IBUC_GuidData GuidData;

	private b1.GameState.Data.IBGC_WeaponManagerData WeaponManagerData;

	private IBUC_MasterData MasterData;

	private bool IsInitFinish;

	public override void OnAttach()
	{
		WeaponCommData = RequireWritableData<BUC_WeaponCommData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		WeaponManagerData = RequireReadOnlyGameStateData<b1.GameState.Data.IBGC_WeaponManagerData, BGC_WeaponManagerData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		base.BUSEventCollection.Evt_ScaleWeaponByCurve += new Del_ScaleWeaponByCurve(OnScaleWeaponByCurve);
		base.BUSEventCollection.Evt_ToggleWeaponRenderStatic += new Del_Void_Bool(OnToggleWeaponRenderStatic);
		base.BUSEventCollection.Evt_PlayOrStopAnimation += new Del_PlayOrStopAnimation(OnPlayOrStopAnimation);
		base.BUSEventCollection.Evt_ToggleWeaponActive += new Del_Void_Bool(OnToggleWeaponActive);
		base.BUSEventCollection.Evt_HandleWeaponDetach += new Del_HandleWeaponDetach(OnHandleWeaponDetach);
		base.BUSEventCollection.Evt_HandleWeaponReset += new Del_Void(OnHandleWeaponReset);
	}

	private void OnHandleWeaponReset()
	{
		WeaponCommData.Init();
		OnToggleWeaponActive(bActive: false);
		IsInitFinish = false;
	}

	public override void PreBeginPlay()
	{
		WeaponCommData.Init();
	}

	public override void OnBeginPlay()
	{
		OnToggleWeaponActive(bActive: false);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		if (!IsInitFinish)
		{
			IsInitFinish = true;
			if (!WeaponManagerData.GetWeaponMasterGUID(GuidData.GetFinalGuid(), out var WeaponMasterGUID))
			{
				return;
			}
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(owner, WeaponMasterGUID);
			if (actorByGuid != null)
			{
				base.BUSEventCollection.Evt_SetMaster.Invoke(actorByGuid);
				bool flag = true;
				IBUC_WeaponManagerData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_WeaponManagerData, BUC_WeaponManagerData>(actorByGuid);
				if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.GetWeaponStatus(owner, out var IsActive))
				{
					flag = false;
					OnToggleWeaponActive(IsActive);
				}
				if (flag)
				{
					bool flag2 = BGUFunctionLibraryCS.FindWeaponDefualInActicedByActor(owner, actorByGuid);
					OnToggleWeaponActive(!flag2);
				}
			}
		}
		else
		{
			TickForHidden();
			TickForScale(DeltaTime);
			TickForDestroy(DeltaTime);
		}
	}

	private void TickForHidden()
	{
		BGUWeaponBase bGUWeaponBase = GetOwner() as BGUWeaponBase;
		if (!(bGUWeaponBase == null))
		{
			bool flag = !WeaponCommData.bIsActive;
			if (MasterData != null && !flag)
			{
				flag = MasterData.IsMasterHiddenInGame();
			}
			if (flag != bGUWeaponBase.Hidden)
			{
				bGUWeaponBase.SetActorHiddenInGame(flag);
				bGUWeaponBase.SetActorEnableCollision(!flag);
			}
		}
	}

	private void TickForScale(float DeltaTime)
	{
		if (WeaponCommData == null || !WeaponCommData.EnableScale)
		{
			return;
		}
		if (WeaponCommData.ScaleCurve == null)
		{
			WeaponCommData.Init();
			return;
		}
		FVector vectorValue = WeaponCommData.ScaleCurve.GetVectorValue(WeaponCommData.ScaleTimer);
		BGUWeaponBase bGUWeaponBase = GetOwner() as BGUWeaponBase;
		if (bGUWeaponBase == null)
		{
			WeaponCommData.Init();
			return;
		}
		bGUWeaponBase.SetActorScale3D(vectorValue);
		WeaponCommData.ScaleTimer += DeltaTime;
	}

	private void TickForDestroy(float DeltaTime)
	{
		if (WeaponCommData.DestroyDelayTime >= 0f)
		{
			WeaponCommData.DestroyDelayTime -= DeltaTime;
			if (WeaponCommData.DestroyDelayTime < 0f)
			{
				BGU_UnrealWorldUtil.DestroyActor(GetOwner());
			}
		}
	}

	private void OnScaleWeaponByCurve(UCurveVector ScaleCurve)
	{
		WeaponCommData.ScaleCurve = ScaleCurve;
		WeaponCommData.EnableScale = true;
		WeaponCommData.ScaleTimer = 0f;
	}

	private void OnToggleWeaponRenderStatic(bool bEnable)
	{
		USkeletalMeshComponent componentByClass = (GetOwner() as BGUWeaponBase).GetComponentByClass<USkeletalMeshComponent>();
		if (componentByClass != null)
		{
			componentByClass.SetRenderStatic(bEnable);
		}
	}

	private void OnPlayOrStopAnimation(bool IsPlay, bool IsLoop = false, UAnimationAsset NewAnimToPlay = null)
	{
		BGUWeaponBase bGUWeaponBase = GetOwner() as BGUWeaponBase;
		if (bGUWeaponBase == null)
		{
			return;
		}
		USkeletalMeshComponent componentByClass = bGUWeaponBase.GetComponentByClass<USkeletalMeshComponent>();
		if (!(componentByClass == null))
		{
			if (IsPlay)
			{
				componentByClass.PlayAnimation(NewAnimToPlay, IsLoop);
				return;
			}
			componentByClass.SetAnimation(null);
			componentByClass.Stop();
		}
	}

	private void OnToggleWeaponActive(bool bActive)
	{
		BGUWeaponBase bGUWeaponBase = GetOwner() as BGUWeaponBase;
		if (!(bGUWeaponBase == null))
		{
			WeaponCommData.bIsActive = bActive;
			bGUWeaponBase.SetActorHiddenInGame(!bActive);
			bGUWeaponBase.SetActorEnableCollision(bActive);
		}
	}

	private void OnHandleWeaponDetach(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, float DestroyDelayTime, bool WeaponEnablePhysic)
	{
		BGUWeaponBase bGUWeaponBase = Owner as BGUWeaponBase;
		if (bGUWeaponBase != null)
		{
			bGUWeaponBase.GetRootComponent().DetachFromComponent(LocationRule, RotationRule, ScaleRule);
			if (WeaponEnablePhysic)
			{
				BUS_EventCollectionCS.Get(bGUWeaponBase)?.Evt_SetStringProperty.Invoke(EPropType.Mesh_CollisionProfileName, "CharacterMesh_Death");
				bGUWeaponBase.SetActorEnableCollision(bNewActorEnableCollision: true);
				UGSE_SkeletalMeshFuncLib.SetAllBodiesShapeCollisionEnabled(bGUWeaponBase.SkeletalMeshComp, ECollisionEnabled.PhysicsOnly);
				bGUWeaponBase.SkeletalMeshComp.SetRenderStatic(bNewValue: false);
				bGUWeaponBase.SkeletalMeshComp.NoSkeletonUpdate = false;
				bGUWeaponBase.SkeletalMeshComp.SetSimulatePhysics(bSimulate: true);
			}
			WeaponCommData.DestroyDelayTime = DestroyDelayTime;
		}
	}
}
