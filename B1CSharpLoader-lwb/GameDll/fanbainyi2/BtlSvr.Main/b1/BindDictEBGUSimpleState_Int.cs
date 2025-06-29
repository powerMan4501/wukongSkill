using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictEBGUSimpleState_Int : GSBindDictionary<EBGUSimpleState, int>
{
	public delegate RepeatedField<DictDeltaMsgEBGUSimpleState_Int> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgEBGUSimpleState_Int> DeltaDataCache;

	private RepeatedField<DictDeltaMsgEBGUSimpleState_Int> DeltaData
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
				OnRemove = (Action<EBGUSimpleState, int>)Delegate.Combine(OnRemove, new Action<EBGUSimpleState, int>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<EBGUSimpleState, int>)Delegate.Remove(OnRemove, new Action<EBGUSimpleState, int>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictEBGUSimpleState_Int()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(EBGUSimpleState Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEBGUSimpleState_Int dictDeltaMsgEBGUSimpleState_Int = new DictDeltaMsgEBGUSimpleState_Int();
			DeltaData.Add(dictDeltaMsgEBGUSimpleState_Int);
			dictDeltaMsgEBGUSimpleState_Int.Idx = (int)Key;
			dictDeltaMsgEBGUSimpleState_Int.Value = Value;
			dictDeltaMsgEBGUSimpleState_Int.Op = OPType.Add;
			dictDeltaMsgEBGUSimpleState_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(EBGUSimpleState Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEBGUSimpleState_Int dictDeltaMsgEBGUSimpleState_Int = new DictDeltaMsgEBGUSimpleState_Int();
			DeltaData.Add(dictDeltaMsgEBGUSimpleState_Int);
			dictDeltaMsgEBGUSimpleState_Int.Idx = (int)Key;
			dictDeltaMsgEBGUSimpleState_Int.Op = OPType.Remove;
			dictDeltaMsgEBGUSimpleState_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(EBGUSimpleState Key, int OldValue, int NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEBGUSimpleState_Int dictDeltaMsgEBGUSimpleState_Int = new DictDeltaMsgEBGUSimpleState_Int();
			DeltaData.Add(dictDeltaMsgEBGUSimpleState_Int);
			dictDeltaMsgEBGUSimpleState_Int.Idx = (int)Key;
			dictDeltaMsgEBGUSimpleState_Int.Value = NewValue;
			dictDeltaMsgEBGUSimpleState_Int.Op = OPType.Modify;
			dictDeltaMsgEBGUSimpleState_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgEBGUSimpleState_Int dictDeltaMsgEBGUSimpleState_Int = new DictDeltaMsgEBGUSimpleState_Int();
			DeltaData.Add(dictDeltaMsgEBGUSimpleState_Int);
			dictDeltaMsgEBGUSimpleState_Int.Op = OPType.Clear;
			dictDeltaMsgEBGUSimpleState_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgEBGUSimpleState_Int> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgEBGUSimpleState_Int
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<EBGUSimpleState, int>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<EBGUSimpleState, int> current = enumerator.Current;
			DictDeltaMsgEBGUSimpleState_Int dictDeltaMsgEBGUSimpleState_Int = new DictDeltaMsgEBGUSimpleState_Int();
			dictDeltaMsgEBGUSimpleState_Int.Idx = (int)current.Key;
			dictDeltaMsgEBGUSimpleState_Int.Value = current.Value;
			dictDeltaMsgEBGUSimpleState_Int.Version = version;
			dictDeltaMsgEBGUSimpleState_Int.Op = OPType.Add;
			Data.Add(dictDeltaMsgEBGUSimpleState_Int);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
