using System;
using System.Collections.Generic;
using BtlB1;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictEquipPosition_Int : GSBindDictionary<EquipPosition, int>
{
	public delegate RepeatedField<DictDeltaMsgEquipPosition_Int> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgEquipPosition_Int> DeltaDataCache;

	private RepeatedField<DictDeltaMsgEquipPosition_Int> DeltaData
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
				OnRemove = (Action<EquipPosition, int>)Delegate.Combine(OnRemove, new Action<EquipPosition, int>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<EquipPosition, int>)Delegate.Remove(OnRemove, new Action<EquipPosition, int>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictEquipPosition_Int()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(EquipPosition Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEquipPosition_Int dictDeltaMsgEquipPosition_Int = new DictDeltaMsgEquipPosition_Int();
			DeltaData.Add(dictDeltaMsgEquipPosition_Int);
			dictDeltaMsgEquipPosition_Int.Idx = (int)Key;
			dictDeltaMsgEquipPosition_Int.Value = Value;
			dictDeltaMsgEquipPosition_Int.Op = OPType.Add;
			dictDeltaMsgEquipPosition_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(EquipPosition Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEquipPosition_Int dictDeltaMsgEquipPosition_Int = new DictDeltaMsgEquipPosition_Int();
			DeltaData.Add(dictDeltaMsgEquipPosition_Int);
			dictDeltaMsgEquipPosition_Int.Idx = (int)Key;
			dictDeltaMsgEquipPosition_Int.Op = OPType.Remove;
			dictDeltaMsgEquipPosition_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(EquipPosition Key, int OldValue, int NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgEquipPosition_Int dictDeltaMsgEquipPosition_Int = new DictDeltaMsgEquipPosition_Int();
			DeltaData.Add(dictDeltaMsgEquipPosition_Int);
			dictDeltaMsgEquipPosition_Int.Idx = (int)Key;
			dictDeltaMsgEquipPosition_Int.Value = NewValue;
			dictDeltaMsgEquipPosition_Int.Op = OPType.Modify;
			dictDeltaMsgEquipPosition_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgEquipPosition_Int dictDeltaMsgEquipPosition_Int = new DictDeltaMsgEquipPosition_Int();
			DeltaData.Add(dictDeltaMsgEquipPosition_Int);
			dictDeltaMsgEquipPosition_Int.Op = OPType.Clear;
			dictDeltaMsgEquipPosition_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgEquipPosition_Int> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgEquipPosition_Int
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<EquipPosition, int>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<EquipPosition, int> current = enumerator.Current;
			DictDeltaMsgEquipPosition_Int dictDeltaMsgEquipPosition_Int = new DictDeltaMsgEquipPosition_Int();
			dictDeltaMsgEquipPosition_Int.Idx = (int)current.Key;
			dictDeltaMsgEquipPosition_Int.Value = current.Value;
			dictDeltaMsgEquipPosition_Int.Version = version;
			dictDeltaMsgEquipPosition_Int.Op = OPType.Add;
			Data.Add(dictDeltaMsgEquipPosition_Int);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
