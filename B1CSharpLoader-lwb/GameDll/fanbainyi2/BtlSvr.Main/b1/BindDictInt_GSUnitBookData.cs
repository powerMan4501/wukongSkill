using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictInt_GSUnitBookData : GSBindDictionary<int, GSUnitBookData>
{
	public delegate RepeatedField<DictDeltaMsgInt_GSUnitBookData> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgInt_GSUnitBookData> DeltaDataCache;

	private RepeatedField<DictDeltaMsgInt_GSUnitBookData> DeltaData
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
		using Dictionary<int, GSUnitBookData>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, GSUnitBookData> Item = enumerator.Current;
			if (IsActive)
			{
				Item.Value.RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						DictDeltaMsgInt_GSUnitBookData dictDeltaMsgInt_GSUnitBookData = new DictDeltaMsgInt_GSUnitBookData
						{
							Idx = Item.Key,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(dictDeltaMsgInt_GSUnitBookData);
						return dictDeltaMsgInt_GSUnitBookData.Value;
					}
					return (RepeatedField<ClassDeltaMsgGSUnitBookData>)null;
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
				OnRemove = (Action<int, GSUnitBookData>)Delegate.Combine(OnRemove, new Action<int, GSUnitBookData>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<int, GSUnitBookData>)Delegate.Remove(OnRemove, new Action<int, GSUnitBookData>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictInt_GSUnitBookData()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Key, GSUnitBookData Value)
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
				DictDeltaMsgInt_GSUnitBookData dictDeltaMsgInt_GSUnitBookData2 = new DictDeltaMsgInt_GSUnitBookData
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_GSUnitBookData2);
				return dictDeltaMsgInt_GSUnitBookData2.Value;
			}
			return (RepeatedField<ClassDeltaMsgGSUnitBookData>)null;
		});
		DictDeltaMsgInt_GSUnitBookData dictDeltaMsgInt_GSUnitBookData = new DictDeltaMsgInt_GSUnitBookData();
		DeltaData.Add(dictDeltaMsgInt_GSUnitBookData);
		dictDeltaMsgInt_GSUnitBookData.Idx = Key;
		Value?.DumpFull(dictDeltaMsgInt_GSUnitBookData.Value);
		dictDeltaMsgInt_GSUnitBookData.Op = OPType.Add;
		dictDeltaMsgInt_GSUnitBookData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Key, GSUnitBookData Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_GSUnitBookData dictDeltaMsgInt_GSUnitBookData = new DictDeltaMsgInt_GSUnitBookData();
			DeltaData.Add(dictDeltaMsgInt_GSUnitBookData);
			dictDeltaMsgInt_GSUnitBookData.Idx = Key;
			Value?.ClearDeltaData();
			Value?.RegGetDeltaDataFunc(null);
			dictDeltaMsgInt_GSUnitBookData.Op = OPType.Remove;
			dictDeltaMsgInt_GSUnitBookData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(int Key, GSUnitBookData OldValue, GSUnitBookData NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		DictDeltaMsgInt_GSUnitBookData dictDeltaMsgInt_GSUnitBookData = new DictDeltaMsgInt_GSUnitBookData();
		DeltaData.Add(dictDeltaMsgInt_GSUnitBookData);
		dictDeltaMsgInt_GSUnitBookData.Idx = Key;
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				DictDeltaMsgInt_GSUnitBookData dictDeltaMsgInt_GSUnitBookData2 = new DictDeltaMsgInt_GSUnitBookData
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_GSUnitBookData2);
				return dictDeltaMsgInt_GSUnitBookData2.Value;
			}
			return (RepeatedField<ClassDeltaMsgGSUnitBookData>)null;
		});
		NewValue?.DumpFull(dictDeltaMsgInt_GSUnitBookData.Value);
		dictDeltaMsgInt_GSUnitBookData.Op = OPType.Modify;
		dictDeltaMsgInt_GSUnitBookData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (Dictionary<int, GSUnitBookData>.Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<int, GSUnitBookData> current = enumerator.Current;
				current.Value?.ClearDeltaData();
				current.Value?.RegGetDeltaDataFunc(null);
			}
		}
		DictDeltaMsgInt_GSUnitBookData dictDeltaMsgInt_GSUnitBookData = new DictDeltaMsgInt_GSUnitBookData();
		DeltaData.Add(dictDeltaMsgInt_GSUnitBookData);
		dictDeltaMsgInt_GSUnitBookData.Op = OPType.Clear;
		dictDeltaMsgInt_GSUnitBookData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<DictDeltaMsgInt_GSUnitBookData> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgInt_GSUnitBookData
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<int, GSUnitBookData>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, GSUnitBookData> current = enumerator.Current;
			DictDeltaMsgInt_GSUnitBookData dictDeltaMsgInt_GSUnitBookData = new DictDeltaMsgInt_GSUnitBookData();
			dictDeltaMsgInt_GSUnitBookData.Idx = current.Key;
			current.Value.DumpFull(dictDeltaMsgInt_GSUnitBookData.Value);
			dictDeltaMsgInt_GSUnitBookData.Version = version;
			dictDeltaMsgInt_GSUnitBookData.Op = OPType.Add;
			Data.Add(dictDeltaMsgInt_GSUnitBookData);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using Dictionary<int, GSUnitBookData>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value?.ClearDeltaData();
		}
	}
}
