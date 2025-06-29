using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using GUR.Runtime;
using GurGsPersistent;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_MapSymbolData : IPersistentECSData, IBPC_MapSymbolData
{
	public bool NeedCheckUnLock;

	private BindDictString_EMapSymbolState __MapSymbolStateDict_Raw;

	[GSPersistent]
	public BindDictString_EMapSymbolState MapSymbolStateDict
	{
		get
		{
			return __MapSymbolStateDict_Raw;
		}
		set
		{
			BindDictString_EMapSymbolState _MapSymbolStateDict_Raw = __MapSymbolStateDict_Raw;
			__MapSymbolStateDict_Raw = value;
			OnMapSymbolStateDictChg_Invoke(_MapSymbolStateDict_Raw, value);
		}
	}

	public BindDictString_EMapSymbolActiveState MapSymbolActiveDict { get; set; }

	public BindListString CoustomMapSymbolList { get; set; }

	public UnrealEngine.Runtime.FVector SelfDestinationPos { get; set; }

	public Dictionary<ABGPPlayerState, GurGsPersistent.FVector> TargetPosList { get; set; }

	public event Action<BindDictString_EMapSymbolState, BindDictString_EMapSymbolState> OnMapSymbolStateDictChg;

	public BPC_MapSymbolData()
	{
		MapSymbolStateDict = new BindDictString_EMapSymbolState();
		CoustomMapSymbolList = new BindListString();
		MapSymbolActiveDict = new BindDictString_EMapSymbolActiveState();
	}

	public void SetMapSymbolState(string MapSymbolStateGuid, EMapSymbolState MapSymbolState)
	{
		if (MapSymbolStateDict.ContainsKey(MapSymbolStateGuid))
		{
			MapSymbolStateDict[MapSymbolStateGuid] = MapSymbolState;
		}
		else
		{
			MapSymbolStateDict.Add(MapSymbolStateGuid, MapSymbolState);
		}
	}

	public BindDictString_EMapSymbolState GetMapSymbolStateDict()
	{
		return MapSymbolStateDict;
	}

	public BindListString GetCoustomMapSymbolList()
	{
		return CoustomMapSymbolList;
	}

	public void SetDestinationPos(UnrealEngine.Runtime.FVector Destination)
	{
		SelfDestinationPos = Destination;
	}

	public void AddCoustomMapSymbol()
	{
	}

	public void SetMapSymbolActiveDict(string MapSymbolStateGuid, EMapSymbolActiveState MapSymbolState)
	{
		if (!MapSymbolActiveDict.ContainsKey(MapSymbolStateGuid))
		{
			MapSymbolActiveDict[MapSymbolStateGuid] = MapSymbolState;
		}
	}

	private void OnMapSymbolStateDictChg_Invoke(BindDictString_EMapSymbolState OldValue, BindDictString_EMapSymbolState NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnMapSymbolStateDictChg?.Invoke(OldValue, NewValue);
		}
	}
}
