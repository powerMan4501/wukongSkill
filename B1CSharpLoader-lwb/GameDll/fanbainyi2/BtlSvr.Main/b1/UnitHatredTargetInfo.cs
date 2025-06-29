using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;
using UnrealEngine.Engine;

namespace b1;

[ReplicateData]
public class UnitHatredTargetInfo
{
	public delegate RepeatedField<ClassDeltaMsgUnitHatredTargetInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgUnitHatredTargetInfo> DeltaDataCache;

	private Entity __HatredTargetEntity_Raw;

	private float __HatredValueBase_Raw;

	private float __HatredValueSkillExtra_Raw;

	private float __HatredValueFinal_Raw;

	private float __LastTickTimeForCalcBaseValue_Raw;

	private float __LastTickTimeForCalcSkillExtraValue_Raw;

	private bool __IsFarawayFromOwner_Raw;

	private float __FarawayTimer_Raw;

	private float __FinalHatredValueWithoutViewWeight_Raw;

	private float __QualityCorrection_Raw;

	private float __LockCorrection_Raw;

	private float __BeLockedCorrection_Raw;

	private bool __IsInView_Raw;

	private float __HatredViewWeight_Raw;

	private AActor mHatredTargetActor;

	protected RepeatedField<ClassDeltaMsgUnitHatredTargetInfo> DeltaData
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

	[GSReplicated]
	public Entity HatredTargetEntity
	{
		get
		{
			return __HatredTargetEntity_Raw;
		}
		set
		{
			Entity _HatredTargetEntity_Raw = __HatredTargetEntity_Raw;
			__HatredTargetEntity_Raw = value;
			OnHatredTargetEntityChg_Invoke(_HatredTargetEntity_Raw, value);
		}
	}

	[GSReplicated]
	public float HatredValueBase
	{
		get
		{
			return __HatredValueBase_Raw;
		}
		set
		{
			float _HatredValueBase_Raw = __HatredValueBase_Raw;
			__HatredValueBase_Raw = value;
			OnHatredValueBaseChg_Invoke(_HatredValueBase_Raw, value);
		}
	}

	[GSReplicated]
	public float HatredValueSkillExtra
	{
		get
		{
			return __HatredValueSkillExtra_Raw;
		}
		set
		{
			float _HatredValueSkillExtra_Raw = __HatredValueSkillExtra_Raw;
			__HatredValueSkillExtra_Raw = value;
			OnHatredValueSkillExtraChg_Invoke(_HatredValueSkillExtra_Raw, value);
		}
	}

	[GSReplicated]
	public float HatredValueFinal
	{
		get
		{
			return __HatredValueFinal_Raw;
		}
		set
		{
			float _HatredValueFinal_Raw = __HatredValueFinal_Raw;
			__HatredValueFinal_Raw = value;
			OnHatredValueFinalChg_Invoke(_HatredValueFinal_Raw, value);
		}
	}

	[GSReplicated]
	public float LastTickTimeForCalcBaseValue
	{
		get
		{
			return __LastTickTimeForCalcBaseValue_Raw;
		}
		set
		{
			float _LastTickTimeForCalcBaseValue_Raw = __LastTickTimeForCalcBaseValue_Raw;
			__LastTickTimeForCalcBaseValue_Raw = value;
			OnLastTickTimeForCalcBaseValueChg_Invoke(_LastTickTimeForCalcBaseValue_Raw, value);
		}
	}

	[GSReplicated]
	public float LastTickTimeForCalcSkillExtraValue
	{
		get
		{
			return __LastTickTimeForCalcSkillExtraValue_Raw;
		}
		set
		{
			float _LastTickTimeForCalcSkillExtraValue_Raw = __LastTickTimeForCalcSkillExtraValue_Raw;
			__LastTickTimeForCalcSkillExtraValue_Raw = value;
			OnLastTickTimeForCalcSkillExtraValueChg_Invoke(_LastTickTimeForCalcSkillExtraValue_Raw, value);
		}
	}

	[GSReplicated]
	public bool IsFarawayFromOwner
	{
		get
		{
			return __IsFarawayFromOwner_Raw;
		}
		set
		{
			bool _IsFarawayFromOwner_Raw = __IsFarawayFromOwner_Raw;
			__IsFarawayFromOwner_Raw = value;
			OnIsFarawayFromOwnerChg_Invoke(_IsFarawayFromOwner_Raw, value);
		}
	}

	[GSReplicated]
	public float FarawayTimer
	{
		get
		{
			return __FarawayTimer_Raw;
		}
		set
		{
			float _FarawayTimer_Raw = __FarawayTimer_Raw;
			__FarawayTimer_Raw = value;
			OnFarawayTimerChg_Invoke(_FarawayTimer_Raw, value);
		}
	}

