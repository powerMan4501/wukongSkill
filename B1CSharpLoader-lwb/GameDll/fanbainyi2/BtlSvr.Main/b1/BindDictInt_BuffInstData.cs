using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictInt_BuffInstData : GSBindDictionary<int, BuffInstData>
{
	public delegate RepeatedField<DictDeltaMsgInt_BuffInstData> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgInt_BuffInstData> DeltaDataCache;

	private RepeatedField<DictDeltaMsgInt_BuffInstData> DeltaData
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
		using Dictionary<int, BuffInstData>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, BuffInstData> Item = enumerator.Current;
			if (IsActive)
			{
				Item.Value.RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						DictDeltaMsgInt_BuffInstData dictDeltaMsgInt_BuffInstData = new DictDeltaMsgInt_BuffInstData
						{
							Idx = Item.Key,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(dictDeltaMsgInt_BuffInstData);
						return dictDeltaMsgInt_BuffInstData.Value;
					}
					return (RepeatedField<ClassDeltaMsgBuffInstData>)null;
				});
			}
			else
			{
				Item.Value.RegGetDeltaDataFunc(null);
			}
			Item.Value.RefreshGetDeltaDataFunc(IsActive);
		}
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
				OnRemove = (Action<int, BuffInstData>)Delegate.Combine(OnRemove, new Action<int, BuffInstData>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<int, BuffInstData>)Delegate.Remove(OnRemove, new Action<int, BuffInstData>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictInt_BuffInstData()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Key, BuffInstData Value)
	{
		if (DeltaData == null)
		{
			return;
		}
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				DictDeltaMsgInt_BuffInstData dictDeltaMsgInt_BuffInstData2 = new DictDeltaMsgInt_BuffInstData
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_BuffInstData2);
				return dictDeltaMsgInt_BuffInstData2.Value;
			}
			return (RepeatedField<ClassDeltaMsgBuffInstData>)null;
		});
		DictDeltaMsgInt_BuffInstData dictDeltaMsgInt_BuffInstData = new DictDeltaMsgInt_BuffInstData();
		DeltaData.Add(dictDeltaMsgInt_BuffInstData);
		dictDeltaMsgInt_BuffInstData.Idx = Key;
		Value?.DumpFull(dictDeltaMsgInt_BuffInstData.Value);
		dictDeltaMsgInt_BuffInstData.Op = OPType.Add;
		dictDeltaMsgInt_BuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Key, BuffInstData Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_BuffInstData dictDeltaMsgInt_BuffInstData = new DictDeltaMsgInt_BuffInstData();
			DeltaData.Add(dictDeltaMsgInt_BuffInstData);
			dictDeltaMsgInt_BuffInstData.Idx = Key;
			Value?.ClearDeltaData();
			Value?.RegGetDeltaDataFunc(null);
			dictDeltaMsgInt_BuffInstData.Op = OPType.Remove;
			dictDeltaMsgInt_BuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(int Key, BuffInstData OldValue, BuffInstData NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		DictDeltaMsgInt_BuffInstData dictDeltaMsgInt_BuffInstData = new DictDeltaMsgInt_BuffInstData();
		DeltaData.Add(dictDeltaMsgInt_BuffInstData);
		dictDeltaMsgInt_BuffInstData.Idx = Key;
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				DictDeltaMsgInt_BuffInstData dictDeltaMsgInt_BuffInstData2 = new DictDeltaMsgInt_BuffInstData
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_BuffInstData2);
				return dictDeltaMsgInt_BuffInstData2.Value;
			}
			return (RepeatedField<ClassDeltaMsgBuffInstData>)null;
		});
		NewValue?.DumpFull(dictDeltaMsgInt_BuffInstData.Value);
		dictDeltaMsgInt_BuffInstData.Op = OPType.Modify;
		dictDeltaMsgInt_BuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (Dictionary<int, BuffInstData>.Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<int, BuffInstData> current = enumerator.Current;
				current.Value?.ClearDeltaData();
				current.Value?.RegGetDeltaDataFunc(null);
			}
		}
		DictDeltaMsgInt_BuffInstData dictDeltaMsgInt_BuffInstData = new DictDeltaMsgInt_BuffInstData();
		DeltaData.Add(dictDeltaMsgInt_BuffInstData);
		dictDeltaMsgInt_BuffInstData.Op = OPType.Clear;
		dictDeltaMsgInt_BuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<DictDeltaMsgInt_BuffInstData> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgInt_BuffInstData
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<int, BuffInstData>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, BuffInstData> current = enumerator.Current;
			DictDeltaMsgInt_BuffInstData dictDeltaMsgInt_BuffInstData = new DictDeltaMsgInt_BuffInstData();
			dictDeltaMsgInt_BuffInstData.Idx = current.Key;
			current.Value.DumpFull(dictDeltaMsgInt_BuffInstData.Value);
			dictDeltaMsgInt_BuffInstData.Version = version;
			dictDeltaMsgInt_BuffInstData.Op = OPType.Add;
			Data.Add(dictDeltaMsgInt_BuffInstData);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using Dictionary<int, BuffInstData>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value?.ClearDeltaData();
		}
	}
}
