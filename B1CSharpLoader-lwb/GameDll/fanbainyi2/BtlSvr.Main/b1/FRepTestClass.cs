using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData(RepAsStruct = true)]
public class FRepTestClass
{
	public delegate RepeatedField<ClassDeltaMsgFRepTestClass> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgFRepTestClass> DeltaDataCache;

	private bool __RepTestClassBool_Raw;

	private FRepInnerClass __InnerClass_Raw;

	private BindListFRepInnerClass __InnerClassList_Raw;

	protected RepeatedField<ClassDeltaMsgFRepTestClass> DeltaData
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
	public bool RepTestClassBool
	{
		get
		{
			return __RepTestClassBool_Raw;
		}
		set
		{
			bool _RepTestClassBool_Raw = __RepTestClassBool_Raw;
			__RepTestClassBool_Raw = value;
			OnRepTestClassBoolChg_Invoke(_RepTestClassBool_Raw, value);
		}
	}

	[GSReplicated]
	public FRepInnerClass InnerClass
	{
		get
		{
			return __InnerClass_Raw;
		}
		set
		{
			FRepInnerClass _InnerClass_Raw = __InnerClass_Raw;
			__InnerClass_Raw = value;
			OnInnerClassChg_Invoke(_InnerClass_Raw, value);
		}
	}

	[GSReplicated]
	public BindListFRepInnerClass InnerClassList
	{
		get
		{
			return __InnerClassList_Raw;
		}
		set
		{
			BindListFRepInnerClass _InnerClassList_Raw = __InnerClassList_Raw;
			__InnerClassList_Raw = value;
			OnInnerClassListChg_Invoke(_InnerClassList_Raw, value);
		}
	}

	public event Action<bool, bool> OnRepTestClassBoolChg;

	public event Action<FRepInnerClass, FRepInnerClass> OnInnerClassChg;

	public event Action<BindListFRepInnerClass, BindListFRepInnerClass> OnInnerClassListChg;

	public virtual void RefreshGetDeltaDataFunc(bool IsActive)
	{
		if (IsActive)
		{
			InnerClass?.RegGetDeltaDataFunc(AllocRepDataForInnerClass);
			InnerClassList?.RegGetDeltaDataFunc(AllocRepDataForInnerClassList);
		}
		else
		{
			InnerClass?.RegGetDeltaDataFunc(null);
			InnerClassList?.RegGetDeltaDataFunc(null);
		}
		InnerClass?.RefreshGetDeltaDataFunc(IsActive);
		InnerClassList?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ClassDeltaMsgFRepInnerClass> AllocRepDataForInnerClass()
	{
		if (DeltaData != null)
		{
			ClassDeltaMsgFRepTestClass classDeltaMsgFRepTestClass = new ClassDeltaMsgFRepTestClass();
			classDeltaMsgFRepTestClass.Value = new GurGsStruct.FRepTestClass();
			classDeltaMsgFRepTestClass.Op = OPType.Modify;
			classDeltaMsgFRepTestClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgFRepTestClass);
			return classDeltaMsgFRepTestClass.Value.InnerClass;
		}
		return null;
	}

