using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_PlayerInteractData : GSBattleDataDStore
{
	private IBPC_PlayerInteractData ReadData;

	private BPC_PlayerInteractData Data;

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

	public bool TmpIsSpDrop
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.TmpIsSpDrop;
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

	public DS_IBPC_PlayerInteractData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_PlayerInteractData, BPC_PlayerInteractData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_PlayerInteractData>(actor);
		}
	}

	public bool IsInInteraction()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsInInteraction();
	}

	public bool IsToolInteraction()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsToolInteraction();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_PlayerInteractData, BPC_PlayerInteractData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_PlayerInteractData>(actor);
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
