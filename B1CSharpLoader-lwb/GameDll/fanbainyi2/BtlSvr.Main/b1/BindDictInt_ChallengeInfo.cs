using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictInt_ChallengeInfo : GSBindDictionary<int, ChallengeInfo>
{
	public delegate RepeatedField<DictDeltaMsgInt_ChallengeInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgInt_ChallengeInfo> DeltaDataCache;

	private RepeatedField<DictDeltaMsgInt_ChallengeInfo> DeltaData
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
		using Dictionary<int, ChallengeInfo>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, ChallengeInfo> Item = enumerator.Current;
			if (IsActive)
			{
				Item.Value.RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						DictDeltaMsgInt_ChallengeInfo dictDeltaMsgInt_ChallengeInfo = new DictDeltaMsgInt_ChallengeInfo
						{
							Idx = Item.Key,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(dictDeltaMsgInt_ChallengeInfo);
						return dictDeltaMsgInt_ChallengeInfo.Value;
					}
					return (RepeatedField<ClassDeltaMsgChallengeInfo>)null;
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
				OnRemove = (Action<int, ChallengeInfo>)Delegate.Combine(OnRemove, new Action<int, ChallengeInfo>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<int, ChallengeInfo>)Delegate.Remove(OnRemove, new Action<int, ChallengeInfo>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictInt_ChallengeInfo()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Key, ChallengeInfo Value)
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
				DictDeltaMsgInt_ChallengeInfo dictDeltaMsgInt_ChallengeInfo2 = new DictDeltaMsgInt_ChallengeInfo
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_ChallengeInfo2);
				return dictDeltaMsgInt_ChallengeInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgChallengeInfo>)null;
		});
		DictDeltaMsgInt_ChallengeInfo dictDeltaMsgInt_ChallengeInfo = new DictDeltaMsgInt_ChallengeInfo();
		DeltaData.Add(dictDeltaMsgInt_ChallengeInfo);
		dictDeltaMsgInt_ChallengeInfo.Idx = Key;
		Value?.DumpFull(dictDeltaMsgInt_ChallengeInfo.Value);
		dictDeltaMsgInt_ChallengeInfo.Op = OPType.Add;
		dictDeltaMsgInt_ChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnRemoveImpl(int Key, ChallengeInfo Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_ChallengeInfo dictDeltaMsgInt_ChallengeInfo = new DictDeltaMsgInt_ChallengeInfo();
			DeltaData.Add(dictDeltaMsgInt_ChallengeInfo);
			dictDeltaMsgInt_ChallengeInfo.Idx = Key;
			Value?.ClearDeltaData();
			Value?.RegGetDeltaDataFunc(null);
			dictDeltaMsgInt_ChallengeInfo.Op = OPType.Remove;
			dictDeltaMsgInt_ChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(int Key, ChallengeInfo OldValue, ChallengeInfo NewValue)
	{
		if (DeltaData == null)
		{
			return;
		}
		DictDeltaMsgInt_ChallengeInfo dictDeltaMsgInt_ChallengeInfo = new DictDeltaMsgInt_ChallengeInfo();
		DeltaData.Add(dictDeltaMsgInt_ChallengeInfo);
		dictDeltaMsgInt_ChallengeInfo.Idx = Key;
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				DictDeltaMsgInt_ChallengeInfo dictDeltaMsgInt_ChallengeInfo2 = new DictDeltaMsgInt_ChallengeInfo
				{
					Idx = Key,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(dictDeltaMsgInt_ChallengeInfo2);
				return dictDeltaMsgInt_ChallengeInfo2.Value;
			}
			return (RepeatedField<ClassDeltaMsgChallengeInfo>)null;
		});
		NewValue?.DumpFull(dictDeltaMsgInt_ChallengeInfo.Value);
		dictDeltaMsgInt_ChallengeInfo.Op = OPType.Modify;
		dictDeltaMsgInt_ChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	protected void OnClearImpl()
	{
		if (DeltaData == null || base.Count == 0)
		{
			return;
		}
		using (Dictionary<int, ChallengeInfo>.Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<int, ChallengeInfo> current = enumerator.Current;
				current.Value?.ClearDeltaData();
				current.Value?.RegGetDeltaDataFunc(null);
			}
		}
		DictDeltaMsgInt_ChallengeInfo dictDeltaMsgInt_ChallengeInfo = new DictDeltaMsgInt_ChallengeInfo();
		DeltaData.Add(dictDeltaMsgInt_ChallengeInfo);
		dictDeltaMsgInt_ChallengeInfo.Op = OPType.Clear;
		dictDeltaMsgInt_ChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<DictDeltaMsgInt_ChallengeInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgInt_ChallengeInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<int, ChallengeInfo>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, ChallengeInfo> current = enumerator.Current;
			DictDeltaMsgInt_ChallengeInfo dictDeltaMsgInt_ChallengeInfo = new DictDeltaMsgInt_ChallengeInfo();
			dictDeltaMsgInt_ChallengeInfo.Idx = current.Key;
			current.Value.DumpFull(dictDeltaMsgInt_ChallengeInfo.Value);
			dictDeltaMsgInt_ChallengeInfo.Version = version;
			dictDeltaMsgInt_ChallengeInfo.Op = OPType.Add;
			Data.Add(dictDeltaMsgInt_ChallengeInfo);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using Dictionary<int, ChallengeInfo>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value?.ClearDeltaData();
		}
	}
}
