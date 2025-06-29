using System;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListFloat : GSBindList<float>
{
	public delegate RepeatedField<ListDeltaMsgFloat> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgFloat> DeltaDataCache;

	private RepeatedField<ListDeltaMsgFloat> DeltaData
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

	public BindListFloat()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(float Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgFloat listDeltaMsgFloat = new ListDeltaMsgFloat();
			DeltaData.Add(listDeltaMsgFloat);
			listDeltaMsgFloat.Value = Value;
			listDeltaMsgFloat.Op = OPType.Add;
			listDeltaMsgFloat.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(int Idx, float Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgFloat listDeltaMsgFloat = new ListDeltaMsgFloat();
			DeltaData.Add(listDeltaMsgFloat);
			listDeltaMsgFloat.Idx = (uint)Idx;
			listDeltaMsgFloat.Op = OPType.Remove;
			listDeltaMsgFloat.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnSetIdxValueImpl(int Idx, float OldValue, float NewValue)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgFloat listDeltaMsgFloat = new ListDeltaMsgFloat();
			DeltaData.Add(listDeltaMsgFloat);
			listDeltaMsgFloat.Value = NewValue;
			listDeltaMsgFloat.Idx = (uint)Idx;
			listDeltaMsgFloat.Op = OPType.Modify;
			listDeltaMsgFloat.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			ListDeltaMsgFloat listDeltaMsgFloat = new ListDeltaMsgFloat();
			DeltaData.Add(listDeltaMsgFloat);
			listDeltaMsgFloat.Op = OPType.Clear;
			listDeltaMsgFloat.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<ListDeltaMsgFloat> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgFloat
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			float value = base[i];
			ListDeltaMsgFloat listDeltaMsgFloat = new ListDeltaMsgFloat();
			listDeltaMsgFloat.Value = value;
			listDeltaMsgFloat.Version = version;
			listDeltaMsgFloat.Op = OPType.Add;
			Data.Add(listDeltaMsgFloat);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
