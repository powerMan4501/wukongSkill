using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictString_BindListString : GSBindDictionary<string, BindListString>
{
	public delegate RepeatedField<DictDeltaMsgString_BindListString> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgString_BindListString> DeltaDataCache;

	private RepeatedField<DictDeltaMsgString_BindListString> DeltaData
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
		using Dictionary<string, BindListString>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, BindListString> Item = enumerator.Current;
			if (IsActive)
			{
				Item.Value.RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						DictDeltaMsgString_BindListString dictDeltaMsgString_BindListString = new DictDeltaMsgString_BindListString
						{
							Idx = ((Item.Key == null) ? string.Empty : Item.Key),
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(dictDeltaMsgString_BindListString);
						return dictDeltaMsgString_BindListString.Value;
					}
					return (RepeatedField<ListDeltaMsgString>)null;
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
				OnRemove = (Action<string, BindListString>)Delegate.Combine(OnRemove, new Action<string, BindListString>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<string, BindListString>)Delegate.Remove(OnRemove, new Action<string, BindListString>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictString_BindListString()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(string Key, BindListString Value)
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
				DictDeltaMsgString_BindListString dictDeltaMsgString_BindListString2 = new DictDeltaMsgString_BindListString
				{
					Idx = ((Key == null) ? string.Empty : Key),
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgString_BindListString2);
				return dictDeltaMsgString_BindListString2.Value;
			}
			return (RepeatedField<ListDeltaMsgString>)null;
		});
		DictDeltaMsgString_BindListString dictDeltaMsgString_BindListString = new DictDeltaMsgString_BindListString();
		DeltaData.Add(dictDeltaMsgString_BindListString);
		dictDeltaMsgString_BindListString.Idx = ((Key == null) ? string.Empty : Key);
		Value?.DumpFull(dictDeltaMsgString_BindListString.Value);
		dictDeltaMsgString_BindListString.Op = OPType.Add;
		dictDeltaMsgString_BindListString.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(string Key, BindListString Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgString_BindListString dictDeltaMsgString_BindListString = new DictDeltaMsgString_BindListString();
			DeltaData.Add(dictDeltaMsgString_BindListString);
			dictDeltaMsgString_BindListString.Idx = ((Key == null) ? string.Empty : Key);
			Value?.ClearDeltaData();
			Value?.RegGetDeltaDataFunc(null);
			dictDeltaMsgString_BindListString.Op = OPType.Remove;
			dictDeltaMsgString_BindListString.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(string Key, BindListString OldValue, BindListString NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		DictDeltaMsgString_BindListString dictDeltaMsgString_BindListString = new DictDeltaMsgString_BindListString();
		DeltaData.Add(dictDeltaMsgString_BindListString);
		dictDeltaMsgString_BindListString.Idx = ((Key == null) ? string.Empty : Key);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				DictDeltaMsgString_BindListString dictDeltaMsgString_BindListString2 = new DictDeltaMsgString_BindListString
				{
					Idx = ((Key == null) ? string.Empty : Key),
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgString_BindListString2);
				return dictDeltaMsgString_BindListString2.Value;
			}
			return (RepeatedField<ListDeltaMsgString>)null;
		});
		NewValue?.DumpFull(dictDeltaMsgString_BindListString.Value);
		dictDeltaMsgString_BindListString.Op = OPType.Modify;
		dictDeltaMsgString_BindListString.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (Dictionary<string, BindListString>.Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, BindListString> current = enumerator.Current;
				current.Value?.ClearDeltaData();
				current.Value?.RegGetDeltaDataFunc(null);
			}
		}
		DictDeltaMsgString_BindListString dictDeltaMsgString_BindListString = new DictDeltaMsgString_BindListString();
		DeltaData.Add(dictDeltaMsgString_BindListString);
		dictDeltaMsgString_BindListString.Op = OPType.Clear;
		dictDeltaMsgString_BindListString.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<DictDeltaMsgString_BindListString> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgString_BindListString
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<string, BindListString>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, BindListString> current = enumerator.Current;
			DictDeltaMsgString_BindListString dictDeltaMsgString_BindListString = new DictDeltaMsgString_BindListString();
			dictDeltaMsgString_BindListString.Idx = ((current.Key == null) ? string.Empty : current.Key);
			current.Value.DumpFull(dictDeltaMsgString_BindListString.Value);
			dictDeltaMsgString_BindListString.Version = version;
			dictDeltaMsgString_BindListString.Op = OPType.Add;
			Data.Add(dictDeltaMsgString_BindListString);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using Dictionary<string, BindListString>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value?.ClearDeltaData();
		}
	}
}
