using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_CloudMoveData : GSBattleDataDStore
{
	private IBUC_CloudMoveData ReadData;

	private BUC_CloudMoveData Data;

	public bool ForbidEnableCloudMove
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.ForbidEnableCloudMove;
		}
	}

	public bool ForbidDisableCloudMove
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.ForbidDisableCloudMove;
		}
	}

	public bool IsCloudMoveEnabled
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.IsCloudMoveEnabled;
		}
	}

	public List<int> CloudSkillList_GetOff
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CloudSkillList_GetOff;
		}
	}

	public float CurrentPositionHeightLimit
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.CurrentPositionHeightLimit;
		}
	}

	public bool DisableHeightLimitIfNoInput
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.DisableHeightLimitIfNoInput;
		}
	}

	public bool bCloudFall
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bCloudFall;
		}
	}

	public bool bIsCloudFallInLowAirArea
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bIsCloudFallInLowAirArea;
		}
	}

	public int CloudBreakAnimId
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CloudBreakAnimId;
		}
	}

	public int CloudMoveItemId
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CloudMoveItemId;
		}
	}

	public bool bIsAutoCloudMoveEnabled
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bIsAutoCloudMoveEnabled;
		}
	}

	public FVector AutoMoveTargetLocation
	{
		get
		{
			if (ReadData == null)
			{
				return default(FVector);
			}
			return ReadData.AutoMoveTargetLocation;
		}
	}

	public DS_IBUC_CloudMoveData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_CloudMoveData>(actor);
		}
	}

	public int BindIsCloudMoveEnabledChange(Action<bool, bool> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnIsCloudMoveEnabledChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnIsCloudMoveEnabledChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnIsCloudMoveEnabledChg -= ChangeHandler;
		}
	}

	public void UnBindIsCloudMoveEnabledChange(int BindIdx, Action<bool, bool> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnIsCloudMoveEnabledChg -= ChangeHandler;
			RemoveAction(BindIdx);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_CloudMoveData>(actor);
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
