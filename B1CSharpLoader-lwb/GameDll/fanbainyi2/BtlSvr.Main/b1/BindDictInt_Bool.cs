using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictInt_Bool : GSBindDictionary<int, bool>
{
	public delegate RepeatedField<DictDeltaMsgInt_Bool> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgInt_Bool> DeltaDataCache;

	private RepeatedField<DictDeltaMsgInt_Bool> DeltaData
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
				OnRemove = (Action<int, bool>)Delegate.Combine(OnRemove, new Action<int, bool>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<int, bool>)Delegate.Remove(OnRemove, new Action<int, bool>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictInt_Bool()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Key, bool Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_Bool dictDeltaMsgInt_Bool = new DictDeltaMsgInt_Bool();
			DeltaData.Add(dictDeltaMsgInt_Bool);
			dictDeltaMsgInt_Bool.Idx = Key;
			dictDeltaMsgInt_Bool.Value = Value;
			dictDeltaMsgInt_Bool.Op = OPType.Add;
			dictDeltaMsgInt_Bool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(int Key, bool Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_Bool dictDeltaMsgInt_Bool = new DictDeltaMsgInt_Bool();
			DeltaData.Add(dictDeltaMsgInt_Bool);
			dictDeltaMsgInt_Bool.Idx = Key;
			dictDeltaMsgInt_Bool.Op = OPType.Remove;
			dictDeltaMsgInt_Bool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(int Key, bool OldValue, bool NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_Bool dictDeltaMsgInt_Bool = new DictDeltaMsgInt_Bool();
			DeltaData.Add(dictDeltaMsgInt_Bool);
			dictDeltaMsgInt_Bool.Idx = Key;
			dictDeltaMsgInt_Bool.Value = NewValue;
			dictDeltaMsgInt_Bool.Op = OPType.Modify;
			dictDeltaMsgInt_Bool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgInt_Bool dictDeltaMsgInt_Bool = new DictDeltaMsgInt_Bool();
			DeltaData.Add(dictDeltaMsgInt_Bool);
			dictDeltaMsgInt_Bool.Op = OPType.Clear;
			dictDeltaMsgInt_Bool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgInt_Bool> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgInt_Bool
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<int, bool>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, bool> current = enumerator.Current;
			DictDeltaMsgInt_Bool dictDeltaMsgInt_Bool = new DictDeltaMsgInt_Bool();
			dictDeltaMsgInt_Bool.Idx = current.Key;
			dictDeltaMsgInt_Bool.Value = current.Value;
			dictDeltaMsgInt_Bool.Version = version;
			dictDeltaMsgInt_Bool.Op = OPType.Add;
			Data.Add(dictDeltaMsgInt_Bool);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
