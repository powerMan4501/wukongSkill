using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictString_FCrusadeUnitInfo : GSBindDictionary<string, FCrusadeUnitInfo>
{
	public delegate RepeatedField<DictDeltaMsgString_FCrusadeUnitInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgString_FCrusadeUnitInfo> DeltaDataCache;

	private RepeatedField<DictDeltaMsgString_FCrusadeUnitInfo> DeltaData
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
		using Dictionary<string, FCrusadeUnitInfo>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, FCrusadeUnitInfo> Item = enumerator.Current;
			if (IsActive)
			{
				Item.Value.RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo = new DictDeltaMsgString_FCrusadeUnitInfo
						{
							Idx = ((Item.Key == null) ? string.Empty : Item.Key),
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(dictDeltaMsgString_FCrusadeUnitInfo);
						return dictDeltaMsgString_FCrusadeUnitInfo.Value;
					}
					return (RepeatedField<ClassDeltaMsgFCrusadeUnitInfo>)null;
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
				OnRemove = (Action<string, FCrusadeUnitInfo>)Delegate.Combine(OnRemove, new Action<string, FCrusadeUnitInfo>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<string, FCrusadeUnitInfo>)Delegate.Remove(OnRemove, new Action<string, FCrusadeUnitInfo>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictString_FCrusadeUnitInfo()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(string Key, FCrusadeUnitInfo Value)
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
				DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo2 = new DictDeltaMsgString_FCrusadeUnitInfo
				{
					Idx = ((Key == null) ? string.Empty : Key),
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgString_FCrusadeUnitInfo2);
				return dictDeltaMsgString_FCrusadeUnitInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgFCrusadeUnitInfo>)null;
		});
		DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo = new DictDeltaMsgString_FCrusadeUnitInfo();
		DeltaData.Add(dictDeltaMsgString_FCrusadeUnitInfo);
		dictDeltaMsgString_FCrusadeUnitInfo.Idx = ((Key == null) ? string.Empty : Key);
		Value?.DumpFull(dictDeltaMsgString_FCrusadeUnitInfo.Value);
		dictDeltaMsgString_FCrusadeUnitInfo.Op = OPType.Add;
		dictDeltaMsgString_FCrusadeUnitInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(string Key, FCrusadeUnitInfo Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo = new DictDeltaMsgString_FCrusadeUnitInfo();
			DeltaData.Add(dictDeltaMsgString_FCrusadeUnitInfo);
			dictDeltaMsgString_FCrusadeUnitInfo.Idx = ((Key == null) ? string.Empty : Key);
			Value?.ClearDeltaData();
			Value?.RegGetDeltaDataFunc(null);
			dictDeltaMsgString_FCrusadeUnitInfo.Op = OPType.Remove;
			dictDeltaMsgString_FCrusadeUnitInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(string Key, FCrusadeUnitInfo OldValue, FCrusadeUnitInfo NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo = new DictDeltaMsgString_FCrusadeUnitInfo();
		DeltaData.Add(dictDeltaMsgString_FCrusadeUnitInfo);
		dictDeltaMsgString_FCrusadeUnitInfo.Idx = ((Key == null) ? string.Empty : Key);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo2 = new DictDeltaMsgString_FCrusadeUnitInfo
				{
					Idx = ((Key == null) ? string.Empty : Key),
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgString_FCrusadeUnitInfo2);
				return dictDeltaMsgString_FCrusadeUnitInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgFCrusadeUnitInfo>)null;
		});
		NewValue?.DumpFull(dictDeltaMsgString_FCrusadeUnitInfo.Value);
		dictDeltaMsgString_FCrusadeUnitInfo.Op = OPType.Modify;
		dictDeltaMsgString_FCrusadeUnitInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (Dictionary<string, FCrusadeUnitInfo>.Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, FCrusadeUnitInfo> current = enumerator.Current;
				current.Value?.ClearDeltaData();
				current.Value?.RegGetDeltaDataFunc(null);
			}
		}
		DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo = new DictDeltaMsgString_FCrusadeUnitInfo();
		DeltaData.Add(dictDeltaMsgString_FCrusadeUnitInfo);
		dictDeltaMsgString_FCrusadeUnitInfo.Op = OPType.Clear;
		dictDeltaMsgString_FCrusadeUnitInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<DictDeltaMsgString_FCrusadeUnitInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgString_FCrusadeUnitInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<string, FCrusadeUnitInfo>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, FCrusadeUnitInfo> current = enumerator.Current;
			DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo = new DictDeltaMsgString_FCrusadeUnitInfo();
			dictDeltaMsgString_FCrusadeUnitInfo.Idx = ((current.Key == null) ? string.Empty : current.Key);
			current.Value.DumpFull(dictDeltaMsgString_FCrusadeUnitInfo.Value);
			dictDeltaMsgString_FCrusadeUnitInfo.Version = version;
			dictDeltaMsgString_FCrusadeUnitInfo.Op = OPType.Add;
			Data.Add(dictDeltaMsgString_FCrusadeUnitInfo);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using Dictionary<string, FCrusadeUnitInfo>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value?.ClearDeltaData();
		}
	}
}
