using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_AbnormalStateHandlers : GSBattleDataDStore
{
	private IBUC_AbnormalStateHandlers ReadData;

	private BUC_AbnormalStateHandlers Data;

	public DS_IBUC_AbnormalStateHandlers(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AbnormalStateHandlers, BUC_AbnormalStateHandlers>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateHandlers>(actor);
		}
	}

	public bool IsInState(EAbnormalStateType AbnormalStateType)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsInState(AbnormalStateType);
	}

	public bool IsInFinalState(EAbnormalStateType AbnormalStateType)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsInFinalState(AbnormalStateType);
	}

	public List<EAbnormalStateType> GetInFinalStateList()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetInFinalStateList();
	}

	public Dictionary<EAbnormalStateType, int> GetInFinalStateAndAttackerAbnormalStateDispID()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetInFinalStateAndAttackerAbnormalStateDispID();
	}

	public bool bNeedShowAbnormalAccUI(EAbnormalStateType Type)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.bNeedShowAbnormalAccUI(Type);
	}

	public float GetFinalEffectRemainTime(EAbnormalStateType Type)
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetFinalEffectRemainTime(Type);
	}

	public int GetCurFinalEffectBuffID(EAbnormalStateType Type)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetCurFinalEffectBuffID(Type);
	}

	public List<EAbnormalStateType> GetAllActiveAbnormalState()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetAllActiveAbnormalState();
	}

	public void PlayHitExtFX(FTransform FXTrans)
	{
		if (ReadData != null)
		{
			ReadData.PlayHitExtFX(FXTrans);
		}
	}

	public void PlayDeadLoopFX(EAbnormalStateType AbnormalType, int CachedAttackerDispID, bool bEnd)
	{
		if (ReadData != null)
		{
			ReadData.PlayDeadLoopFX(AbnormalType, CachedAttackerDispID, bEnd);
		}
	}

	public void PlayDeadDisapearFX(EAbnormalStateType AbnormalType, int CachedAttackerDispID)
	{
		if (ReadData != null)
		{
			ReadData.PlayDeadDisapearFX(AbnormalType, CachedAttackerDispID);
		}
	}

	public void UpdateCurLoopAbnormalDisp()
	{
		if (ReadData != null)
		{
			ReadData.UpdateCurLoopAbnormalDisp();
		}
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AbnormalStateHandlers, BUC_AbnormalStateHandlers>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateHandlers>(actor);
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
