using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBGC_OnlineChallengeData : GSBattleDataDStore
{
	private IBGC_OnlineChallengeData ReadData;

	private BGC_OnlineChallengeData Data;

	public DS_IBGC_OnlineChallengeData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_OnlineChallengeData, BGC_OnlineChallengeData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_OnlineChallengeData>(actor);
		}
	}

	public bool ChallengeIsBegin(int ChallengeId, int ChallengeLevel = 0)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.ChallengeIsBegin(ChallengeId, ChallengeLevel);
	}

	public bool PlayerInChallenge(APlayerController PlayerController, out int ChallengeId)
	{
		ChallengeId = 0;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.PlayerInChallenge(PlayerController, out ChallengeId);
	}

	public bool CheckPlayerInChallengeAndRemove(APlayerController PlayerController, out int ChallengeId)
	{
		ChallengeId = 0;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.CheckPlayerInChallengeAndRemove(PlayerController, out ChallengeId);
	}

	public int GetChallengeLevel(int ChallenegeId)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetChallengeLevel(ChallenegeId);
	}

	public float GetLimitTime(int ChallenegeId)
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetLimitTime(ChallenegeId);
	}

	public int GetDropIdByGuid(int ChallengeId, int CurLevel = 0)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetDropIdByGuid(ChallengeId, CurLevel);
	}

	public override void ResetActor(AActor actor)
	{
		base.ResetActor(actor);
		if (ReadData != null && Data != null)
		{
			foreach (List<Action> value in NeedActionDic.Values)
			{
				value[1]?.Invoke();
			}
		}
		if (actor.IsNullOrDestroyed())
		{
			ReadData = null;
			Data = null;
			return;
		}
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_OnlineChallengeData, BGC_OnlineChallengeData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_OnlineChallengeData>(actor);
		if (ReadData == null || Data == null)
		{
			return;
		}
		foreach (List<Action> value2 in NeedActionDic.Values)
		{
			value2[0]?.Invoke();
		}
	}
}
