using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictInt_Int : GSBindDictionary<int, int>
{
	public delegate RepeatedField<DictDeltaMsgInt_Int> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgInt_Int> DeltaDataCache;

	private RepeatedField<DictDeltaMsgInt_Int> DeltaData
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
				OnRemove = (Action<int, int>)Delegate.Combine(OnRemove, new Action<int, int>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<int, int>)Delegate.Remove(OnRemove, new Action<int, int>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictInt_Int()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_Int dictDeltaMsgInt_Int = new DictDeltaMsgInt_Int();
			DeltaData.Add(dictDeltaMsgInt_Int);
			dictDeltaMsgInt_Int.Idx = Key;
			dictDeltaMsgInt_Int.Value = Value;
			dictDeltaMsgInt_Int.Op = OPType.Add;
			dictDeltaMsgInt_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(int Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_Int dictDeltaMsgInt_Int = new DictDeltaMsgInt_Int();
			DeltaData.Add(dictDeltaMsgInt_Int);
			dictDeltaMsgInt_Int.Idx = Key;
			dictDeltaMsgInt_Int.Op = OPType.Remove;
			dictDeltaMsgInt_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(int Key, int OldValue, int NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_Int dictDeltaMsgInt_Int = new DictDeltaMsgInt_Int();
			DeltaData.Add(dictDeltaMsgInt_Int);
			dictDeltaMsgInt_Int.Idx = Key;
			dictDeltaMsgInt_Int.Value = NewValue;
			dictDeltaMsgInt_Int.Op = OPType.Modify;
			dictDeltaMsgInt_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgInt_Int dictDeltaMsgInt_Int = new DictDeltaMsgInt_Int();
			DeltaData.Add(dictDeltaMsgInt_Int);
			dictDeltaMsgInt_Int.Op = OPType.Clear;
			dictDeltaMsgInt_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgInt_Int> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgInt_Int
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<int, int>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, int> current = enumerator.Current;
			DictDeltaMsgInt_Int dictDeltaMsgInt_Int = new DictDeltaMsgInt_Int();
			dictDeltaMsgInt_Int.Idx = current.Key;
			dictDeltaMsgInt_Int.Value = current.Value;
			dictDeltaMsgInt_Int.Version = version;
			dictDeltaMsgInt_Int.Op = OPType.Add;
			Data.Add(dictDeltaMsgInt_Int);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
