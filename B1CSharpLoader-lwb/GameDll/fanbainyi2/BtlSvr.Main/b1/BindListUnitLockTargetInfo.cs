using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListUnitLockTargetInfo : GSBindList<UnitLockTargetInfo>
{
	public delegate RepeatedField<ListDeltaMsgUnitLockTargetInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgUnitLockTargetInfo> DeltaDataCache;

	private RepeatedField<ListDeltaMsgUnitLockTargetInfo> DeltaData
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
						ListDeltaMsgUnitLockTargetInfo listDeltaMsgUnitLockTargetInfo = new ListDeltaMsgUnitLockTargetInfo
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgUnitLockTargetInfo);
						return listDeltaMsgUnitLockTargetInfo.Value;
					}
					return (RepeatedField<ClassDeltaMsgUnitLockTargetInfo>)null;
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

	public BindListUnitLockTargetInfo()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(UnitLockTargetInfo Value)
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
				ListDeltaMsgUnitLockTargetInfo listDeltaMsgUnitLockTargetInfo2 = new ListDeltaMsgUnitLockTargetInfo
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgUnitLockTargetInfo2);
				return listDeltaMsgUnitLockTargetInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgUnitLockTargetInfo>)null;
		});
		ListDeltaMsgUnitLockTargetInfo listDeltaMsgUnitLockTargetInfo = new ListDeltaMsgUnitLockTargetInfo();
		DeltaData.Add(listDeltaMsgUnitLockTargetInfo);
		Value?.DumpFull(listDeltaMsgUnitLockTargetInfo.Value);
		listDeltaMsgUnitLockTargetInfo.Op = OPType.Add;
		listDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, UnitLockTargetInfo Value)
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
					ListDeltaMsgUnitLockTargetInfo listDeltaMsgUnitLockTargetInfo2 = new ListDeltaMsgUnitLockTargetInfo
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgUnitLockTargetInfo2);
					return listDeltaMsgUnitLockTargetInfo2.Value;
				}
				return (RepeatedField<ClassDeltaMsgUnitLockTargetInfo>)null;
			});
		}
		ListDeltaMsgUnitLockTargetInfo listDeltaMsgUnitLockTargetInfo = new ListDeltaMsgUnitLockTargetInfo();
		DeltaData.Add(listDeltaMsgUnitLockTargetInfo);
		listDeltaMsgUnitLockTargetInfo.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgUnitLockTargetInfo.Op = OPType.Remove;
		listDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, UnitLockTargetInfo OldValue, UnitLockTargetInfo NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgUnitLockTargetInfo listDeltaMsgUnitLockTargetInfo = new ListDeltaMsgUnitLockTargetInfo();
		DeltaData.Add(listDeltaMsgUnitLockTargetInfo);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgUnitLockTargetInfo listDeltaMsgUnitLockTargetInfo2 = new ListDeltaMsgUnitLockTargetInfo
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgUnitLockTargetInfo2);
				return listDeltaMsgUnitLockTargetInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgUnitLockTargetInfo>)null;
		});
		NewValue?.DumpFull(listDeltaMsgUnitLockTargetInfo.Value);
		listDeltaMsgUnitLockTargetInfo.Idx = (uint)Idx;
		listDeltaMsgUnitLockTargetInfo.Op = OPType.Modify;
		listDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<UnitLockTargetInfo> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				UnitLockTargetInfo current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgUnitLockTargetInfo listDeltaMsgUnitLockTargetInfo = new ListDeltaMsgUnitLockTargetInfo();
		DeltaData.Add(listDeltaMsgUnitLockTargetInfo);
		listDeltaMsgUnitLockTargetInfo.Op = OPType.Clear;
		listDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgUnitLockTargetInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgUnitLockTargetInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			UnitLockTargetInfo unitLockTargetInfo = base[i];
			ListDeltaMsgUnitLockTargetInfo listDeltaMsgUnitLockTargetInfo = new ListDeltaMsgUnitLockTargetInfo();
			unitLockTargetInfo.DumpFull(listDeltaMsgUnitLockTargetInfo.Value);
			listDeltaMsgUnitLockTargetInfo.Version = version;
			listDeltaMsgUnitLockTargetInfo.Op = OPType.Add;
			Data.Add(listDeltaMsgUnitLockTargetInfo);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<UnitLockTargetInfo> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
