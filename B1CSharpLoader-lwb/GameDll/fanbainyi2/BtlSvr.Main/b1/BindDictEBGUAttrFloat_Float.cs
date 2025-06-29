using System;
using System.Collections.Generic;
using BtlShare;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictEBGUAttrFloat_Float : GSBindDictionary<EBGUAttrFloat, float>
{
	public delegate RepeatedField<DictDeltaMsgEBGUAttrFloat_Float> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgEBGUAttrFloat_Float> DeltaDataCache;

	private RepeatedField<DictDeltaMsgEBGUAttrFloat_Float> DeltaData
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
				OnRemove = (Action<EBGUAttrFloat, float>)Delegate.Combine(OnRemove, new Action<EBGUAttrFloat, float>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<EBGUAttrFloat, float>)Delegate.Remove(OnRemove, new Action<EBGUAttrFloat, float>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictEBGUAttrFloat_Float()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(EBGUAttrFloat Key, float Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEBGUAttrFloat_Float dictDeltaMsgEBGUAttrFloat_Float = new DictDeltaMsgEBGUAttrFloat_Float();
			DeltaData.Add(dictDeltaMsgEBGUAttrFloat_Float);
			dictDeltaMsgEBGUAttrFloat_Float.Idx = (int)Key;
			dictDeltaMsgEBGUAttrFloat_Float.Value = Value;
			dictDeltaMsgEBGUAttrFloat_Float.Op = OPType.Add;
			dictDeltaMsgEBGUAttrFloat_Float.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(EBGUAttrFloat Key, float Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEBGUAttrFloat_Float dictDeltaMsgEBGUAttrFloat_Float = new DictDeltaMsgEBGUAttrFloat_Float();
			DeltaData.Add(dictDeltaMsgEBGUAttrFloat_Float);
			dictDeltaMsgEBGUAttrFloat_Float.Idx = (int)Key;
			dictDeltaMsgEBGUAttrFloat_Float.Op = OPType.Remove;
			dictDeltaMsgEBGUAttrFloat_Float.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(EBGUAttrFloat Key, float OldValue, float NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEBGUAttrFloat_Float dictDeltaMsgEBGUAttrFloat_Float = new DictDeltaMsgEBGUAttrFloat_Float();
			DeltaData.Add(dictDeltaMsgEBGUAttrFloat_Float);
			dictDeltaMsgEBGUAttrFloat_Float.Idx = (int)Key;
			dictDeltaMsgEBGUAttrFloat_Float.Value = NewValue;
			dictDeltaMsgEBGUAttrFloat_Float.Op = OPType.Modify;
			dictDeltaMsgEBGUAttrFloat_Float.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgEBGUAttrFloat_Float dictDeltaMsgEBGUAttrFloat_Float = new DictDeltaMsgEBGUAttrFloat_Float();
			DeltaData.Add(dictDeltaMsgEBGUAttrFloat_Float);
			dictDeltaMsgEBGUAttrFloat_Float.Op = OPType.Clear;
			dictDeltaMsgEBGUAttrFloat_Float.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgEBGUAttrFloat_Float> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgEBGUAttrFloat_Float
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<EBGUAttrFloat, float>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<EBGUAttrFloat, float> current = enumerator.Current;
			DictDeltaMsgEBGUAttrFloat_Float dictDeltaMsgEBGUAttrFloat_Float = new DictDeltaMsgEBGUAttrFloat_Float();
			dictDeltaMsgEBGUAttrFloat_Float.Idx = (int)current.Key;
			dictDeltaMsgEBGUAttrFloat_Float.Value = current.Value;
			dictDeltaMsgEBGUAttrFloat_Float.Version = version;
			dictDeltaMsgEBGUAttrFloat_Float.Op = OPType.Add;
			Data.Add(dictDeltaMsgEBGUAttrFloat_Float);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
