using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

internal class BGS_ProjectileManager : GameStateSystemBase
{
	private List<EntitySharedRef> AttachedList { get; set; }

	private Queue<FGSProjectileSpawnInfo> SpawnReqList { get; set; }

	public override void OnAttach()
	{
		base.BGSEventCollection.Evt_OnProjectileBeginAttach += new Del_Void_Actor(OnProjectileBeginAttach);
		base.BGSEventCollection.Evt_OnProjectileDestroyed += new Del_Void_Actor(OnProjectileDestroyed);
		base.BGSEventCollection.Evt_RequestSpawnAProjectile += new Del_RequestSpawnAProjectile(RequestSpawnAProjectile);
		base.BGSEventCollection.Evt_ClearAllAttachedProjectiles += new Del_Void(ClearAllAttachedProjectiles);
		base.BGSEventCollection.Evt_BGS_OnEnterLevelSequenceClearBattleItem += new Del_Void(OnEnterLevelSequenceClearBattleItem);
		base.BGSEventCollection.Evt_BGS_ClearAttachedProjectiles_OnUnit += new Del_Void_Actor(ClearAttachedProjectiles_OnUnit);
		AttachedList = new List<EntitySharedRef>();
		SpawnReqList = new Queue<FGSProjectileSpawnInfo>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		AttachedProjectile_ValidCheck();
		SpawnTick();
	}

	public void ClearAllAttachedProjectiles()
	{
		foreach (EntitySharedRef attached in AttachedList)
		{
			AActor aActor = EntitySharedRefFuncLib.Actor(attached);
			if (aActor != null)
			{
				BUS_EventCollectionCS.Get(aActor)?.Evt_ProjectileFinishAttachAndDestroyImmediatly.Invoke();
			}
		}
		AttachedList.Clear();
	}

	public void ClearAttachedProjectiles_OnUnit(AActor ParentActor)
	{
		if (ParentActor.IsNullOrDestroyed())
		{
			return;
		}
		List<EntitySharedRef> list = new List<EntitySharedRef>();
		foreach (EntitySharedRef attached in AttachedList)
		{
			BGUProjectileBaseActor bGUProjectileBaseActor = EntitySharedRefFuncLib.Actor(attached) as BGUProjectileBaseActor;
			if (bGUProjectileBaseActor != null && bGUProjectileBaseActor.GetAttachParentActor() == ParentActor)
			{
				list.Add(attached);
				BUS_EventCollectionCS.Get(bGUProjectileBaseActor)?.Evt_ProjectileFinishAttachAndDestroyImmediatly.Invoke();
			}
		}
		foreach (EntitySharedRef item in list)
		{
			AttachedList.Remove(item);
		}
	}

	public void OnProjectileBeginAttach(AActor ProjectileActor)
	{
		if (!(ProjectileActor as BGUProjectileBaseActor == null))
		{
			EntitySharedRef item = new EntitySharedRef(ProjectileActor);
			if (ProjectileActor != null && !AttachedList.Contains(item))
			{
				AttachedList.Add(item);
			}
		}
	}

	public void OnProjectileDestroyed(AActor ProjectileActor)
	{
		if (!(ProjectileActor as BGUProjectileBaseActor == null))
		{
			EntitySharedRef item = new EntitySharedRef(ProjectileActor);
			if (AttachedList.Contains(item))
			{
				AttachedList.Remove(item);
			}
		}
	}

	private void AttachedProjectile_ValidCheck()
	{
		for (int i = 0; i < AttachedList.Count; i++)
		{
			if (EntitySharedRefFuncLib.Actor(AttachedList[i]) == null)
			{
				AttachedList.RemoveAt(i);
				i--;
			}
		}
	}

	private void SpawnTick()
	{
		if (SpawnReqList.Count < 1)
		{
			return;
		}
		int num = 0;
		while (num < 4 && SpawnReqList.Count >= 1)
		{
			FGSProjectileSpawnInfo projectileSpawnInfo = SpawnReqList.Dequeue();
			if (SpawnAProjectileObj(projectileSpawnInfo))
			{
				num++;
			}
		}
	}

	public void RequestSpawnAProjectile(FGSProjectileSpawnInfo ProjectileSpawnInfo)
	{
		SpawnReqList.Enqueue(ProjectileSpawnInfo);
	}

