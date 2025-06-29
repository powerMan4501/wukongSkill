using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListPlayerTransactionTaskBase : GSBindList<PlayerTransactionTaskBase>
{
	public delegate RepeatedField<ListDeltaMsgPlayerTransactionTaskBase> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgPlayerTransactionTaskBase> DeltaDataCache;

	private RepeatedField<ListDeltaMsgPlayerTransactionTaskBase> DeltaData
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
						ListDeltaMsgPlayerTransactionTaskBase listDeltaMsgPlayerTransactionTaskBase = new ListDeltaMsgPlayerTransactionTaskBase
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgPlayerTransactionTaskBase);
						return listDeltaMsgPlayerTransactionTaskBase.Value;
					}
					return (RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase>)null;
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

	public BindListPlayerTransactionTaskBase()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(PlayerTransactionTaskBase Value)
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
				ListDeltaMsgPlayerTransactionTaskBase listDeltaMsgPlayerTransactionTaskBase2 = new ListDeltaMsgPlayerTransactionTaskBase
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgPlayerTransactionTaskBase2);
				return listDeltaMsgPlayerTransactionTaskBase2.Value;
			}
			return (RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase>)null;
		});
		ListDeltaMsgPlayerTransactionTaskBase listDeltaMsgPlayerTransactionTaskBase = new ListDeltaMsgPlayerTransactionTaskBase();
		DeltaData.Add(listDeltaMsgPlayerTransactionTaskBase);
		Value?.DumpFull(listDeltaMsgPlayerTransactionTaskBase.Value);
		listDeltaMsgPlayerTransactionTaskBase.Op = OPType.Add;
		listDeltaMsgPlayerTransactionTaskBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, PlayerTransactionTaskBase Value)
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
					ListDeltaMsgPlayerTransactionTaskBase listDeltaMsgPlayerTransactionTaskBase2 = new ListDeltaMsgPlayerTransactionTaskBase
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgPlayerTransactionTaskBase2);
					return listDeltaMsgPlayerTransactionTaskBase2.Value;
				}
				return (RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase>)null;
			});
		}
		ListDeltaMsgPlayerTransactionTaskBase listDeltaMsgPlayerTransactionTaskBase = new ListDeltaMsgPlayerTransactionTaskBase();
		DeltaData.Add(listDeltaMsgPlayerTransactionTaskBase);
		listDeltaMsgPlayerTransactionTaskBase.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgPlayerTransactionTaskBase.Op = OPType.Remove;
		listDeltaMsgPlayerTransactionTaskBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, PlayerTransactionTaskBase OldValue, PlayerTransactionTaskBase NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgPlayerTransactionTaskBase listDeltaMsgPlayerTransactionTaskBase = new ListDeltaMsgPlayerTransactionTaskBase();
		DeltaData.Add(listDeltaMsgPlayerTransactionTaskBase);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgPlayerTransactionTaskBase listDeltaMsgPlayerTransactionTaskBase2 = new ListDeltaMsgPlayerTransactionTaskBase
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgPlayerTransactionTaskBase2);
				return listDeltaMsgPlayerTransactionTaskBase2.Value;
			}
			return (RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase>)null;
		});
		NewValue?.DumpFull(listDeltaMsgPlayerTransactionTaskBase.Value);
		listDeltaMsgPlayerTransactionTaskBase.Idx = (uint)Idx;
		listDeltaMsgPlayerTransactionTaskBase.Op = OPType.Modify;
		listDeltaMsgPlayerTransactionTaskBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<PlayerTransactionTaskBase> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				PlayerTransactionTaskBase current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgPlayerTransactionTaskBase listDeltaMsgPlayerTransactionTaskBase = new ListDeltaMsgPlayerTransactionTaskBase();
		DeltaData.Add(listDeltaMsgPlayerTransactionTaskBase);
		listDeltaMsgPlayerTransactionTaskBase.Op = OPType.Clear;
		listDeltaMsgPlayerTransactionTaskBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgPlayerTransactionTaskBase> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgPlayerTransactionTaskBase
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			PlayerTransactionTaskBase playerTransactionTaskBase = base[i];
			ListDeltaMsgPlayerTransactionTaskBase listDeltaMsgPlayerTransactionTaskBase = new ListDeltaMsgPlayerTransactionTaskBase();
			playerTransactionTaskBase.DumpFull(listDeltaMsgPlayerTransactionTaskBase.Value);
			listDeltaMsgPlayerTransactionTaskBase.Version = version;
			listDeltaMsgPlayerTransactionTaskBase.Op = OPType.Add;
			Data.Add(listDeltaMsgPlayerTransactionTaskBase);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<PlayerTransactionTaskBase> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
