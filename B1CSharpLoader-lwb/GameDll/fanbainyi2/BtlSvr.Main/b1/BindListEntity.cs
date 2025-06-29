using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindListEntity : GSBindList<Entity>
{
	public delegate RepeatedField<ListDeltaMsgEntity> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<ListDeltaMsgEntity> DeltaDataCache;

	private RepeatedField<ListDeltaMsgEntity> DeltaData
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

	public BindListEntity()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(Entity Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgEntity listDeltaMsgEntity = new ListDeltaMsgEntity();
			DeltaData.Add(listDeltaMsgEntity);
			listDeltaMsgEntity.Value = BGUFuncLibReplication.GetNetGUIDByEntity(Value);
			listDeltaMsgEntity.Op = OPType.Add;
			listDeltaMsgEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(int Idx, Entity Value)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgEntity listDeltaMsgEntity = new ListDeltaMsgEntity();
			DeltaData.Add(listDeltaMsgEntity);
			listDeltaMsgEntity.Idx = (uint)Idx;
			listDeltaMsgEntity.Op = OPType.Remove;
			listDeltaMsgEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnSetIdxValueImpl(int Idx, Entity OldValue, Entity NewValue)
	{
		if (DeltaData != null)
		{
			ListDeltaMsgEntity listDeltaMsgEntity = new ListDeltaMsgEntity();
			DeltaData.Add(listDeltaMsgEntity);
			listDeltaMsgEntity.Value = BGUFuncLibReplication.GetNetGUIDByEntity(NewValue);
			listDeltaMsgEntity.Idx = (uint)Idx;
			listDeltaMsgEntity.Op = OPType.Modify;
			listDeltaMsgEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			ListDeltaMsgEntity listDeltaMsgEntity = new ListDeltaMsgEntity();
			DeltaData.Add(listDeltaMsgEntity);
			listDeltaMsgEntity.Op = OPType.Clear;
			listDeltaMsgEntity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<ListDeltaMsgEntity> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ListDeltaMsgEntity
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		for (int i = 0; i < base.Count; i++)
		{
			Entity entity = base[i];
			ListDeltaMsgEntity listDeltaMsgEntity = new ListDeltaMsgEntity();
			listDeltaMsgEntity.Value = BGUFuncLibReplication.GetNetGUIDByEntity(entity);
			listDeltaMsgEntity.Version = version;
			listDeltaMsgEntity.Op = OPType.Add;
			Data.Add(listDeltaMsgEntity);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
