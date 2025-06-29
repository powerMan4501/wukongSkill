using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictString_String : GSBindDictionary<string, string>
{
	public delegate RepeatedField<DictDeltaMsgString_String> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgString_String> DeltaDataCache;

	private RepeatedField<DictDeltaMsgString_String> DeltaData
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
				OnRemove = (Action<string, string>)Delegate.Combine(OnRemove, new Action<string, string>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<string, string>)Delegate.Remove(OnRemove, new Action<string, string>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictString_String()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(string Key, string Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_String dictDeltaMsgString_String = new DictDeltaMsgString_String();
			DeltaData.Add(dictDeltaMsgString_String);
			dictDeltaMsgString_String.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_String.Value = ((Value == null) ? string.Empty : Value);
			dictDeltaMsgString_String.Op = OPType.Add;
			dictDeltaMsgString_String.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(string Key, string Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_String dictDeltaMsgString_String = new DictDeltaMsgString_String();
			DeltaData.Add(dictDeltaMsgString_String);
			dictDeltaMsgString_String.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_String.Op = OPType.Remove;
			dictDeltaMsgString_String.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(string Key, string OldValue, string NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_String dictDeltaMsgString_String = new DictDeltaMsgString_String();
			DeltaData.Add(dictDeltaMsgString_String);
			dictDeltaMsgString_String.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_String.Value = ((NewValue == null) ? string.Empty : NewValue);
			dictDeltaMsgString_String.Op = OPType.Modify;
			dictDeltaMsgString_String.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgString_String dictDeltaMsgString_String = new DictDeltaMsgString_String();
			DeltaData.Add(dictDeltaMsgString_String);
			dictDeltaMsgString_String.Op = OPType.Clear;
			dictDeltaMsgString_String.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgString_String> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgString_String
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<string, string>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, string> current = enumerator.Current;
			DictDeltaMsgString_String dictDeltaMsgString_String = new DictDeltaMsgString_String();
			dictDeltaMsgString_String.Idx = ((current.Key == null) ? string.Empty : current.Key);
			dictDeltaMsgString_String.Value = ((current.Value == null) ? string.Empty : current.Value);
			dictDeltaMsgString_String.Version = version;
			dictDeltaMsgString_String.Op = OPType.Add;
			Data.Add(dictDeltaMsgString_String);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
