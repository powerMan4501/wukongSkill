using System;
using System.Collections.Generic;
using BtlB1;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictString_EMapSymbolState : GSBindDictionary<string, EMapSymbolState>
{
	public delegate RepeatedField<DictDeltaMsgString_EMapSymbolState> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgString_EMapSymbolState> DeltaDataCache;

	private RepeatedField<DictDeltaMsgString_EMapSymbolState> DeltaData
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
				OnRemove = (Action<string, EMapSymbolState>)Delegate.Combine(OnRemove, new Action<string, EMapSymbolState>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<string, EMapSymbolState>)Delegate.Remove(OnRemove, new Action<string, EMapSymbolState>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictString_EMapSymbolState()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(string Key, EMapSymbolState Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_EMapSymbolState dictDeltaMsgString_EMapSymbolState = new DictDeltaMsgString_EMapSymbolState();
			DeltaData.Add(dictDeltaMsgString_EMapSymbolState);
			dictDeltaMsgString_EMapSymbolState.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_EMapSymbolState.Value = (int)Value;
			dictDeltaMsgString_EMapSymbolState.Op = OPType.Add;
			dictDeltaMsgString_EMapSymbolState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(string Key, EMapSymbolState Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_EMapSymbolState dictDeltaMsgString_EMapSymbolState = new DictDeltaMsgString_EMapSymbolState();
			DeltaData.Add(dictDeltaMsgString_EMapSymbolState);
			dictDeltaMsgString_EMapSymbolState.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_EMapSymbolState.Op = OPType.Remove;
			dictDeltaMsgString_EMapSymbolState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(string Key, EMapSymbolState OldValue, EMapSymbolState NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_EMapSymbolState dictDeltaMsgString_EMapSymbolState = new DictDeltaMsgString_EMapSymbolState();
			DeltaData.Add(dictDeltaMsgString_EMapSymbolState);
			dictDeltaMsgString_EMapSymbolState.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_EMapSymbolState.Value = (int)NewValue;
			dictDeltaMsgString_EMapSymbolState.Op = OPType.Modify;
			dictDeltaMsgString_EMapSymbolState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgString_EMapSymbolState dictDeltaMsgString_EMapSymbolState = new DictDeltaMsgString_EMapSymbolState();
			DeltaData.Add(dictDeltaMsgString_EMapSymbolState);
			dictDeltaMsgString_EMapSymbolState.Op = OPType.Clear;
			dictDeltaMsgString_EMapSymbolState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgString_EMapSymbolState> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgString_EMapSymbolState
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<string, EMapSymbolState>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, EMapSymbolState> current = enumerator.Current;
			DictDeltaMsgString_EMapSymbolState dictDeltaMsgString_EMapSymbolState = new DictDeltaMsgString_EMapSymbolState();
			dictDeltaMsgString_EMapSymbolState.Idx = ((current.Key == null) ? string.Empty : current.Key);
			dictDeltaMsgString_EMapSymbolState.Value = (int)current.Value;
			dictDeltaMsgString_EMapSymbolState.Version = version;
			dictDeltaMsgString_EMapSymbolState.Op = OPType.Add;
			Data.Add(dictDeltaMsgString_EMapSymbolState);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
