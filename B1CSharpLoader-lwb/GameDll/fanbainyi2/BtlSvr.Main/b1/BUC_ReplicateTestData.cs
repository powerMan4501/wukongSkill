using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;

namespace b1;

public class BUC_ReplicateTestData : IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public ReplicateTestData[] _RepData = new ReplicateTestData[64];

	private int __TestInt_Raw;

	private FRepTestClass __TestClass_Raw;

	private BindListInt __IntArr_Raw;

	private BindListFRepInnerClass __InnerClassList_Raw;

	[GSReplicated]
	public int TestInt
	{
		get
		{
			return __TestInt_Raw;
		}
		set
		{
			int _TestInt_Raw = __TestInt_Raw;
			__TestInt_Raw = value;
			OnTestIntChg_Invoke(_TestInt_Raw, value);
		}
	}

	[GSReplicated]
	public FRepTestClass TestClass
	{
		get
		{
			return __TestClass_Raw;
		}
		set
		{
			FRepTestClass _TestClass_Raw = __TestClass_Raw;
			__TestClass_Raw = value;
			OnTestClassChg_Invoke(_TestClass_Raw, value);
		}
	}

	[GSReplicated]
	public BindListInt IntArr
	{
		get
		{
			return __IntArr_Raw;
		}
		set
		{
			BindListInt _IntArr_Raw = __IntArr_Raw;
			__IntArr_Raw = value;
			OnIntArrChg_Invoke(_IntArr_Raw, value);
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

	public event Action<int, int> OnTestIntChg;

	public event Action<FRepTestClass, FRepTestClass> OnTestClassChg;

	public event Action<BindListInt, BindListInt> OnIntArrChg;

	public event Action<BindListFRepInnerClass, BindListFRepInnerClass> OnInnerClassListChg;

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
		if (IsActive)
		{
			TestClass?.RegGetDeltaDataFunc(AllocRepDataForTestClass);
			IntArr?.RegGetDeltaDataFunc(AllocRepDataForIntArr);
			InnerClassList?.RegGetDeltaDataFunc(AllocRepDataForInnerClassList);
		}
		else
		{
			TestClass?.RegGetDeltaDataFunc(null);
			IntArr?.RegGetDeltaDataFunc(null);
			InnerClassList?.RegGetDeltaDataFunc(null);
		}
		TestClass?.RefreshGetDeltaDataFunc(IsActive);
		IntArr?.RefreshGetDeltaDataFunc(IsActive);
		InnerClassList?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ClassDeltaMsgFRepTestClass> AllocRepDataForTestClass()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().TestClass;
		}
		return null;
	}

	private RepeatedField<ListDeltaMsgInt> AllocRepDataForIntArr()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().IntArr;
		}
		return null;
	}

	private RepeatedField<ListDeltaMsgFRepInnerClass> AllocRepDataForInnerClassList()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().InnerClassList;
		}
		return null;
	}

	public ReplicateTestData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		ReplicateTestData replicateTestData = _RepData[__LocalRepVersion % 64];
		if (replicateTestData == null)
		{
			replicateTestData = new ReplicateTestData();
			TestClass?.ClearDeltaData();
			IntArr?.ClearDeltaData();
			InnerClassList?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = replicateTestData;
		}
		else if (flag)
		{
			replicateTestData.ClearTestInt();
			replicateTestData.TestClass.Clear();
			TestClass?.ClearDeltaData();
			replicateTestData.IntArr.Clear();
			IntArr?.ClearDeltaData();
			replicateTestData.InnerClassList.Clear();
			InnerClassList?.ClearDeltaData();
		}
		return replicateTestData;
	}

	public ReplicateTestData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			TestClass?.ClearDeltaData();
			IntArr?.ClearDeltaData();
			InnerClassList?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		ReplicateTestData replicateTestData = new ReplicateTestData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"ReplicateTestData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			replicateTestData.TestInt = TestInt;
			if (TestClass == null)
			{
				replicateTestData.TestClass.Add(new ClassDeltaMsgFRepTestClass
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				TestClass.DumpFull(replicateTestData.TestClass);
			}
			if (IntArr == null)
			{
				replicateTestData.IntArr.Add(new ListDeltaMsgInt
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				IntArr.DumpFull(replicateTestData.IntArr);
			}
			if (InnerClassList == null)
			{
				replicateTestData.InnerClassList.Add(new ListDeltaMsgFRepInnerClass
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				InnerClassList.DumpFull(replicateTestData.InnerClassList);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					ReplicateTestData other = _RepData[i % 64];
					replicateTestData.MergeFrom(other);
				}
			}
		}
		return replicateTestData;
	}

	private void OnTestIntChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().TestInt = NewValue;
			}
			this.OnTestIntChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestClassChg_Invoke(FRepTestClass OldValue, FRepTestClass NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			ReplicateTestData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.TestClass.Clear();
			if (NewValue == null)
			{
				orAllocRepData.TestClass.Add(new ClassDeltaMsgFRepTestClass
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.TestClass);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForTestClass);
		this.OnTestClassChg?.Invoke(OldValue, NewValue);
	}

	private void OnIntArrChg_Invoke(BindListInt OldValue, BindListInt NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			ReplicateTestData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.IntArr.Clear();
			if (NewValue == null)
			{
				orAllocRepData.IntArr.Add(new ListDeltaMsgInt
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.IntArr);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForIntArr);
		this.OnIntArrChg?.Invoke(OldValue, NewValue);
	}

	private void OnInnerClassListChg_Invoke(BindListFRepInnerClass OldValue, BindListFRepInnerClass NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			ReplicateTestData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.InnerClassList.Clear();
			if (NewValue == null)
			{
				orAllocRepData.InnerClassList.Add(new ListDeltaMsgFRepInnerClass
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.InnerClassList);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForInnerClassList);
		this.OnInnerClassListChg?.Invoke(OldValue, NewValue);
	}
}
