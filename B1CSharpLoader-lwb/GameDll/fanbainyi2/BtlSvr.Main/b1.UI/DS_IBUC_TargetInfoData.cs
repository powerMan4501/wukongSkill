using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_TargetInfoData : GSBattleDataDStore
{
	private IBUC_TargetInfoData ReadData;

	private BUC_TargetInfoData Data;

	public List<string> CachedLockSkeletonSocket
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedLockSkeletonSocket;
		}
	}

	public HashSet<string> DisabledLockSkeletonSocket
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.DisabledLockSkeletonSocket;
		}
	}

	public HashSet<string> DisabledAutoLockSceneComp
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.DisabledAutoLockSceneComp;
		}
	}

	public DS_IBUC_TargetInfoData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_TargetInfoData>(actor);
		}
	}

	public List<UnitLockTargetInfo> GetMultiTargetInfoList()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetMultiTargetInfoList();
	}

	public UnitLockTargetInfo GetTargetInfo()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetTargetInfo();
	}

	public UnitLockTargetInfo GetSkillBaseTarget()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetSkillBaseTarget();
	}

	public UnitLockTargetInfo GetComboTarget()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetComboTarget();
	}

	public UnitLockTargetInfo GetAOTarget()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetAOTarget();
	}

	public UnitLockTargetInfo GetMoveToTarget()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetMoveToTarget();
	}

	public int GetTargetedCount()
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetTargetedCount();
	}

	public bool GetCanSetTarget()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetCanSetTarget();
	}

	public bool IsSupportMultiLockTarget()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsSupportMultiLockTarget();
	}

	public FVector GetLockPointPosition()
	{
		if (ReadData == null)
		{
			return default(FVector);
		}
		return ReadData.GetLockPointPosition();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_TargetInfoData>(actor);
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
