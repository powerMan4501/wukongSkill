using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_AiInteractData : GSBattleDataDStore
{
	private IBUC_AiInteractData ReadData;

	private BUC_AiInteractData Data;

	public EntitySharedRef BestInteractEntityRef
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.BestInteractEntityRef;
		}
	}

	public Entity CurrentInteractingEntityRef
	{
		get
		{
			if (ReadData == null)
			{
				return default(Entity);
			}
			return ReadData.CurrentInteractingEntityRef;
		}
	}

	public FTransform MatchingPosTargetTransform
	{
		get
		{
			if (ReadData == null)
			{
				return default(FTransform);
			}
			return ReadData.MatchingPosTargetTransform;
		}
	}

	public FUStInteractionMappingDesc InteractActionDesc
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.InteractActionDesc;
		}
	}

	public DS_IBUC_AiInteractData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AiInteractData, BUC_AiInteractData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AiInteractData>(actor);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AiInteractData, BUC_AiInteractData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AiInteractData>(actor);
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
