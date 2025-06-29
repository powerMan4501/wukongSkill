using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_ProjectileBasicComp : UActorCompBaseCS
{
	private BUC_ProjectileBasicData ProjectileBasicData;

	private BUC_BulletSweepReactionData BulletSweepReactionData;

	protected IBUC_MasterData MasterData { get; set; }

	public override void OnAttach()
	{
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		BulletSweepReactionData = RequireWritableData<BUC_BulletSweepReactionData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		base.BUSEventCollection.Evt_ProjectileInitialization += new Del_ProjectileInitialization(ProjectileInitialization);
		base.BUSEventCollection.Evt_SwitchProjectileStatus += new Del_SwitchProjectileStatus(OnSwitchProjectileStatus);
		base.BUSEventCollection.Evt_SwitchProjectilePropertyInfo += new Del_SwitchBulletPropertyInfo(OnSwitchProjectilePropertyInfo);
		base.BUSEventCollection.Evt_OnSwitchBullet_Begin += new Del_Void(OnSwitchBullet_Begin);
		base.BUSEventCollection.Evt_OnSwitchBullet_Finished += new Del_Void(OnSwitchBullet_Finished);
		base.BUSEventCollection.Evt_OnSwitchBullet_Pre += new Del_Void(OnSwitchBullet_Pre);
		base.BUSEventCollection.Evt_OnBulletSpawnFinished += new Del_OnBulletSpawnFinished(OnBulletSpawnFinished);
	}

	private void ProjectileInitialization(FGSProjectileSpawnInfo ProjectileSpawnInfo, AActor MasterActor)
	{
		base.BUSEventCollection.Evt_SetMaster.Invoke(MasterActor);
		AttachBuffToProjectile(ProjectileSpawnInfo.BuffIDList);
		OnSetProjectileBasicData(ProjectileSpawnInfo);
		SetBulletSweepReactionData();
	}

	public void OnSetProjectileBasicData(FGSProjectileSpawnInfo ProjectileSpawnInfo)
	{
		ProjectileBasicData.SkillID = ProjectileSpawnInfo.SkillID;
		ProjectileBasicData.UseSocket_Spawn = ProjectileSpawnInfo.UseSocket_Spawn;
		ProjectileBasicData.SpawnPointName = ProjectileSpawnInfo.SpawnPointName;
		ProjectileBasicData.FacingTarget = ProjectileSpawnInfo.CurTarget;
		SetProjectileCommDescData(ProjectileSpawnInfo.ProjectileID);
	}

	private void SetProjectileCommDescData(int ProjectileID)
	{
		ProjectileBasicData.ProjectileID = ProjectileID;
		AActor masterActor = MasterData.GetMasterActor();
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(ProjectileID, masterActor);
		if (projectileCommDesc != null)
		{
			ProjectileBasicData.isFacingTarget = projectileCommDesc.ProjectileMeshIsFacingTarget == EGSYesNo.Yes;
			ProjectileBasicData.ProjectileType = projectileCommDesc.ProjectileType;
			AttachBuffToProjectile(projectileCommDesc.BirthBuff);
		}
	}

	private void SetBulletSweepReactionData()
	{
		if (BulletSweepReactionData == null)
		{
			return;
		}
		BulletSweepReactionData.ClearSweepReactionInfo();
		if (GetOwner() as BGUProjectileBaseActor == null)
		{
			return;
		}
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(ProjectileBasicData.ProjectileID, MasterData.GetMasterActor());
		if (projectileCommDesc != null)
		{
			BGWDataAsset_BulletSweepReactionConfig sweepReactionInfo = null;
			if (!string.IsNullOrEmpty(projectileCommDesc.ProjectileSweepReactionDataAssetPath))
			{
				sweepReactionInfo = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_BulletSweepReactionConfig>(projectileCommDesc.ProjectileSweepReactionDataAssetPath, ELoadResourceType.SyncLoadAndCache);
			}
			BulletSweepReactionData.SetSweepReactionInfo(sweepReactionInfo);
		}
	}

	private void OnSwitchProjectileStatus(EBGUProjectileStatus BulletStatus, float ActiveTime)
	{
		ProjectileBasicData.BulletStatus = BulletStatus;
	}

	private void OnSwitchProjectilePropertyInfo(int BulletSwitchID)
	{
		FUStBulletSwitchDesc bulletSwitchDesc = BGW_GameDB.GetBulletSwitchDesc(BulletSwitchID);
		if (bulletSwitchDesc == null)
		{
			return;
		}
		SetProjectileCommDescData(bulletSwitchDesc.BulletID);
		SetBulletSweepReactionData();
		if (bulletSwitchDesc.AttachBuffID.Count > 0)
		{
			base.BUSEventCollection.Evt_BuffAllRemove.Invoke(EBuffEffectTriggerType.None);
			if (bulletSwitchDesc.AttachBuffID[0] != -1)
			{
				AttachBuffToProjectile(bulletSwitchDesc.AttachBuffID);
			}
		}
	}

	private void AttachBuffToProjectile(IList<int> BuffIDList)
	{
		if (BuffIDList != null)
		{
			for (int i = 0; i < BuffIDList.Count && BuffIDList[i] != 0; i++)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(BuffIDList[i], GetOwner(), GetOwner(), 0f, EBuffSourceType.ProjectilBasic);
			}
		}
	}

	public void OnSwitchBullet_Finished()
	{
		BGUBulletBaseCS bGUBulletBaseCS = Owner as BGUBulletBaseCS;
		if (!bGUBulletBaseCS.IsNullOrDestroyed())
		{
			bGUBulletBaseCS.SwitchFinished();
		}
	}

	public void OnSwitchBullet_Begin()
	{
		BGUBulletBaseCS bGUBulletBaseCS = Owner as BGUBulletBaseCS;
		if (!bGUBulletBaseCS.IsNullOrDestroyed())
		{
			bGUBulletBaseCS.SwitchBegin();
		}
	}

	public void OnSwitchBullet_Pre()
	{
		BGUBulletBaseCS bGUBulletBaseCS = Owner as BGUBulletBaseCS;
		if (!bGUBulletBaseCS.IsNullOrDestroyed())
		{
			bGUBulletBaseCS.SwitchPre();
		}
	}

	public void OnBulletSpawnFinished(FProjectileSpawnEventInfo ProjectileSpawnEventInfo)
	{
		if (ProjectileBasicData.bNotify_SpawnFinished)
		{
			BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
			if (!bGUProjectileBaseActor.IsNullOrDestroyed())
			{
				bGUProjectileBaseActor.SpawnFinished(ProjectileSpawnEventInfo);
			}
		}
	}
}
