using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[ReplicateData(RepAsStruct = true)]
public class UnitLockTargetInfo
{
	public delegate RepeatedField<ClassDeltaMsgUnitLockTargetInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgUnitLockTargetInfo> DeltaDataCache;

	private Entity __LockTargetEntity_Raw;

	private ELockTargetWayType __LockTargetWayType_Raw;

	private ELockTargetType __LockTargetType_Raw;

	private string __LockTargetSceneCompName_Raw;

	private string __LockTargetSkeletonSocketName_Raw;

	private UnrealEngine.Runtime.FVector __LockPointLocation_Raw;

	private ETargetSourceType __SourceType_Raw;

	private AActor mLockTargetActor;

	protected RepeatedField<ClassDeltaMsgUnitLockTargetInfo> DeltaData
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
	[GSGameDataSnapShot]
	public Entity LockTargetEntity
	{
		get
		{
			return __LockTargetEntity_Raw;
		}
		set
		{
			Entity _LockTargetEntity_Raw = __LockTargetEntity_Raw;
			__LockTargetEntity_Raw = value;
			OnLockTargetEntityChg_Invoke(_LockTargetEntity_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	[GSReplicated]
	public ELockTargetWayType LockTargetWayType
	{
		get
		{
			return __LockTargetWayType_Raw;
		}
		set
		{
			ELockTargetWayType _LockTargetWayType_Raw = __LockTargetWayType_Raw;
			__LockTargetWayType_Raw = value;
			OnLockTargetWayTypeChg_Invoke(_LockTargetWayType_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	[GSReplicated]
	public ELockTargetType LockTargetType
	{
		get
		{
			return __LockTargetType_Raw;
		}
		set
		{
			ELockTargetType _LockTargetType_Raw = __LockTargetType_Raw;
			__LockTargetType_Raw = value;
			OnLockTargetTypeChg_Invoke(_LockTargetType_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	[GSReplicated]
	public string LockTargetSceneCompName
	{
		get
		{
			return __LockTargetSceneCompName_Raw;
		}
		set
		{
			string _LockTargetSceneCompName_Raw = __LockTargetSceneCompName_Raw;
			__LockTargetSceneCompName_Raw = value;
			OnLockTargetSceneCompNameChg_Invoke(_LockTargetSceneCompName_Raw, value);
		}
	}

	[GSReplicated]
	[GSGameDataSnapShot]
	public string LockTargetSkeletonSocketName
	{
		get
		{
			return __LockTargetSkeletonSocketName_Raw;
		}
		set
		{
			string _LockTargetSkeletonSocketName_Raw = __LockTargetSkeletonSocketName_Raw;
			__LockTargetSkeletonSocketName_Raw = value;
			OnLockTargetSkeletonSocketNameChg_Invoke(_LockTargetSkeletonSocketName_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	[GSReplicated]
	public UnrealEngine.Runtime.FVector LockPointLocation
	{
		get
		{
			return __LockPointLocation_Raw;
		}
		set
		{
			UnrealEngine.Runtime.FVector _LockPointLocation_Raw = __LockPointLocation_Raw;
			__LockPointLocation_Raw = value;
			OnLockPointLocationChg_Invoke(_LockPointLocation_Raw, value);
		}
	}

	[GSReplicated]
	[GSGameDataSnapShot]
	public ETargetSourceType SourceType
	{
		get
		{
			return __SourceType_Raw;
		}
		set
		{
			ETargetSourceType _SourceType_Raw = __SourceType_Raw;
			__SourceType_Raw = value;
			OnSourceTypeChg_Invoke(_SourceType_Raw, value);
		}
	}

	public float NonCombatantAOTargetDegreeLimit { get; set; }

	public AActor LockTargetActor
	{
		get
		{
			if (mLockTargetActor == null)
			{
				mLockTargetActor = ECSExtension.ToActor(LockTargetEntity);
			}
			return mLockTargetActor;
		}
		private set
		{
			mLockTargetActor = value;
		}
	}

	public event Action<Entity, Entity> OnLockTargetEntityChg;

	public event Action<ELockTargetWayType, ELockTargetWayType> OnLockTargetWayTypeChg;

	public event Action<ELockTargetType, ELockTargetType> OnLockTargetTypeChg;

	public event Action<string, string> OnLockTargetSceneCompNameChg;

	public event Action<string, string> OnLockTargetSkeletonSocketNameChg;

	public event Action<UnrealEngine.Runtime.FVector, UnrealEngine.Runtime.FVector> OnLockPointLocationChg;

	public event Action<ETargetSourceType, ETargetSourceType> OnSourceTypeChg;

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

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgUnitLockTargetInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgUnitLockTargetInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgUnitLockTargetInfo classDeltaMsgUnitLockTargetInfo = new ClassDeltaMsgUnitLockTargetInfo();
		classDeltaMsgUnitLockTargetInfo.Op = OPType.Modify;
		classDeltaMsgUnitLockTargetInfo.Version = version;
		classDeltaMsgUnitLockTargetInfo.Value = new GurGsStruct.UnitLockTargetInfo();
		classDeltaMsgUnitLockTargetInfo.Value.LockTargetEntity = BGUFuncLibReplication.GetNetGUIDByEntity(LockTargetEntity);
		classDeltaMsgUnitLockTargetInfo.Value.LockTargetWayType = (int)LockTargetWayType;
		classDeltaMsgUnitLockTargetInfo.Value.LockTargetType = (int)LockTargetType;
		classDeltaMsgUnitLockTargetInfo.Value.LockTargetSceneCompName = ((LockTargetSceneCompName == null) ? string.Empty : LockTargetSceneCompName);
		classDeltaMsgUnitLockTargetInfo.Value.LockTargetSkeletonSocketName = ((LockTargetSkeletonSocketName == null) ? string.Empty : LockTargetSkeletonSocketName);
		classDeltaMsgUnitLockTargetInfo.Value.LockPointLocation = new GurGsStruct.FVector();
		classDeltaMsgUnitLockTargetInfo.Value.LockPointLocation.X = LockPointLocation.X;
		classDeltaMsgUnitLockTargetInfo.Value.LockPointLocation.Y = LockPointLocation.Y;
		classDeltaMsgUnitLockTargetInfo.Value.LockPointLocation.Z = LockPointLocation.Z;
		classDeltaMsgUnitLockTargetInfo.Value.SourceType = (int)SourceType;
		Data.Add(classDeltaMsgUnitLockTargetInfo);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnLockTargetEntityChg_Invoke(Entity OldValue, Entity NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitLockTargetInfo classDeltaMsgUnitLockTargetInfo = new ClassDeltaMsgUnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Value = new GurGsStruct.UnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitLockTargetInfo);
				classDeltaMsgUnitLockTargetInfo.Value.LockTargetEntity = BGUFuncLibReplication.GetNetGUIDByEntity(NewValue);
			}
			this.OnLockTargetEntityChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLockTargetWayTypeChg_Invoke(ELockTargetWayType OldValue, ELockTargetWayType NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitLockTargetInfo classDeltaMsgUnitLockTargetInfo = new ClassDeltaMsgUnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Value = new GurGsStruct.UnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitLockTargetInfo);
				classDeltaMsgUnitLockTargetInfo.Value.LockTargetWayType = (int)NewValue;
			}
			this.OnLockTargetWayTypeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLockTargetTypeChg_Invoke(ELockTargetType OldValue, ELockTargetType NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitLockTargetInfo classDeltaMsgUnitLockTargetInfo = new ClassDeltaMsgUnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Value = new GurGsStruct.UnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitLockTargetInfo);
				classDeltaMsgUnitLockTargetInfo.Value.LockTargetType = (int)NewValue;
			}
			this.OnLockTargetTypeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLockTargetSceneCompNameChg_Invoke(string OldValue, string NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitLockTargetInfo classDeltaMsgUnitLockTargetInfo = new ClassDeltaMsgUnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Value = new GurGsStruct.UnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitLockTargetInfo);
				classDeltaMsgUnitLockTargetInfo.Value.LockTargetSceneCompName = ((NewValue == null) ? string.Empty : NewValue);
			}
			this.OnLockTargetSceneCompNameChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLockTargetSkeletonSocketNameChg_Invoke(string OldValue, string NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitLockTargetInfo classDeltaMsgUnitLockTargetInfo = new ClassDeltaMsgUnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Value = new GurGsStruct.UnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitLockTargetInfo);
				classDeltaMsgUnitLockTargetInfo.Value.LockTargetSkeletonSocketName = ((NewValue == null) ? string.Empty : NewValue);
			}
			this.OnLockTargetSkeletonSocketNameChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLockPointLocationChg_Invoke(UnrealEngine.Runtime.FVector OldValue, UnrealEngine.Runtime.FVector NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitLockTargetInfo classDeltaMsgUnitLockTargetInfo = new ClassDeltaMsgUnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Value = new GurGsStruct.UnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitLockTargetInfo);
				classDeltaMsgUnitLockTargetInfo.Value.LockPointLocation = new GurGsStruct.FVector();
				classDeltaMsgUnitLockTargetInfo.Value.LockPointLocation.X = NewValue.X;
				classDeltaMsgUnitLockTargetInfo.Value.LockPointLocation.Y = NewValue.Y;
				classDeltaMsgUnitLockTargetInfo.Value.LockPointLocation.Z = NewValue.Z;
			}
			this.OnLockPointLocationChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnSourceTypeChg_Invoke(ETargetSourceType OldValue, ETargetSourceType NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgUnitLockTargetInfo classDeltaMsgUnitLockTargetInfo = new ClassDeltaMsgUnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Value = new GurGsStruct.UnitLockTargetInfo();
				classDeltaMsgUnitLockTargetInfo.Op = OPType.Modify;
				classDeltaMsgUnitLockTargetInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgUnitLockTargetInfo);
				classDeltaMsgUnitLockTargetInfo.Value.SourceType = (int)NewValue;
			}
			this.OnSourceTypeChg?.Invoke(OldValue, NewValue);
		}
	}

	public UnitLockTargetInfo()
	{
		LockTargetEntity = Entity.Null;
		LockTargetType = ELockTargetType.Actor;
		LockTargetWayType = ELockTargetWayType.Manual;
		LockTargetSceneCompName = string.Empty;
		LockTargetSkeletonSocketName = string.Empty;
		SourceType = ETargetSourceType.None;
		NonCombatantAOTargetDegreeLimit = -1f;
		OnLockTargetEntityChg += OnTriggerLockTargetEntityChg;
	}

	public UnitLockTargetInfo(AActor TargetActor, UnrealEngine.Runtime.FVector Location, ETargetSourceType _SourceType, ELockTargetWayType _LockTargetWayType = ELockTargetWayType.Manual, string SceneCompName = "", string SkeletonSocketName = "")
	{
		Init(TargetActor, Location, _LockTargetWayType, _SourceType, SceneCompName, SkeletonSocketName);
	}

	public UnitLockTargetInfo(AActor TargetActor, ETargetSourceType _SourceType, ELockTargetWayType _LockTargetWayType = ELockTargetWayType.Manual, string SceneCompName = "", string SkeletonSocketName = "")
	{
		Init(TargetActor, UnrealEngine.Runtime.FVector.ZeroVector, _LockTargetWayType, _SourceType, SceneCompName, SkeletonSocketName);
	}

	private void Init(AActor TargetActor, UnrealEngine.Runtime.FVector _LockLocation, ELockTargetWayType _LockTargetWayType, ETargetSourceType _SourceType, string SceneCompName, string SkeletonSocketName)
	{
		OnLockTargetEntityChg += OnTriggerLockTargetEntityChg;
		LockTargetEntity = Entity.Null;
		LockTargetType = ELockTargetType.Actor;
		LockTargetWayType = ELockTargetWayType.Manual;
		SourceType = _SourceType;
		LockTargetSceneCompName = SceneCompName;
		LockTargetSkeletonSocketName = SkeletonSocketName;
		NonCombatantAOTargetDegreeLimit = -1f;
		if (TargetActor != null)
		{
			LockTargetEntity = ECSExtension.ToEntity(TargetActor);
			LockTargetType = ELockTargetType.Actor;
			LockTargetWayType = _LockTargetWayType;
			if (!string.IsNullOrEmpty(SceneCompName))
			{
				LockTargetType = ELockTargetType.SceneComp;
			}
			if (!string.IsNullOrEmpty(SkeletonSocketName))
			{
				LockTargetType = ELockTargetType.SkeletonSocket;
			}
		}
		else
		{
			LockTargetType = ELockTargetType.Point;
			LockPointLocation = _LockLocation;
			LockTargetWayType = _LockTargetWayType;
		}
	}

	public bool IsValidManualTargetInfo()
	{
		if (LockTargetEntity != Entity.Null && LockTargetWayType == ELockTargetWayType.Manual)
		{
			return true;
		}
		return false;
	}

	private void OnTriggerLockTargetEntityChg(Entity OldValue, Entity NewValue)
	{
		LockTargetActor = ECSUtil.ToActor(NewValue);
	}
}
