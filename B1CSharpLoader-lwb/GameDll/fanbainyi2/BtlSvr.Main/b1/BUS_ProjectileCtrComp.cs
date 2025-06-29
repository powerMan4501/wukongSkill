using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_ProjectileCtrComp : UActorCompBaseCS
{
	private b1.BUC_ProjectileCtrData ProjectileCtrData;

	private IBUC_TargetInfoData TargetInfoData;

	public override void OnAttach()
	{
		ProjectileCtrData = RequireWritableData<b1.BUC_ProjectileCtrData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		base.BUSEventCollection.Evt_CastControllBullet += new Del_CastSwitchBullet(CastControllBullet);
		base.BUSEventCollection.Evt_CastBulletAuto += new Del_CastBulletAuto(AutoBulletUseInnerTarget);
		base.BUSEventCollection.Evt_AddCtrableBulletToPack += new Del_Void_Actor(AddCtrableBulletToPack);
		base.BUSEventCollection.Evt_RemoveCtrableBulletFromPack += new Del_Void_Actor(RemoveCtrableBulletFromPack);
		base.BUSEventCollection.Evt_ProjectileMoveBackorOutNest += new Del_ProjectileMoveBackorOutNest(MoveBackorOutNest);
		base.BUSEventCollection.Evt_ProjectileGetSlotNameToBack += new Del_ProjectileGetSlotNameToBack(GetSlotNameToBack);
		base.BUSEventCollection.Evt_OnSwitchOneProjectile += new Del_OnSwitchOneProjectile(SwitchBulletInfoIfNeed);
		base.BUSEventCollection.Evt_SwitchBulletTarget += new Del_SwitchBulletTarget(OnSwitchBulletTarget);
		base.BUSEventCollection.Evt_DestroyAllCtrableBullet += new Del_Void(DestroyAllCtrableBullet);
		base.BUSEventCollection.Evt_DestroyProjectileByID += new Del_DestroyProjectileByID(DestroyProjectileByID);
		base.BUSEventCollection.Evt_DestroyProjectile_ExceptID += new Del_DestroyProjectile_ExceptID(DestroyProjectile_ExceptID);
		base.BUSEventCollection.Evt_BulletsSimpleCreator += new Del_BulletSimpleCreator(BulletSimpleCreator);
		base.BUSEventCollection.Evt_AddToPassiveQuene += new Del_Void_IntActor(AddToPassiveQuene);
		base.BUSEventCollection.Evt_OnNotifyStateSpawnProjectileObj += new Del_OnNotifyStateSpawnProjectileObj(OnNotifyStateSpawnProjectileObj);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_TriggerPlayerRest += new Del_TriggerPlayerRest(OnPlayerRest);
		base.BUSEventCollection.Evt_OnNotifyStateSpawnProjectileObjEnd += new Del_OnNotifyStateSpawnProjectileObjEnd(OnNotifyStateSpawnProjectileObjEnd);
		base.BUSEventCollection.Evt_CheckProjectileNumLimit += new Del_Void_Int(CheckProjectileNumLimit);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_CollectAllRelatedActorForReplicated += new Del_CollectAllRelatedActorForReplicated(CollectAllRelatedActorForReplicated);
		base.BUSEventCollection.Evt_PCSEW_Regist += new Del_PCSEW_Regist(PCSEW_Regist);
		base.BUSEventCollection.Evt_PCSEW_Destroy += new Del_PCSEW_Regist(PCSEW_Destroy);
		base.BUSEventCollection.Evt_CastProjectileLifeOver += new Del_CastProjectileLifeOver(CastProjectileLifeOver);
		base.BUSEventCollection.Evt_NotifyTransitToUnit += new Del_Void_Actor(OnTransitToUnit);
		base.BGSEventCollection.Evt_BGS_OnEnterLevelSequenceClearBattleItem += new Del_Void(OnEnterLevelSequence_DestroyAllCtrableBullet);
	}

	protected void CollectAllRelatedActorForReplicated(List<AActor> RelatedActor)
	{
		foreach (BGUProjectileBaseActor projectile in ProjectileCtrData.ProjectileList)
		{
			if (BGU_DataUtil.GetActorType(projectile) == BGU_ActorType.MagicField)
			{
				RelatedActor.Add(projectile);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!(GetOwner() == null) && !GetOwner().IsPendingKill)
		{
			ProjectileSpawnEventTick(DeltaTime);
			DelaySwitchTick(DeltaTime);
			PassiveProtectTimerTick(DeltaTime);
			PassiveQueneUpdate();
		}
	}

	private void ProjectileSpawnEventTick(float DeltaTime)
	{
		if (ProjectileCtrData == null || ProjectileCtrData.ProjectileSpawnEvents == null || ProjectileCtrData.ProjectileSpawnEvents.GetSize() < 1)
		{
			return;
		}
		ProjectileCtrData.ProjectileSpawnEvents.BeginItr();
		GSProjectileSpawnEventBase output;
		while (ProjectileCtrData.ProjectileSpawnEvents.NextItr(out output))
		{
			output.DoTickImpl(DeltaTime);
			if (output.IsFinished())
			{
				ProjectileCtrData.ProjectileSpawnEvents.Remove();
			}
		}
	}

	private void DelaySwitchTick(float DeltaTime)
	{
		if (ProjectileCtrData == null || !ProjectileCtrData.EnableSwitch)
		{
			return;
		}
		if (ProjectileCtrData.CurSwitchIdx >= ProjectileCtrData.CurSwitchList.Count)
		{
			ProjectileCtrData.EnableSwitch = false;
			ProjectileCtrData.CurSwitchIdx = 0;
			ProjectileCtrData.CurSwitchList.Clear();
		}
		else if (ProjectileCtrData.IntervalTime == 0f)
		{
			for (int i = 0; i < ProjectileCtrData.CurSwitchList.Count; i++)
			{
				SwitchBulletInfoIfNeed(ProjectileCtrData.CurSwitchList[i], ProjectileCtrData.CurBulletSwitchID, i);
			}
			ProjectileCtrData.EnableSwitch = false;
			ProjectileCtrData.CurSwitchIdx = 0;
			ProjectileCtrData.CurSwitchList.Clear();
		}
		else if (ProjectileCtrData.IntervalTimer > 0f)
		{
			ProjectileCtrData.IntervalTimer -= DeltaTime;
		}
		else
		{
			SwitchBulletInfoIfNeed(ProjectileCtrData.CurSwitchList[ProjectileCtrData.CurSwitchIdx], ProjectileCtrData.CurBulletSwitchID, ProjectileCtrData.CurSwitchIdx);
			ProjectileCtrData.CurSwitchIdx++;
			if (ProjectileCtrData.CurSwitchIdx < ProjectileCtrData.CurSwitchList.Count)
			{
				BUS_EventCollectionCS.Get(ProjectileCtrData.CurSwitchList[ProjectileCtrData.CurSwitchIdx])?.Evt_OnSwitchBullet_Pre.Invoke();
			}
			ProjectileCtrData.IntervalTimer = ProjectileCtrData.IntervalTime;
		}
	}

	private void PassiveProtectTimerTick(float DeltaTime)
	{
		if (ProjectileCtrData == null)
		{
			return;
		}
		int[] array = ProjectileCtrData.PassiveProtectTimerMap.Keys.ToArray();
		foreach (int key in array)
		{
			EntitySharedRef[] array2 = ProjectileCtrData.PassiveProtectTimerMap[key].Keys.ToArray();
			foreach (EntitySharedRef entitySharedRef in array2)
			{
				if (ProjectileCtrData.PassiveProtectTimerMap[key][entitySharedRef] > 0f)
				{
					ProjectileCtrData.PassiveProtectTimerMap[key][entitySharedRef] -= DeltaTime;
				}
				else
				{
					ProjectileCtrData.PassiveProtectTimerMap[key].Remove(entitySharedRef);
				}
			}
		}
	}

	private void CastControllBullet(int ctr_number, int BulletSwitchID, float SwitchInterval, float DestroyTimeFilter, ESwitchFilterMode FilterMode, int FilterBulletID, bool bSwitchImmediate = false, bool bSelectWithOrder = true)
	{
		if (GetOwner() == null || GetOwner().IsPendingKill || ProjectileCtrData.EnableSwitch)
		{
			return;
		}
		FUStBulletSwitchDesc bulletSwitchDesc = BGW_GameDB.GetBulletSwitchDesc(BulletSwitchID);
		if (bulletSwitchDesc == null)
		{
			return;
		}
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(bulletSwitchDesc.BulletID);
		List<BGUProjectileBaseActor> list = new List<BGUProjectileBaseActor>();
		bool callNestBullet = true;
		if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.TraceMode && projectileMoveDesc.ProjectileMoveModeIntParam[0] == 2)
		{
			callNestBullet = false;
		}
		list = GetCallBulletListAfterFilter(ctr_number, callNestBullet, DestroyTimeFilter, FilterMode, FilterBulletID, null, bSelectWithOrder);
		if (list != null && list.Count > ProjectileCtrData.CurSwitchIdx)
		{
			ProjectileCtrData.CurSwitchList = list;
			ProjectileCtrData.EnableSwitch = true;
			ProjectileCtrData.CurBulletSwitchID = BulletSwitchID;
			ProjectileCtrData.IntervalTime = SwitchInterval;
			if (bSwitchImmediate)
			{
				ProjectileCtrData.IntervalTimer = 0f;
				return;
			}
			ProjectileCtrData.IntervalTimer = ProjectileCtrData.IntervalTime;
			BUS_EventCollectionCS.Get(ProjectileCtrData.CurSwitchList[ProjectileCtrData.CurSwitchIdx])?.Evt_OnSwitchBullet_Pre.Invoke();
		}
	}

	private void OnSwitchBulletTarget(BGUProjectileBaseActor ProjectileActor, AActor InnerTarget, string SocketName = "")
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(ProjectileActor);
		if (!(bUS_GSEventCollection == null))
		{
			bUS_GSEventCollection.Evt_SwitchMovementTarget.Invoke(InnerTarget, SocketName);
		}
	}

	private void SwitchBulletInfoIfNeed(BGUProjectileBaseActor ProjectileActor, int BulletSwitchID, int SwitchIdx = 0, AActor InnerTarget = null)
	{
		FUStBulletSwitchDesc bulletSwitchDesc = BGW_GameDB.GetBulletSwitchDesc(BulletSwitchID);
		if (bulletSwitchDesc == null)
		{
			return;
		}
		int p = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileBasicData>(ProjectileActor)?.ProjectileID ?? 0;
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(bulletSwitchDesc.BulletID);
		if (projectileMoveDesc == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(ProjectileActor);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		bUS_GSEventCollection.Evt_OnSwitchBullet_Begin.Invoke();
		bUS_GSEventCollection.Evt_OnProjectileIDChanged.Invoke(bulletSwitchDesc.BulletID);
		bUS_GSEventCollection.Evt_ReActiveProjectileTick.Invoke();
		bUS_GSEventCollection.Evt_ObjectActorDisablePhysics.Invoke();
		bUS_GSEventCollection.Evt_SwitchProjectilePropertyInfo.Invoke(BulletSwitchID);
		bUS_GSEventCollection.Evt_SetBulletMatMgrData.Invoke(bulletSwitchDesc.BulletID, SwitchIdx);
		FGSwitchBulletMovableInfo movableInfo = new FGSwitchBulletMovableInfo
		{
			BulletSwitchID = BulletSwitchID
		};
		if (bulletSwitchDesc.ResetTargetType != EProjectileResetTargetType.None)
		{
			AActor aActor = null;
			ProjectileBaseType projectileBaseType = ProjectileBaseType.None;
			UEnvQuery eQSTemplate = null;
			if (bulletSwitchDesc.ResetTargetType == EProjectileResetTargetType.InnerTarget)
			{
				projectileBaseType = ProjectileBaseType.EffectTarget;
				aActor = InnerTarget;
			}
			else
			{
				projectileBaseType = ResetTargetTypeMapping(bulletSwitchDesc.ResetTargetType);
				aActor = BGU_ObjActorUtil.GetBaseActor(Owner, Owner, projectileBaseType);
				if (projectileBaseType == ProjectileBaseType.UseEQSPoint)
				{
					eQSTemplate = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UEnvQuery>(bulletSwitchDesc.TargetEQSTemplate, ELoadResourceType.SyncLoadAndCache);
				}
			}
			ProjectileBaseStruct BaseInfo = default(ProjectileBaseStruct);
			BaseInfo.BaseActor = new TStrongObjectPtr<AActor>();
			BaseInfo.BaseActor.Set(aActor);
			BaseInfo.BaseType = projectileBaseType;
			BaseInfo.UseSocket = true;
			BaseInfo.SocketName = new FName(bulletSwitchDesc.TargetSocket);
			BaseInfo.PointSetCachedReqID = bulletSwitchDesc.TargetPointSetCachedReqID;
			BaseInfo.EQSTemplate = eQSTemplate;
			FGSTargetOffsetInfo fGSTargetOffsetInfo = new FGSTargetOffsetInfo();
			fGSTargetOffsetInfo.BaseActor.Set(aActor);
			BGUFuncLibProjectile.PrepareSpawnPositions(Owner, ref BaseInfo);
			List<FVector> RangeOffsetList = new List<FVector>();
			USceneComponent SocketOwnerComp;
			FVector basePos = BGUFuncLibProjectile.GetBasePos(BaseInfo, fGSTargetOffsetInfo, out SocketOwnerComp, ref RangeOffsetList, SwitchIdx);
			movableInfo.TargetOffsetInfo = fGSTargetOffsetInfo;
			movableInfo.TargetPos = basePos;
			movableInfo.TargetActor = aActor;
		}
		bool isBackNest = false;
		if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.TraceMode && projectileMoveDesc.ProjectileMoveModeIntParam[0] == 2)
		{
			BUC_ProjectileBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileBasicData>(ProjectileActor);
			if (readOnlyData.ProjectileType != EBGUBulletType.Weapon)
			{
				FName slotNameToBack = GetSlotNameToBack(projectileMoveDesc.ProjectileMoveModeStrParam[0]);
				if (slotNameToBack == FName.None)
				{
					return;
				}
				movableInfo.NestName = slotNameToBack;
				isBackNest = true;
			}
			else
			{
				movableInfo.NestName = readOnlyData.SpawnPointName;
			}
			MoveBackorOutNest(ProjectileActor, isBackNest: false);
		}
		MoveBackorOutNest(ProjectileActor, isBackNest, movableInfo.NestName);
		bUS_GSEventCollection.Evt_OnSwitchBulletMove.Invoke(movableInfo, GetOwner());
		base.BUSEventCollection.Evt_NotifyMasterProjectileSwitchFinished.Invoke(ProjectileActor, p);
		bUS_GSEventCollection.Evt_OnSwitchBullet_Finished.Invoke();
	}

	private ProjectileBaseType ResetTargetTypeMapping(EProjectileResetTargetType ResetTargetType)
	{
		ProjectileBaseType result = ProjectileBaseType.None;
		switch (ResetTargetType)
		{
		case EProjectileResetTargetType.ProjectileSpawner:
			result = ProjectileBaseType.ProjectileSpawner;
			break;
		case EProjectileResetTargetType.CurTargetProjectileSpawner:
			result = ProjectileBaseType.CurTarget_ProjectileSpawner;
			break;
		case EProjectileResetTargetType.UsePointSetCached:
			result = ProjectileBaseType.UsePointSetCached;
			break;
		case EProjectileResetTargetType.UseSkillBaseTarget:
			result = ProjectileBaseType.UseSkillBaseTarget;
			break;
		case EProjectileResetTargetType.SceneItemCached:
			result = ProjectileBaseType.SceneItemCached;
			break;
		case EProjectileResetTargetType.EQSPoint:
			result = ProjectileBaseType.UseEQSPoint;
			break;
		}
		return result;
	}

	private void AddCtrableBulletToPack(AActor PrjtileActor)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = PrjtileActor as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor != null)
		{
			ProjectileCtrData.ProjectileList.Add(bGUProjectileBaseActor);
		}
	}

	private void RemoveCtrableBulletFromPack(AActor PrjtileActor)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = PrjtileActor as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor != null)
		{
			ProjectileCtrData.ProjectileList.Remove(bGUProjectileBaseActor);
			MoveBackorOutNest(bGUProjectileBaseActor, isBackNest: false);
		}
	}

	private FName GetSlotNameToBack(string PreSlotName)
	{
		FName key = new FName(PreSlotName);
		FName result = default(FName);
		InitSlotBulletPack(PreSlotName);
		for (int i = 0; i < ProjectileCtrData.SlotBulletPack[key].Count; i++)
		{
			FName fName = new FName(PreSlotName + (i + 1));
			if (ProjectileCtrData.SlotBulletPack[key].ContainsKey(fName) && ProjectileCtrData.SlotBulletPack[key][fName] == null)
			{
				return fName;
			}
		}
		return result;
	}

	private void MoveBackorOutNest(BGUProjectileBaseActor Bullet, bool isBackNest, FName NestName = default(FName))
	{
		if (Bullet == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Bullet);
		if (isBackNest)
		{
			if (NestName == FName.None)
			{
				return;
			}
			FName fName = default(FName);
			foreach (KeyValuePair<FName, Dictionary<FName, BGUProjectileBaseActor>> item in ProjectileCtrData.SlotBulletPack)
			{
				foreach (KeyValuePair<FName, BGUProjectileBaseActor> item2 in item.Value)
				{
					if (item2.Key == NestName)
					{
						fName = item.Key;
						break;
					}
				}
				if (fName != FName.None)
				{
					break;
				}
			}
			if (!(fName == FName.None))
			{
				ProjectileCtrData.SlotBulletPack[fName][NestName] = Bullet;
				bUS_GSEventCollection.Evt_SwitchProjectileStatus.Invoke(EBGUProjectileStatus.InNest, -1f);
			}
			return;
		}
		FName fName2 = default(FName);
		FName fName3 = default(FName);
		foreach (KeyValuePair<FName, Dictionary<FName, BGUProjectileBaseActor>> item3 in ProjectileCtrData.SlotBulletPack)
		{
			foreach (KeyValuePair<FName, BGUProjectileBaseActor> item4 in item3.Value)
			{
				if (item4.Value == Bullet)
				{
					fName2 = item3.Key;
					fName3 = item4.Key;
					break;
				}
			}
		}
		if (fName2 == FName.None || fName3 == FName.None)
		{
			return;
		}
		ProjectileCtrData.SlotBulletPack[fName2][fName3] = null;
		bool flag = true;
		BUC_ProjectileLifeData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileLifeData>(Bullet);
		if (readOnlyData != null && readOnlyData.ProjectileIsDead)
		{
			FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(Bullet.GetProjectileID(), Owner);
			if (projectileCommDesc != null && projectileCommDesc.LifeOverWithDetach == EGSYesNo.No)
			{
				flag = false;
			}
		}
		if (flag)
		{
			BGUFuncLibActorTransformCS.BGUDetachFromActor(Bullet, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}
		bUS_GSEventCollection.Evt_SwitchProjectileStatus.Invoke(EBGUProjectileStatus.Active, -1f);
	}

	private void InitSlotBulletPack(string PreSlotName)
	{
		FName key = new FName(PreSlotName);
		if (ProjectileCtrData.SlotBulletPack.ContainsKey(key))
		{
			return;
		}
		Dictionary<FName, BGUProjectileBaseActor> dictionary = new Dictionary<FName, BGUProjectileBaseActor>();
		BGUCharacterCS owner = GetOwner() as BGUCharacterCS;
		int num = 1;
		FName socketName = new FName(PreSlotName + num);
		BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, owner, socketName, out var SocketOwnerComp);
		USkeletalMeshComponent uSkeletalMeshComponent = SocketOwnerComp as USkeletalMeshComponent;
		if (!(uSkeletalMeshComponent == null))
		{
			socketName = new FName(PreSlotName + num);
			while (uSkeletalMeshComponent.DoesSocketExist(socketName))
			{
				FName fName = default(FName);
				fName = socketName;
				dictionary.Add(fName, null);
				num++;
				socketName = new FName(PreSlotName + num);
			}
			ProjectileCtrData.SlotBulletPack.Add(key, dictionary);
		}
	}

	private List<BGUProjectileBaseActor> GetCallBulletListAfterFilter(int number, bool CallNestBullet, float DestroyTimeFilter, ESwitchFilterMode FilterMode, int FilterBulletID, AActor Target = null, bool WithOrder = true)
	{
		if (ProjectileCtrData.ProjectileList.Count == 0)
		{
			return null;
		}
		if (Owner == null)
		{
			return null;
		}
		List<BGUProjectileBaseActor> list = new List<BGUProjectileBaseActor>();
		for (int i = 0; i < ProjectileCtrData.ProjectileList.Count; i++)
		{
			BUC_ProjectileBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileBasicData>(ProjectileCtrData.ProjectileList[i]);
			BUC_BulletEffectData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_BulletEffectData>(ProjectileCtrData.ProjectileList[i]);
			BUC_ProjectileLifeData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileLifeData>(ProjectileCtrData.ProjectileList[i]);
			if (readOnlyData == null || readOnlyData2 == null)
			{
				continue;
			}
			_ = readOnlyData.BulletStatus;
			_ = 1;
			if (readOnlyData3.ProjectileLifeTimer != -1f && !(readOnlyData3.ProjectileLifeTimer >= DestroyTimeFilter))
			{
				continue;
			}
			switch (FilterMode)
			{
			case ESwitchFilterMode.Nearest:
			case ESwitchFilterMode.NearestToTarget:
				if (!CallNestBullet)
				{
					if (readOnlyData.BulletStatus != EBGUProjectileStatus.InNest)
					{
						list.Add(ProjectileCtrData.ProjectileList[i]);
					}
				}
				else
				{
					list.Add(ProjectileCtrData.ProjectileList[i]);
				}
				break;
			case ESwitchFilterMode.InNest:
				if (readOnlyData.BulletStatus == EBGUProjectileStatus.InNest)
				{
					list.Add(ProjectileCtrData.ProjectileList[i]);
				}
				break;
			case ESwitchFilterMode.IsFresh:
				if (readOnlyData3.ProjectileisFresh)
				{
					list.Add(ProjectileCtrData.ProjectileList[i]);
				}
				break;
			case ESwitchFilterMode.FilterID:
				if (ProjectileCtrData.ProjectileList[i].GetProjectileID() == FilterBulletID)
				{
					list.Add(ProjectileCtrData.ProjectileList[i]);
				}
				break;
			}
		}
		List<BGUProjectileBaseActor> list2 = new List<BGUProjectileBaseActor>();
		if (WithOrder)
		{
			if (FilterMode == ESwitchFilterMode.InNest)
			{
				int num = 0;
				foreach (FName key2 in ProjectileCtrData.SlotBulletPack.Keys)
				{
					for (int j = 1; j < ProjectileCtrData.SlotBulletPack[key2].Count + 1; j++)
					{
						FName key = new FName(key2.ToString() + j);
						if (!ProjectileCtrData.SlotBulletPack[key2].ContainsKey(key))
						{
							continue;
						}
						BGUProjectileBaseActor bGUProjectileBaseActor = ProjectileCtrData.SlotBulletPack[key2][key];
						if (bGUProjectileBaseActor != null && list.Contains(bGUProjectileBaseActor))
						{
							list2.Add(bGUProjectileBaseActor);
							num++;
							if (num >= number)
							{
								break;
							}
						}
					}
					if (num >= number)
					{
						break;
					}
				}
			}
			else
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorTransform(GetOwner()).GetLocation();
				if (FilterMode == ESwitchFilterMode.NearestToTarget)
				{
					if (Target == null && GetOwner() as BGUCharacterCS != null)
					{
						Target = TargetInfoData.GetTargetInfo().LockTargetActor as ABGUCharacter;
					}
					if (Target != null)
					{
						v = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
					}
				}
				for (int k = 0; k < number; k++)
				{
					if (list.Count == 0)
					{
						break;
					}
					int index = 0;
					float num2 = FVector.Dist(v, BGUFuncLibActorTransformCS.BGUGetActorTransform(list[index]).GetLocation());
					for (int l = 0; l < list.Count; l++)
					{
						if (FVector.Dist(v, BGUFuncLibActorTransformCS.BGUGetActorTransform(list[l]).GetLocation()) < num2)
						{
							index = l;
							num2 = FVector.Dist(v, BGUFuncLibActorTransformCS.BGUGetActorTransform(list[l]).GetLocation());
						}
					}
					BGUProjectileBaseActor item = list[index];
					list.RemoveAt(index);
					list2.Add(item);
				}
			}
		}
		else
		{
			for (int m = 0; m < number; m++)
			{
				if (list.Count == 0)
				{
					break;
				}
				int index2 = MathLib.RandomIntInRange(0, list.Count - 1);
				BGUProjectileBaseActor item2 = list[index2];
				list.RemoveAt(index2);
				list2.Add(item2);
			}
		}
		return list2;
	}

	private void CastProjectileLifeOver(int number, ESwitchFilterMode FilterMode, int FilterBulletID)
	{
		List<BGUProjectileBaseActor> callBulletListAfterFilter = GetCallBulletListAfterFilter(number, CallNestBullet: true, -1f, FilterMode, FilterBulletID);
		if (callBulletListAfterFilter == null)
		{
			return;
		}
		foreach (BGUProjectileBaseActor item in callBulletListAfterFilter)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(item);
			if (bUS_GSEventCollection != null)
			{
				FEffectInstReq EffectInstReq = default(FEffectInstReq);
				bUS_GSEventCollection.Evt_BulletTriggerEffectsByReson.Invoke(EBGUBulletTriggerEffectReason.LifeOver, ref EffectInstReq);
			}
		}
	}

	private void DestroyAllCtrableBullet()
	{
		if (ProjectileCtrData.ProjectileList == null)
		{
			return;
		}
		List<BGUProjectileBaseActor> list = new List<BGUProjectileBaseActor>();
		list.AddRange(ProjectileCtrData.ProjectileList);
		for (int i = 0; i < list.Count; i++)
		{
			if (!(list[i] == null))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(list[i]);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.EffectDestroy);
				}
			}
		}
		ProjectileCtrData.ProjectileList.Clear();
	}

	private void OnEnterLevelSequence_DestroyAllCtrableBullet()
	{
		if (ProjectileCtrData.ProjectileList == null)
		{
			return;
		}
		List<BGUProjectileBaseActor> list = new List<BGUProjectileBaseActor>();
		list.AddRange(ProjectileCtrData.ProjectileList);
		for (int i = 0; i < list.Count; i++)
		{
			BGUProjectileBaseActor bGUProjectileBaseActor = list[i];
			if (!(bGUProjectileBaseActor == null))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUProjectileBaseActor);
				if (bUS_GSEventCollection != null && BGW_GameDB.IsProjectileNeedDestroyOnEnterLevelSequence(bGUProjectileBaseActor.GetProjectileID()))
				{
					bUS_GSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.LevelSequenceDestroy);
				}
			}
		}
	}

	private void DestroyProjectileByID(List<int> ProjectileID)
	{
		if (ProjectileCtrData.ProjectileList == null)
		{
			return;
		}
		if (ProjectileID == null || (ProjectileID != null && ProjectileID.Count < 1))
		{
			DestroyAllCtrableBullet();
			return;
		}
		List<BGUProjectileBaseActor> list = new List<BGUProjectileBaseActor>();
		list.AddRange(ProjectileCtrData.ProjectileList);
		List<BGUProjectileBaseActor> list2 = new List<BGUProjectileBaseActor>();
		for (int i = 0; i < list.Count; i++)
		{
			int projectileID = list[i].GetProjectileID();
			if (ProjectileID.Contains(projectileID))
			{
				list2.Add(list[i]);
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(list[i]);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.EffectDestroy);
				}
			}
		}
	}

	private void DestroyProjectile_ExceptID(List<int> ExceptProjectileIDList)
	{
		if (ProjectileCtrData.ProjectileList == null)
		{
			return;
		}
		if (ExceptProjectileIDList == null || (ExceptProjectileIDList != null && ExceptProjectileIDList.Count < 1))
		{
			DestroyAllCtrableBullet();
			return;
		}
		List<BGUProjectileBaseActor> list = new List<BGUProjectileBaseActor>();
		list.AddRange(ProjectileCtrData.ProjectileList);
		List<BGUProjectileBaseActor> list2 = new List<BGUProjectileBaseActor>();
		for (int i = 0; i < list.Count; i++)
		{
			int projectileID = list[i].GetProjectileID();
			if (!ExceptProjectileIDList.Contains(projectileID))
			{
				list2.Add(list[i]);
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(list[i]);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.EffectDestroy);
				}
			}
		}
	}

	private void OnTransitToUnit(AActor Actor)
	{
		TransferAllProjectilesAuthority(Actor);
	}

	private void TransferAllProjectilesAuthority(AActor NewOwner)
	{
		if (NewOwner == null || !(NewOwner is BGUCharacterCS))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NewOwner);
		foreach (BGUProjectileBaseActor projectile in ProjectileCtrData.ProjectileList)
		{
			BUS_EventCollectionCS.Get(projectile).Evt_SetMaster.Invoke(NewOwner);
			bUS_GSEventCollection.Evt_AddCtrableBulletToPack.Invoke(projectile);
		}
		ProjectileCtrData.ProjectileList.Clear();
	}

	private void AutoBulletUseInnerTarget(int ctr_number, int BulletSwitchID, float SwitchInterval, float DestroyTimeFilter, ESwitchFilterMode FilterMode, int FilterBulletID, AActor InnerTarget)
	{
		if (GetOwner() == null || GetOwner().IsPendingKill || ProjectileCtrData.EnableSwitch)
		{
			return;
		}
		FUStBulletSwitchDesc bulletSwitchDesc = BGW_GameDB.GetBulletSwitchDesc(BulletSwitchID);
		if (bulletSwitchDesc == null)
		{
			return;
		}
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(bulletSwitchDesc.BulletID);
		if (projectileMoveDesc == null)
		{
			return;
		}
		List<BGUProjectileBaseActor> list = new List<BGUProjectileBaseActor>();
		bool callNestBullet = true;
		if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.TraceMode && projectileMoveDesc.ProjectileMoveModeIntParam[0] == 2)
		{
			callNestBullet = false;
		}
		list = GetCallBulletListAfterFilter(ctr_number, callNestBullet, DestroyTimeFilter, FilterMode, FilterBulletID);
		if (list != null)
		{
			ProjectileCtrData.CurSwitchList = list;
			ProjectileCtrData.EnableSwitch = true;
			ProjectileCtrData.CurBulletSwitchID = BulletSwitchID;
			for (int i = 0; i < ProjectileCtrData.CurSwitchList.Count; i++)
			{
				SwitchBulletInfoIfNeed(ProjectileCtrData.CurSwitchList[i], ProjectileCtrData.CurBulletSwitchID, i, InnerTarget);
			}
			ProjectileCtrData.EnableSwitch = false;
			ProjectileCtrData.CurSwitchIdx = 0;
			ProjectileCtrData.CurSwitchList.Clear();
		}
	}

	private void PassiveQueneUpdate()
	{
		if (ProjectileCtrData == null)
		{
			return;
		}
		int[] array = ProjectileCtrData.PassiveTargetQueue.Keys.ToArray();
		if (array.Length < 1)
		{
			return;
		}
		AActor owner = GetOwner();
		int[] array2 = array;
		foreach (int num in array2)
		{
			if (ProjectileCtrData.PassiveTargetQueue[num].Count < 1)
			{
				continue;
			}
			int num2;
			for (num2 = 0; num2 < ProjectileCtrData.PassiveTargetQueue[num].Count; num2++)
			{
				EntitySharedRef entitySharedRef = ProjectileCtrData.PassiveTargetQueue[num][num2];
				if (base.BUSEventCollection != null)
				{
					FEffectInstReq effectInstReq = new FEffectInstReq(GetOwner());
					effectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
					effectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
					effectInstReq.HitActionDir = EHitActionDir.Default;
					base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(num, effectInstReq, EntitySharedRefFuncLib.Actor(entitySharedRef));
				}
				FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(num, owner);
				if (skillEffectDesc.EffectParamsFloat.Count > 0)
				{
					float num3 = skillEffectDesc.EffectParamsFloat[0];
					if (ProjectileCtrData.PassiveProtectTimerMap.ContainsKey(num))
					{
						if (ProjectileCtrData.PassiveProtectTimerMap[num].ContainsKey(entitySharedRef))
						{
							ProjectileCtrData.PassiveProtectTimerMap[num][entitySharedRef] = num3;
						}
						else
						{
							ProjectileCtrData.PassiveProtectTimerMap[num].Add(entitySharedRef, num3);
						}
					}
					else
					{
						EntitySharedRefDic<float> entitySharedRefDic = new EntitySharedRefDic<float>();
						entitySharedRefDic.Add(entitySharedRef, num3);
						ProjectileCtrData.PassiveProtectTimerMap.Add(num, entitySharedRefDic);
					}
				}
				ProjectileCtrData.PassiveTargetQueue[num].RemoveAt(num2);
				num2--;
			}
		}
	}

	private void AddToPassiveQuene(int EffectID, AActor TargetActor)
	{
		if (TargetActor.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("BUS_ProjectileCtrComp::AddToPassiveQuene TargetActor == null");
			return;
		}
		EntitySharedRef entityRef = new EntitySharedRef(TargetActor);
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, GetOwner());
		if (skillEffectDesc == null || skillEffectDesc.EffectType != EBuffAndSkillEffectType.BulletAutoAttack)
		{
			return;
		}
		if (ProjectileCtrData.PassiveProtectTimerMap.ContainsKey(EffectID))
		{
			if (!ProjectileCtrData.PassiveProtectTimerMap[EffectID].ContainsKey(entityRef))
			{
				if (ProjectileCtrData.PassiveTargetQueue.ContainsKey(EffectID))
				{
					ProjectileCtrData.PassiveTargetQueue[EffectID].Add(entityRef);
					return;
				}
				EntitySharedRefList entitySharedRefList = new EntitySharedRefList();
				entitySharedRefList.Add(entityRef);
				ProjectileCtrData.PassiveTargetQueue.Add(EffectID, entitySharedRefList);
			}
		}
		else if (ProjectileCtrData.PassiveTargetQueue.ContainsKey(EffectID))
		{
			ProjectileCtrData.PassiveTargetQueue[EffectID].Add(entityRef);
		}
		else
		{
			EntitySharedRefList entitySharedRefList2 = new EntitySharedRefList();
			entitySharedRefList2.Add(entityRef);
			ProjectileCtrData.PassiveTargetQueue.Add(EffectID, entitySharedRefList2);
		}
	}

	private void OnNotifyStateSpawnProjectileObj(ref FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo, bool bNeedHandleStopReq = false, EProjectileSpawnMethod SpawnMethod = EProjectileSpawnMethod.None, int MethodUniqueID = -1)
	{
		if (BGW_GameDB.GetBulletExpandDesc(ProjectileSpawnNSInfo.ProjectileID) == null && (OwnerNetRole & 2) == 0)
		{
			return;
		}
		GSProjectileSpawnEventBase gSProjectileSpawnEventBase = new GSProjectileSpawnEventBase(GetOwner());
		gSProjectileSpawnEventBase.OnNotifyStateSpawnProjectileObj(ProjectileSpawnNSInfo);
		if (gSProjectileSpawnEventBase.IsFinished())
		{
			return;
		}
		uint num = ProjectileCtrData.RequestNewUniqueID();
		if (bNeedHandleStopReq)
		{
			switch (SpawnMethod)
			{
			case EProjectileSpawnMethod.SpawnByBuff:
			{
				if (ProjectileCtrData.SpawnReqMap_Buff.ContainsKey(MethodUniqueID))
				{
					ProjectileCtrData.SpawnReqMap_Buff[MethodUniqueID].Add(num);
					break;
				}
				List<uint> list = new List<uint>();
				list.Add(num);
				ProjectileCtrData.SpawnReqMap_Buff.Add(MethodUniqueID, list);
				break;
			}
			case EProjectileSpawnMethod.SpawnByNotifyState:
				if (ProjectileCtrData.SpawnReqMap_Notify.ContainsKey(MethodUniqueID))
				{
					return;
				}
				ProjectileCtrData.SpawnReqMap_Notify.Add(MethodUniqueID, num);
				break;
			}
		}
		ProjectileCtrData.ProjectileSpawnEvents.Set(num, gSProjectileSpawnEventBase);
	}

	private void OnNotifyStateSpawnProjectileObjEnd(EProjectileSpawnMethod SpawnMethod, int MethodUniqueID)
	{
		switch (SpawnMethod)
		{
		case EProjectileSpawnMethod.SpawnByBuff:
		{
			if (!ProjectileCtrData.SpawnReqMap_Buff.TryGetValue(MethodUniqueID, out var value2))
			{
				break;
			}
			foreach (uint item in value2)
			{
				RemoveSpawnEventByReqID(item);
			}
			ProjectileCtrData.SpawnReqMap_Buff.Remove(MethodUniqueID);
			break;
		}
		case EProjectileSpawnMethod.SpawnByNotifyState:
		{
			if (ProjectileCtrData.SpawnReqMap_Notify.TryGetValue(MethodUniqueID, out var value))
			{
				RemoveSpawnEventByReqID(value);
			}
			ProjectileCtrData.SpawnReqMap_Notify.Remove(MethodUniqueID);
			break;
		}
		}
	}

	private void RemoveSpawnEventByReqID(uint ReqID)
	{
		if (ProjectileCtrData.ProjectileSpawnEvents.Find(ReqID, out var output))
		{
			output.DoTickImpl(Owner.World.GetWorldDeltaSeconds());
			ProjectileCtrData.ProjectileSpawnEvents.Remove(ReqID);
		}
	}

	private void OnPlayerRest()
	{
		ResetActorPre();
		ResetActorAfter();
	}

	private void ResetActorPre()
	{
		ProjectileCtrData.ProjectileSpawnEvents.Clear();
		ProjectileCtrData.SpawnReqMap_Notify.Clear();
		ProjectileCtrData.SpawnReqMap_Buff.Clear();
	}

	private void ResetActorAfter()
	{
		DestroyAllCtrableBullet();
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		ResetActorPre();
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		ResetActorAfter();
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		ProjectileCtrData.ProjectileSpawnEvents.Clear();
		IBUC_ConfigInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>(Owner);
		if (readOnlyData == null)
		{
			return;
		}
		List<int> destroyProjectileWhenDead = readOnlyData.GetDestroyProjectileWhenDead();
		if (destroyProjectileWhenDead != null && destroyProjectileWhenDead.Count > 0)
		{
			if (destroyProjectileWhenDead.Contains(-1))
			{
				DestroyAllCtrableBullet();
			}
			else
			{
				DestroyProjectileByID(destroyProjectileWhenDead);
			}
		}
	}

	private void CheckProjectileNumLimit(int ProjectileID)
	{
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(ProjectileID, Owner);
		if (projectileCommDesc == null || projectileCommDesc.ProjectileNumLimit <= 0 || ProjectileCtrData.GetAllCtrableProjectilesByID(ProjectileID, out var OutProjectileList) < projectileCommDesc.ProjectileNumLimit)
		{
			return;
		}
		using List<BGUProjectileBaseActor>.Enumerator enumerator = OutProjectileList.GetEnumerator();
		if (enumerator.MoveNext())
		{
			BUS_EventCollectionCS.Get(enumerator.Current).Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.EffectDestroy);
		}
	}

	private void BulletSimpleCreator(BulletSimpleCreateType CreateType, FSimpleCreatorInfo CreatorInfo)
	{
	}

	private void PCSEW_Regist(PCSEW_Base PCSEWObj)
	{
		ProjectileCtrData.PCSEW_Registry.Add(PCSEWObj);
	}

	private void PCSEW_Destroy(PCSEW_Base PCSEWObj)
	{
		ProjectileCtrData.PCSEW_Registry.Remove(PCSEWObj);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (EndPlayReason == EEndPlayReason.Destroyed)
		{
			DestroyAllCtrableBullet();
			base.BGSEventCollection.Evt_BGS_OnEnterLevelSequenceClearBattleItem -= new Del_Void(OnEnterLevelSequence_DestroyAllCtrableBullet);
		}
	}
}