	private bool SpawnAProjectileObj(FGSProjectileSpawnInfo ProjectileSpawnInfo)
	{
		ABGUCharacter aBGUCharacter = ProjectileSpawnInfo.Spawner as ABGUCharacter;
		if (aBGUCharacter.IsNullOrDestroyed())
		{
			OnSpawnFailed();
			return false;
		}
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(ProjectileSpawnInfo.ProjectileID, aBGUCharacter);
		if (BGW_LogUtil.LogIfNull(projectileCommDesc, "BGW_GameDB.GetProjectileCommDesc is null, ProjectileID:{0}", ProjectileSpawnInfo.ProjectileID))
		{
			OnSpawnFailed();
			return false;
		}
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(ProjectileSpawnInfo.ProjectileID);
		if (BGW_LogUtil.LogIfNull(projectileMoveDesc, "BGW_GameDB.GetProjectileMoveDesc is null, ProjectileID:{0}", ProjectileSpawnInfo.ProjectileID))
		{
			OnSpawnFailed();
			return false;
		}
		string projectileBPTemplatePath = projectileCommDesc.ProjectileBPTemplatePath;
		TSubclassOf<BGUProjectileBaseActor> tSubclassOf = BGW_PreloadAssetMgr.Get(aBGUCharacter).TryGetCachedResourceObj<UClass>(projectileBPTemplatePath, ELoadResourceType.SyncLoadAndCache);
		if (tSubclassOf != null)
		{
			FRotator Rotation = ProjectileSpawnInfo.BornDir;
			UWorld world = aBGUCharacter.World;
			BGUProjectileBaseActor bGUProjectileBaseActor = null;
			if (BGW_LogUtil.LogIfNull(world, "Spawn bullets failed! {0}'s streaming level world is null!", aBGUCharacter.GetName()))
			{
				OnSpawnFailed();
				return false;
			}
			if (projectileCommDesc.ProjectileType == EBGUBulletType.NormalSpawn || projectileCommDesc.ProjectileType == EBGUBulletType.MultiTarget)
			{
				FActorSpawnParametersInterop fActorSpawnParametersInterop = new FActorSpawnParametersInterop
				{
					SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
				};
				bGUProjectileBaseActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(world, tSubclassOf.Value, in ProjectileSpawnInfo.SpawnPosition, in Rotation) as BGUProjectileBaseActor;
				if (ProjectileSpawnInfo.AttachToSpawnBase)
				{
					if (ProjectileSpawnInfo.AttachToSpawnBase_SocketOwnerComp != null)
					{
						BGUFuncLibActorTransformCS.BGUAttachToComp(bGUProjectileBaseActor, ProjectileSpawnInfo.AttachToSpawnBase_SocketOwnerComp, ProjectileSpawnInfo.AttachToSpawnBase_SocketName, EAttachmentRule.SnapToTarget, ProjectileSpawnInfo.AttachRule_Rot, EAttachmentRule.KeepWorld);
					}
					else if (ProjectileSpawnInfo.AttachToSpawnBase_SpawnBaseActor != null)
					{
						BGUFuncLibActorTransformCS.BGUAttachToActor(bGUProjectileBaseActor, ProjectileSpawnInfo.AttachToSpawnBase_SpawnBaseActor, ProjectileSpawnInfo.AttachToSpawnBase_SocketName, EAttachmentRule.SnapToTarget, ProjectileSpawnInfo.AttachRule_Rot, EAttachmentRule.KeepWorld);
					}
				}
			}
			else if (projectileCommDesc.ProjectileType == EBGUBulletType.Weapon)
			{
				int index = (int)projectileCommDesc.ProjectileTypeParam;
				AActor aActor = BGUFunctionLibraryCS.BGUGetWeaponByIndex(aBGUCharacter, index);
				if (aActor != null)
				{
					bGUProjectileBaseActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(world, tSubclassOf.Value, in ProjectileSpawnInfo.SpawnPosition, in Rotation) as BGUBulletBaseCS;
					BGUFunctionLibraryCS.BGUGetWeaponByIndex(aBGUCharacter, index);
					BUS_EventCollectionCS.Get(aBGUCharacter)?.Evt_DetachWeapon.Invoke(index, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, -1f, WeaponEnablePhysic: false);
					aActor.AttachToActor(bGUProjectileBaseActor, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
					BGUWeaponBase actor = aActor as BGUWeaponBase;
					UAnimationAsset newAnimToPlay = BGW_PreloadAssetMgr.Get(aBGUCharacter).TryGetCachedResourceObj<UObject>(projectileCommDesc.ProjectileAnimPath, ELoadResourceType.AsyncLoadAndCache) as UAnimationAsset;
					BUS_EventCollectionCS.Get(actor)?.Evt_PlayOrStopAnimation.Invoke(IsPlay: true, IsLoop: true, newAnimToPlay);
				}
			}
			else if (projectileCommDesc.ProjectileType == EBGUBulletType.WeaponSceneItem)
			{
				BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(aBGUCharacter).SceneItemCatch.GetAttachedActors(out var OutActors);
				BGUWeaponBase bGUWeaponBase = null;
				foreach (AActor item in OutActors)
				{
					BGUWeaponBase bGUWeaponBase2 = item as BGUWeaponBase;
					if (bGUWeaponBase2 != null)
					{
						bGUWeaponBase = bGUWeaponBase2;
						break;
					}
				}
				if (bGUWeaponBase != null)
				{
					bGUProjectileBaseActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(world, tSubclassOf.Value, in ProjectileSpawnInfo.SpawnPosition, in Rotation) as BGUBulletBaseCS;
					bGUWeaponBase.AttachToActor(bGUProjectileBaseActor, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
					UAnimationAsset newAnimToPlay2 = BGW_PreloadAssetMgr.Get(aBGUCharacter).TryGetCachedResourceObj<UObject>(projectileCommDesc.ProjectileAnimPath, ELoadResourceType.AsyncLoadAndCache) as UAnimationAsset;
					BUS_EventCollectionCS.Get(bGUWeaponBase)?.Evt_PlayOrStopAnimation.Invoke(IsPlay: true, IsLoop: true, newAnimToPlay2);
				}
			}
			else if (projectileCommDesc.ProjectileType == EBGUBulletType.SceneItem)
			{
				BGUSceneItemBase bGUSceneItemBase;
				if (ProjectileSpawnInfo.InnerSceneItem != null)
				{
					bGUSceneItemBase = ProjectileSpawnInfo.InnerSceneItem as BGUSceneItemBase;
				}
				else
				{
					BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(aBGUCharacter);
					if (readOnlyData == null)
					{
						OnSpawnFailed();
						return false;
					}
					bGUSceneItemBase = readOnlyData.RemoveAttachSceneItem();
				}
				if (bGUSceneItemBase == null)
				{
					OnSpawnFailed();
					return false;
				}
				bGUProjectileBaseActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(world, tSubclassOf.Value, in ProjectileSpawnInfo.SpawnPosition, in Rotation) as BGUBulletBaseCS;
				FVector fVector = ProjectileSpawnInfo.TargetPos;
				if (fVector == FVector.ZeroVector)
				{
					fVector = ProjectileSpawnInfo.SpawnPosition + bGUProjectileBaseActor.GetActorForwardVector() * 1000.0;
				}
				FVector zeroVector = FVector.ZeroVector;
				zeroVector = BGUFunctionLibraryCS.BGUCalcImpulseP2P(bGUSceneItemBase, fVector, ProjectileSpawnInfo.ProjectileFlySpd.Spd.LeftValue);
				BUS_EventCollectionCS.Get(aBGUCharacter).Evt_DetachSceneItemAndAttachByProjectileActor.Invoke(bGUProjectileBaseActor, projectileCommDesc.ProjectileTypeParam, zeroVector, bGUSceneItemBase);
			}
			else if (projectileCommDesc.ProjectileType == EBGUBulletType.ModularActor)
			{
				if (ProjectileSpawnInfo.ModularActor == null)
				{
					OnSpawnFailed();
					return false;
				}
				bGUProjectileBaseActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(world, tSubclassOf.Value, in ProjectileSpawnInfo.SpawnPosition, in Rotation) as BGUBulletBaseCS;
				BGUFuncLibActorTransformCS.BGUAttachToActor(bGUProjectileBaseActor, ProjectileSpawnInfo.ModularActor, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld);
			}
			if (bGUProjectileBaseActor != null)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUProjectileBaseActor);
				BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(aBGUCharacter);
				if (bUS_GSEventCollection == null || bUS_GSEventCollection2 == null)
				{
					bGUProjectileBaseActor.DestroyActor();
					return false;
				}
				bUS_GSEventCollection2.Evt_CheckProjectileNumLimit.Invoke(ProjectileSpawnInfo.ProjectileID);
				FUStProjectileDispDesc projectileDispDesc = BGW_GameDB.GetProjectileDispDesc(ProjectileSpawnInfo.ProjectileID);
				if (projectileDispDesc != null)
				{
					bUS_GSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(projectileDispDesc.ProjectileSelfSpawnDBCPath, out var RequestID, bGUProjectileBaseActor.RootComponent);
					bUS_GSEventCollection.Evt_NotifyBulletMarkDBCReqID.Invoke(RequestID);
				}
				bUS_GSEventCollection.Evt_ProjectileInitialization.Invoke(ProjectileSpawnInfo, aBGUCharacter);
				bUS_GSEventCollection.Evt_OnProjectileIDChanged.Invoke(ProjectileSpawnInfo.ProjectileID);
				bUS_GSEventCollection.Evt_SetBulletMatMgrData.Invoke(ProjectileSpawnInfo.ProjectileID, 0);
				GSObjActorMoveInfo objActorMoveProperty = default(GSObjActorMoveInfo);
				AActor curTarget = ProjectileSpawnInfo.CurTarget;
				objActorMoveProperty.ProjectileCommID = ProjectileSpawnInfo.ProjectileID;
				objActorMoveProperty.ProjectileFlySpd = ProjectileSpawnInfo.ProjectileFlySpd;
				objActorMoveProperty.ProjectileRotSpd = ProjectileSpawnInfo.ProjectileRotSpd;
				objActorMoveProperty.TargetActor = curTarget;
				objActorMoveProperty.TargetOffsetInfo = new FGSTargetOffsetInfo(ProjectileSpawnInfo.TargetOffsetInfo);
				objActorMoveProperty.bUseSocket_Target = ProjectileSpawnInfo.UseSocket_Target;
				objActorMoveProperty.TargetActorSocketNameFromNotify = ProjectileSpawnInfo.TargetSocketNameFromNotify.ToString();
				objActorMoveProperty.StartLocation = ProjectileSpawnInfo.SpawnPosition;
				objActorMoveProperty.TargetPos = ProjectileSpawnInfo.TargetPos;
				objActorMoveProperty.TotalNumInAWave = ProjectileSpawnInfo.TotalNumInAWave;
				objActorMoveProperty.SelfIndexInAWave = ProjectileSpawnInfo.SelfIndexInAWave;
				if (projectileCommDesc.BulletSkillArea != null && projectileCommDesc.BulletSkillArea.AreaType != EBulletAreaType.None)
				{
					b1.BGUProjectileFuncLib.UpdateBulletSkillAffectArea(aBGUCharacter, bGUProjectileBaseActor, ProjectileSpawnInfo, curTarget);
				}
				if (!curTarget.IsNullOrDestroyed())
				{
					objActorMoveProperty.TargetPosAtSpawn = BGUFuncLibActorTransformCS.BGUGetActorLocation(curTarget);
				}
				if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.TraceMode)
				{
					objActorMoveProperty.TraceType = (EBGUBulletTraceType)projectileMoveDesc.ProjectileMoveModeIntParam[0];
					if (objActorMoveProperty.TraceType == EBGUBulletTraceType.BackNest)
					{
						objActorMoveProperty.NestName = bUS_GSEventCollection2.Evt_ProjectileGetSlotNameToBack.Invoke(projectileMoveDesc.ProjectileMoveModeStrParam[0]);
						bUS_GSEventCollection2.Evt_ProjectileMoveBackorOutNest.Invoke(bGUProjectileBaseActor, isBackNest: true, objActorMoveProperty.NestName);
					}
				}
				bUS_GSEventCollection.Evt_InitObjectMoveInfo.Invoke(objActorMoveProperty);
				bUS_GSEventCollection2.Evt_NotifyMasterProjectileSpawned.Invoke(bGUProjectileBaseActor);
				bUS_GSEventCollection2.Evt_AddCtrableBulletToPack.Invoke(bGUProjectileBaseActor);
				FProjectileSpawnEventInfo projectileSpawnEventInfo = new FProjectileSpawnEventInfo
				{
					TotalNumInAWave = ProjectileSpawnInfo.TotalNumInAWave,
					SelfIndexInAWave = ProjectileSpawnInfo.SelfIndexInAWave
				};
				bUS_GSEventCollection.Evt_OnBulletSpawnFinished.Invoke(projectileSpawnEventInfo);
			}
		}
		return true;
	}

	private void OnSpawnFailed()
	{
	}

	private void OnEnterLevelSequenceClearBattleItem()
	{
		ClearAllAttachedProjectiles();
	}
}
