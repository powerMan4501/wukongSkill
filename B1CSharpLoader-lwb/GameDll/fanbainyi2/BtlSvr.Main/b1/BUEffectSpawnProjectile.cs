using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectSpawnProjectile : BUEffectTemplate
{
	public BUEffectSpawnProjectile()
	{
		EffectType = EBuffAndSkillEffectType.SpawnProjectile;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Target);
		if (skillEffectDesc == null)
		{
			return;
		}
		string path = skillEffectDesc.EffectParamsStr[0];
		BGWDataAsset_ProjectileSpawnConfig bGWDataAsset_ProjectileSpawnConfig = BGW_PreloadAssetMgr.Get(Caster).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(path, ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_ProjectileSpawnConfig == null)
		{
			return;
		}
		AActor aActor = null;
		switch (bGWDataAsset_ProjectileSpawnConfig.SpawnerType)
		{
		case EProjectileSpawnerType.EffectCaster:
		case EProjectileSpawnerType.EffectRootCaster:
			aActor = Caster;
			break;
		case EProjectileSpawnerType.EffectTarget:
			aActor = Target;
			break;
		}
		if (aActor == null || b1.EffectTemplateUtil.ReturnIfUnitDead(aActor))
		{
			return;
		}
		ACharacter aCharacter = aActor as ACharacter;
		if (aCharacter == null)
		{
			aCharacter = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(aActor).GetMasterActor() as ACharacter;
		}
		if (aCharacter == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
		if (bUS_GSEventCollection != null)
		{
			FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
			ProjectileSpawnNSInfo.ProjectileType = EProjectileType.Bullet;
			ProjectileSpawnNSInfo.BuffIDList = bGWDataAsset_ProjectileSpawnConfig.BuffIDList.ToList();
			ProjectileSpawnNSInfo.ProjectileID = bGWDataAsset_ProjectileSpawnConfig.ProjectileID;
			ProjectileSpawnNSInfo.SpawnWave = bGWDataAsset_ProjectileSpawnConfig.ProjectileWave;
			ProjectileSpawnNSInfo.SpawnNumPerWave = bGWDataAsset_ProjectileSpawnConfig.ProjectileNumInOneWave;
			ProjectileSpawnNSInfo.InitSpawnInfo(bGWDataAsset_ProjectileSpawnConfig.SpawnBase, bGWDataAsset_ProjectileSpawnConfig.SpawnPosOffsetInfo, bGWDataAsset_ProjectileSpawnConfig.bEnableSpawnBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.SpawnBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.SpawnPosOffsetInfo_NoneTarget, Caster, aCharacter, Target, null, in EffectInstReq);
			ProjectileSpawnNSInfo.AttachToSpawnBase = bGWDataAsset_ProjectileSpawnConfig.AttachToSpawnBase;
			ProjectileSpawnNSInfo.AttachRule_Rot = bGWDataAsset_ProjectileSpawnConfig.AttachRule_Rot;
			ProjectileSpawnNSInfo.InitTargetInfo(bGWDataAsset_ProjectileSpawnConfig.TargetBase, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo, bGWDataAsset_ProjectileSpawnConfig.bEnableTargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo_NoneTarget, Caster, aCharacter, Target, null, in EffectInstReq);
			ProjectileSpawnNSInfo.BornDirBaseInfo = bGWDataAsset_ProjectileSpawnConfig.BornDirBaseInfo;
			switch (ProjectileSpawnNSInfo.BornDirBaseInfo.BornDirType)
			{
			case ProjectileBornDirType.UseEffectNormal:
				ProjectileSpawnNSInfo.BornDirBaseInfo.HitPointNormalDir = EffectInstReq.HitPointNormalDir;
				break;
			case ProjectileBornDirType.UseEffectCasterRot:
				ProjectileSpawnNSInfo.BornDirBaseInfo.ExtraRotBaseActor = Caster;
				break;
			}
			ProjectileSpawnNSInfo.BornDirOffset = bGWDataAsset_ProjectileSpawnConfig.BornDirOffset;
			ProjectileSpawnNSInfo.ProjectileFlySpd = bGWDataAsset_ProjectileSpawnConfig.BulletFlySpd;
			ProjectileSpawnNSInfo.ProjectileRotSpd = bGWDataAsset_ProjectileSpawnConfig.BulletRotSpd;
			ProjectileSpawnNSInfo.MontageID = -1;
			ProjectileSpawnNSInfo.ANSTotalTime = ((skillEffectDesc.EffectParamsFloat.Count > 0) ? skillEffectDesc.EffectParamsFloat[0] : 0f);
			ProjectileSpawnNSInfo.SpawnWaveDuration = (ProjectileSpawnNSInfo.SpawnWaveDuration = ((ProjectileSpawnNSInfo.SpawnWave > 1) ? (ProjectileSpawnNSInfo.ANSTotalTime / (float)(ProjectileSpawnNSInfo.SpawnWave - 1)) : 0f));
			ProjectileSpawnNSInfo.SpawnCounter = 0;
			ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
			ProjectileSpawnNSInfo.bEnableMultiTargetMode = bGWDataAsset_ProjectileSpawnConfig.bEnableMultiTargetMode;
			ProjectileSpawnNSInfo.MutilTargetRule = bGWDataAsset_ProjectileSpawnConfig.MutilTargetRule;
			bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo);
		}
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
		BGWDataAsset_ProjectileSpawnConfig bGWDataAsset_ProjectileSpawnConfig = new BGWDataAsset_ProjectileSpawnConfig();
		bGWDataAsset_ProjectileSpawnConfig = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(stringEffectParam, ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_ProjectileSpawnConfig == null)
		{
			return;
		}
		AActor spawnner_Buff = GetSpawnner_Buff(bGWDataAsset_ProjectileSpawnConfig.SpawnerType, BuffInst, Target);
		if (spawnner_Buff == null || b1.EffectTemplateUtil.ReturnIfUnitDead(spawnner_Buff))
		{
			return;
		}
		AActor aActor = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
		AActor effectRootCaster = EntitySharedRefFuncLib.Actor(BuffInst.RootCasterRef);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(spawnner_Buff);
		if (bUS_GSEventCollection != null)
		{
			FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
			ProjectileSpawnNSInfo.ProjectileType = EProjectileType.Bullet;
			ProjectileSpawnNSInfo.BuffIDList = bGWDataAsset_ProjectileSpawnConfig.BuffIDList.ToList();
			ProjectileSpawnNSInfo.ProjectileID = bGWDataAsset_ProjectileSpawnConfig.ProjectileID;
			ProjectileSpawnNSInfo.SpawnWave = bGWDataAsset_ProjectileSpawnConfig.ProjectileWave;
			ProjectileSpawnNSInfo.SpawnNumPerWave = bGWDataAsset_ProjectileSpawnConfig.ProjectileNumInOneWave;
			ProjectileSpawnNSInfo.InitSpawnInfo(bGWDataAsset_ProjectileSpawnConfig.SpawnBase, bGWDataAsset_ProjectileSpawnConfig.SpawnPosOffsetInfo, bGWDataAsset_ProjectileSpawnConfig.bEnableSpawnBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.SpawnBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.SpawnPosOffsetInfo_NoneTarget, aActor, spawnner_Buff, Target, effectRootCaster, in EffectInstReq);
			ProjectileSpawnNSInfo.AttachToSpawnBase = bGWDataAsset_ProjectileSpawnConfig.AttachToSpawnBase;
			ProjectileSpawnNSInfo.AttachRule_Rot = bGWDataAsset_ProjectileSpawnConfig.AttachRule_Rot;
			ProjectileSpawnNSInfo.InitTargetInfo(bGWDataAsset_ProjectileSpawnConfig.TargetBase, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo, bGWDataAsset_ProjectileSpawnConfig.bEnableTargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo_NoneTarget, aActor, spawnner_Buff, Target, effectRootCaster, in EffectInstReq);
			ProjectileSpawnNSInfo.BornDirBaseInfo = bGWDataAsset_ProjectileSpawnConfig.BornDirBaseInfo;
			switch (ProjectileSpawnNSInfo.BornDirBaseInfo.BornDirType)
			{
			case ProjectileBornDirType.UseEffectNormal:
				ProjectileSpawnNSInfo.BornDirBaseInfo.HitPointNormalDir = EffectInstReq.HitPointNormalDir;
				break;
			case ProjectileBornDirType.UseEffectCasterRot:
				ProjectileSpawnNSInfo.BornDirBaseInfo.ExtraRotBaseActor = aActor;
				break;
			}
			ProjectileSpawnNSInfo.BornDirOffset = bGWDataAsset_ProjectileSpawnConfig.BornDirOffset;
			ProjectileSpawnNSInfo.ProjectileFlySpd = bGWDataAsset_ProjectileSpawnConfig.BulletFlySpd;
			ProjectileSpawnNSInfo.ProjectileRotSpd = bGWDataAsset_ProjectileSpawnConfig.BulletRotSpd;
			ProjectileSpawnNSInfo.MontageID = -1;
			ProjectileSpawnNSInfo.ANSTotalTime = ((buffDescRuntime.GetFloatEffectParamCount(EffectIdx) > 0) ? buffDescRuntime.GetFloatEffectParam(EffectIdx, 0) : 0f);
			ProjectileSpawnNSInfo.SpawnWaveDuration = ((ProjectileSpawnNSInfo.SpawnWave > 1) ? (ProjectileSpawnNSInfo.ANSTotalTime / (float)(ProjectileSpawnNSInfo.SpawnWave - 1)) : 0f);
			ProjectileSpawnNSInfo.SpawnCounter = 0;
			ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
			ProjectileSpawnNSInfo.bEnableMultiTargetMode = bGWDataAsset_ProjectileSpawnConfig.bEnableMultiTargetMode;
			ProjectileSpawnNSInfo.MutilTargetRule = bGWDataAsset_ProjectileSpawnConfig.MutilTargetRule;
			bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo, bGWDataAsset_ProjectileSpawnConfig.bNeedHandleStopReq, EProjectileSpawnMethod.SpawnByBuff, BuffInst.BuffID);
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
		BGWDataAsset_ProjectileSpawnConfig bGWDataAsset_ProjectileSpawnConfig = new BGWDataAsset_ProjectileSpawnConfig();
		bGWDataAsset_ProjectileSpawnConfig = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(stringEffectParam, ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_ProjectileSpawnConfig == null)
		{
			return;
		}
		AActor spawnner_Buff = GetSpawnner_Buff(bGWDataAsset_ProjectileSpawnConfig.SpawnerType, BuffInst, Target);
		if (!(spawnner_Buff == null) && !b1.EffectTemplateUtil.ReturnIfUnitDead(spawnner_Buff))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(spawnner_Buff);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObjEnd.Invoke(EProjectileSpawnMethod.SpawnByBuff, BuffInst.BuffID);
			}
		}
	}

	private AActor GetSpawnner_Buff(EProjectileSpawnerType SpawnerType, BuffInstData BuffInst, AActor Target)
	{
		AActor aActor = null;
		switch (SpawnerType)
		{
		case EProjectileSpawnerType.EffectCaster:
			aActor = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
			break;
		case EProjectileSpawnerType.EffectRootCaster:
			aActor = EntitySharedRefFuncLib.Actor(BuffInst.RootCasterRef);
			break;
		case EProjectileSpawnerType.EffectTarget:
			aActor = Target;
			break;
		}
		if (aActor == null)
		{
			return null;
		}
		ACharacter aCharacter = aActor as ACharacter;
		if (aCharacter == null)
		{
			BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(aActor);
			if (readOnlyData != null)
			{
				aCharacter = readOnlyData.GetMasterActor() as ACharacter;
			}
		}
		return aCharacter;
	}
}