	private RepeatedField<ListDeltaMsgFRepInnerClass> AllocRepDataForInnerClassList()
	{
		if (DeltaData != null)
		{
			ClassDeltaMsgFRepTestClass classDeltaMsgFRepTestClass = new ClassDeltaMsgFRepTestClass();
			classDeltaMsgFRepTestClass.Value = new GurGsStruct.FRepTestClass();
			classDeltaMsgFRepTestClass.Op = OPType.Modify;
			classDeltaMsgFRepTestClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgFRepTestClass);
			return classDeltaMsgFRepTestClass.Value.InnerClassList;
		}
		return null;
	}

	public void RegGetDeltaDataFunc(Del_GetRepData Func)
	{
		GetDeltaDataFunc = Func;
	}

	public virtual int GetGSRepSubClassIdx()
	{
		return -1;
	}

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgFRepTestClass> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgFRepTestClass
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgFRepTestClass classDeltaMsgFRepTestClass = new ClassDeltaMsgFRepTestClass();
		classDeltaMsgFRepTestClass.Op = OPType.Modify;
		classDeltaMsgFRepTestClass.Version = version;
		classDeltaMsgFRepTestClass.Value = new GurGsStruct.FRepTestClass();
		classDeltaMsgFRepTestClass.Value.RepTestClassBool = RepTestClassBool;
		if (InnerClass == null)
		{
			classDeltaMsgFRepTestClass.Value.InnerClass.Add(new ClassDeltaMsgFRepInnerClass
			{
				Op = OPType.SetNull,
				Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
			});
		}
		else
		{
			InnerClass.DumpFull(classDeltaMsgFRepTestClass.Value.InnerClass);
		}
		if (InnerClassList == null)
		{
			classDeltaMsgFRepTestClass.Value.InnerClassList.Add(new ListDeltaMsgFRepInnerClass
			{
				Op = OPType.SetNull,
				Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
			});
		}
		else
		{
			InnerClassList.DumpFull(classDeltaMsgFRepTestClass.Value.InnerClassList);
		}
		Data.Add(classDeltaMsgFRepTestClass);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		InnerClass?.ClearDeltaData();
		InnerClassList?.ClearDeltaData();
	}

	private void OnRepTestClassBoolChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgFRepTestClass classDeltaMsgFRepTestClass = new ClassDeltaMsgFRepTestClass();
				classDeltaMsgFRepTestClass.Value = new GurGsStruct.FRepTestClass();
				classDeltaMsgFRepTestClass.Op = OPType.Modify;
				classDeltaMsgFRepTestClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgFRepTestClass);
				classDeltaMsgFRepTestClass.Value.RepTestClassBool = NewValue;
			}
			this.OnRepTestClassBoolChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnInnerClassChg_Invoke(FRepInnerClass OldValue, FRepInnerClass NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (DeltaData != null)
		{
			OldValue?.ClearDeltaData();
			ClassDeltaMsgFRepTestClass classDeltaMsgFRepTestClass = new ClassDeltaMsgFRepTestClass();
			classDeltaMsgFRepTestClass.Value = new GurGsStruct.FRepTestClass();
			classDeltaMsgFRepTestClass.Op = OPType.Modify;
			classDeltaMsgFRepTestClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgFRepTestClass);
			if (NewValue == null)
			{
				classDeltaMsgFRepTestClass.Value.InnerClass.Add(new ClassDeltaMsgFRepInnerClass
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.RegGetDeltaDataFunc(AllocRepDataForInnerClass);
				NewValue.DumpFull(classDeltaMsgFRepTestClass.Value.InnerClass);
			}
		}
		this.OnInnerClassChg?.Invoke(OldValue, NewValue);
	}

	private void OnInnerClassListChg_Invoke(BindListFRepInnerClass OldValue, BindListFRepInnerClass NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (DeltaData != null)
		{
			OldValue?.ClearDeltaData();
			ClassDeltaMsgFRepTestClass classDeltaMsgFRepTestClass = new ClassDeltaMsgFRepTestClass();
			classDeltaMsgFRepTestClass.Value = new GurGsStruct.FRepTestClass();
			classDeltaMsgFRepTestClass.Op = OPType.Modify;
			classDeltaMsgFRepTestClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgFRepTestClass);
			if (NewValue == null)
			{
				classDeltaMsgFRepTestClass.Value.InnerClassList.Add(new ListDeltaMsgFRepInnerClass
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.RegGetDeltaDataFunc(AllocRepDataForInnerClassList);
				NewValue.DumpFull(classDeltaMsgFRepTestClass.Value.InnerClassList);
			}
		}
		this.OnInnerClassListChg?.Invoke(OldValue, NewValue);
	}
}
