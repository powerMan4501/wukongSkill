using System;
using b1.ECS;
using b1.Prediction;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_PredictionTestData : IBUC_PredictionTestData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public PredictionTestData[] _RepData = new PredictionTestData[64];

	private int __TestInt_Raw;

	private string __TestString_Raw;

	private UnrealEngine.Runtime.FVector __TestVector_Raw;

	private GSBindList<int> __TestList_Raw;

	private GSBindDictionary<string, int> __TestDictionary_Raw;

	private Entity __TestEntity1_Raw;

	private BindListEntity __TestEntityList1_Raw;

	private BindListWNREntity __TestEntityListWithNetRole_Raw;

	private BindDictInt_Entity __TestEntityDic_Raw;

	public IBGC_PredictionKeyData PredictionKeyData;

	private int __PredictionDataFinalValue__TestInt;

	private OpratablePredictionDataSet<int> __PredictionDataSet__TestInt;

	private string __PredictionDataFinalValue__TestString;

	private NormalPredictionDataSet<string> __PredictionDataSet__TestString;

	private UnrealEngine.Runtime.FVector __PredictionDataFinalValue__TestVector;

	private OpratablePredictionDataSet<UnrealEngine.Runtime.FVector> __PredictionDataSet__TestVector;

	[GSPredictable]
	public int TestInt
	{
		get
		{
			return __TestInt_PredictionGet();
		}
		set
		{
			int _TestInt_Raw = __TestInt_Raw;
			__TestInt_Set(value);
			OnTestIntChg_Invoke(_TestInt_Raw, value);
		}
	}

	[GSPredictable]
	public string TestString
	{
		get
		{
			return __TestString_PredictionGet();
		}
		set
		{
			string _TestString_Raw = __TestString_Raw;
			__TestString_Set(value);
			OnTestStringChg_Invoke(_TestString_Raw, value);
		}
	}

	[GSPredictable]
	public UnrealEngine.Runtime.FVector TestVector
	{
		get
		{
			return __TestVector_PredictionGet();
		}
		set
		{
			UnrealEngine.Runtime.FVector _TestVector_Raw = __TestVector_Raw;
			__TestVector_Set(value);
			OnTestVectorChg_Invoke(_TestVector_Raw, value);
		}
	}

	[GSPredictable]
	public GSBindList<int> TestList { get; set; }

	[GSPredictable]
	public GSBindDictionary<string, int> TestDictionary { get; set; }

	[GSReplicated]
	public Entity TestEntity1
	{
		get
		{
			return __TestEntity1_Raw;
		}
		set
		{
			Entity _TestEntity1_Raw = __TestEntity1_Raw;
			__TestEntity1_Raw = value;
			OnTestEntity1Chg_Invoke(_TestEntity1_Raw, value);
		}
	}

	[GSReplicated]
	public BindListEntity TestEntityList1
	{
		get
		{
			return __TestEntityList1_Raw;
		}
		set
		{
			BindListEntity _TestEntityList1_Raw = __TestEntityList1_Raw;
			__TestEntityList1_Raw = value;
			OnTestEntityList1Chg_Invoke(_TestEntityList1_Raw, value);
		}
	}

	[GSReplicated]
	public BindListWNREntity TestEntityListWithNetRole
	{
		get
		{
			return __TestEntityListWithNetRole_Raw;
		}
		set
		{
			BindListWNREntity _TestEntityListWithNetRole_Raw = __TestEntityListWithNetRole_Raw;
			__TestEntityListWithNetRole_Raw = value;
			OnTestEntityListWithNetRoleChg_Invoke(_TestEntityListWithNetRole_Raw, value);
		}
	}

	[GSReplicated]
	public BindDictInt_Entity TestEntityDic
	{
		get
		{
			return __TestEntityDic_Raw;
		}
		set
		{
			BindDictInt_Entity _TestEntityDic_Raw = __TestEntityDic_Raw;
			__TestEntityDic_Raw = value;
			OnTestEntityDicChg_Invoke(_TestEntityDic_Raw, value);
		}
	}

	public event Action<int, int> OnTestIntChg;

	public event Action<string, string> OnTestStringChg;

	public event Action<UnrealEngine.Runtime.FVector, UnrealEngine.Runtime.FVector> OnTestVectorChg;

	public event Action<GSBindList<int>, GSBindList<int>> OnTestListChg;

	public event Action<GSBindDictionary<string, int>, GSBindDictionary<string, int>> OnTestDictionaryChg;

	public event Action<Entity, Entity> OnTestEntity1Chg;

	public event Action<BindListEntity, BindListEntity> OnTestEntityList1Chg;

	public event Action<BindListWNREntity, BindListWNREntity> OnTestEntityListWithNetRoleChg;

	public event Action<BindDictInt_Entity, BindDictInt_Entity> OnTestEntityDicChg;

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
			TestEntityList1?.RegGetDeltaDataFunc(AllocRepDataForTestEntityList1);
			TestEntityListWithNetRole?.RegGetDeltaDataFunc(AllocRepDataForTestEntityListWithNetRole);
			TestEntityDic?.RegGetDeltaDataFunc(AllocRepDataForTestEntityDic);
		}
		else
		{
			TestEntityList1?.RegGetDeltaDataFunc(null);
			TestEntityListWithNetRole?.RegGetDeltaDataFunc(null);
			TestEntityDic?.RegGetDeltaDataFunc(null);
		}
		TestEntityList1?.RefreshGetDeltaDataFunc(IsActive);
		TestEntityListWithNetRole?.RefreshGetDeltaDataFunc(IsActive);
		TestEntityDic?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListDeltaMsgEntity> AllocRepDataForTestEntityList1()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().TestEntityList1;
		}
		return null;
	}

	private RepeatedField<ListWNRDeltaMsgEntity> AllocRepDataForTestEntityListWithNetRole()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().TestEntityListWithNetRole;
		}
		return null;
	}

	private RepeatedField<DictDeltaMsgInt_Entity> AllocRepDataForTestEntityDic()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().TestEntityDic;
		}
		return null;
	}

	public PredictionTestData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		PredictionTestData predictionTestData = _RepData[__LocalRepVersion % 64];
		if (predictionTestData == null)
		{
			predictionTestData = new PredictionTestData();
			TestEntityList1?.ClearDeltaData();
			TestEntityListWithNetRole?.ClearDeltaData();
			TestEntityDic?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = predictionTestData;
		}
		else if (flag)
		{
			predictionTestData.ClearTestEntity1();
			predictionTestData.TestEntityList1.Clear();
			TestEntityList1?.ClearDeltaData();
			predictionTestData.TestEntityListWithNetRole.Clear();
			TestEntityListWithNetRole?.ClearDeltaData();
			predictionTestData.TestEntityDic.Clear();
			TestEntityDic?.ClearDeltaData();
		}
		return predictionTestData;
	}

	public PredictionTestData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			TestEntityList1?.ClearDeltaData();
			TestEntityListWithNetRole?.ClearDeltaData();
			TestEntityDic?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		PredictionTestData predictionTestData = new PredictionTestData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"PredictionTestData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			predictionTestData.TestEntity1 = BGUFuncLibReplication.GetNetGUIDByEntity(TestEntity1);
			if (TestEntityList1 == null)
			{
				predictionTestData.TestEntityList1.Add(new ListDeltaMsgEntity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				TestEntityList1.DumpFull(predictionTestData.TestEntityList1);
			}
			if (TestEntityListWithNetRole == null)
			{
				predictionTestData.TestEntityListWithNetRole.Add(new ListWNRDeltaMsgEntity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				TestEntityListWithNetRole.DumpFull(predictionTestData.TestEntityListWithNetRole);
			}
			if (TestEntityDic == null)
			{
				predictionTestData.TestEntityDic.Add(new DictDeltaMsgInt_Entity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				TestEntityDic.DumpFull(predictionTestData.TestEntityDic);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					PredictionTestData other = _RepData[i % 64];
					predictionTestData.MergeFrom(other);
				}
			}
		}
		return predictionTestData;
	}

	private void OnTestIntChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnTestIntChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestStringChg_Invoke(string OldValue, string NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnTestStringChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestVectorChg_Invoke(UnrealEngine.Runtime.FVector OldValue, UnrealEngine.Runtime.FVector NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnTestVectorChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestListChg_Invoke(GSBindList<int> OldValue, GSBindList<int> NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnTestListChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestDictionaryChg_Invoke(GSBindDictionary<string, int> OldValue, GSBindDictionary<string, int> NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnTestDictionaryChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestEntity1Chg_Invoke(Entity OldValue, Entity NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().TestEntity1 = BGUFuncLibReplication.GetNetGUIDByEntity(NewValue);
			}
			this.OnTestEntity1Chg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTestEntityList1Chg_Invoke(BindListEntity OldValue, BindListEntity NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			PredictionTestData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.TestEntityList1.Clear();
			if (NewValue == null)
			{
				orAllocRepData.TestEntityList1.Add(new ListDeltaMsgEntity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.TestEntityList1);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForTestEntityList1);
		this.OnTestEntityList1Chg?.Invoke(OldValue, NewValue);
	}

	private void OnTestEntityListWithNetRoleChg_Invoke(BindListWNREntity OldValue, BindListWNREntity NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			PredictionTestData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.TestEntityListWithNetRole.Clear();
			if (NewValue == null)
			{
				orAllocRepData.TestEntityListWithNetRole.Add(new ListWNRDeltaMsgEntity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.TestEntityListWithNetRole);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForTestEntityListWithNetRole);
		this.OnTestEntityListWithNetRoleChg?.Invoke(OldValue, NewValue);
	}

	private void OnTestEntityDicChg_Invoke(BindDictInt_Entity OldValue, BindDictInt_Entity NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			PredictionTestData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.TestEntityDic.Clear();
			if (NewValue == null)
			{
				orAllocRepData.TestEntityDic.Add(new DictDeltaMsgInt_Entity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.TestEntityDic);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForTestEntityDic);
		this.OnTestEntityDicChg?.Invoke(OldValue, NewValue);
	}

	private void __TestInt_PredictSet(GSPredictionKey PredictionKey, int NewValue)
	{
		if (__PredictionDataSet__TestInt == null)
		{
			__PredictionDataSet__TestInt = new OpratablePredictionDataSet<int>();
			OpratablePredictionDataSet<int> _PredictionDataSet__TestInt = __PredictionDataSet__TestInt;
			_PredictionDataSet__TestInt.ActionOnPredictionChg = (Action<int, bool>)Delegate.Combine(_PredictionDataSet__TestInt.ActionOnPredictionChg, new Action<int, bool>(TestIntPredictionDeltaChg));
		}
		__PredictionDataSet__TestInt.AddPrediction(PredictionKey, NewValue - TestInt);
	}

	private void TestIntPredictionDeltaChg(int NewDeltaValue, bool HasPredictionData)
	{
		__PredictionDataFinalValue__TestInt = __TestInt_Raw + NewDeltaValue;
	}

	private int __TestInt_PredictionGet()
	{
		if (__PredictionDataSet__TestInt == null || !__PredictionDataSet__TestInt.HasPrediction() || PredictionKeyData.ConfirmmingPredictionKey != null)
		{
			return __TestInt_Raw;
		}
		return __PredictionDataFinalValue__TestInt;
	}

	private void __TestInt_Set(int Value)
	{
		if (PredictionKeyData.PredictingingPredictionKey != null)
		{
			__TestInt_PredictSet(PredictionKeyData.PredictingingPredictionKey, Value);
		}
		else
		{
			__TestInt_RawSet(Value);
		}
	}

	private void __TestInt_RawSet(int Value)
	{
		__TestInt_Raw = Value;
	}

	private void __TestString_PredictSet(GSPredictionKey PredictionKey, string NewValue)
	{
		if (__PredictionDataSet__TestString == null)
		{
			__PredictionDataSet__TestString = new NormalPredictionDataSet<string>();
			NormalPredictionDataSet<string> _PredictionDataSet__TestString = __PredictionDataSet__TestString;
			_PredictionDataSet__TestString.ActionOnPredictionChg = (Action<string, bool>)Delegate.Combine(_PredictionDataSet__TestString.ActionOnPredictionChg, new Action<string, bool>(TestStringPredictionValueChg));
		}
		__PredictionDataSet__TestString.AddPrediction(PredictionKey, NewValue);
	}

	private void TestStringPredictionValueChg(string NewValue, bool HasPredictionData)
	{
		__PredictionDataFinalValue__TestString = NewValue;
	}

	private string __TestString_PredictionGet()
	{
		if (__PredictionDataSet__TestString == null || !__PredictionDataSet__TestString.HasPrediction() || PredictionKeyData.ConfirmmingPredictionKey != null)
		{
			return __TestString_Raw;
		}
		return __PredictionDataFinalValue__TestString;
	}

	private void __TestString_Set(string Value)
	{
		if (PredictionKeyData.PredictingingPredictionKey != null)
		{
			__TestString_PredictSet(PredictionKeyData.PredictingingPredictionKey, Value);
		}
		else
		{
			__TestString_RawSet(Value);
		}
	}

	private void __TestString_RawSet(string Value)
	{
		__TestString_Raw = Value;
	}

	private void __TestVector_PredictSet(GSPredictionKey PredictionKey, UnrealEngine.Runtime.FVector NewValue)
	{
		if (__PredictionDataSet__TestVector == null)
		{
			__PredictionDataSet__TestVector = new OpratablePredictionDataSet<UnrealEngine.Runtime.FVector>();
			OpratablePredictionDataSet<UnrealEngine.Runtime.FVector> _PredictionDataSet__TestVector = __PredictionDataSet__TestVector;
			_PredictionDataSet__TestVector.ActionOnPredictionChg = (Action<UnrealEngine.Runtime.FVector, bool>)Delegate.Combine(_PredictionDataSet__TestVector.ActionOnPredictionChg, new Action<UnrealEngine.Runtime.FVector, bool>(TestVectorPredictionDeltaChg));
		}
		__PredictionDataSet__TestVector.AddPrediction(PredictionKey, NewValue - TestVector);
	}

	private void TestVectorPredictionDeltaChg(UnrealEngine.Runtime.FVector NewDeltaValue, bool HasPredictionData)
	{
		__PredictionDataFinalValue__TestVector = __TestVector_Raw + NewDeltaValue;
	}

	private UnrealEngine.Runtime.FVector __TestVector_PredictionGet()
	{
		if (__PredictionDataSet__TestVector == null || !__PredictionDataSet__TestVector.HasPrediction() || PredictionKeyData.ConfirmmingPredictionKey != null)
		{
			return __TestVector_Raw;
		}
		return __PredictionDataFinalValue__TestVector;
	}

	private void __TestVector_Set(UnrealEngine.Runtime.FVector Value)
	{
		if (PredictionKeyData.PredictingingPredictionKey != null)
		{
			__TestVector_PredictSet(PredictionKeyData.PredictingingPredictionKey, Value);
		}
		else
		{
			__TestVector_RawSet(Value);
		}
	}

	private void __TestVector_RawSet(UnrealEngine.Runtime.FVector Value)
	{
		__TestVector_Raw = Value;
	}

	public BUC_PredictionTestData()
	{
		TestList = new GSBindList<int>(Predictable: true, PredictElementOperable: true);
		TestDictionary = new GSBindDictionary<string, int>(Predictable: true, PredictElementOperable: true);
		TestEntityList1 = new BindListEntity();
		TestEntityDic = new BindDictInt_Entity();
	}

	public void Init(int NetRole)
	{
		TestEntityListWithNetRole = new BindListWNREntity(new EGSBindRepType[2]
		{
			EGSBindRepType.Local,
			EGSBindRepType.ServerAuthority
		}, NetRole);
	}
}