	[GSReplicated]
	public float FinalHatredValueWithoutViewWeight
	{
		get
		{
			return __FinalHatredValueWithoutViewWeight_Raw;
		}
		set
		{
			float _FinalHatredValueWithoutViewWeight_Raw = __FinalHatredValueWithoutViewWeight_Raw;
			__FinalHatredValueWithoutViewWeight_Raw = value;
			OnFinalHatredValueWithoutViewWeightChg_Invoke(_FinalHatredValueWithoutViewWeight_Raw, value);
		}
	}

	[GSReplicated]
	public float QualityCorrection
	{
		get
		{
			return __QualityCorrection_Raw;
		}
		set
		{
			float _QualityCorrection_Raw = __QualityCorrection_Raw;
			__QualityCorrection_Raw = value;
			OnQualityCorrectionChg_Invoke(_QualityCorrection_Raw, value);
		}
	}

	[GSReplicated]
	public float LockCorrection
	{
		get
		{
			return __LockCorrection_Raw;
		}
		set
		{
			float _LockCorrection_Raw = __LockCorrection_Raw;
			__LockCorrection_Raw = value;
			OnLockCorrectionChg_Invoke(_LockCorrection_Raw, value);
		}
	}

	[GSReplicated]
	public float BeLockedCorrection
	{
		get
		{
			return __BeLockedCorrection_Raw;
		}
		set
		{
			float _BeLockedCorrection_Raw = __BeLockedCorrection_Raw;
			__BeLockedCorrection_Raw = value;
			OnBeLockedCorrectionChg_Invoke(_BeLockedCorrection_Raw, value);
		}
	}

	[GSReplicated]
	public bool IsInView
	{
		get
		{
			return __IsInView_Raw;
		}
		set
		{
			bool _IsInView_Raw = __IsInView_Raw;
			__IsInView_Raw = value;
			OnIsInViewChg_Invoke(_IsInView_Raw, value);
		}
	}

	[GSReplicated]
	public float HatredViewWeight
	{
		get
		{
			return __HatredViewWeight_Raw;
		}
		set
		{
			float _HatredViewWeight_Raw = __HatredViewWeight_Raw;
			__HatredViewWeight_Raw = value;
			OnHatredViewWeightChg_Invoke(_HatredViewWeight_Raw, value);
		}
	}

	public AActor HatredTargetActor
	{
		get
		{
			if (mHatredTargetActor == null)
			{
				mHatredTargetActor = ECSExtension.ToActor(HatredTargetEntity);
			}
			return mHatredTargetActor;
		}
		private set
		{
			mHatredTargetActor = value;
		}
	}

	public event Action<Entity, Entity> OnHatredTargetEntityChg;

	public event Action<float, float> OnHatredValueBaseChg;

	public event Action<float, float> OnHatredValueSkillExtraChg;

	public event Action<float, float> OnHatredValueFinalChg;

	public event Action<float, float> OnLastTickTimeForCalcBaseValueChg;

	public event Action<float, float> OnLastTickTimeForCalcSkillExtraValueChg;

	public event Action<bool, bool> OnIsFarawayFromOwnerChg;

	public event Action<float, float> OnFarawayTimerChg;

	public event Action<float, float> OnFinalHatredValueWithoutViewWeightChg;

	public event Action<float, float> OnQualityCorrectionChg;

	public event Action<float, float> OnLockCorrectionChg;

	public event Action<float, float> OnBeLockedCorrectionChg;

	public event Action<bool, bool> OnIsInViewChg;

