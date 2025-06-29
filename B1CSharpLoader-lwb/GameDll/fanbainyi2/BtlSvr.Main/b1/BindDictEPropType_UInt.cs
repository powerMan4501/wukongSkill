using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictEPropType_UInt : GSBindDictionary<EPropType, uint>
{
	public delegate RepeatedField<DictDeltaMsgEPropType_UInt> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgEPropType_UInt> DeltaDataCache;

	private RepeatedField<DictDeltaMsgEPropType_UInt> DeltaData
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
				OnRemove = (Action<EPropType, uint>)Delegate.Combine(OnRemove, new Action<EPropType, uint>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<EPropType, uint>)Delegate.Remove(OnRemove, new Action<EPropType, uint>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictEPropType_UInt()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(EPropType Key, uint Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEPropType_UInt dictDeltaMsgEPropType_UInt = new DictDeltaMsgEPropType_UInt();
			DeltaData.Add(dictDeltaMsgEPropType_UInt);
			dictDeltaMsgEPropType_UInt.Idx = (int)Key;
			dictDeltaMsgEPropType_UInt.Value = Value;
			dictDeltaMsgEPropType_UInt.Op = OPType.Add;
			dictDeltaMsgEPropType_UInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(EPropType Key, uint Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEPropType_UInt dictDeltaMsgEPropType_UInt = new DictDeltaMsgEPropType_UInt();
			DeltaData.Add(dictDeltaMsgEPropType_UInt);
			dictDeltaMsgEPropType_UInt.Idx = (int)Key;
			dictDeltaMsgEPropType_UInt.Op = OPType.Remove;
			dictDeltaMsgEPropType_UInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(EPropType Key, uint OldValue, uint NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEPropType_UInt dictDeltaMsgEPropType_UInt = new DictDeltaMsgEPropType_UInt();
			DeltaData.Add(dictDeltaMsgEPropType_UInt);
			dictDeltaMsgEPropType_UInt.Idx = (int)Key;
			dictDeltaMsgEPropType_UInt.Value = NewValue;
			dictDeltaMsgEPropType_UInt.Op = OPType.Modify;
			dictDeltaMsgEPropType_UInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgEPropType_UInt dictDeltaMsgEPropType_UInt = new DictDeltaMsgEPropType_UInt();
			DeltaData.Add(dictDeltaMsgEPropType_UInt);
			dictDeltaMsgEPropType_UInt.Op = OPType.Clear;
			dictDeltaMsgEPropType_UInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgEPropType_UInt> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgEPropType_UInt
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<EPropType, uint>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<EPropType, uint> current = enumerator.Current;
			DictDeltaMsgEPropType_UInt dictDeltaMsgEPropType_UInt = new DictDeltaMsgEPropType_UInt();
			dictDeltaMsgEPropType_UInt.Idx = (int)current.Key;
			dictDeltaMsgEPropType_UInt.Value = current.Value;
			dictDeltaMsgEPropType_UInt.Version = version;
			dictDeltaMsgEPropType_UInt.Op = OPType.Add;
			Data.Add(dictDeltaMsgEPropType_UInt);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
