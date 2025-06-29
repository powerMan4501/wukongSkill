using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListBindListUnitLockTargetInfo : GSBindList<BindListUnitLockTargetInfo>
{
	public delegate RepeatedField<ListDeltaMsgBindListUnitLockTargetInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgBindListUnitLockTargetInfo> DeltaDataCache;

	private RepeatedField<ListDeltaMsgBindListUnitLockTargetInfo> DeltaData
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
						ListDeltaMsgBindListUnitLockTargetInfo listDeltaMsgBindListUnitLockTargetInfo = new ListDeltaMsgBindListUnitLockTargetInfo
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgBindListUnitLockTargetInfo);
						return listDeltaMsgBindListUnitLockTargetInfo.Value;
					}
					return (RepeatedField<ListDeltaMsgUnitLockTargetInfo>)null;
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

	public BindListBindListUnitLockTargetInfo()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(BindListUnitLockTargetInfo Value)
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
				ListDeltaMsgBindListUnitLockTargetInfo listDeltaMsgBindListUnitLockTargetInfo2 = new ListDeltaMsgBindListUnitLockTargetInfo
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgBindListUnitLockTargetInfo2);
				return listDeltaMsgBindListUnitLockTargetInfo2.Value;
			}
			return (RepeatedField<ListDeltaMsgUnitLockTargetInfo>)null;
		});
		ListDeltaMsgBindListUnitLockTargetInfo listDeltaMsgBindListUnitLockTargetInfo = new ListDeltaMsgBindListUnitLockTargetInfo();
		DeltaData.Add(listDeltaMsgBindListUnitLockTargetInfo);
		Value?.DumpFull(listDeltaMsgBindListUnitLockTargetInfo.Value);
		listDeltaMsgBindListUnitLockTargetInfo.Op = OPType.Add;
		listDeltaMsgBindListUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, BindListUnitLockTargetInfo Value)
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
					ListDeltaMsgBindListUnitLockTargetInfo listDeltaMsgBindListUnitLockTargetInfo2 = new ListDeltaMsgBindListUnitLockTargetInfo
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgBindListUnitLockTargetInfo2);
					return listDeltaMsgBindListUnitLockTargetInfo2.Value;
				}
				return (RepeatedField<ListDeltaMsgUnitLockTargetInfo>)null;
			});
		}
		ListDeltaMsgBindListUnitLockTargetInfo listDeltaMsgBindListUnitLockTargetInfo = new ListDeltaMsgBindListUnitLockTargetInfo();
		DeltaData.Add(listDeltaMsgBindListUnitLockTargetInfo);
		listDeltaMsgBindListUnitLockTargetInfo.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgBindListUnitLockTargetInfo.Op = OPType.Remove;
		listDeltaMsgBindListUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, BindListUnitLockTargetInfo OldValue, BindListUnitLockTargetInfo NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgBindListUnitLockTargetInfo listDeltaMsgBindListUnitLockTargetInfo = new ListDeltaMsgBindListUnitLockTargetInfo();
		DeltaData.Add(listDeltaMsgBindListUnitLockTargetInfo);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgBindListUnitLockTargetInfo listDeltaMsgBindListUnitLockTargetInfo2 = new ListDeltaMsgBindListUnitLockTargetInfo
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgBindListUnitLockTargetInfo2);
				return listDeltaMsgBindListUnitLockTargetInfo2.Value;
			}
			return (RepeatedField<ListDeltaMsgUnitLockTargetInfo>)null;
		});
		NewValue?.DumpFull(listDeltaMsgBindListUnitLockTargetInfo.Value);
		listDeltaMsgBindListUnitLockTargetInfo.Idx = (uint)Idx;
		listDeltaMsgBindListUnitLockTargetInfo.Op = OPType.Modify;
		listDeltaMsgBindListUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<BindListUnitLockTargetInfo> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				BindListUnitLockTargetInfo current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgBindListUnitLockTargetInfo listDeltaMsgBindListUnitLockTargetInfo = new ListDeltaMsgBindListUnitLockTargetInfo();
		DeltaData.Add(listDeltaMsgBindListUnitLockTargetInfo);
		listDeltaMsgBindListUnitLockTargetInfo.Op = OPType.Clear;
		listDeltaMsgBindListUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgBindListUnitLockTargetInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgBindListUnitLockTargetInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			BindListUnitLockTargetInfo bindListUnitLockTargetInfo = base[i];
			ListDeltaMsgBindListUnitLockTargetInfo listDeltaMsgBindListUnitLockTargetInfo = new ListDeltaMsgBindListUnitLockTargetInfo();
			bindListUnitLockTargetInfo.DumpFull(listDeltaMsgBindListUnitLockTargetInfo.Value);
			listDeltaMsgBindListUnitLockTargetInfo.Version = version;
			listDeltaMsgBindListUnitLockTargetInfo.Op = OPType.Add;
			Data.Add(listDeltaMsgBindListUnitLockTargetInfo);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<BindListUnitLockTargetInfo> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
