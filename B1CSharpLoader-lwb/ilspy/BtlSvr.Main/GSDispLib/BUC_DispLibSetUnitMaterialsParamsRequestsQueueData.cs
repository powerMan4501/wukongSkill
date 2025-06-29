using System.Collections.Generic;
using UnrealEngine.Engine;

namespace GSDispLib;

public class BUC_DispLibSetUnitMaterialsParamsRequestsQueueData : BUC_DispLibDataBase
{
	private uint UniqueRequestID { get; set; }

	internal Dictionary<uint, DispLibMaterialParamsRequestsInfo[]> Queue { get; set; }

	public uint RequestNewUniqueID()
	{
		UniqueRequestID++;
		return UniqueRequestID;
	}

	internal bool GetOneMaterialParamsRequestsInfo(uint MeshCompID, int MatIndex, out DispLibMaterialParamsRequestsInfo MatParamsRequestInfo)
	{
		MatParamsRequestInfo = null;
		if (MatIndex < 0)
		{
			return false;
		}
		if (Queue.TryGetValue(MeshCompID, out var value))
		{
			if (value == null || MatIndex > value.Length - 1)
			{
				return false;
			}
			MatParamsRequestInfo = value[MatIndex];
			return MatParamsRequestInfo != null;
		}
		return false;
	}

	internal void Init(BUC_DispLibUnitRendererBaseData RenderBaseData)
	{
		UniqueRequestID = 0u;
		Queue = new Dictionary<uint, DispLibMaterialParamsRequestsInfo[]>();
		if (RenderBaseData.OriginMaterialInterfaces != null)
		{
			foreach (KeyValuePair<uint, UMaterialInterface[]> originMaterialInterface in RenderBaseData.OriginMaterialInterfaces)
			{
				uint key = originMaterialInterface.Key;
				int num = originMaterialInterface.Value.Length;
				DispLibMaterialParamsRequestsInfo[] array = new DispLibMaterialParamsRequestsInfo[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = new DispLibMaterialParamsRequestsInfo();
				}
				Queue.Add(key, array);
			}
		}
		base.DataInitOver = true;
	}

	internal void Reset()
	{
		base.DataInitOver = false;
		UniqueRequestID = 0u;
	}

	internal int GetValidEventsCount(uint MeshCompID, int MatIndex)
	{
		if (MatIndex < 0)
		{
			return -1;
		}
		if (Queue.TryGetValue(MeshCompID, out var value))
		{
			if (value == null || MatIndex > value.Length - 1)
			{
				return -1;
			}
			return value[MatIndex]?.GetValidEventsCount() ?? (-1);
		}
		return -1;
	}
}
