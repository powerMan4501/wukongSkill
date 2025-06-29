using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_InteractData : GSBattleDataDStore
{
	private IBUC_InteractData ReadData;

	private BUC_InteractData Data;

	public int InteractiveUnitID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.InteractiveUnitID;
		}
	}

	public int RewardDropID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.RewardDropID;
		}
	}

	public int DefalutInteractiveGroupID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.DefalutInteractiveGroupID;
		}
	}

	public Entity TriggerInteractPlayerEntity
	{
		get
		{
			if (ReadData == null)
			{
				return default(Entity);
			}
			return ReadData.TriggerInteractPlayerEntity;
		}
	}

	public EBGUInteractUnitState InteractUnitState
	{
		get
		{
			if (ReadData == null)
			{
				return EBGUInteractUnitState.Default;
			}
			return ReadData.InteractUnitState;
		}
	}

	public EInteractUIState InteractUIState
	{
		get
		{
			if (ReadData == null)
			{
				return EInteractUIState.Min;
			}
			return ReadData.InteractUIState;
		}
	}

	public FVector IconSockVector
	{
		get
		{
			if (ReadData == null)
			{
				return default(FVector);
			}
			return ReadData.IconSockVector;
		}
	}

	public bool bSpecialIcon
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bSpecialIcon;
		}
	}

	public bool bMuteSubtitle
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bMuteSubtitle;
		}
	}

	public float CD
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.CD;
		}
	}

	public Dictionary<string, TWeakObject<UCameraComponent>> CameraComps
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CameraComps;
		}
	}

	public EInteractConstraint InteractConstraint
	{
		get
		{
			if (ReadData == null)
			{
				return EInteractConstraint.None;
			}
			return ReadData.InteractConstraint;
		}
	}

	public int ActionGroupID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.ActionGroupID;
		}
	}

	public int InteractCounter
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.InteractCounter;
		}
	}

	public int ShopID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.ShopID;
		}
	}

	public string InteractTipOverride
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.InteractTipOverride;
		}
	}

	public float InteractinputTime
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.InteractinputTime;
		}
	}

	public bool bIsNPC
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bIsNPC;
		}
	}

	public int AiConversationNeedToPlay
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.AiConversationNeedToPlay;
		}
	}

	public bool bIsInteracting
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bIsInteracting;
		}
	}

	public List<FUStInteractionMappingDesc> ActionList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.ActionList;
		}
	}

	public FUStInteractiveUnitCommDesc InteractiveUnitCommDesc
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.InteractiveUnitCommDesc;
		}
	}

	public List<int> InteractFuncList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.InteractFuncList;
		}
	}

	public float RemainingInteractTime
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.RemainingInteractTime;
		}
	}

	public float BlendOutTimer
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.BlendOutTimer;
		}
	}

	public DS_IBUC_InteractData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_InteractData, BUC_InteractData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_InteractData>(actor);
		}
	}

	public int BindInteractUIStateChange(Action<EInteractUIState, EInteractUIState> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnInteractUIStateChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnInteractUIStateChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnInteractUIStateChg -= ChangeHandler;
		}
	}

	public void UnBindInteractUIStateChange(int BindIdx, Action<EInteractUIState, EInteractUIState> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnInteractUIStateChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindInteractTipOverrideChange(Action<string, string> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnInteractTipOverrideChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnInteractTipOverrideChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnInteractTipOverrideChg -= ChangeHandler;
		}
	}

	public void UnBindInteractTipOverrideChange(int BindIdx, Action<string, string> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnInteractTipOverrideChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindInteractinputTimeChange(Action<float, float> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnInteractinputTimeChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnInteractinputTimeChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnInteractinputTimeChg -= ChangeHandler;
		}
	}

	public void UnBindInteractinputTimeChange(int BindIdx, Action<float, float> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnInteractinputTimeChg -= ChangeHandler;
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_InteractData, BUC_InteractData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_InteractData>(actor);
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
