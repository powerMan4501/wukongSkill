using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictInt_EChallengeState : GSBindDictionary<int, EChallengeState>
{
	public delegate RepeatedField<DictDeltaMsgInt_EChallengeState> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgInt_EChallengeState> DeltaDataCache;

	private RepeatedField<DictDeltaMsgInt_EChallengeState> DeltaData
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
				OnRemove = (Action<int, EChallengeState>)Delegate.Combine(OnRemove, new Action<int, EChallengeState>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<int, EChallengeState>)Delegate.Remove(OnRemove, new Action<int, EChallengeState>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictInt_EChallengeState()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Key, EChallengeState Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_EChallengeState dictDeltaMsgInt_EChallengeState = new DictDeltaMsgInt_EChallengeState();
			DeltaData.Add(dictDeltaMsgInt_EChallengeState);
			dictDeltaMsgInt_EChallengeState.Idx = Key;
			dictDeltaMsgInt_EChallengeState.Value = (int)Value;
			dictDeltaMsgInt_EChallengeState.Op = OPType.Add;
			dictDeltaMsgInt_EChallengeState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(int Key, EChallengeState Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_EChallengeState dictDeltaMsgInt_EChallengeState = new DictDeltaMsgInt_EChallengeState();
			DeltaData.Add(dictDeltaMsgInt_EChallengeState);
			dictDeltaMsgInt_EChallengeState.Idx = Key;
			dictDeltaMsgInt_EChallengeState.Op = OPType.Remove;
			dictDeltaMsgInt_EChallengeState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(int Key, EChallengeState OldValue, EChallengeState NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_EChallengeState dictDeltaMsgInt_EChallengeState = new DictDeltaMsgInt_EChallengeState();
			DeltaData.Add(dictDeltaMsgInt_EChallengeState);
			dictDeltaMsgInt_EChallengeState.Idx = Key;
			dictDeltaMsgInt_EChallengeState.Value = (int)NewValue;
			dictDeltaMsgInt_EChallengeState.Op = OPType.Modify;
			dictDeltaMsgInt_EChallengeState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgInt_EChallengeState dictDeltaMsgInt_EChallengeState = new DictDeltaMsgInt_EChallengeState();
			DeltaData.Add(dictDeltaMsgInt_EChallengeState);
			dictDeltaMsgInt_EChallengeState.Op = OPType.Clear;
			dictDeltaMsgInt_EChallengeState.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgInt_EChallengeState> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgInt_EChallengeState
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<int, EChallengeState>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, EChallengeState> current = enumerator.Current;
			DictDeltaMsgInt_EChallengeState dictDeltaMsgInt_EChallengeState = new DictDeltaMsgInt_EChallengeState();
			dictDeltaMsgInt_EChallengeState.Idx = current.Key;
			dictDeltaMsgInt_EChallengeState.Value = (int)current.Value;
			dictDeltaMsgInt_EChallengeState.Version = version;
			dictDeltaMsgInt_EChallengeState.Op = OPType.Add;
			Data.Add(dictDeltaMsgInt_EChallengeState);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
