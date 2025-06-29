using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListBindListEntity : GSBindList<BindListEntity>
{
	public delegate RepeatedField<ListDeltaMsgBindListEntity> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgBindListEntity> DeltaDataCache;

	private RepeatedField<ListDeltaMsgBindListEntity> DeltaData
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
		for (int i = 0; i < base.Count; i++)
		{
			uint ItemIdx = (uint)i;
			if (IsActive)
			{
				base[i].RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						ListDeltaMsgBindListEntity listDeltaMsgBindListEntity = new ListDeltaMsgBindListEntity
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgBindListEntity);
						return listDeltaMsgBindListEntity.Value;
					}
					return (RepeatedField<ListDeltaMsgEntity>)null;
				});
			}
			else
			{
				base[i].RegGetDeltaDataFunc(null);
			}
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
				base.OnRemove += OnRemoveImpl;
				base.OnSetIdxValue += OnSetIdxValueImpl;
				OnClear = (Action)Delegate.Combine(OnClear, new Action(OnClearImpl));
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				base.OnRemove -= OnRemoveImpl;
				base.OnSetIdxValue -= OnSetIdxValueImpl;
				OnClear = (Action)Delegate.Remove(OnClear, new Action(OnClearImpl));
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindListBindListEntity()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(BindListEntity Value)
	{
		if (DeltaData == null)
		{
			return;
		}
		Value?.ClearDeltaData();
		int Idx = base.Count - 1;
		Value?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgBindListEntity listDeltaMsgBindListEntity2 = new ListDeltaMsgBindListEntity
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgBindListEntity2);
				return listDeltaMsgBindListEntity2.Value;
			}
			return (RepeatedField<ListDeltaMsgEntity>)null;
		});
		ListDeltaMsgBindListEntity listDeltaMsgBindListEntity = new ListDeltaMsgBindListEntity();
		DeltaData.Add(listDeltaMsgBindListEntity);
		Value?.DumpFull(listDeltaMsgBindListEntity.Value);
		listDeltaMsgBindListEntity.Op = OPType.Add;
		listDeltaMsgBindListEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, BindListEntity Value)
	{
		if (DeltaData == null)
		{
			return;
		}
		for (int i = 0; i < base.Count; i++)
		{
			if (i <= Idx)
			{
				continue;
			}
			uint ItemIdx = (uint)(i - 1);
			base[i].RegGetDeltaDataFunc(delegate
			{
				if (DeltaData != null)
				{
					ListDeltaMsgBindListEntity listDeltaMsgBindListEntity2 = new ListDeltaMsgBindListEntity
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgBindListEntity2);
					return listDeltaMsgBindListEntity2.Value;
				}
				return (RepeatedField<ListDeltaMsgEntity>)null;
			});
		}
		ListDeltaMsgBindListEntity listDeltaMsgBindListEntity = new ListDeltaMsgBindListEntity();
		DeltaData.Add(listDeltaMsgBindListEntity);
		listDeltaMsgBindListEntity.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgBindListEntity.Op = OPType.Remove;
		listDeltaMsgBindListEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, BindListEntity OldValue, BindListEntity NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgBindListEntity listDeltaMsgBindListEntity = new ListDeltaMsgBindListEntity();
		DeltaData.Add(listDeltaMsgBindListEntity);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgBindListEntity listDeltaMsgBindListEntity2 = new ListDeltaMsgBindListEntity
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgBindListEntity2);
				return listDeltaMsgBindListEntity2.Value;
			}
			return (RepeatedField<ListDeltaMsgEntity>)null;
		});
		NewValue?.DumpFull(listDeltaMsgBindListEntity.Value);
		listDeltaMsgBindListEntity.Idx = (uint)Idx;
		listDeltaMsgBindListEntity.Op = OPType.Modify;
		listDeltaMsgBindListEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<BindListEntity> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				BindListEntity current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgBindListEntity listDeltaMsgBindListEntity = new ListDeltaMsgBindListEntity();
		DeltaData.Add(listDeltaMsgBindListEntity);
		listDeltaMsgBindListEntity.Op = OPType.Clear;
		listDeltaMsgBindListEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgBindListEntity> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgBindListEntity
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			BindListEntity bindListEntity = base[i];
			ListDeltaMsgBindListEntity listDeltaMsgBindListEntity = new ListDeltaMsgBindListEntity();
			bindListEntity.DumpFull(listDeltaMsgBindListEntity.Value);
			listDeltaMsgBindListEntity.Version = version;
			listDeltaMsgBindListEntity.Op = OPType.Add;
			Data.Add(listDeltaMsgBindListEntity);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<BindListEntity> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
