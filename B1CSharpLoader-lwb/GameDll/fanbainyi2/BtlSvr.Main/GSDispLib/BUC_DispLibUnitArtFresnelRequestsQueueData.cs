using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUC_DispLibUnitArtFresnelRequestsQueueData : BUC_DispLibDataBase
{
	internal bool ApplyAnyUAF;

	internal Dictionary<UPrimitiveComponent, BUC_DispLibOneUnitArtFresnelData[]> Queue;

	private uint UniqueRequestID { get; set; }

	public uint RequestNewUniqueID()
	{
		UniqueRequestID++;
		return UniqueRequestID;
	}

	internal BUC_DispLibOneUnitArtFresnelData[] GetOneUAFEventCacheQueue(UPrimitiveComponent MeshComp)
	{
		if (Queue.TryGetValue(MeshComp, out var value))
		{
			return value;
		}
		return null;
	}

	internal void Init(BUC_DispLibUnitRendererBaseData RenderBaseData)
	{
		UniqueRequestID = 0u;
		int num = 4;
		if (!BGW_DispLibGameDB.GameDBDataAsset.IsNullOrDestroyed() && !BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.IsNullOrDestroyed())
		{
			num = UMathLibrary.Max(1, BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.MAX_UAF_REQUESTS_COUNT);
		}
		Dictionary<UPrimitiveComponent, List<FName>> dictionary = new Dictionary<UPrimitiveComponent, List<FName>>(0);
		if (RenderBaseData != null && RenderBaseData.MeshComp2TagList != null)
		{
			dictionary = RenderBaseData.MeshComp2TagList;
		}
		Queue = new Dictionary<UPrimitiveComponent, BUC_DispLibOneUnitArtFresnelData[]>(dictionary.Count);
		foreach (UPrimitiveComponent key in dictionary.Keys)
		{
			BUC_DispLibOneUnitArtFresnelData[] array = new BUC_DispLibOneUnitArtFresnelData[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = null;
			}
			Queue.Add(key, array);
		}
	}

	internal void Reset()
	{
		UniqueRequestID = 0u;
		Queue.Clear();
	}
}
