using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class PlayerPersistentAttr
{
	public delegate RepeatedField<ClassDeltaMsgPlayerPersistentAttr> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgPlayerPersistentAttr> DeltaDataCache;

	private int __AttrId_Raw;

	private int __AttrMaxId_Raw;

	private float __AttrValue_Raw;

	private EPlayerAttrRecoverType __AttrValueType_Raw;

	protected RepeatedField<ClassDeltaMsgPlayerPersistentAttr> DeltaData
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

	[GSPersistent]
	public int AttrId
	{
		get
		{
			return __AttrId_Raw;
		}
		set
		{
			int _AttrId_Raw = __AttrId_Raw;
			__AttrId_Raw = value;
			OnAttrIdChg_Invoke(_AttrId_Raw, value);
		}
	}

	[GSPersistent]
	public int AttrMaxId
	{
		get
		{
			return __AttrMaxId_Raw;
		}
		set
		{
			int _AttrMaxId_Raw = __AttrMaxId_Raw;
			__AttrMaxId_Raw = value;
			OnAttrMaxIdChg_Invoke(_AttrMaxId_Raw, value);
		}
	}

	[GSPersistent]
	public float AttrValue
	{
		get
		{
			return __AttrValue_Raw;
		}
		set
		{
			float _AttrValue_Raw = __AttrValue_Raw;
			__AttrValue_Raw = value;
			OnAttrValueChg_Invoke(_AttrValue_Raw, value);
		}
	}

	[GSPersistent]
	public EPlayerAttrRecoverType AttrValueType
	{
		get
		{
			return __AttrValueType_Raw;
		}
		set
		{
			EPlayerAttrRecoverType _AttrValueType_Raw = __AttrValueType_Raw;
			__AttrValueType_Raw = value;
			OnAttrValueTypeChg_Invoke(_AttrValueType_Raw, value);
		}
	}

	public event Action<int, int> OnAttrIdChg;

	public event Action<int, int> OnAttrMaxIdChg;

	public event Action<float, float> OnAttrValueChg;

	public event Action<EPlayerAttrRecoverType, EPlayerAttrRecoverType> OnAttrValueTypeChg;

	public virtual void RefreshGetDeltaDataFunc(bool IsActive)
	{
	}

	public void RegGetDeltaDataFunc(Del_GetRepData Func)
	{
		GetDeltaDataFunc = Func;
	}

	public virtual int GetGSRepSubClassIdx()
	{
		return -1;
	}

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgPlayerPersistentAttr> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgPlayerPersistentAttr
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgPlayerPersistentAttr classDeltaMsgPlayerPersistentAttr = new ClassDeltaMsgPlayerPersistentAttr();
		classDeltaMsgPlayerPersistentAttr.Op = OPType.Modify;
		classDeltaMsgPlayerPersistentAttr.Version = version;
		classDeltaMsgPlayerPersistentAttr.Value = new GurGsStruct.PlayerPersistentAttr();
		Data.Add(classDeltaMsgPlayerPersistentAttr);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnAttrIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnAttrIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnAttrMaxIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnAttrMaxIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnAttrValueChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnAttrValueChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnAttrValueTypeChg_Invoke(EPlayerAttrRecoverType OldValue, EPlayerAttrRecoverType NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnAttrValueTypeChg?.Invoke(OldValue, NewValue);
		}
	}
}
