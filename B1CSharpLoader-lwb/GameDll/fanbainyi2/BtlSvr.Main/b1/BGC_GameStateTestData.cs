using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;

namespace b1;

public class BGC_GameStateTestData : IBGC_GameStateTestData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public GameStateTestData[] _RepData = new GameStateTestData[64];

	private BindListInt __TestIDList_Raw;

	private BindDictEPropType_UInt __TestPropIDDict_Raw;

	private BindListFRepInnerClass __TestInnerClassList_Raw;

	private int __TestID_Raw;

	private BindListInt __TestArr_Raw;

	[GSPersistent]
	public BindListInt TestIDList
	{
		get
		{
			return __TestIDList_Raw;
		}
		set
		{
			BindListInt _TestIDList_Raw = __TestIDList_Raw;
			__TestIDList_Raw = value;
			OnTestIDListChg_Invoke(_TestIDList_Raw, value);
		}
	}

	[GSPersistent]
	public BindDictEPropType_UInt TestPropIDDict
	{
		get
		{
			return __TestPropIDDict_Raw;
		}
		set
		{
			BindDictEPropType_UInt _TestPropIDDict_Raw = __TestPropIDDict_Raw;
			__TestPropIDDict_Raw = value;
			OnTestPropIDDictChg_Invoke(_TestPropIDDict_Raw, value);
		}
	}

	[GSPersistent]
	public BindListFRepInnerClass TestInnerClassList
	{
		get
		{
			return __TestInnerClassList_Raw;
		}
		set
		{
			BindListFRepInnerClass _TestInnerClassList_Raw = __TestInnerClassList_Raw;
			__TestInnerClassList_Raw = value;
			OnTestInnerClassListChg_Invoke(_TestInnerClassList_Raw, value);
		}
	}

	[GSReplicated]
	[NeedToUI]
	[GSPersistent]
	public int TestID
	{
		get
		{
			return __TestID_Raw;
		}
		set
		{
			int _TestID_Raw = __TestID_Raw;
			__TestID_Raw = value;
			OnTestIDChg_Invoke(_TestID_Raw, value);
		}
	}

	public bool StopOptimizeTickRate { get; set; }

	[GSReplicated]
	public BindListInt TestArr
	{
		get
		{
			return __TestArr_Raw;
		}
		set
		{
			BindListInt _TestArr_Raw = __TestArr_Raw;
			__TestArr_Raw = value;
			OnTestArrChg_Invoke(_TestArr_Raw, value);
		}
	}

	public event Action<BindListInt, BindListInt> OnTestIDListChg;

	public event Action<BindDictEPropType_UInt, BindDictEPropType_UInt> OnTestPropIDDictChg;

	public event Action<BindListFRepInnerClass, BindListFRepInnerClass> OnTestInnerClassListChg;

	public event Action<int, int> OnTestIDChg;

	public event Action<BindListInt, BindListInt> OnTestArrChg;

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
			TestArr?.RegGetDeltaDataFunc(AllocRepDataForTestArr);
		}
		else
		{
			TestArr?.RegGetDeltaDataFunc(null);
		}
		TestArr?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListDeltaMsgInt> AllocRepDataForTestArr()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().TestArr;
		}
		return null;
	}

	public GameStateTestData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		GameStateTestData gameStateTestData = _RepData[__LocalRepVersion % 64];
		if (gameStateTestData == null)
		{
			gameStateTestData = new GameStateTestData();
			TestArr?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = gameStateTestData;
		}
		else if (flag)
		{
			gameStateTestData.ClearTestID();
			gameStateTestData.TestArr.Clear();
			TestArr?.ClearDeltaData();
		}
		return gameStateTestData;
	}

	public GameStateTestData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			TestArr?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		GameStateTestData gameStateTestData = new GameStateTestData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"GameStateTestData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			gameStateTestData.TestID = TestID;
			if (TestArr == null)
			{
				gameStateTestData.TestArr.Add(new ListDeltaMsgInt
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				TestArr.DumpFull(gameStateTestData.TestArr);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					GameStateTestData other = _RepData[i % 64];
					gameStateTestData.MergeFrom(other);
				}
			}
		}
		return gameStateTestData;
	}

	private void OnTestIDListChg_Invoke(BindListInt OldValue, BindListInt NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnTestIDListChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestPropIDDictChg_Invoke(BindDictEPropType_UInt OldValue, BindDictEPropType_UInt NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnTestPropIDDictChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestInnerClassListChg_Invoke(BindListFRepInnerClass OldValue, BindListFRepInnerClass NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnTestInnerClassListChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestIDChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().TestID = NewValue;
			}
			this.OnTestIDChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestArrChg_Invoke(BindListInt OldValue, BindListInt NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			GameStateTestData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.TestArr.Clear();
			if (NewValue == null)
			{
				orAllocRepData.TestArr.Add(new ListDeltaMsgInt
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.TestArr);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForTestArr);
		this.OnTestArrChg?.Invoke(OldValue, NewValue);
	}

	public BGC_GameStateTestData()
	{
		TestPropIDDict = new BindDictEPropType_UInt();
		TestIDList = new BindListInt();
		TestInnerClassList = new BindListFRepInnerClass();
		TestArr = new BindListInt();
	}
}
