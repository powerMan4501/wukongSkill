using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListPlayerPersistentAttr : GSBindList<PlayerPersistentAttr>
{
	public delegate RepeatedField<ListDeltaMsgPlayerPersistentAttr> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgPlayerPersistentAttr> DeltaDataCache;

	private RepeatedField<ListDeltaMsgPlayerPersistentAttr> DeltaData
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
						ListDeltaMsgPlayerPersistentAttr listDeltaMsgPlayerPersistentAttr = new ListDeltaMsgPlayerPersistentAttr
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgPlayerPersistentAttr);
						return listDeltaMsgPlayerPersistentAttr.Value;
					}
					return (RepeatedField<ClassDeltaMsgPlayerPersistentAttr>)null;
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

	public BindListPlayerPersistentAttr()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(PlayerPersistentAttr Value)
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
				ListDeltaMsgPlayerPersistentAttr listDeltaMsgPlayerPersistentAttr2 = new ListDeltaMsgPlayerPersistentAttr
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgPlayerPersistentAttr2);
				return listDeltaMsgPlayerPersistentAttr2.Value;
			}
			return (RepeatedField<ClassDeltaMsgPlayerPersistentAttr>)null;
		});
		ListDeltaMsgPlayerPersistentAttr listDeltaMsgPlayerPersistentAttr = new ListDeltaMsgPlayerPersistentAttr();
		DeltaData.Add(listDeltaMsgPlayerPersistentAttr);
		Value?.DumpFull(listDeltaMsgPlayerPersistentAttr.Value);
		listDeltaMsgPlayerPersistentAttr.Op = OPType.Add;
		listDeltaMsgPlayerPersistentAttr.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, PlayerPersistentAttr Value)
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
					ListDeltaMsgPlayerPersistentAttr listDeltaMsgPlayerPersistentAttr2 = new ListDeltaMsgPlayerPersistentAttr
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgPlayerPersistentAttr2);
					return listDeltaMsgPlayerPersistentAttr2.Value;
				}
				return (RepeatedField<ClassDeltaMsgPlayerPersistentAttr>)null;
			});
		}
		ListDeltaMsgPlayerPersistentAttr listDeltaMsgPlayerPersistentAttr = new ListDeltaMsgPlayerPersistentAttr();
		DeltaData.Add(listDeltaMsgPlayerPersistentAttr);
		listDeltaMsgPlayerPersistentAttr.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgPlayerPersistentAttr.Op = OPType.Remove;
		listDeltaMsgPlayerPersistentAttr.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, PlayerPersistentAttr OldValue, PlayerPersistentAttr NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgPlayerPersistentAttr listDeltaMsgPlayerPersistentAttr = new ListDeltaMsgPlayerPersistentAttr();
		DeltaData.Add(listDeltaMsgPlayerPersistentAttr);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgPlayerPersistentAttr listDeltaMsgPlayerPersistentAttr2 = new ListDeltaMsgPlayerPersistentAttr
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgPlayerPersistentAttr2);
				return listDeltaMsgPlayerPersistentAttr2.Value;
			}
			return (RepeatedField<ClassDeltaMsgPlayerPersistentAttr>)null;
		});
		NewValue?.DumpFull(listDeltaMsgPlayerPersistentAttr.Value);
		listDeltaMsgPlayerPersistentAttr.Idx = (uint)Idx;
		listDeltaMsgPlayerPersistentAttr.Op = OPType.Modify;
		listDeltaMsgPlayerPersistentAttr.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<PlayerPersistentAttr> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				PlayerPersistentAttr current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgPlayerPersistentAttr listDeltaMsgPlayerPersistentAttr = new ListDeltaMsgPlayerPersistentAttr();
		DeltaData.Add(listDeltaMsgPlayerPersistentAttr);
		listDeltaMsgPlayerPersistentAttr.Op = OPType.Clear;
		listDeltaMsgPlayerPersistentAttr.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgPlayerPersistentAttr> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgPlayerPersistentAttr
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			PlayerPersistentAttr playerPersistentAttr = base[i];
			ListDeltaMsgPlayerPersistentAttr listDeltaMsgPlayerPersistentAttr = new ListDeltaMsgPlayerPersistentAttr();
			playerPersistentAttr.DumpFull(listDeltaMsgPlayerPersistentAttr.Value);
			listDeltaMsgPlayerPersistentAttr.Version = version;
			listDeltaMsgPlayerPersistentAttr.Op = OPType.Add;
			Data.Add(listDeltaMsgPlayerPersistentAttr);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<PlayerPersistentAttr> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
