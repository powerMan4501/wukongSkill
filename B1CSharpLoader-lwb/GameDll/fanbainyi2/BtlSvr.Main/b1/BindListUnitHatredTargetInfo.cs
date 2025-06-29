using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListUnitHatredTargetInfo : GSBindList<UnitHatredTargetInfo>
{
	public delegate RepeatedField<ListDeltaMsgUnitHatredTargetInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgUnitHatredTargetInfo> DeltaDataCache;

	private RepeatedField<ListDeltaMsgUnitHatredTargetInfo> DeltaData
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
						ListDeltaMsgUnitHatredTargetInfo listDeltaMsgUnitHatredTargetInfo = new ListDeltaMsgUnitHatredTargetInfo
						{
							Idx = ItemIdx,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listDeltaMsgUnitHatredTargetInfo);
						return listDeltaMsgUnitHatredTargetInfo.Value;
					}
					return (RepeatedField<ClassDeltaMsgUnitHatredTargetInfo>)null;
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

	public BindListUnitHatredTargetInfo()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(UnitHatredTargetInfo Value)
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
				ListDeltaMsgUnitHatredTargetInfo listDeltaMsgUnitHatredTargetInfo2 = new ListDeltaMsgUnitHatredTargetInfo
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgUnitHatredTargetInfo2);
				return listDeltaMsgUnitHatredTargetInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgUnitHatredTargetInfo>)null;
		});
		ListDeltaMsgUnitHatredTargetInfo listDeltaMsgUnitHatredTargetInfo = new ListDeltaMsgUnitHatredTargetInfo();
		DeltaData.Add(listDeltaMsgUnitHatredTargetInfo);
		Value?.DumpFull(listDeltaMsgUnitHatredTargetInfo.Value);
		listDeltaMsgUnitHatredTargetInfo.Op = OPType.Add;
		listDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Idx, UnitHatredTargetInfo Value)
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
					ListDeltaMsgUnitHatredTargetInfo listDeltaMsgUnitHatredTargetInfo2 = new ListDeltaMsgUnitHatredTargetInfo
					{
						Idx = ItemIdx,
						Op = OPType.Modify,
						Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
					};
					DeltaData.Add(listDeltaMsgUnitHatredTargetInfo2);
					return listDeltaMsgUnitHatredTargetInfo2.Value;
				}
				return (RepeatedField<ClassDeltaMsgUnitHatredTargetInfo>)null;
			});
		}
		ListDeltaMsgUnitHatredTargetInfo listDeltaMsgUnitHatredTargetInfo = new ListDeltaMsgUnitHatredTargetInfo();
		DeltaData.Add(listDeltaMsgUnitHatredTargetInfo);
		listDeltaMsgUnitHatredTargetInfo.Idx = (uint)Idx;
		Value?.ClearDeltaData();
		Value?.RegGetDeltaDataFunc(null);
		listDeltaMsgUnitHatredTargetInfo.Op = OPType.Remove;
		listDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnSetIdxValueImpl(int Idx, UnitHatredTargetInfo OldValue, UnitHatredTargetInfo NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		ListDeltaMsgUnitHatredTargetInfo listDeltaMsgUnitHatredTargetInfo = new ListDeltaMsgUnitHatredTargetInfo();
		DeltaData.Add(listDeltaMsgUnitHatredTargetInfo);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListDeltaMsgUnitHatredTargetInfo listDeltaMsgUnitHatredTargetInfo2 = new ListDeltaMsgUnitHatredTargetInfo
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listDeltaMsgUnitHatredTargetInfo2);
				return listDeltaMsgUnitHatredTargetInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgUnitHatredTargetInfo>)null;
		});
		NewValue?.DumpFull(listDeltaMsgUnitHatredTargetInfo.Value);
		listDeltaMsgUnitHatredTargetInfo.Idx = (uint)Idx;
		listDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
		listDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (IEnumerator<UnitHatredTargetInfo> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				UnitHatredTargetInfo current = enumerator.Current;
				current?.ClearDeltaData();
				current?.RegGetDeltaDataFunc(null);
			}
		}
		ListDeltaMsgUnitHatredTargetInfo listDeltaMsgUnitHatredTargetInfo = new ListDeltaMsgUnitHatredTargetInfo();
		DeltaData.Add(listDeltaMsgUnitHatredTargetInfo);
		listDeltaMsgUnitHatredTargetInfo.Op = OPType.Clear;
		listDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListDeltaMsgUnitHatredTargetInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgUnitHatredTargetInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			UnitHatredTargetInfo unitHatredTargetInfo = base[i];
			ListDeltaMsgUnitHatredTargetInfo listDeltaMsgUnitHatredTargetInfo = new ListDeltaMsgUnitHatredTargetInfo();
			unitHatredTargetInfo.DumpFull(listDeltaMsgUnitHatredTargetInfo.Value);
			listDeltaMsgUnitHatredTargetInfo.Version = version;
			listDeltaMsgUnitHatredTargetInfo.Op = OPType.Add;
			Data.Add(listDeltaMsgUnitHatredTargetInfo);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<UnitHatredTargetInfo> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
