using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListWNRFloat : GSBindListWithNetRole<float>
{
	public delegate RepeatedField<ListWNRDeltaMsgFloat> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListWNRDeltaMsgFloat> DeltaDataCache;

	private RepeatedField<ListWNRDeltaMsgFloat> DeltaData
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
				base.OnSetIdxValue -= OnSetIdxValueImpl;
			}
			else
			{
				base.OnSetIdxValue -= OnSetIdxValueImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindListWNRFloat(EGSBindRepType[] StateRepFlag = null, int NetRole = 0, bool Predictable = false, bool PredictElementOperable = false)
		: base(StateRepFlag, NetRole, Predictable, PredictElementOperable)
	{
	}

	protected void OnSetIdxValueImpl(int Idx, float OldValue, float NewValue)
	{
		if (DeltaData != null && GetReplicateType(Idx) == EGSBindRepType.ServerAuthority)
		{
			ListWNRDeltaMsgFloat listWNRDeltaMsgFloat = new ListWNRDeltaMsgFloat();
			DeltaData.Add(listWNRDeltaMsgFloat);
			listWNRDeltaMsgFloat.Value = NewValue;
			listWNRDeltaMsgFloat.Idx = (uint)Idx;
			listWNRDeltaMsgFloat.Op = OPType.Modify;
			listWNRDeltaMsgFloat.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<ListWNRDeltaMsgFloat> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		for (int i = 0; i < base.Count; i++)
		{
			float value = base[i];
			ListWNRDeltaMsgFloat listWNRDeltaMsgFloat = new ListWNRDeltaMsgFloat();
			listWNRDeltaMsgFloat.Value = value;
			listWNRDeltaMsgFloat.Idx = (uint)i;
			listWNRDeltaMsgFloat.Version = version;
			listWNRDeltaMsgFloat.Op = OPType.Modify;
			Data.Add(listWNRDeltaMsgFloat);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
