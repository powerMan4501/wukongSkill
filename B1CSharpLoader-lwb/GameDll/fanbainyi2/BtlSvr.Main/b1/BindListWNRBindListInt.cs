using System.Collections.Generic;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListWNRBindListInt : GSBindListWithNetRole<BindListInt>
{
	public delegate RepeatedField<ListWNRDeltaMsgBindListInt> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListWNRDeltaMsgBindListInt> DeltaDataCache;

	private RepeatedField<ListWNRDeltaMsgBindListInt> DeltaData
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
		int i;
		for (i = 0; i < base.Count; i++)
		{
			if (IsActive)
			{
				base[i].RegGetDeltaDataFunc(delegate
				{
					if (DeltaData != null)
					{
						ListWNRDeltaMsgBindListInt listWNRDeltaMsgBindListInt = new ListWNRDeltaMsgBindListInt
						{
							Idx = (uint)i,
							Op = OPType.Modify,
							Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
						};
						DeltaData.Add(listWNRDeltaMsgBindListInt);
						return listWNRDeltaMsgBindListInt.Value;
					}
					return (RepeatedField<ListDeltaMsgInt>)null;
				});
			}
			else
			{
				base[i].RegGetDeltaDataFunc(null);
			}
			base[i].RefreshGetDeltaDataFunc(IsActive);
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
				base.OnSetIdxValue -= OnSetIdxValueImpl;
			}
			else
			{
				base.OnSetIdxValue -= OnSetIdxValueImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindListWNRBindListInt(EGSBindRepType[] StateRepFlag = null, int NetRole = 0, bool Predictable = false, bool PredictElementOperable = false)
		: base(StateRepFlag, NetRole, Predictable, PredictElementOperable)
	{
	}

	protected void OnSetIdxValueImpl(int Idx, BindListInt OldValue, BindListInt NewValue)
	{
		if (DeltaData == null || GetReplicateType(Idx) != EGSBindRepType.ServerAuthority)
		{
			return;
		}
		ListWNRDeltaMsgBindListInt listWNRDeltaMsgBindListInt = new ListWNRDeltaMsgBindListInt();
		DeltaData.Add(listWNRDeltaMsgBindListInt);
		OldValue?.ClearDeltaData();
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.ClearDeltaData();
		NewValue?.RegGetDeltaDataFunc(delegate
		{
			if (DeltaData != null)
			{
				ListWNRDeltaMsgBindListInt listWNRDeltaMsgBindListInt2 = new ListWNRDeltaMsgBindListInt
				{
					Idx = (uint)Idx,
					Op = OPType.Modify,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				};
				DeltaData.Add(listWNRDeltaMsgBindListInt2);
				return listWNRDeltaMsgBindListInt2.Value;
			}
			return (RepeatedField<ListDeltaMsgInt>)null;
		});
		NewValue?.DumpFull(listWNRDeltaMsgBindListInt.Value);
		listWNRDeltaMsgBindListInt.Idx = (uint)Idx;
		listWNRDeltaMsgBindListInt.Op = OPType.Modify;
		listWNRDeltaMsgBindListInt.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
	}

	public void DumpFull(RepeatedField<ListWNRDeltaMsgBindListInt> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		for (int i = 0; i < base.Count; i++)
		{
			BindListInt bindListInt = base[i];
			ListWNRDeltaMsgBindListInt listWNRDeltaMsgBindListInt = new ListWNRDeltaMsgBindListInt();
			bindListInt.DumpFull(listWNRDeltaMsgBindListInt.Value);
			listWNRDeltaMsgBindListInt.Idx = (uint)i;
			listWNRDeltaMsgBindListInt.Version = version;
			listWNRDeltaMsgBindListInt.Op = OPType.Modify;
			Data.Add(listWNRDeltaMsgBindListInt);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		using IEnumerator<BindListInt> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current?.ClearDeltaData();
		}
	}
}