	public event Action<float, float> OnHatredViewWeightChg;

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

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgUnitHatredTargetInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgUnitHatredTargetInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
		classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
		classDeltaMsgUnitHatredTargetInfo.Version = version;
		classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
		classDeltaMsgUnitHatredTargetInfo.Value.HatredTargetEntity = BGUFuncLibReplication.GetNetGUIDByEntity(HatredTargetEntity);
		classDeltaMsgUnitHatredTargetInfo.Value.HatredValueBase = HatredValueBase;
		classDeltaMsgUnitHatredTargetInfo.Value.HatredValueSkillExtra = HatredValueSkillExtra;
		classDeltaMsgUnitHatredTargetInfo.Value.HatredValueFinal = HatredValueFinal;
		classDeltaMsgUnitHatredTargetInfo.Value.LastTickTimeForCalcBaseValue = LastTickTimeForCalcBaseValue;
		classDeltaMsgUnitHatredTargetInfo.Value.LastTickTimeForCalcSkillExtraValue = LastTickTimeForCalcSkillExtraValue;
		classDeltaMsgUnitHatredTargetInfo.Value.IsFarawayFromOwner = IsFarawayFromOwner;
		classDeltaMsgUnitHatredTargetInfo.Value.FarawayTimer = FarawayTimer;
		classDeltaMsgUnitHatredTargetInfo.Value.FinalHatredValueWithoutViewWeight = FinalHatredValueWithoutViewWeight;
		classDeltaMsgUnitHatredTargetInfo.Value.QualityCorrection = QualityCorrection;
		classDeltaMsgUnitHatredTargetInfo.Value.LockCorrection = LockCorrection;
		classDeltaMsgUnitHatredTargetInfo.Value.BeLockedCorrection = BeLockedCorrection;
		classDeltaMsgUnitHatredTargetInfo.Value.IsInView = IsInView;
		classDeltaMsgUnitHatredTargetInfo.Value.HatredViewWeight = HatredViewWeight;
		Data.Add(classDeltaMsgUnitHatredTargetInfo);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnHatredTargetEntityChg_Invoke(Entity OldValue, Entity NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.HatredTargetEntity = BGUFuncLibReplication.GetNetGUIDByEntity(NewValue);
			}
			this.OnHatredTargetEntityChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnHatredValueBaseChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.HatredValueBase = NewValue;
			}
			this.OnHatredValueBaseChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnHatredValueSkillExtraChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.HatredValueSkillExtra = NewValue;
			}
			this.OnHatredValueSkillExtraChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnHatredValueFinalChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.HatredValueFinal = NewValue;
			}
			this.OnHatredValueFinalChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLastTickTimeForCalcBaseValueChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.LastTickTimeForCalcBaseValue = NewValue;
			}
			this.OnLastTickTimeForCalcBaseValueChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLastTickTimeForCalcSkillExtraValueChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.LastTickTimeForCalcSkillExtraValue = NewValue;
			}
			this.OnLastTickTimeForCalcSkillExtraValueChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnIsFarawayFromOwnerChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.IsFarawayFromOwner = NewValue;
			}
			this.OnIsFarawayFromOwnerChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnFarawayTimerChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.FarawayTimer = NewValue;
			}
			this.OnFarawayTimerChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnFinalHatredValueWithoutViewWeightChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.FinalHatredValueWithoutViewWeight = NewValue;
			}
			this.OnFinalHatredValueWithoutViewWeightChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnQualityCorrectionChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.QualityCorrection = NewValue;
			}
			this.OnQualityCorrectionChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLockCorrectionChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.LockCorrection = NewValue;
			}
			this.OnLockCorrectionChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnBeLockedCorrectionChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.BeLockedCorrection = NewValue;
			}
			this.OnBeLockedCorrectionChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnIsInViewChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.IsInView = NewValue;
			}
			this.OnIsInViewChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnHatredViewWeightChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitHatredTargetInfo classDeltaMsgUnitHatredTargetInfo = new ClassDeltaMsgUnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Value = new GurGsStruct.UnitHatredTargetInfo();
				classDeltaMsgUnitHatredTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitHatredTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitHatredTargetInfo);
				classDeltaMsgUnitHatredTargetInfo.Value.HatredViewWeight = NewValue;
			}
			this.OnHatredViewWeightChg?.Invoke(OldValue, NewValue);
		}
	}

	public UnitHatredTargetInfo()
	{
		mHatredTargetActor = null;
		HatredTargetEntity = Entity.Null;
		HatredValueBase = 0f;
		HatredValueSkillExtra = 0f;
		HatredValueFinal = 0f;
		LastTickTimeForCalcBaseValue = 0f;
		LastTickTimeForCalcSkillExtraValue = 0f;
		IsFarawayFromOwner = false;
		FarawayTimer = 0f;
		FinalHatredValueWithoutViewWeight = 0f;
		QualityCorrection = 0f;
		LockCorrection = 0f;
		BeLockedCorrection = 0f;
		IsInView = true;
		HatredViewWeight = 1f;
	}

	public void CopyAndUpdateHatredInfo(UnitHatredTargetInfo Other, float ValueMultiple, float ExtraValue)
	{
		HatredValueBase = ((ValueMultiple > 0f) ? (Other.HatredValueBase * ValueMultiple) : Other.HatredValueBase) + ExtraValue;
		HatredValueSkillExtra = ((ValueMultiple > 0f) ? (Other.HatredValueSkillExtra * ValueMultiple) : Other.HatredValueSkillExtra) + ExtraValue;
		HatredValueFinal = 0f;
		LastTickTimeForCalcBaseValue = Other.LastTickTimeForCalcBaseValue;
		LastTickTimeForCalcSkillExtraValue = Other.LastTickTimeForCalcSkillExtraValue;
		IsFarawayFromOwner = false;
		FarawayTimer = 0f;
		FinalHatredValueWithoutViewWeight = 0f;
		QualityCorrection = 0f;
		LockCorrection = 0f;
		BeLockedCorrection = 0f;
		IsInView = true;
		HatredViewWeight = 1f;
	}
}
