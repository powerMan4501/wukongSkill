using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictString_Int : GSBindDictionary<string, int>
{
	public delegate RepeatedField<DictDeltaMsgString_Int> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgString_Int> DeltaDataCache;

	private RepeatedField<DictDeltaMsgString_Int> DeltaData
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
				OnRemove = (Action<string, int>)Delegate.Combine(OnRemove, new Action<string, int>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<string, int>)Delegate.Remove(OnRemove, new Action<string, int>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictString_Int()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(string Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_Int dictDeltaMsgString_Int = new DictDeltaMsgString_Int();
			DeltaData.Add(dictDeltaMsgString_Int);
			dictDeltaMsgString_Int.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_Int.Value = Value;
			dictDeltaMsgString_Int.Op = OPType.Add;
			dictDeltaMsgString_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(string Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_Int dictDeltaMsgString_Int = new DictDeltaMsgString_Int();
			DeltaData.Add(dictDeltaMsgString_Int);
			dictDeltaMsgString_Int.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_Int.Op = OPType.Remove;
			dictDeltaMsgString_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(string Key, int OldValue, int NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_Int dictDeltaMsgString_Int = new DictDeltaMsgString_Int();
			DeltaData.Add(dictDeltaMsgString_Int);
			dictDeltaMsgString_Int.Idx = ((Key == null) ? string.Empty : Key);
			dictDeltaMsgString_Int.Value = NewValue;
			dictDeltaMsgString_Int.Op = OPType.Modify;
			dictDeltaMsgString_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgString_Int dictDeltaMsgString_Int = new DictDeltaMsgString_Int();
			DeltaData.Add(dictDeltaMsgString_Int);
			dictDeltaMsgString_Int.Op = OPType.Clear;
			dictDeltaMsgString_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgString_Int> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgString_Int
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<string, int>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, int> current = enumerator.Current;
			DictDeltaMsgString_Int dictDeltaMsgString_Int = new DictDeltaMsgString_Int();
			dictDeltaMsgString_Int.Idx = ((current.Key == null) ? string.Empty : current.Key);
			dictDeltaMsgString_Int.Value = current.Value;
			dictDeltaMsgString_Int.Version = version;
			dictDeltaMsgString_Int.Op = OPType.Add;
			Data.Add(dictDeltaMsgString_Int);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
