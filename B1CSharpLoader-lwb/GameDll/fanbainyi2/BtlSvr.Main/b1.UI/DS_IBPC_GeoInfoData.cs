using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_GeoInfoData : GSBattleDataDStore
{
	private IBPC_GeoInfoData ReadData;

	private BPC_GeoInfoData Data;

	public int CurMapSpriteId
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CurMapSpriteId;
		}
	}

	public DS_IBPC_GeoInfoData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_GeoInfoData, BPC_GeoInfoData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_GeoInfoData>(actor);
		}
	}

	public List<GeoInfoStruct> GetRebirthPointGeoInfoList()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetRebirthPointGeoInfoList();
	}

	public BindListGeoInfoAreaData GetAreaPointGeoInfoList()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetAreaPointGeoInfoList();
	}

	public BindListGeoInfoCustomData GetCustomGeoInfoList()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetCustomGeoInfoList();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_GeoInfoData, BPC_GeoInfoData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_GeoInfoData>(actor);
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
