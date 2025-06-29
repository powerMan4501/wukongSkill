using System;
using System.Collections.Generic;
using b1.ECS;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace b1;

public class BindDictInt_Entity : GSBindDictionary<int, Entity>
{
	public delegate RepeatedField<DictDeltaMsgInt_Entity> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private bool IsBindDataChangeFunc;

	private RepeatedField<DictDeltaMsgInt_Entity> DeltaDataCache;

	private RepeatedField<DictDeltaMsgInt_Entity> DeltaData
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
				OnRemove = (Action<int, Entity>)Delegate.Combine(OnRemove, new Action<int, Entity>(OnRemoveImpl));
				base.OnAnyValueChanged += OnAnyValueChangedImpl;
				base.OnClear += OnClearImpl;
			}
			else
			{
				base.OnAdd -= OnAddImpl;
				OnRemove = (Action<int, Entity>)Delegate.Remove(OnRemove, new Action<int, Entity>(OnRemoveImpl));
				base.OnAnyValueChanged -= OnAnyValueChangedImpl;
				base.OnClear -= OnClearImpl;
			}
			IsBindDataChangeFunc = IsBind;
		}
	}

	public BindDictInt_Entity()
		: base(Predictable: false, PredictElementOperable: false)
	{
	}

	protected void OnAddImpl(int Key, Entity Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_Entity dictDeltaMsgInt_Entity = new DictDeltaMsgInt_Entity();
			DeltaData.Add(dictDeltaMsgInt_Entity);
			dictDeltaMsgInt_Entity.Idx = Key;
			dictDeltaMsgInt_Entity.Value = BGUFuncLibReplication.GetNetGUIDByEntity(Value);
			dictDeltaMsgInt_Entity.Op = OPType.Add;
			dictDeltaMsgInt_Entity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnRemoveImpl(int Key, Entity Value)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_Entity dictDeltaMsgInt_Entity = new DictDeltaMsgInt_Entity();
			DeltaData.Add(dictDeltaMsgInt_Entity);
			dictDeltaMsgInt_Entity.Idx = Key;
			dictDeltaMsgInt_Entity.Op = OPType.Remove;
			dictDeltaMsgInt_Entity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnAnyValueChangedImpl(int Key, Entity OldValue, Entity NewValue)
	{
		if (DeltaData != null)
		{
			DictDeltaMsgInt_Entity dictDeltaMsgInt_Entity = new DictDeltaMsgInt_Entity();
			DeltaData.Add(dictDeltaMsgInt_Entity);
			dictDeltaMsgInt_Entity.Idx = Key;
			dictDeltaMsgInt_Entity.Value = BGUFuncLibReplication.GetNetGUIDByEntity(NewValue);
			dictDeltaMsgInt_Entity.Op = OPType.Modify;
			dictDeltaMsgInt_Entity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	protected void OnClearImpl()
	{
		if (DeltaData != null && base.Count != 0)
		{
			DictDeltaMsgInt_Entity dictDeltaMsgInt_Entity = new DictDeltaMsgInt_Entity();
			DeltaData.Add(dictDeltaMsgInt_Entity);
			dictDeltaMsgInt_Entity.Op = OPType.Clear;
			dictDeltaMsgInt_Entity.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		}
	}

	public void DumpFull(RepeatedField<DictDeltaMsgInt_Entity> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new DictDeltaMsgInt_Entity
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		using Dictionary<int, Entity>.Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<int, Entity> current = enumerator.Current;
			DictDeltaMsgInt_Entity dictDeltaMsgInt_Entity = new DictDeltaMsgInt_Entity();
			dictDeltaMsgInt_Entity.Idx = current.Key;
			dictDeltaMsgInt_Entity.Value = BGUFuncLibReplication.GetNetGUIDByEntity(current.Value);
			dictDeltaMsgInt_Entity.Version = version;
			dictDeltaMsgInt_Entity.Op = OPType.Add;
			Data.Add(dictDeltaMsgInt_Entity);
		}
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}
}
