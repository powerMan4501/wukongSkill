using System;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListString : GSBindList<string>
{
	public delegate RepeatedField<ListDeltaMsgString> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgString> DeltaDataCache;

	private RepeatedField<ListDeltaMsgString> DeltaData
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

	public BindListString()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(string Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgString listDeltaMsgString = new ListDeltaMsgString();
			DeltaData.Add(listDeltaMsgString);
			listDeltaMsgString.Value = ((Value == null) ? string.Empty : Value);
			listDeltaMsgString.Op = OPType.Add;
			listDeltaMsgString.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(int Idx, string Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgString listDeltaMsgString = new ListDeltaMsgString();
			DeltaData.Add(listDeltaMsgString);
			listDeltaMsgString.Idx = (uint)Idx;
			listDeltaMsgString.Op = OPType.Remove;
			listDeltaMsgString.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnSetIdxValueImpl(int Idx, string OldValue, string NewValue)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgString listDeltaMsgString = new ListDeltaMsgString();
			DeltaData.Add(listDeltaMsgString);
			listDeltaMsgString.Value = ((NewValue == null) ? string.Empty : NewValue);
			listDeltaMsgString.Idx = (uint)Idx;
			listDeltaMsgString.Op = OPType.Modify;
			listDeltaMsgString.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			ListDeltaMsgString listDeltaMsgString = new ListDeltaMsgString();
			DeltaData.Add(listDeltaMsgString);
			listDeltaMsgString.Op = OPType.Clear;
			listDeltaMsgString.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<ListDeltaMsgString> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgString
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			string text = base[i];
			ListDeltaMsgString listDeltaMsgString = new ListDeltaMsgString();
			listDeltaMsgString.Value = ((text == null) ? string.Empty : text);
			listDeltaMsgString.Version = version;
			listDeltaMsgString.Op = OPType.Add;
			Data.Add(listDeltaMsgString);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
