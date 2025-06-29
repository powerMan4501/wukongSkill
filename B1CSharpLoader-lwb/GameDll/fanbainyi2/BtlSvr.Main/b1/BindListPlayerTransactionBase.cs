using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListPlayerTransactionBase : GSBindList<PlayerTransactionBase>
{
	public delegate RepeatedField<ListDeltaMsgPlayerTransactionBase> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgPlayerTransactionBase> DeltaDataCache;

	private RepeatedField<ListDeltaMsgPlayerTransactionBase> DeltaData
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
						ListDeltaMsgPlayerTransactionBase listDeltaMsgPlayerTransactionBase = new ListDeltaMsgPlayerTransactionBase
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgPlayerTransactionBase);
						return listDeltaMsgPlayerTransactionBase.Value;
					}
					return (RepeatedField<ClassDeltaMsgPlayerTransactionBase>)null;
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

	public BindListPlayerTransactionBase()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(PlayerTransactionBase Value)
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
				ListDeltaMsgPlayerTransactionBase listDeltaMsgPlayerTransactionBase2 = new ListDeltaMsgPlayerTransactionBase
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgPlayerTransactionBase2);
				return listDeltaMsgPlayerTransactionBase2.Value;
			}
			return (RepeatedField<ClassDeltaMsgPlayerTransactionBase>)null;
		});
		ListDeltaMsgPlayerTransactionBase listDeltaMsgPlayerTransactionBase = new ListDeltaMsgPlayerTransactionBase();
		DeltaData.Add(listDeltaMsgPlayerTransactionBase);
		Value?.DumpFull(listDeltaMsgPlayerTransactionBase.Value);
		listDeltaMsgPlayerTransactionBase.Op = OPType.Add;
		listDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, PlayerTransactionBase Value)
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
					ListDeltaMsgPlayerTransactionBase listDeltaMsgPlayerTransactionBase2 = new ListDeltaMsgPlayerTransactionBase
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgPlayerTransactionBase2);
					return listDeltaMsgPlayerTransactionBase2.Value;
				}
				return (RepeatedField<ClassDeltaMsgPlayerTransactionBase>)null;
			});
		}
		ListDeltaMsgPlayerTransactionBase listDeltaMsgPlayerTransactionBase = new ListDeltaMsgPlayerTransactionBase();
		DeltaData.Add(listDeltaMsgPlayerTransactionBase);
		listDeltaMsgPlayerTransactionBase.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgPlayerTransactionBase.Op = OPType.Remove;
		listDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, PlayerTransactionBase OldValue, PlayerTransactionBase NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgPlayerTransactionBase listDeltaMsgPlayerTransactionBase = new ListDeltaMsgPlayerTransactionBase();
		DeltaData.Add(listDeltaMsgPlayerTransactionBase);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgPlayerTransactionBase listDeltaMsgPlayerTransactionBase2 = new ListDeltaMsgPlayerTransactionBase
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgPlayerTransactionBase2);
				return listDeltaMsgPlayerTransactionBase2.Value;
			}
			return (RepeatedField<ClassDeltaMsgPlayerTransactionBase>)null;
		});
		NewValue?.DumpFull(listDeltaMsgPlayerTransactionBase.Value);
		listDeltaMsgPlayerTransactionBase.Idx = (uint)Idx;
		listDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
		listDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<PlayerTransactionBase> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				PlayerTransactionBase current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgPlayerTransactionBase listDeltaMsgPlayerTransactionBase = new ListDeltaMsgPlayerTransactionBase();
		DeltaData.Add(listDeltaMsgPlayerTransactionBase);
		listDeltaMsgPlayerTransactionBase.Op = OPType.Clear;
		listDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgPlayerTransactionBase> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgPlayerTransactionBase
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			PlayerTransactionBase playerTransactionBase = base[i];
			ListDeltaMsgPlayerTransactionBase listDeltaMsgPlayerTransactionBase = new ListDeltaMsgPlayerTransactionBase();
			playerTransactionBase.DumpFull(listDeltaMsgPlayerTransactionBase.Value);
			listDeltaMsgPlayerTransactionBase.Version = version;
			listDeltaMsgPlayerTransactionBase.Op = OPType.Add;
			Data.Add(listDeltaMsgPlayerTransactionBase);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<PlayerTransactionBase> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
