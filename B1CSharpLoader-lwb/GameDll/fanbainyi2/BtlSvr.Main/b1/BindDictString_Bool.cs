using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictString_Bool : GSBindDictionary<string, bool>
{
	public delegate RepeatedField<DictDeltaMsgString_Bool> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgString_Bool> DeltaDataCache;

	private RepeatedField<DictDeltaMsgString_Bool> DeltaData
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
				OnRemove = (Action<string, bool>)Delegate.Combine(OnRemove, new Action<string, bool>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<string, bool>)Delegate.Remove(OnRemove, new Action<string, bool>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictString_Bool()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(string Key, bool Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_Bool dictDeltaMsgString_Bool = new DictDeltaMsgString_Bool();
			DeltaData.Add(dictDeltaMsgString_Bool);
			dictDeltaMsgString_Bool.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_Bool.Value = Value;
			dictDeltaMsgString_Bool.Op = OPType.Add;
			dictDeltaMsgString_Bool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(string Key, bool Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_Bool dictDeltaMsgString_Bool = new DictDeltaMsgString_Bool();
			DeltaData.Add(dictDeltaMsgString_Bool);
			dictDeltaMsgString_Bool.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_Bool.Op = OPType.Remove;
			dictDeltaMsgString_Bool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(string Key, bool OldValue, bool NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_Bool dictDeltaMsgString_Bool = new DictDeltaMsgString_Bool();
			DeltaData.Add(dictDeltaMsgString_Bool);
			dictDeltaMsgString_Bool.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_Bool.Value = NewValue;
			dictDeltaMsgString_Bool.Op = OPType.Modify;
			dictDeltaMsgString_Bool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgString_Bool dictDeltaMsgString_Bool = new DictDeltaMsgString_Bool();
			DeltaData.Add(dictDeltaMsgString_Bool);
			dictDeltaMsgString_Bool.Op = OPType.Clear;
			dictDeltaMsgString_Bool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgString_Bool> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgString_Bool
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<string, bool>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, bool> current = enumerator.Current;
			DictDeltaMsgString_Bool dictDeltaMsgString_Bool = new DictDeltaMsgString_Bool();
			dictDeltaMsgString_Bool.Idx = ((current.Key == null) ? string.Empty : current.Key);
			dictDeltaMsgString_Bool.Value = current.Value;
			dictDeltaMsgString_Bool.Version = version;
			dictDeltaMsgString_Bool.Op = OPType.Add;
			Data.Add(dictDeltaMsgString_Bool);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
