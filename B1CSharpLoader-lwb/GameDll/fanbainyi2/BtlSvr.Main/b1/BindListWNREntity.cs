using b1.ECS;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListWNREntity : GSBindListWithNetRole<Entity>
{
	public delegate RepeatedField<ListWNRDeltaMsgEntity> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListWNRDeltaMsgEntity> DeltaDataCache;

	private RepeatedField<ListWNRDeltaMsgEntity> DeltaData
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

	public BindListWNREntity(EGSBindRepType[] StateRepFlag = null, int NetRole = 0, bool Predictable = false, bool PredictElementOperable = false)
		: base(StateRepFlag, NetRole, Predictable, PredictElementOperable)
	{
	}

	protected void OnSetIdxValueImpl(int Idx, Entity OldValue, Entity NewValue)
	{
		if (DeltaData != null && GetReplicateType(Idx) == EGSBindRepType.ServerAuthority)
		{
			ListWNRDeltaMsgEntity listWNRDeltaMsgEntity = new ListWNRDeltaMsgEntity();
			DeltaData.Add(listWNRDeltaMsgEntity);
			listWNRDeltaMsgEntity.Value = BGUFuncLibReplication.GetNetGUIDByEntity(NewValue);
			listWNRDeltaMsgEntity.Idx = (uint)Idx;
			listWNRDeltaMsgEntity.Op = OPType.Modify;
			listWNRDeltaMsgEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<ListWNRDeltaMsgEntity> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		for (int i = 0; i < base.Count; i++)
		{
			Entity entity = base[i];
			ListWNRDeltaMsgEntity listWNRDeltaMsgEntity = new ListWNRDeltaMsgEntity();
			listWNRDeltaMsgEntity.Value = BGUFuncLibReplication.GetNetGUIDByEntity(entity);
			listWNRDeltaMsgEntity.Idx = (uint)i;
			listWNRDeltaMsgEntity.Version = version;
			listWNRDeltaMsgEntity.Op = OPType.Modify;
			Data.Add(listWNRDeltaMsgEntity);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
