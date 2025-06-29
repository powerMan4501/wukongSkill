using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictInt_CollectionGroupDataInfo : GSBindDictionary<int, CollectionGroupDataInfo>
{
	public delegate RepeatedField<DictDeltaMsgInt_CollectionGroupDataInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgInt_CollectionGroupDataInfo> DeltaDataCache;

	private RepeatedField<DictDeltaMsgInt_CollectionGroupDataInfo> DeltaData
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
		using Dictionary<int, CollectionGroupDataInfo>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, CollectionGroupDataInfo> Item = enumerator.Current;
			if (IsActive)
			{
				Item.Value.RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						DictDeltaMsgInt_CollectionGroupDataInfo dictDeltaMsgInt_CollectionGroupDataInfo = new DictDeltaMsgInt_CollectionGroupDataInfo
						{
							Idx = Item.Key,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(dictDeltaMsgInt_CollectionGroupDataInfo);
						return dictDeltaMsgInt_CollectionGroupDataInfo.Value;
					}
					return (RepeatedField<ClassDeltaMsgCollectionGroupDataInfo>)null;
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
				OnRemove = (Action<int, CollectionGroupDataInfo>)Delegate.Combine(OnRemove, new Action<int, CollectionGroupDataInfo>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<int, CollectionGroupDataInfo>)Delegate.Remove(OnRemove, new Action<int, CollectionGroupDataInfo>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictInt_CollectionGroupDataInfo()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Key, CollectionGroupDataInfo Value)
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
				DictDeltaMsgInt_CollectionGroupDataInfo dictDeltaMsgInt_CollectionGroupDataInfo2 = new DictDeltaMsgInt_CollectionGroupDataInfo
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_CollectionGroupDataInfo2);
				return dictDeltaMsgInt_CollectionGroupDataInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgCollectionGroupDataInfo>)null;
		});
		DictDeltaMsgInt_CollectionGroupDataInfo dictDeltaMsgInt_CollectionGroupDataInfo = new DictDeltaMsgInt_CollectionGroupDataInfo();
		DeltaData.Add(dictDeltaMsgInt_CollectionGroupDataInfo);
		dictDeltaMsgInt_CollectionGroupDataInfo.Idx = Key;
		Value?.DumpFull(dictDeltaMsgInt_CollectionGroupDataInfo.Value);
		dictDeltaMsgInt_CollectionGroupDataInfo.Op = OPType.Add;
		dictDeltaMsgInt_CollectionGroupDataInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Key, CollectionGroupDataInfo Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_CollectionGroupDataInfo dictDeltaMsgInt_CollectionGroupDataInfo = new DictDeltaMsgInt_CollectionGroupDataInfo();
			DeltaData.Add(dictDeltaMsgInt_CollectionGroupDataInfo);
			dictDeltaMsgInt_CollectionGroupDataInfo.Idx = Key;
			Value?.ClearDeltaData();
			Value?.RegGetDeltaDataFunc(null);
			dictDeltaMsgInt_CollectionGroupDataInfo.Op = OPType.Remove;
			dictDeltaMsgInt_CollectionGroupDataInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(int Key, CollectionGroupDataInfo OldValue, CollectionGroupDataInfo NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		DictDeltaMsgInt_CollectionGroupDataInfo dictDeltaMsgInt_CollectionGroupDataInfo = new DictDeltaMsgInt_CollectionGroupDataInfo();
		DeltaData.Add(dictDeltaMsgInt_CollectionGroupDataInfo);
		dictDeltaMsgInt_CollectionGroupDataInfo.Idx = Key;
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				DictDeltaMsgInt_CollectionGroupDataInfo dictDeltaMsgInt_CollectionGroupDataInfo2 = new DictDeltaMsgInt_CollectionGroupDataInfo
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_CollectionGroupDataInfo2);
				return dictDeltaMsgInt_CollectionGroupDataInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgCollectionGroupDataInfo>)null;
		});
		NewValue?.DumpFull(dictDeltaMsgInt_CollectionGroupDataInfo.Value);
		dictDeltaMsgInt_CollectionGroupDataInfo.Op = OPType.Modify;
		dictDeltaMsgInt_CollectionGroupDataInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (Dictionary<int, CollectionGroupDataInfo>.Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<int, CollectionGroupDataInfo> current = enumerator.Current;
				current.Value?.ClearDeltaData();
				current.Value?.RegGetDeltaDataFunc(null);
			}
		}
		DictDeltaMsgInt_CollectionGroupDataInfo dictDeltaMsgInt_CollectionGroupDataInfo = new DictDeltaMsgInt_CollectionGroupDataInfo();
		DeltaData.Add(dictDeltaMsgInt_CollectionGroupDataInfo);
		dictDeltaMsgInt_CollectionGroupDataInfo.Op = OPType.Clear;
		dictDeltaMsgInt_CollectionGroupDataInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<DictDeltaMsgInt_CollectionGroupDataInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgInt_CollectionGroupDataInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<int, CollectionGroupDataInfo>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, CollectionGroupDataInfo> current = enumerator.Current;
			DictDeltaMsgInt_CollectionGroupDataInfo dictDeltaMsgInt_CollectionGroupDataInfo = new DictDeltaMsgInt_CollectionGroupDataInfo();
			dictDeltaMsgInt_CollectionGroupDataInfo.Idx = current.Key;
			current.Value.DumpFull(dictDeltaMsgInt_CollectionGroupDataInfo.Value);
			dictDeltaMsgInt_CollectionGroupDataInfo.Version = version;
			dictDeltaMsgInt_CollectionGroupDataInfo.Op = OPType.Add;
			Data.Add(dictDeltaMsgInt_CollectionGroupDataInfo);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using Dictionary<int, CollectionGroupDataInfo>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value?.ClearDeltaData();
		}
	}
}
