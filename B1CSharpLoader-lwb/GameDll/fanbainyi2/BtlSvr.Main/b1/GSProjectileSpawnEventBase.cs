using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GSProjectileSpawnEventBase
{
	private AActor Owner;

	private FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo;

	private List<FGSProjectileSpawnMng> ProjectileDelaySpawnMngList;

	private List<FVector> PointSetCacheMap_RangeSpawnOffset;

	private List<FVector> PointSetCacheMap_RangeTargetOffset;

	private bool SpawnFailed;

	private bool SpawnFinished;

	private bool SpawnBreak;

	public GSProjectileSpawnEventBase(AActor _Owner)
	{
		SpawnFinished = false;
		SpawnBreak = false;
		Owner = _Owner;
		ProjectileDelaySpawnMngList = new List<FGSProjectileSpawnMng>();
		PointSetCacheMap_RangeSpawnOffset = new List<FVector>();
		PointSetCacheMap_RangeTargetOffset = new List<FVector>();
	}

	public void DoTickImpl(float DeltaTime)
	{
		TickForSpawnBullet(DeltaTime);
		BulletDelaySpawnMngTick(DeltaTime);
	}

	private void OnSpawnFailed()
	{
		SpawnFailed = true;
	}

	private void OnSpawnFinished()
	{
		SpawnFinished = true;
	}

	public bool IsFinished()
	{
		if (SpawnBreak || SpawnFinished || SpawnFailed)
		{
			return ProjectileDelaySpawnMngList.Count < 1;
		}
		return false;
	}

	public void OnSpawnBreak()
	{
		SpawnBreak = true;
	}

	public void OnNotifyStateSpawnProjectileObj(FGSProjecttileObjSpawnNSInfo _ProjectileSpawnNSInfo)
	{
		if (BGW_GameDB.GetProjectileCommDesc(_ProjectileSpawnNSInfo.ProjectileID, Owner) == null)
		{
			OnSpawnFailed();
			return;
		}
		_ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
		ProjectileSpawnNSInfo = _ProjectileSpawnNSInfo;
		if (ProjectileSpawnNSInfo.SpawnBase.DontUpdatePosPerWave)
		{
			BGUFuncLibProjectile.PrepareSpawnPositions(Owner, ref ProjectileSpawnNSInfo.SpawnBase);
		}
		if (ProjectileSpawnNSInfo.TargetBase.DontUpdatePosPerWave)
		{
			BGUFuncLibProjectile.PrepareSpawnPositions(Owner, ref ProjectileSpawnNSInfo.TargetBase);
		}
		SpawnWaveProjectileObj(ref ProjectileSpawnNSInfo);
	}

	private void SpawnWaveProjectileObj(ref FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo)
	{
		if (ProjectileSpawnNSInfo.SpawnWaveCounter > ProjectileSpawnNSInfo.SpawnWave)
		{
			return;
		}
		if (ProjectileSpawnNSInfo.WaveDurationList.Count > 0)
		{
			ProjectileSpawnNSInfo.SpawnWaveDuration = ProjectileSpawnNSInfo.WaveDurationList[0];
			ProjectileSpawnNSInfo.WaveDurationList.RemoveAt(0);
		}
		int num = -1;
		List<AActor> TargetList = new List<AActor>();
		if (ProjectileSpawnNSInfo.bEnableMultiTargetMode)
		{
			b1.BGUProjectileFuncLib.SelectMultiTarget(Owner, out TargetList, ProjectileSpawnNSInfo.MutilTargetRule);
			num = TargetList.Count;
		}
		if (!ProjectileSpawnNSInfo.SpawnBase.DontUpdatePosPerWave)
		{
			BGUFuncLibProjectile.PrepareSpawnPositions(Owner, ref ProjectileSpawnNSInfo.SpawnBase);
		}
		if (!ProjectileSpawnNSInfo.TargetBase.DontUpdatePosPerWave)
		{
			BGUFuncLibProjectile.PrepareSpawnPositions(Owner, ref ProjectileSpawnNSInfo.TargetBase);
		}
		for (int i = 0; i < ProjectileSpawnNSInfo.SpawnNumPerWave; i++)
		{
			if (num != -1)
			{
				if (i >= num)
				{
					break;
				}
				if (ProjectileSpawnNSInfo.SpawnBase.BaseType == ProjectileBaseType.CurTarget_ProjectileSpawner)
				{
					ProjectileSpawnNSInfo.SpawnBase.BaseActor.Set(TargetList[i]);
				}
				if (ProjectileSpawnNSInfo.TargetBase.BaseType == ProjectileBaseType.CurTarget_ProjectileSpawner)
				{
					ProjectileSpawnNSInfo.TargetBase.BaseActor.Set(TargetList[i]);
				}
			}
			ProjectileSpawnNSInfo.CurNoInOneWave = i;
			WrapOneProjectileSpawnEvent();
		}
	}

	private void WrapOneProjectileSpawnEvent()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			OnSpawnFailed();
			return;
		}
		ProjectileSpawnNSInfo.SpawnCounter++;
		int montageID = ProjectileSpawnNSInfo.MontageID;
		int skillID = 0;
		BUC_AnimNotifyAndStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AnimNotifyAndStateData>(bGUCharacterCS);
		if (unPersistentReadOnlyData != null)
		{
			skillID = unPersistentReadOnlyData.FindBindingSkillID(montageID);
		}
		USceneComponent SocketOwnerComp;
		FGSTargetOffsetInfo OffsetInfoCache;
		FVector basePos = BGUFuncLibProjectile.GetBasePos(ProjectileSpawnNSInfo.TargetBase, ProjectileSpawnNSInfo.TargetPosOffsetInfo, out SocketOwnerComp, ref PointSetCacheMap_RangeTargetOffset, out OffsetInfoCache, ProjectileSpawnNSInfo.CurNoInOneWave, ProjectileSpawnNSInfo.SpawnWaveCounter, ProjectileSpawnNSInfo.SpawnNumPerWave);
		FGSProjectileSpawnInfo fGSProjectileSpawnInfo = new FGSProjectileSpawnInfo();
		fGSProjectileSpawnInfo.ProjectileType = ProjectileSpawnNSInfo.ProjectileType;
		fGSProjectileSpawnInfo.SkillID = skillID;
		fGSProjectileSpawnInfo.BuffIDList = ProjectileSpawnNSInfo.BuffIDList;
		fGSProjectileSpawnInfo.ProjectileID = ProjectileSpawnNSInfo.ProjectileID;
		fGSProjectileSpawnInfo.TotalNumInAWave = ProjectileSpawnNSInfo.SpawnNumPerWave;
		fGSProjectileSpawnInfo.SelfIndexInAWave = ProjectileSpawnNSInfo.SpawnCounter;
		fGSProjectileSpawnInfo.UseSocket_Spawn = ProjectileSpawnNSInfo.SpawnBase.UseSocket;
		fGSProjectileSpawnInfo.SpawnPointName = ProjectileSpawnNSInfo.SpawnBase.SocketName;
		fGSProjectileSpawnInfo.ProjectileFlySpd = ProjectileSpawnNSInfo.ProjectileFlySpd;
		fGSProjectileSpawnInfo.ProjectileRotSpd = ProjectileSpawnNSInfo.ProjectileRotSpd;
		fGSProjectileSpawnInfo.TargetOffsetInfo = OffsetInfoCache;
		fGSProjectileSpawnInfo.CurTarget = ProjectileSpawnNSInfo.TargetBase.BaseActor.Get();
		fGSProjectileSpawnInfo.UseSocket_Target = ProjectileSpawnNSInfo.TargetBase.UseSocket;
		fGSProjectileSpawnInfo.TargetSocketNameFromNotify = ProjectileSpawnNSInfo.TargetBase.SocketName;
		fGSProjectileSpawnInfo.TargetPos = basePos;
		fGSProjectileSpawnInfo.ModularActor = ProjectileSpawnNSInfo.ModularActor;
		if (ProjectileSpawnNSInfo.SceneItems != null && ProjectileSpawnNSInfo.SceneItems.Count >= ProjectileSpawnNSInfo.SpawnCounter)
		{
			fGSProjectileSpawnInfo.InnerSceneItem = ProjectileSpawnNSInfo.SceneItems[ProjectileSpawnNSInfo.SpawnCounter - 1];
		}
		fGSProjectileSpawnInfo.SpawnPosition = BGUFuncLibProjectile.GetBasePos(ProjectileSpawnNSInfo.SpawnBase, ProjectileSpawnNSInfo.SpawnPosOffsetInfo, out var SocketOwnerComp2, ref PointSetCacheMap_RangeSpawnOffset, out var _, ProjectileSpawnNSInfo.CurNoInOneWave, ProjectileSpawnNSInfo.SpawnWaveCounter, ProjectileSpawnNSInfo.SpawnNumPerWave);
		fGSProjectileSpawnInfo.BornDir = GetProjectileBornDir(in ProjectileSpawnNSInfo, fGSProjectileSpawnInfo.SpawnPosition, basePos);
		fGSProjectileSpawnInfo.AttachToSpawnBase = ProjectileSpawnNSInfo.AttachToSpawnBase;
		if (fGSProjectileSpawnInfo.AttachToSpawnBase)
		{
			fGSProjectileSpawnInfo.AttachToSpawnBase_SpawnBaseActor = ProjectileSpawnNSInfo.SpawnBase.BaseActor.Get();
			fGSProjectileSpawnInfo.AttachRule_Rot = ProjectileSpawnNSInfo.AttachRule_Rot;
			fGSProjectileSpawnInfo.AttachToSpawnBase_SocketName = ProjectileSpawnNSInfo.SpawnBase.SocketName;
			fGSProjectileSpawnInfo.AttachToSpawnBase_SocketOwnerComp = SocketOwnerComp2;
		}
		CastProjectileSkill(fGSProjectileSpawnInfo);
	}

	private FRotator GetProjectileBornDir(in FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo, FVector BornPos, FVector CurTargetPos)
	{
		FRotator fRotator = default(FRotator);
		switch (ProjectileSpawnNSInfo.BornDirBaseInfo.BornDirType)
		{
		case ProjectileBornDirType.BaseActorRot:
		{
			AActor aActor = ProjectileSpawnNSInfo.SpawnBase.BaseActor.Get();
			if (!aActor.IsNullOrDestroyed())
			{
				fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor);
			}
			break;
		}
		case ProjectileBornDirType.LookAtTargetPos:
			fRotator = UMathLibrary.FindLookAtRotation(BornPos, CurTargetPos);
			break;
		case ProjectileBornDirType.UseEffectNormal:
			fRotator = ProjectileSpawnNSInfo.BornDirBaseInfo.HitPointNormalDir;
			break;
		case ProjectileBornDirType.UseSlotDir:
		{
			fRotator = BGU_ObjActorUtil.GetSocketOrCompTransform(ProjectileSpawnNSInfo.SpawnBase.UseSocket, ProjectileSpawnNSInfo.SpawnBase.BaseActor.Get(), ProjectileSpawnNSInfo.SpawnBase.SocketName, out var _).Rotator();
			break;
		}
		case ProjectileBornDirType.UsePointSetCached:
		{
			List<FRotator> list = BGUFunctionLibraryCS.BGUGetCachedPointSet_Rot(Owner, ProjectileSpawnNSInfo.BornDirBaseInfo.PointSetCachedReqID);
			fRotator = ((list == null || list.Count <= 0) ? FRotator.ZeroRotator : ((list.Count <= ProjectileSpawnNSInfo.CurNoInOneWave) ? list[list.Count - 1] : list[ProjectileSpawnNSInfo.CurNoInOneWave]));
			break;
		}
		case ProjectileBornDirType.UseEffectCasterRot:
		{
			AActor extraRotBaseActor = ProjectileSpawnNSInfo.BornDirBaseInfo.ExtraRotBaseActor;
			if (!extraRotBaseActor.IsNullOrDestroyed())
			{
				fRotator = extraRotBaseActor.GetActorRotation();
			}
			break;
		}
		case ProjectileBornDirType.LineFromSpawner:
		{
			FVector start = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			fRotator = MathLib.FindLookAtRotation(start, BornPos);
			break;
		}
		}
		if (ProjectileSpawnNSInfo.BornDirBaseInfo.JustUseYawInfo)
		{
			fRotator.Roll = 0f;
			fRotator.Pitch = 0f;
		}
		ProjectileBornDirOffsetStruct bornDirOffset = ProjectileSpawnNSInfo.BornDirOffset;
		if (bornDirOffset.UseExtraAimPoint)
		{
			USceneComponent SocketOwnerComp2;
			FRotator fRotator2 = (BGU_ObjActorUtil.GetSocketOrCompTransform(bornDirOffset.ExtraAimPointUseSocket, ProjectileSpawnNSInfo.SpawnBase.BaseActor.Get(), bornDirOffset.ExtraAimPointName, out SocketOwnerComp2).GetLocation() - BornPos).Rotation();
			FRotator fRotator3 = fRotator - fRotator2;
			if (FMath.Abs(fRotator3.Roll) > bornDirOffset.MaxDiffAngle)
			{
				fRotator.Roll = fRotator2.Roll + ((fRotator3.Roll > 0f) ? bornDirOffset.MaxDiffAngle : (0f - bornDirOffset.MaxDiffAngle));
			}
			if (FMath.Abs(fRotator3.Pitch) > bornDirOffset.MaxDiffAngle)
			{
				fRotator.Pitch = fRotator2.Pitch + ((fRotator3.Pitch > 0f) ? bornDirOffset.MaxDiffAngle : (0f - bornDirOffset.MaxDiffAngle));
			}
			if (FMath.Abs(fRotator3.Yaw) > bornDirOffset.MaxDiffAngle)
			{
				fRotator.Yaw = fRotator2.Yaw + ((fRotator3.Yaw > 0f) ? bornDirOffset.MaxDiffAngle : (0f - bornDirOffset.MaxDiffAngle));
			}
		}
		int spawnCounter = ProjectileSpawnNSInfo.SpawnCounter;
		int spawnNumPerWave = ProjectileSpawnNSInfo.SpawnNumPerWave;
		if (bornDirOffset.AimConstraintAxis.X == 0f)
		{
			float num = CalcRotOffsetValue(spawnCounter % ProjectileSpawnNSInfo.SpawnNumPerWave + 1, spawnNumPerWave, bornDirOffset.BornDirOffsetX.IsEquidistance, bornDirOffset.BornDirOffsetX.LeftValue, bornDirOffset.BornDirOffsetX.RightValue);
			fRotator.Roll += num;
		}
		if (bornDirOffset.AimConstraintAxis.Y == 0f)
		{
			float num2 = CalcRotOffsetValue(spawnCounter % ProjectileSpawnNSInfo.SpawnNumPerWave + 1, spawnNumPerWave, bornDirOffset.BornDirOffsetY.IsEquidistance, bornDirOffset.BornDirOffsetY.LeftValue, bornDirOffset.BornDirOffsetY.RightValue);
			fRotator.Pitch += num2;
		}
		if (bornDirOffset.AimConstraintAxis.Z == 0f)
		{
			float num3 = CalcRotOffsetValue(spawnCounter % ProjectileSpawnNSInfo.SpawnNumPerWave + 1, spawnNumPerWave, bornDirOffset.BornDirOffsetZ.IsEquidistance, bornDirOffset.BornDirOffsetZ.LeftValue, bornDirOffset.BornDirOffsetZ.RightValue);
			fRotator.Yaw += num3;
		}
		return fRotator;
	}

	private float CalcRotOffsetValue(int SpawnBulletCounter, int BulletNumInOneWave, bool IsEquidDis, float LeftValue, float RightValue)
	{
		if (!IsEquidDis)
		{
			return UB1Util.GetRandomNumberFloat(LeftValue, RightValue);
		}
		int num = SpawnBulletCounter - 1;
		int num2 = BulletNumInOneWave - 1;
		if (BulletNumInOneWave == 1)
		{
			num = 0;
			num2 = 2;
		}
		return LeftValue + (float)num * (RightValue - LeftValue) / (float)num2;
	}

	private void CastProjectileSkill(FGSProjectileSpawnInfo ProjectileSpawnInfo)
	{
		FUStProjectileDispDesc projectileDispDesc = BGW_GameDB.GetProjectileDispDesc(ProjectileSpawnInfo.ProjectileID);
		if (projectileDispDesc == null)
		{
			OnSpawnFailed();
		}
		else if (projectileDispDesc.SpawnPStoSpawnInterval == 0f)
		{
			SpawnPS(ref ProjectileSpawnInfo);
			SpawnAProjectileObj(ProjectileSpawnInfo);
		}
		else if (projectileDispDesc.SpawnPStoSpawnInterval > 0f)
		{
			SpawnPS(ref ProjectileSpawnInfo);
			FGSProjectileSpawnMng item = new FGSProjectileSpawnMng
			{
				Timer = projectileDispDesc.SpawnPStoSpawnInterval,
				ProjectileSpawnInfo = ProjectileSpawnInfo
			};
			ProjectileDelaySpawnMngList.Add(item);
		}
	}

	private void SpawnPS(ref FGSProjectileSpawnInfo SpawnBulletInfo)
	{
		FUStProjectileDispDesc projectileDispDesc = BGW_GameDB.GetProjectileDispDesc(SpawnBulletInfo.ProjectileID);
		if (projectileDispDesc.ProjectileSpawnPSPath.Length > 0)
		{
			FVector spawnPosition = SpawnBulletInfo.SpawnPosition;
			FRotator bornDir = SpawnBulletInfo.BornDir;
			if (projectileDispDesc.ProjectileFXUseDBC == EGSYesNo.No)
			{
				UParticleSystem emitterTemplate = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UObject>(projectileDispDesc.ProjectileSpawnPSPath, ELoadResourceType.AsyncLoadAndCache) as UParticleSystem;
				UGameplayStatics.SpawnEmitterAtLocation(Owner, emitterTemplate, spawnPosition, bornDir, FVector.OneVector, bAutoDestroy: true, EPSCPoolMethod.AutoRelease, bAutoActivateSystem: true);
				return;
			}
			FTransform spawnTransform = default(FTransform);
			spawnTransform.SetTranslation(spawnPosition);
			spawnTransform.SetRotation(bornDir.Quaternion());
			spawnTransform.SetScale3D(FVector.OneVector);
			BUS_EventCollectionCS.Get(Owner).Evt_RequestSpawnFXByDispConfig.Invoke(projectileDispDesc.ProjectileSpawnPSPath, out var RequestID, null, NeedSetSpawnTransform: true, spawnTransform);
			BUS_EventCollectionCS.Get(Owner).Evt_NotifyBulletMarkDBCReqID.Invoke(RequestID);
		}
	}

	private void SpawnAProjectileObj(FGSProjectileSpawnInfo ProjectileSpawnInfo)
	{
		ProjectileSpawnInfo.Spawner = Owner;
		BGS_EventCollectionCS.Get(Owner).Evt_RequestSpawnAProjectile.Invoke(ProjectileSpawnInfo);
	}

	private void TickForSpawnBullet(float DeltaTime)
	{
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.Immobilizing) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.Frozen) || ProjectileSpawnNSInfo == null || SpawnBreak || SpawnFinished || SpawnFailed)
		{
			return;
		}
		if (ProjectileSpawnNSInfo.SpawnWave == 0 || ProjectileSpawnNSInfo.SpawnNumPerWave == 0 || ProjectileSpawnNSInfo.SpawnWaveCounter >= ProjectileSpawnNSInfo.SpawnWave - 1 || ProjectileSpawnNSInfo.SpawnWaveDuration <= 0f)
		{
			if (ProjectileDelaySpawnMngList.Count < 1)
			{
				OnSpawnFinished();
			}
			return;
		}
		ProjectileSpawnNSInfo.SpawnWaveDurationTimer += DeltaTime;
		while (ProjectileSpawnNSInfo.SpawnWaveDurationTimer >= ProjectileSpawnNSInfo.SpawnWaveDuration)
		{
			if (ProjectileSpawnNSInfo.SpawnWaveCounter >= ProjectileSpawnNSInfo.SpawnWave - 1)
			{
				OnSpawnFinished();
				break;
			}
			ProjectileSpawnNSInfo.SpawnWaveDurationTimer -= ProjectileSpawnNSInfo.SpawnWaveDuration;
			ProjectileSpawnNSInfo.SpawnWaveCounter++;
			SpawnWaveProjectileObj(ref ProjectileSpawnNSInfo);
		}
	}

	private void BulletDelaySpawnMngTick(float DeltaTime)
	{
		if (ProjectileDelaySpawnMngList == null || ProjectileDelaySpawnMngList.Count < 1)
		{
			return;
		}
		for (int i = 0; i < ProjectileDelaySpawnMngList.Count; i++)
		{
			if (ProjectileDelaySpawnMngList[i].Timer > 0f)
			{
				FGSProjectileSpawnMng value = ProjectileDelaySpawnMngList[i];
				value.Timer -= DeltaTime;
				ProjectileDelaySpawnMngList[i] = value;
			}
			else
			{
				SpawnAProjectileObj(ProjectileDelaySpawnMngList[i].ProjectileSpawnInfo);
				ProjectileDelaySpawnMngList.RemoveAt(i);
				i--;
			}
		}
	}
}
