using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictInt_BindListBindListEntity : GSBindDictionary<int, BindListBindListEntity>
{
	public delegate RepeatedField<DictDeltaMsgInt_BindListBindListEntity> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgInt_BindListBindListEntity> DeltaDataCache;

	private RepeatedField<DictDeltaMsgInt_BindListBindListEntity> DeltaData
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
		using Dictionary<int, BindListBindListEntity>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, BindListBindListEntity> Item = enumerator.Current;
			if (IsActive)
			{
				Item.Value.RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						DictDeltaMsgInt_BindListBindListEntity dictDeltaMsgInt_BindListBindListEntity = new DictDeltaMsgInt_BindListBindListEntity
						{
							Idx = Item.Key,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(dictDeltaMsgInt_BindListBindListEntity);
						return dictDeltaMsgInt_BindListBindListEntity.Value;
					}
					return (RepeatedField<ListDeltaMsgBindListEntity>)null;
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
				OnRemove = (Action<int, BindListBindListEntity>)Delegate.Combine(OnRemove, new Action<int, BindListBindListEntity>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<int, BindListBindListEntity>)Delegate.Remove(OnRemove, new Action<int, BindListBindListEntity>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictInt_BindListBindListEntity()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Key, BindListBindListEntity Value)
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
				DictDeltaMsgInt_BindListBindListEntity dictDeltaMsgInt_BindListBindListEntity2 = new DictDeltaMsgInt_BindListBindListEntity
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_BindListBindListEntity2);
				return dictDeltaMsgInt_BindListBindListEntity2.Value;
			}
			return (RepeatedField<ListDeltaMsgBindListEntity>)null;
		});
		DictDeltaMsgInt_BindListBindListEntity dictDeltaMsgInt_BindListBindListEntity = new DictDeltaMsgInt_BindListBindListEntity();
		DeltaData.Add(dictDeltaMsgInt_BindListBindListEntity);
		dictDeltaMsgInt_BindListBindListEntity.Idx = Key;
		Value?.DumpFull(dictDeltaMsgInt_BindListBindListEntity.Value);
		dictDeltaMsgInt_BindListBindListEntity.Op = OPType.Add;
		dictDeltaMsgInt_BindListBindListEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Key, BindListBindListEntity Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_BindListBindListEntity dictDeltaMsgInt_BindListBindListEntity = new DictDeltaMsgInt_BindListBindListEntity();
			DeltaData.Add(dictDeltaMsgInt_BindListBindListEntity);
			dictDeltaMsgInt_BindListBindListEntity.Idx = Key;
			Value?.ClearDeltaData();
			Value?.RegGetDeltaDataFunc(null);
			dictDeltaMsgInt_BindListBindListEntity.Op = OPType.Remove;
			dictDeltaMsgInt_BindListBindListEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(int Key, BindListBindListEntity OldValue, BindListBindListEntity NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		DictDeltaMsgInt_BindListBindListEntity dictDeltaMsgInt_BindListBindListEntity = new DictDeltaMsgInt_BindListBindListEntity();
		DeltaData.Add(dictDeltaMsgInt_BindListBindListEntity);
		dictDeltaMsgInt_BindListBindListEntity.Idx = Key;
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				DictDeltaMsgInt_BindListBindListEntity dictDeltaMsgInt_BindListBindListEntity2 = new DictDeltaMsgInt_BindListBindListEntity
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_BindListBindListEntity2);
				return dictDeltaMsgInt_BindListBindListEntity2.Value;
			}
			return (RepeatedField<ListDeltaMsgBindListEntity>)null;
		});
		NewValue?.DumpFull(dictDeltaMsgInt_BindListBindListEntity.Value);
		dictDeltaMsgInt_BindListBindListEntity.Op = OPType.Modify;
		dictDeltaMsgInt_BindListBindListEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (Dictionary<int, BindListBindListEntity>.Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<int, BindListBindListEntity> current = enumerator.Current;
				current.Value?.ClearDeltaData();
				current.Value?.RegGetDeltaDataFunc(null);
			}
		}
		DictDeltaMsgInt_BindListBindListEntity dictDeltaMsgInt_BindListBindListEntity = new DictDeltaMsgInt_BindListBindListEntity();
		DeltaData.Add(dictDeltaMsgInt_BindListBindListEntity);
		dictDeltaMsgInt_BindListBindListEntity.Op = OPType.Clear;
		dictDeltaMsgInt_BindListBindListEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<DictDeltaMsgInt_BindListBindListEntity> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgInt_BindListBindListEntity
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<int, BindListBindListEntity>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, BindListBindListEntity> current = enumerator.Current;
			DictDeltaMsgInt_BindListBindListEntity dictDeltaMsgInt_BindListBindListEntity = new DictDeltaMsgInt_BindListBindListEntity();
			dictDeltaMsgInt_BindListBindListEntity.Idx = current.Key;
			current.Value.DumpFull(dictDeltaMsgInt_BindListBindListEntity.Value);
			dictDeltaMsgInt_BindListBindListEntity.Version = version;
			dictDeltaMsgInt_BindListBindListEntity.Op = OPType.Add;
			Data.Add(dictDeltaMsgInt_BindListBindListEntity);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using Dictionary<int, BindListBindListEntity>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value?.ClearDeltaData();
		}
	}
}
