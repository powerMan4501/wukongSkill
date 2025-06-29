using System;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListBool : GSBindList<bool>
{
	public delegate RepeatedField<ListDeltaMsgBool> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgBool> DeltaDataCache;

	private RepeatedField<ListDeltaMsgBool> DeltaData
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

	public BindListBool()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(bool Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgBool listDeltaMsgBool = new ListDeltaMsgBool();
			DeltaData.Add(listDeltaMsgBool);
			listDeltaMsgBool.Value = Value;
			listDeltaMsgBool.Op = OPType.Add;
			listDeltaMsgBool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(int Idx, bool Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgBool listDeltaMsgBool = new ListDeltaMsgBool();
			DeltaData.Add(listDeltaMsgBool);
			listDeltaMsgBool.Idx = (uint)Idx;
			listDeltaMsgBool.Op = OPType.Remove;
			listDeltaMsgBool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnSetIdxValueImpl(int Idx, bool OldValue, bool NewValue)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgBool listDeltaMsgBool = new ListDeltaMsgBool();
			DeltaData.Add(listDeltaMsgBool);
			listDeltaMsgBool.Value = NewValue;
			listDeltaMsgBool.Idx = (uint)Idx;
			listDeltaMsgBool.Op = OPType.Modify;
			listDeltaMsgBool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			ListDeltaMsgBool listDeltaMsgBool = new ListDeltaMsgBool();
			DeltaData.Add(listDeltaMsgBool);
			listDeltaMsgBool.Op = OPType.Clear;
			listDeltaMsgBool.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<ListDeltaMsgBool> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgBool
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			bool value = base[i];
			ListDeltaMsgBool listDeltaMsgBool = new ListDeltaMsgBool();
			listDeltaMsgBool.Value = value;
			listDeltaMsgBool.Version = version;
			listDeltaMsgBool.Op = OPType.Add;
			Data.Add(listDeltaMsgBool);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
