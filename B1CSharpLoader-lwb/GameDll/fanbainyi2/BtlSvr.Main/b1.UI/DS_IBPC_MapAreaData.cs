using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_MapAreaData : GSBattleDataDStore
{
	private b1.IBPC_MapAreaData ReadData;

	private BPC_MapAreaData Data;

	public GSBindProp<int> CurrentSpriteId
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CurrentSpriteId;
		}
	}

	public GSBindProp<int> CurrentAreaId
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CurrentAreaId;
		}
	}

	public DS_IBPC_MapAreaData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBPC_MapAreaData, BPC_MapAreaData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_MapAreaData>(actor);
		}
	}

	public bool TryGetAreaId(AActor Actor, out int AreaId)
	{
		AreaId = 0;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.TryGetAreaId(Actor, out AreaId);
	}

	public bool TryGetAreaId(UObject WorldContext, int MapSpriteId, FVector2D MapPosition, out int AreaId)
	{
		AreaId = 0;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.TryGetAreaId(WorldContext, MapSpriteId, MapPosition, out AreaId);
	}

	public bool TryGetMapPositionByPlayer(UObject WorldContext, out int MapSpriteId, out FVector2D MapPosition, out float MapRotation)
	{
		MapSpriteId = 0;
		MapPosition = default(FVector2D);
		MapRotation = 0f;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.TryGetMapPositionByPlayer(WorldContext, out MapSpriteId, out MapPosition, out MapRotation);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBPC_MapAreaData, BPC_MapAreaData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_MapAreaData>(actor);
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
