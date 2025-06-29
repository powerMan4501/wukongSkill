using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FGSProjecttileObjSpawnNSInfo
{
	public EProjectileType ProjectileType;

	public List<int> BuffIDList;

	public int ProjectileID;

	public int SpawnWave;

	public int SpawnNumPerWave;

	public int CurNoInOneWave;

	public List<float> WaveDurationList = new List<float>();

	public FSpawnBulletSpeed ProjectileFlySpd;

	public FSpawnBulletSpeed ProjectileRotSpd;

	public int MontageID;

	public float SpawnWaveDuration;

	public float SpawnWaveDurationTimer;

	public int SpawnCounter;

	public int SpawnWaveCounter;

	public float ANSTotalTime;

	public bool bEnableMultiTargetMode;

	public FProjectileMulTargetRule MutilTargetRule;

	public List<AActor> MultiTargetList;

	public List<AActor> SceneItems;

	public bool AttachToSpawnBase;

	public EAttachmentRule AttachRule_Rot;

	public ProjectileBaseStruct SpawnBase;

	public ProjectileBaseStruct TargetBase;

	public ProjectilePosOffsetStruct SpawnPosOffsetInfo;

	public ProjectilePosOffsetStruct TargetPosOffsetInfo;

	public ProjectileBornDirStruct BornDirBaseInfo;

	public ProjectileBornDirOffsetStruct BornDirOffset;

	public AActor ModularActor;

	public void SetWaveDurationList(float TotalTime, int WaveNum, float Noise)
	{
		if (WaveNum > 1)
		{
			WaveDurationList = BGUFunctionLibraryCS.TimeLineMakingNoise(TotalTime, WaveNum, Noise);
		}
	}

	public void InitSpawnInfo(ProjectileBaseStruct _SpawnBase, ProjectilePosOffsetStruct _SpawnPosOffsetInfo, bool bEnableSpawnBase_NoneTarget, ProjectileBaseStruct _SpawnBase_NoneTarget, ProjectilePosOffsetStruct _SpawnPosOffsetInfo_NoneTarget, AActor EffectCaster, AActor ProjectileSpawner, AActor EffectTarget = null, AActor EffectRootCaster = null, in FEffectInstReq EffectInstReq = default(FEffectInstReq))
	{
		if (bEnableSpawnBase_NoneTarget && !BGU_ObjActorUtil.IsBaseActorExist(_SpawnBase, EffectCaster, ProjectileSpawner, EffectTarget, EffectRootCaster))
		{
			InitSpawnInfo(_SpawnBase_NoneTarget, _SpawnPosOffsetInfo_NoneTarget, EffectCaster, ProjectileSpawner, EffectTarget, EffectRootCaster, in EffectInstReq);
		}
		else
		{
			InitSpawnInfo(_SpawnBase, _SpawnPosOffsetInfo, EffectCaster, ProjectileSpawner, EffectTarget, EffectRootCaster, in EffectInstReq);
		}
	}

	private void InitSpawnInfo(ProjectileBaseStruct _SpawnBase, ProjectilePosOffsetStruct _SpawnPosOffsetInfo, AActor EffectCaster, AActor ProjectileSpawner, AActor EffectTarget = null, AActor EffectRootCaster = null, in FEffectInstReq EffectInstReq = default(FEffectInstReq))
	{
		SpawnBase = _SpawnBase;
		SpawnBase.BaseActor = new TStrongObjectPtr<AActor>();
		SpawnBase.BaseActor.Set(BGU_ObjActorUtil.GetBaseActor(EffectCaster, ProjectileSpawner, SpawnBase.BaseType, EffectTarget, EffectRootCaster));
		if (SpawnBase.BaseType == ProjectileBaseType.UseEffectPosition)
		{
			SpawnBase.EffectInstReq = EffectInstReq;
		}
		if (SpawnBase.BaseType == ProjectileBaseType.CurTarget_ProjectileSpawner && SpawnBase.SocketName == FName.None)
		{
			IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(ProjectileSpawner);
			if (readOnlyData != null)
			{
				UnitLockTargetInfo targetInfo = readOnlyData.GetTargetInfo();
				switch (targetInfo.LockTargetType)
				{
				case ELockTargetType.SceneComp:
					SpawnBase.SocketName = new FName(targetInfo.LockTargetSceneCompName);
					SpawnBase.UseSocket = false;
					break;
				case ELockTargetType.SkeletonSocket:
					SpawnBase.SocketName = new FName(targetInfo.LockTargetSkeletonSocketName);
					SpawnBase.UseSocket = true;
					break;
				}
			}
		}
		SpawnPosOffsetInfo = _SpawnPosOffsetInfo;
		SpawnPosOffsetInfo.BaseActor = new TStrongObjectPtr<AActor>();
		SpawnPosOffsetInfo.BaseActor.Set(BGU_ObjActorUtil.GetBaseActor(EffectCaster, ProjectileSpawner, SpawnPosOffsetInfo.BaseType, EffectTarget, EffectRootCaster));
	}

	public void InitTargetInfo(ProjectileBaseStruct _TargetBase, ProjectilePosOffsetStruct _TargetPosOffsetInfo, bool bEnableTargetBase_NoneTarget, ProjectileBaseStruct _TargetBase_NoneTarget, ProjectilePosOffsetStruct _TargetPosOffsetInfo_NoneTarget, AActor EffectCaster, AActor ProjectileSpawner, AActor EffectTarget = null, AActor EffectRootCaster = null, in FEffectInstReq EffectInstReq = default(FEffectInstReq))
	{
		if (bEnableTargetBase_NoneTarget && !BGU_ObjActorUtil.IsBaseActorExist(_TargetBase, EffectCaster, ProjectileSpawner, EffectTarget, EffectRootCaster))
		{
			InitTargetInfo(_TargetBase_NoneTarget, _TargetPosOffsetInfo_NoneTarget, EffectCaster, ProjectileSpawner, EffectTarget, EffectRootCaster, in EffectInstReq);
		}
		else
		{
			InitTargetInfo(_TargetBase, _TargetPosOffsetInfo, EffectCaster, ProjectileSpawner, EffectTarget, EffectRootCaster, in EffectInstReq);
		}
	}

	private void InitTargetInfo(ProjectileBaseStruct _TargetBase, ProjectilePosOffsetStruct _TargetPosOffsetInfo, AActor EffectCaster, AActor ProjectileSpawner, AActor EffectTarget = null, AActor EffectRootCaster = null, in FEffectInstReq EffectInstReq = default(FEffectInstReq))
	{
		TargetBase = _TargetBase;
		TargetBase.BaseActor = new TStrongObjectPtr<AActor>();
		TargetBase.BaseActor.Set(BGU_ObjActorUtil.GetBaseActor(EffectCaster, ProjectileSpawner, TargetBase.BaseType, EffectTarget, EffectRootCaster));
		if (TargetBase.BaseType == ProjectileBaseType.UseEffectPosition)
		{
			TargetBase.EffectInstReq = EffectInstReq;
		}
		if (TargetBase.BaseType == ProjectileBaseType.CurTarget_ProjectileSpawner && TargetBase.SocketName == FName.None)
		{
			IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(ProjectileSpawner);
			if (readOnlyData != null)
			{
				UnitLockTargetInfo targetInfo = readOnlyData.GetTargetInfo();
				switch (targetInfo.LockTargetType)
				{
				case ELockTargetType.SceneComp:
					TargetBase.SocketName = new FName(targetInfo.LockTargetSceneCompName);
					TargetBase.UseSocket = false;
					break;
				case ELockTargetType.SkeletonSocket:
					TargetBase.SocketName = new FName(targetInfo.LockTargetSkeletonSocketName);
					TargetBase.UseSocket = true;
					break;
				}
			}
		}
		TargetPosOffsetInfo = _TargetPosOffsetInfo;
		TargetPosOffsetInfo.BaseActor = new TStrongObjectPtr<AActor>();
		TargetPosOffsetInfo.BaseActor.Set(BGU_ObjActorUtil.GetBaseActor(EffectCaster, ProjectileSpawner, TargetPosOffsetInfo.BaseType, EffectTarget, EffectRootCaster));
	}
}
