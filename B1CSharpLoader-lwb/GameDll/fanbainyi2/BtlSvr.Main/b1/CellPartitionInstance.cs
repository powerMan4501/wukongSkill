using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class CellPartitionInstance
{
	public delegate bool Del_AddActorFilterFunc(AActor Actor);

	public string InstanceName;

	protected List<CellPartitionLayer> ActiveLayers = new List<CellPartitionLayer>();

	public Dictionary<IntPtr, CellPartitionActorInfo> ActorInfoMap = new Dictionary<IntPtr, CellPartitionActorInfo>();

	private Del_AddActorFilterFunc AddActorFilterFunc;

	private int CellPartitionIdx = -1;

	private UWorld World;

	private static IntPtr sCppSwap;

	private const int CPP_GETUNIT_MAX = 64;

	static CellPartitionInstance()
	{
		sCppSwap = Marshal.AllocHGlobal(IntPtr.Size * 64);
	}

	public CellPartitionInstance(UWorld World, string InstanceName, int CellPartitionIdx, Del_AddActorFilterFunc AddActorFilterFunc, FVector2D WorldCellPatitionSize, int CellXCount, int CellYCount, FVector2D WorldCellPatitionBias, int maxUnit, int maxUnitRadius)
	{
		this.InstanceName = InstanceName;
		this.CellPartitionIdx = CellPartitionIdx;
		this.AddActorFilterFunc = AddActorFilterFunc;
		this.World = World;
		BGW_NativeFuncs.CellPartition_SetInitialParam(WorldCellPatitionSize.X, WorldCellPatitionSize.Y, CellXCount, CellYCount, WorldCellPatitionBias.X, WorldCellPatitionBias.Y, maxUnit, maxUnitRadius);
		BGW_NativeFuncs.CellPartition_ResetCellPartition(CellPartitionIdx);
	}

	public void RegisterLayer(string LayerName, FGSCellPatitionLayerConfig LayerCfg, CellPartitionLayerTag LayerTag, Action<CellPartitionActorInfo> OnActorLeave, Action<CellPartitionActorInfo> OnActorEnter)
	{
		CellPartitionLayer cellPartitionLayer = new CellPartitionLayer
		{
			LayerName = InstanceName + "_" + LayerName,
			LayerRadius = LayerCfg.Radius,
			LayerTag = LayerTag,
			Priority = LayerCfg.Priority,
			TeamFilter = LayerCfg.TeamFilter,
			UnitFilter = LayerCfg.UnitFilter,
			FilterAnd = LayerCfg.FilterAnd
		};
		ActiveLayers.Add(cellPartitionLayer);
		cellPartitionLayer.OnActorLeave += OnActorLeave;
		cellPartitionLayer.OnActorEnter += OnActorEnter;
	}

	public void UnRegisterLayer(string LayerName)
	{
		string text = InstanceName + "_" + LayerName;
		for (int i = 0; i < ActiveLayers.Count; i++)
		{
			if (ActiveLayers[i].LayerName == text)
			{
				ActiveLayers.RemoveAt(i);
				return;
			}
		}
		BGW_LogUtil.LogError("BGWCellPatitionWorldSubSystem UnRegisterLayer " + text + " Not Found");
	}

	public bool ShouldAddActor(AActor Actor)
	{
		if (AddActorFilterFunc == null)
		{
			BGW_LogUtil.LogError("CellPartitionInstance " + InstanceName + " ShouldAddActor AddActorFilterFunc == null");
			return false;
		}
		return AddActorFilterFunc(Actor);
	}

	public void AddActor(AActor Actor)
	{
		if (ShouldAddActor(Actor) && !ActorInfoMap.ContainsKey(Actor.Address))
		{
			ActorInfoMap.Add(Actor.Address, new CellPartitionActorInfo
			{
				RelatedActor = Actor,
				LayerTag = 0u
			});
			BGUFuncLibReplication.GetActorCellPartitionFilter(Actor, out var UnitFilter, out var TeamFilter);
			BGW_NativeFuncs.CellPartition_AddUnit(Actor.Address, UnitFilter, TeamFilter, CellPartitionIdx);
		}
	}

	public void RemoveActor(AActor Actor)
	{
		if (!ActorInfoMap.TryGetValue(Actor.Address, out var value))
		{
			return;
		}
		ActorInfoMap.Remove(Actor.Address);
		foreach (CellPartitionLayer activeLayer in ActiveLayers)
		{
			if ((value.LayerTag & (uint)activeLayer.LayerTag) != 0)
			{
				activeLayer.RemoveActor(value);
			}
		}
		BGW_NativeFuncs.CellPartition_RemoveUnit(Actor.Address, CellPartitionIdx);
	}

	public unsafe void OnTick()
	{
		BGW_NativeFuncs.CellPartition_UpdateAllUnitPos(CellPartitionIdx);
		foreach (KeyValuePair<IntPtr, CellPartitionActorInfo> item in ActorInfoMap)
		{
			item.Value.LayerTag = 0u;
		}
		ABGPPlayerState[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ABGPPlayerState>(World);
		foreach (CellPartitionLayer activeLayer in ActiveLayers)
		{
			activeLayer.RemoveAllTagedActor();
			ABGPPlayerState[] array = allActorsOfClass;
			for (int i = 0; i < array.Length; i++)
			{
				APawn pawn = array[i].GetPawn();
				if (BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(pawn) == null)
				{
					continue;
				}
				FVector actorLocation = pawn.GetActorLocation();
				int num = BGW_NativeFuncs.CellPartition_GetUnitInCircle(actorLocation.X, actorLocation.Y, activeLayer.LayerRadius, sCppSwap, 64, activeLayer.TeamFilter, activeLayer.UnitFilter, activeLayer.FilterAnd ? 1 : 0, CellPartitionIdx);
				for (int j = 0; j < num; j++)
				{
					CellPartitionActorInfo cellPartitionActorInfo = ActorInfoMap[((IntPtr*)sCppSwap.ToPointer())[j]];
					if ((cellPartitionActorInfo.LayerTag & (uint)activeLayer.LayerTag) == 0)
					{
						activeLayer.AddActor(cellPartitionActorInfo);
					}
				}
			}
			activeLayer.RemoveAllUnTagedActor();
		}
	}
}
