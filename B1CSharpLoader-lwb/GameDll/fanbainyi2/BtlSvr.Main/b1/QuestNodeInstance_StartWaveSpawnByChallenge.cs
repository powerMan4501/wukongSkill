using System.Collections.Generic;
using System.IO;
using b1.BGW;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_StartWaveSpawnByChallenge : QuestNodeInstance
{
	private List<string> ObservedUnitGuids { get; set; } = new List<string>();

	private int ChallengeId { get; set; }

	private string CasterGuid { get; set; }

	private string AnimMontagePathCacheEasy { get; set; }

	[UProperty]
	private UAnimMontage AnimMontageEasy { get; set; }

	private string AnimMontagePathCacheNormal { get; set; }

	[UProperty]
	private UAnimMontage AnimMontageNormal { get; set; }

	private string AnimMontagePathCacheHard { get; set; }

	[UProperty]
	private UAnimMontage AnimMontageHard { get; set; }

	private bool NeedPlayMontage { get; set; }

	private QuestCustom_StartWaveSpawnByChallenge CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_StartWaveSpawnByChallenge();
		CustomData.MergeFrom(base.Node.NodeData);
		foreach (string item in CustomData.ObserveActorGuid)
		{
			ObservedUnitGuids.Add(item);
		}
		ChallengeId = CustomData.ChallengeId;
		NeedPlayMontage = CustomData.NeedPlayMontage;
		CasterGuid = CustomData.PlayMontageActorGuid;
	}

	public void InitMontageData()
	{
		string amPathEasy = CustomData.AmPathEasy;
		if (!string.IsNullOrEmpty(amPathEasy))
		{
			AnimMontagePathCacheEasy = amPathEasy + "." + Path.GetFileNameWithoutExtension(amPathEasy);
			UAnimMontage uAnimMontage = base.PreloadAssetMgr.TryGetCachedResourceObj<UAnimMontage>(AnimMontagePathCacheEasy, ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				AnimMontageEasy = uAnimMontage;
			}
		}
		string amPathNormal = CustomData.AmPathNormal;
		if (!string.IsNullOrEmpty(amPathNormal))
		{
			AnimMontagePathCacheNormal = amPathNormal + "." + Path.GetFileNameWithoutExtension(amPathNormal);
			UAnimMontage uAnimMontage2 = base.PreloadAssetMgr.TryGetCachedResourceObj<UAnimMontage>(AnimMontagePathCacheNormal, ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage2 != null)
			{
				AnimMontageNormal = uAnimMontage2;
			}
		}
		string amPathHard = CustomData.AmPathHard;
		if (!string.IsNullOrEmpty(amPathHard))
		{
			AnimMontagePathCacheHard = amPathHard + "." + Path.GetFileNameWithoutExtension(amPathHard);
			UAnimMontage uAnimMontage3 = base.PreloadAssetMgr.TryGetCachedResourceObj<UAnimMontage>(AnimMontagePathCacheHard, ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage3 != null)
			{
				AnimMontageHard = uAnimMontage3;
			}
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AGameStateBase gameState = UGameplayStatics.GetGameState(base.Owner);
		IBGC_OnlineChallengeData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBGC_OnlineChallengeData, BGC_OnlineChallengeData>(gameState);
		int gamePlayerNum = BGU_DataUtil.GetReadOnlyData<IBGC_LevelBattleData, BGC_LevelBattleData>(gameState).GetGamePlayerNum();
		int challengeLevel = readOnlyData.GetChallengeLevel(ChallengeId);
		int num = 4;
		int num2 = (challengeLevel - 1) * num + gamePlayerNum - 1;
		if (ObservedUnitGuids.Count > num2)
		{
			string unitGuid = ObservedUnitGuids[num2];
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, unitGuid);
			if (actorByGuid != null)
			{
				BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(base.Owner);
				if (bGS_GSEventCollection != null)
				{
					bGS_GSEventCollection.Evt_BGS_OnlineChallengeSpawn.Invoke(ChallengeId, actorByGuid);
				}
				BUS_EventCollectionCS.Get(actorByGuid).Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.SceneObjCommonEventTag.JumpToState2);
			}
		}
		if (NeedPlayMontage)
		{
			PlayMontage(challengeLevel);
		}
		TriggerFirstOutput(bFinish: true);
	}

	private void PlayMontage(int ChallengeLevel)
	{
		UAnimMontage montageByChallengeLevel = GetMontageByChallengeLevel(ChallengeLevel);
		if (montageByChallengeLevel == null)
		{
			InitMontageData();
			montageByChallengeLevel = GetMontageByChallengeLevel(ChallengeLevel);
		}
		if (montageByChallengeLevel != null)
		{
			BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(base.Owner, CasterGuid) as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				bGUCharacterCS.StopAnimMontage(null);
				BGUFuncLibAnim.BGUActorTryPlayMontage(bGUCharacterCS, montageByChallengeLevel, FName.None);
			}
		}
	}

	private UAnimMontage GetMontageByChallengeLevel(int ChallengeLevel)
	{
		UAnimMontage result = null;
		switch (ChallengeLevel)
		{
		case 1:
			result = AnimMontageEasy;
			break;
		case 2:
			result = AnimMontageNormal;
			break;
		case 3:
			result = AnimMontageHard;
			break;
		}
		return result;
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
