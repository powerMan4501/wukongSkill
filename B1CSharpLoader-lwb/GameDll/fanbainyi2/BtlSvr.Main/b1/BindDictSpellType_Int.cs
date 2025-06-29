using System;
using System.Collections.Generic;
using BtlB1;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictSpellType_Int : GSBindDictionary<SpellType, int>
{
	public delegate RepeatedField<DictDeltaMsgSpellType_Int> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgSpellType_Int> DeltaDataCache;

	private RepeatedField<DictDeltaMsgSpellType_Int> DeltaData
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
				OnRemove = (Action<SpellType, int>)Delegate.Combine(OnRemove, new Action<SpellType, int>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<SpellType, int>)Delegate.Remove(OnRemove, new Action<SpellType, int>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictSpellType_Int()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(SpellType Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgSpellType_Int dictDeltaMsgSpellType_Int = new DictDeltaMsgSpellType_Int();
			DeltaData.Add(dictDeltaMsgSpellType_Int);
			dictDeltaMsgSpellType_Int.Idx = (int)Key;
			dictDeltaMsgSpellType_Int.Value = Value;
			dictDeltaMsgSpellType_Int.Op = OPType.Add;
			dictDeltaMsgSpellType_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(SpellType Key, int Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgSpellType_Int dictDeltaMsgSpellType_Int = new DictDeltaMsgSpellType_Int();
			DeltaData.Add(dictDeltaMsgSpellType_Int);
			dictDeltaMsgSpellType_Int.Idx = (int)Key;
			dictDeltaMsgSpellType_Int.Op = OPType.Remove;
			dictDeltaMsgSpellType_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(SpellType Key, int OldValue, int NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgSpellType_Int dictDeltaMsgSpellType_Int = new DictDeltaMsgSpellType_Int();
			DeltaData.Add(dictDeltaMsgSpellType_Int);
			dictDeltaMsgSpellType_Int.Idx = (int)Key;
			dictDeltaMsgSpellType_Int.Value = NewValue;
			dictDeltaMsgSpellType_Int.Op = OPType.Modify;
			dictDeltaMsgSpellType_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgSpellType_Int dictDeltaMsgSpellType_Int = new DictDeltaMsgSpellType_Int();
			DeltaData.Add(dictDeltaMsgSpellType_Int);
			dictDeltaMsgSpellType_Int.Op = OPType.Clear;
			dictDeltaMsgSpellType_Int.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgSpellType_Int> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgSpellType_Int
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<SpellType, int>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<SpellType, int> current = enumerator.Current;
			DictDeltaMsgSpellType_Int dictDeltaMsgSpellType_Int = new DictDeltaMsgSpellType_Int();
			dictDeltaMsgSpellType_Int.Idx = (int)current.Key;
			dictDeltaMsgSpellType_Int.Value = current.Value;
			dictDeltaMsgSpellType_Int.Version = version;
			dictDeltaMsgSpellType_Int.Op = OPType.Add;
			Data.Add(dictDeltaMsgSpellType_Int);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
