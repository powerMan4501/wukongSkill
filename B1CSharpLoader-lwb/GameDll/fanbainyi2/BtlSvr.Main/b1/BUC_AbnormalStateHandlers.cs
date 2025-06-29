using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AbnormalStateHandlers : IBUC_AbnormalStateHandlers
{
	public BGU_AbnormalStateHanddler_Freeze AbnormalHanddler_Freeze = new BGU_AbnormalStateHanddler_Freeze();

	public BGU_AbnormalStateHanddler_Burn AbnormalHanddler_Burn = new BGU_AbnormalStateHanddler_Burn();

	public BGU_AbnormalStateHanddler_Poison AbnormalHanddler_Poison = new BGU_AbnormalStateHanddler_Poison();

	public BGU_AbnormalStateHanddler_Thunder AbnormalHanddler_Thunder = new BGU_AbnormalStateHanddler_Thunder();

	public BGU_AbnormalStateHanddler_Yin AbnormalHanddler_Yin = new BGU_AbnormalStateHanddler_Yin();

	public BGU_AbnormalStateHanddler_Yang AbnormalHanddler_Yang = new BGU_AbnormalStateHanddler_Yang();

	public bool IsInState(EAbnormalStateType AbnormalStateType)
	{
		return GetAbnormalHanddler(AbnormalStateType).IsActive();
	}

	public bool IsInFinalState(EAbnormalStateType AbnormalStateType)
	{
		return GetAbnormalHanddler(AbnormalStateType).IsInFinalEffect();
	}

	public List<EAbnormalStateType> GetInFinalStateList()
	{
		List<EAbnormalStateType> list = new List<EAbnormalStateType>();
		if (AbnormalHanddler_Freeze.IsInFinalEffect())
		{
			list.Add(EAbnormalStateType.Abnormal_Freeze);
		}
		if (AbnormalHanddler_Burn.IsInFinalEffect())
		{
			list.Add(EAbnormalStateType.Abnormal_Burn);
		}
		if (AbnormalHanddler_Poison.IsInFinalEffect())
		{
			list.Add(EAbnormalStateType.Abnormal_Poison);
		}
		if (AbnormalHanddler_Thunder.IsInFinalEffect())
		{
			list.Add(EAbnormalStateType.Abnormal_Thunder);
		}
		if (AbnormalHanddler_Yin.IsInFinalEffect())
		{
			list.Add(EAbnormalStateType.Abnormal_Yin);
		}
		if (AbnormalHanddler_Yang.IsInFinalEffect())
		{
			list.Add(EAbnormalStateType.Abnormal_Yang);
		}
		return list;
	}

	public Dictionary<EAbnormalStateType, int> GetInFinalStateAndAttackerAbnormalStateDispID()
	{
		Dictionary<EAbnormalStateType, int> dictionary = new Dictionary<EAbnormalStateType, int>();
		foreach (EAbnormalStateType inFinalState in GetInFinalStateList())
		{
			dictionary.Add(inFinalState, GetAbnormalHanddler(inFinalState).GetFinalStateCaster_AttackerAbnormalStateDispID());
		}
		return dictionary;
	}

	public List<EAbnormalStateType> GetAllActiveAbnormalState()
	{
		List<EAbnormalStateType> list = new List<EAbnormalStateType>();
		int num = 7;
		for (int i = 1; i < num; i++)
		{
			EAbnormalStateType eAbnormalStateType = (EAbnormalStateType)i;
			if (GetAbnormalHanddler(eAbnormalStateType).IsActive())
			{
				list.Add(eAbnormalStateType);
			}
		}
		return list;
	}

	public bool bNeedShowAbnormalAccUI(EAbnormalStateType Type)
	{
		return GetAbnormalHanddler(Type).NeedShowUI();
	}

	public float GetFinalEffectRemainTime(EAbnormalStateType Type)
	{
		return GetAbnormalHanddler(Type).GetFinalEffectRemainTime();
	}

	public float GetFinalEffectTotalTime(EAbnormalStateType Type)
	{
		return GetAbnormalHanddler(Type).GetFinalEffectTotalTime();
	}

	public int GetCurFinalEffectBuffID(EAbnormalStateType Type)
	{
		return GetAbnormalHanddler(Type).GetFinalEffectBuffID();
	}

	public BGU_AbnormalStateHandlerBase GetAbnormalHanddler(EAbnormalStateType AbnormalType)
	{
		return AbnormalType switch
		{
			EAbnormalStateType.Abnormal_Freeze => AbnormalHanddler_Freeze, 
			EAbnormalStateType.Abnormal_Burn => AbnormalHanddler_Burn, 
			EAbnormalStateType.Abnormal_Thunder => AbnormalHanddler_Thunder, 
			EAbnormalStateType.Abnormal_Poison => AbnormalHanddler_Poison, 
			EAbnormalStateType.Abnormal_Yin => AbnormalHanddler_Yin, 
			EAbnormalStateType.Abnormal_Yang => AbnormalHanddler_Yang, 
			_ => null, 
		};
	}

	public void PlayHitExtFX(FTransform FXTrans)
	{
		foreach (EAbnormalStateType inFinalState in GetInFinalStateList())
		{
			GetAbnormalHanddler(inFinalState).HandleDisp_BeAttacked(FXTrans);
		}
	}

	public void PlayDeadLoopFX(EAbnormalStateType AbnormalType, int CachedAttackerDispID, bool bEnd)
	{
		GetAbnormalHanddler(AbnormalType).HandleDisp_DeadLoop(CachedAttackerDispID, bEnd);
	}

	public void PlayDeadDisapearFX(EAbnormalStateType AbnormalType, int CachedAttackerDispID)
	{
		GetAbnormalHanddler(AbnormalType).HandleDisp_DeadDisappear(CachedAttackerDispID);
	}

	public void UpdateCurLoopAbnormalDisp()
	{
		foreach (EAbnormalStateType item in GetAllActiveAbnormalState())
		{
			GetAbnormalHanddler(item).UpdateLoopDisp();
		}
	}
}
