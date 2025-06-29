using System;
using System.Collections.Generic;
using BtlB1;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictString_EMapSymbolActiveState : GSBindDictionary<string, EMapSymbolActiveState>
{
	public delegate RepeatedField<DictDeltaMsgString_EMapSymbolActiveState> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgString_EMapSymbolActiveState> DeltaDataCache;

	private RepeatedField<DictDeltaMsgString_EMapSymbolActiveState> DeltaData
	{
		get
		{
			if (GetDeltaDataFunc != null && DeltaDataCache == null)
			{
				DeltaDataCache = GetDeltaDataFunc();
			}
			return DeltaDataCache;
		}
	}

	public void RefreshGetDeltaDataFunc(bool IsActive)
	{
	}

	public void RegGetDeltaDataFunc(Del_GetRepData Func)
	{
		GetDeltaDataFunc = Func;
		BindDataChangeFunc(Func != null);
	}

	private void BindDataChangeFunc(bool IsBind)
	{
		if (IsBind != IsBindDataChangeFunc)
		{
			if (IsBind)
			{
				base.OnAdd += OnAddImpl;
				OnRemove = (Action<string, EMapSymbolActiveState>)Delegate.Combine(OnRemove, new Action<string, EMapSymbolActiveState>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<string, EMapSymbolActiveState>)Delegate.Remove(OnRemove, new Action<string, EMapSymbolActiveState>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictString_EMapSymbolActiveState()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(string Key, EMapSymbolActiveState Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_EMapSymbolActiveState dictDeltaMsgString_EMapSymbolActiveState = new DictDeltaMsgString_EMapSymbolActiveState();
			DeltaData.Add(dictDeltaMsgString_EMapSymbolActiveState);
			dictDeltaMsgString_EMapSymbolActiveState.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_EMapSymbolActiveState.Value = (int)Value;
			dictDeltaMsgString_EMapSymbolActiveState.Op = OPType.Add;
			dictDeltaMsgString_EMapSymbolActiveState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(string Key, EMapSymbolActiveState Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_EMapSymbolActiveState dictDeltaMsgString_EMapSymbolActiveState = new DictDeltaMsgString_EMapSymbolActiveState();
			DeltaData.Add(dictDeltaMsgString_EMapSymbolActiveState);
			dictDeltaMsgString_EMapSymbolActiveState.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_EMapSymbolActiveState.Op = OPType.Remove;
			dictDeltaMsgString_EMapSymbolActiveState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(string Key, EMapSymbolActiveState OldValue, EMapSymbolActiveState NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_EMapSymbolActiveState dictDeltaMsgString_EMapSymbolActiveState = new DictDeltaMsgString_EMapSymbolActiveState();
			DeltaData.Add(dictDeltaMsgString_EMapSymbolActiveState);
			dictDeltaMsgString_EMapSymbolActiveState.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_EMapSymbolActiveState.Value = (int)NewValue;
			dictDeltaMsgString_EMapSymbolActiveState.Op = OPType.Modify;
			dictDeltaMsgString_EMapSymbolActiveState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgString_EMapSymbolActiveState dictDeltaMsgString_EMapSymbolActiveState = new DictDeltaMsgString_EMapSymbolActiveState();
			DeltaData.Add(dictDeltaMsgString_EMapSymbolActiveState);
			dictDeltaMsgString_EMapSymbolActiveState.Op = OPType.Clear;
			dictDeltaMsgString_EMapSymbolActiveState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgString_EMapSymbolActiveState> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgString_EMapSymbolActiveState
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<string, EMapSymbolActiveState>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, EMapSymbolActiveState> current = enumerator.Current;
			DictDeltaMsgString_EMapSymbolActiveState dictDeltaMsgString_EMapSymbolActiveState = new DictDeltaMsgString_EMapSymbolActiveState();
			dictDeltaMsgString_EMapSymbolActiveState.Idx = ((current.Key == null) ? string.Empty : current.Key);
			dictDeltaMsgString_EMapSymbolActiveState.Value = (int)current.Value;
			dictDeltaMsgString_EMapSymbolActiveState.Version = version;
			dictDeltaMsgString_EMapSymbolActiveState.Op = OPType.Add;
			Data.Add(dictDeltaMsgString_EMapSymbolActiveState);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
