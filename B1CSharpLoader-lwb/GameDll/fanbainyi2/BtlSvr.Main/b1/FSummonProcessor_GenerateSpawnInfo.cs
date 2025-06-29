using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSummonProcessor_GenerateSpawnInfo : FSummonProcessorBase
{
	public override ESummonProcessorTag Tag => ESummonProcessorTag.GenerateSpawnInfo;

	protected override bool RunProcessor(FSummonInstance InSummonInstance)
	{
		_ = InSummonInstance.SystemContext;
		FSummonProcessorData summonProcessorData = InSummonInstance.SummonProcessorData;
		FSummonReq summonReq = InSummonInstance.SummonReq;
		AActor summoner = summonReq.Summoner;
		FSummonSpawnConfigWrap spawnConfigWrap = summonReq.SpawnConfigWrap;
		if (spawnConfigWrap.SelectPointsRandom)
		{
			for (int i = 0; i < summonProcessorData.SelectedPoints.Count; i++)
			{
				int num = MathLib.RandomIntInRange(i, summonProcessorData.SelectedPoints.Count - 1);
				if (i != num)
				{
					FTransform value = summonProcessorData.SelectedPoints[i];
					summonProcessorData.SelectedPoints[i] = summonProcessorData.SelectedPoints[num];
					summonProcessorData.SelectedPoints[num] = value;
				}
			}
		}
		int num2 = -1;
		if (summonReq.bTeleportSelf)
		{
			num2 = (summonReq.bConfuseSelf ? FMath.RandRange(0, summonProcessorData.SelectedPoints.Count - 1) : 0);
		}
		UClass tamerTemplate = spawnConfigWrap.TamerTemplate;
		List<UAnimMontage> bornMontages = spawnConfigWrap.BornMontages;
		List<int> bornSkillIDs = spawnConfigWrap.BornSkillIDs;
		UAnimMontage uAnimMontage = bornMontages.LastOrDefault();
		for (int j = 0; j < summonProcessorData.SelectedPoints.Count; j++)
		{
			FTransform bornTransform = summonProcessorData.SelectedPoints[j];
			FServantReq item = new FServantReq
			{
				SummonID = summonReq.SummonID,
				Summoner = summonReq.Summoner,
				SummonInstanceID = summonReq.SummonGuid
			};
			if (summonReq.SummonType == ESummonType.Hatch)
			{
				item.ServantType = EServantType.MonsterSpawn;
			}
			else if (summonReq.SummonType == ESummonType.NeutralAnimSpawn)
			{
				item.ServantType = EServantType.NeutralAnimSpawn;
			}
			else if (summonReq.SummonType == ESummonType.MonsterSpawn)
			{
				item.ServantType = EServantType.MonsterSpawn;
			}
			else if (summonReq.bTeleportSelf && j == num2)
			{
				item.ServantType = EServantType.Dummy;
			}
			else if (spawnConfigWrap.IsCopyEquip)
			{
				if (summonReq.SummonType == ESummonType.PhantomRush)
				{
					item.ServantType = EServantType.PhantomRush;
					item.CBI = summonReq.ContinueBehaviorInfo;
					item.AnimationSyncHostGuid = null;
				}
				else
				{
					item.ServantType = EServantType.Clone;
				}
				IBUC_EquipData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_EquipData, BUC_EquipData>(summoner);
				item.MapEquip = readOnlyData.MapEquip;
			}
			else
			{
				item.ServantType = EServantType.Normal;
			}
			string cooperativeSCGuid = null;
			if (spawnConfigWrap.SyncBattleSC)
			{
				IBUC_BattleAICooperativeData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_BattleAICooperativeData, BUC_BattleAICooperativeData>(summoner);
				if (readOnlyData2 != null && !string.IsNullOrEmpty(readOnlyData2.BattleSC_GUID))
				{
					cooperativeSCGuid = readOnlyData2.BattleSC_GUID;
				}
			}
			item.CooperativeSCGuid = cooperativeSCGuid;
			if (spawnConfigWrap.CopyAttrConfigID > 0 && BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(summoner).GetAttrSnapShot(out var OutAttrSnapShot))
			{
				item.AttrCopyConfigDesc = BGW_GameDB.GetAttrCopyDesc(spawnConfigWrap.CopyAttrConfigID, summoner).ToByteArray().ToList();
				item.AttrSnapShot = OutAttrSnapShot.FloatAttrs;
			}
			item.DelayBornTime = (float)j * spawnConfigWrap.BornDelayTime;
			item.BornMontage = null;
			item.BornSkill = -1;
			if (spawnConfigWrap.UseBornSkill)
			{
				item.BornSkill = ((j >= bornSkillIDs.Count) ? bornSkillIDs.LastOrDefault() : bornSkillIDs[j]);
			}
			else
			{
				item.BornMontage = ((j >= bornMontages.Count) ? uAnimMontage : bornMontages[j]);
			}
			item.AliveTime = spawnConfigWrap.SummonAliveTime;
			item.DelayEffectTime = spawnConfigWrap.BornEffDisplayTime;
			item.DelaySummonTime = spawnConfigWrap.BeforeBornTime;
			item.BornTransform = bornTransform;
			float num3 = MathLib.RandomFloatInRange(spawnConfigWrap.SpawnScaleRange.LowerBound.Value, spawnConfigWrap.SpawnScaleRange.UpperBound.Value);
			num3 = ((num3 <= 0f) ? 1f : num3);
			item.BornTransform.Scale3D = FVector.OneVector * num3;
			item.TamerTemplate = tamerTemplate;
			item.InitSpeed = spawnConfigWrap.InitSpeed;
			item.BornDBC = spawnConfigWrap.BornDBC;
			item.BornNiagara = spawnConfigWrap.BornNiagara;
			item.BornParticle = spawnConfigWrap.BornParticle;
			if (spawnConfigWrap.IsSummonerAsMaster)
			{
				item.MasterActor = summoner;
			}
			if (item.ServantType != EServantType.None)
			{
				item.BirthBuffIDs = new List<int>();
				item.BirthBuffIDs.AddRange(spawnConfigWrap.SpawnBirthBuff);
				item.DisappearMontagePathList = new List<string>();
				item.DisappearMontagePathList.AddRange(spawnConfigWrap.DisappearMontagePathList);
				item.DestroyDelayTime = spawnConfigWrap.DestroyDelayTime;
				item.SafeClampToLand = spawnConfigWrap.SafeClampToLand;
				item.SearchTargetType = spawnConfigWrap.SearchTargetType;
				item.CatchTarget = GetTarget(item.SearchTargetType, item.Summoner, item.MasterActor);
				InSummonInstance.ServantReqList.Add(item);
				if (InSummonInstance.ServantReqList.Count == summonReq.SummonCount)
				{
					break;
				}
			}
		}
		return true;
	}

	private AActor GetTarget(EServantSearchTargetType SearchTargetType, AActor Summoner, AActor Master)
	{
		switch (SearchTargetType)
		{
		case EServantSearchTargetType.CatchPlayer:
			if (!Summoner.IsNullOrDestroyed())
			{
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Summoner);
				if (!firstLocalPlayerController.IsNullOrDestroyed())
				{
					return firstLocalPlayerController.GetControlledPawn();
				}
			}
			break;
		case EServantSearchTargetType.SyncMaster:
			if (!Master.IsNullOrDestroyed())
			{
				return ((IBUC_TargetInfoData)BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(Master)).GetTargetInfo().LockTargetActor;
			}
			break;
		case EServantSearchTargetType.SyncSummoner:
			if (!Summoner.IsNullOrDestroyed())
			{
				return ((IBUC_TargetInfoData)BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(Summoner)).GetTargetInfo().LockTargetActor;
			}
			break;
		}
		return null;
	}

	protected override ESummonProcessorTag GetNext(FSummonInstance InSummonInstance)
	{
		return ESummonProcessorTag.Spawn;
	}
}
