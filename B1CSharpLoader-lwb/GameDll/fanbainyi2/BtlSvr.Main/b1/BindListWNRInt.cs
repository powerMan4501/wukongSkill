using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListWNRInt : GSBindListWithNetRole<int>
{
	public delegate RepeatedField<ListWNRDeltaMsgInt> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListWNRDeltaMsgInt> DeltaDataCache;

	private RepeatedField<ListWNRDeltaMsgInt> DeltaData
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

	public BindListWNRInt(EGSBindRepType[] StateRepFlag = null, int NetRole = 0, bool Predictable = false, bool PredictElementOperable = false)
		: base(StateRepFlag, NetRole, Predictable, PredictElementOperable)
	{
	}

	protected void OnSetIdxValueImpl(int Idx, int OldValue, int NewValue)
	{
		if (DeltaData != null && GetReplicateType(Idx) == EGSBindRepType.ServerAuthority)
		{
			ListWNRDeltaMsgInt listWNRDeltaMsgInt = new ListWNRDeltaMsgInt();
			DeltaData.Add(listWNRDeltaMsgInt);
			listWNRDeltaMsgInt.Value = NewValue;
			listWNRDeltaMsgInt.Idx = (uint)Idx;
			listWNRDeltaMsgInt.Op = OPType.Modify;
			listWNRDeltaMsgInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<ListWNRDeltaMsgInt> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		for (int i = 0; i < base.Count; i++)
		{
			int value = base[i];
			ListWNRDeltaMsgInt listWNRDeltaMsgInt = new ListWNRDeltaMsgInt();
			listWNRDeltaMsgInt.Value = value;
			listWNRDeltaMsgInt.Idx = (uint)i;
			listWNRDeltaMsgInt.Version = version;
			listWNRDeltaMsgInt.Op = OPType.Modify;
			Data.Add(listWNRDeltaMsgInt);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
