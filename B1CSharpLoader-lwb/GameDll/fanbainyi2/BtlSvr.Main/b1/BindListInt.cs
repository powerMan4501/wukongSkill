using System;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListInt : GSBindList<int>
{
	public delegate RepeatedField<ListDeltaMsgInt> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgInt> DeltaDataCache;

	private RepeatedField<ListDeltaMsgInt> DeltaData
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

	public BindListInt()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgInt listDeltaMsgInt = new ListDeltaMsgInt();
			DeltaData.Add(listDeltaMsgInt);
			listDeltaMsgInt.Value = Value;
			listDeltaMsgInt.Op = OPType.Add;
			listDeltaMsgInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(int Idx, int Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgInt listDeltaMsgInt = new ListDeltaMsgInt();
			DeltaData.Add(listDeltaMsgInt);
			listDeltaMsgInt.Idx = (uint)Idx;
			listDeltaMsgInt.Op = OPType.Remove;
			listDeltaMsgInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnSetIdxValueImpl(int Idx, int OldValue, int NewValue)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgInt listDeltaMsgInt = new ListDeltaMsgInt();
			DeltaData.Add(listDeltaMsgInt);
			listDeltaMsgInt.Value = NewValue;
			listDeltaMsgInt.Idx = (uint)Idx;
			listDeltaMsgInt.Op = OPType.Modify;
			listDeltaMsgInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			ListDeltaMsgInt listDeltaMsgInt = new ListDeltaMsgInt();
			DeltaData.Add(listDeltaMsgInt);
			listDeltaMsgInt.Op = OPType.Clear;
			listDeltaMsgInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<ListDeltaMsgInt> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgInt
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			int value = base[i];
			ListDeltaMsgInt listDeltaMsgInt = new ListDeltaMsgInt();
			listDeltaMsgInt.Value = value;
			listDeltaMsgInt.Version = version;
			listDeltaMsgInt.Op = OPType.Add;
			Data.Add(listDeltaMsgInt);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
