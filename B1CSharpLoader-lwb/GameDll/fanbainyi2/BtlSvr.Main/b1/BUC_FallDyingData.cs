using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_FallDyingData : IBUC_FallDyingData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public FallDyingData[] _RepData = new FallDyingData[64];

	private float __FallDyingTime_Raw;

	private float __SaveSelfWaitTime_Raw;

	private EFallDyingState __UnitFallDyingState_Raw;

	private EInteractUIState __InteractStateValue_Raw;

	private UnrealEngine.Runtime.FVector __VectorTest_Raw;

	private UnrealEngine.Runtime.FRotator __RotatorTest_Raw;

	private BindListFloat __GSListTest_Raw;

	public float SavingSelfTime;

	public int TestEntityMgrIdx = -1;

	[GSReplicated]
	public float FallDyingTime
	{
		get
		{
			return __FallDyingTime_Raw;
		}
		set
		{
			float _FallDyingTime_Raw = __FallDyingTime_Raw;
			__FallDyingTime_Raw = value;
			OnFallDyingTimeChg_Invoke(_FallDyingTime_Raw, value);
		}
	}

	[GSReplicated]
	public float SaveSelfWaitTime
	{
		get
		{
			return __SaveSelfWaitTime_Raw;
		}
		set
		{
			float _SaveSelfWaitTime_Raw = __SaveSelfWaitTime_Raw;
			__SaveSelfWaitTime_Raw = value;
			OnSaveSelfWaitTimeChg_Invoke(_SaveSelfWaitTime_Raw, value);
		}
	}

	[NeedToUI]
	[GSReplicated]
	public EFallDyingState UnitFallDyingState
	{
		get
		{
			return __UnitFallDyingState_Raw;
		}
		set
		{
			EFallDyingState _UnitFallDyingState_Raw = __UnitFallDyingState_Raw;
			__UnitFallDyingState_Raw = value;
			OnUnitFallDyingStateChg_Invoke(_UnitFallDyingState_Raw, value);
		}
	}

	[NeedToUI]
	public EInteractUIState InteractStateValue
	{
		get
		{
			return __InteractStateValue_Raw;
		}
		set
		{
			EInteractUIState _InteractStateValue_Raw = __InteractStateValue_Raw;
			__InteractStateValue_Raw = value;
			OnInteractStateValueChg_Invoke(_InteractStateValue_Raw, value);
		}
	}

	[GSReplicated]
	public UnrealEngine.Runtime.FVector VectorTest
	{
		get
		{
			return __VectorTest_Raw;
		}
		set
		{
			UnrealEngine.Runtime.FVector _VectorTest_Raw = __VectorTest_Raw;
			__VectorTest_Raw = value;
			OnVectorTestChg_Invoke(_VectorTest_Raw, value);
		}
	}

	[GSReplicated]
	public UnrealEngine.Runtime.FRotator RotatorTest
	{
		get
		{
			return __RotatorTest_Raw;
		}
		set
		{
			UnrealEngine.Runtime.FRotator _RotatorTest_Raw = __RotatorTest_Raw;
			__RotatorTest_Raw = value;
			OnRotatorTestChg_Invoke(_RotatorTest_Raw, value);
		}
	}

	[GSReplicated]
	public BindListFloat GSListTest
	{
		get
		{
			return __GSListTest_Raw;
		}
		set
		{
			BindListFloat _GSListTest_Raw = __GSListTest_Raw;
			__GSListTest_Raw = value;
			OnGSListTestChg_Invoke(_GSListTest_Raw, value);
		}
	}

	public event Action<float, float> OnFallDyingTimeChg;

	public event Action<float, float> OnSaveSelfWaitTimeChg;

	public event Action<EFallDyingState, EFallDyingState> OnUnitFallDyingStateChg;

	public event Action<EInteractUIState, EInteractUIState> OnInteractStateValueChg;

	public event Action<UnrealEngine.Runtime.FVector, UnrealEngine.Runtime.FVector> OnVectorTestChg;

	public event Action<UnrealEngine.Runtime.FRotator, UnrealEngine.Runtime.FRotator> OnRotatorTestChg;

	public event Action<BindListFloat, BindListFloat> OnGSListTestChg;

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
			GSListTest?.RegGetDeltaDataFunc(AllocRepDataForGSListTest);
		}
		else
		{
			GSListTest?.RegGetDeltaDataFunc(null);
		}
		GSListTest?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListDeltaMsgFloat> AllocRepDataForGSListTest()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().GSListTest;
		}
		return null;
	}

	public FallDyingData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		FallDyingData fallDyingData = _RepData[__LocalRepVersion % 64];
		if (fallDyingData == null)
		{
			fallDyingData = new FallDyingData();
			GSListTest?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = fallDyingData;
		}
		else if (flag)
		{
			fallDyingData.ClearFallDyingTime();
			fallDyingData.ClearSaveSelfWaitTime();
			fallDyingData.ClearUnitFallDyingState();
			fallDyingData.VectorTest = null;
			fallDyingData.RotatorTest = null;
			fallDyingData.GSListTest.Clear();
			GSListTest?.ClearDeltaData();
		}
		return fallDyingData;
	}

	public FallDyingData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			GSListTest?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		FallDyingData fallDyingData = new FallDyingData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"FallDyingData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			fallDyingData.FallDyingTime = FallDyingTime;
			fallDyingData.SaveSelfWaitTime = SaveSelfWaitTime;
			fallDyingData.UnitFallDyingState = (int)UnitFallDyingState;
			fallDyingData.VectorTest = new GurGsStruct.FVector();
			fallDyingData.VectorTest.X = VectorTest.X;
			fallDyingData.VectorTest.Y = VectorTest.Y;
			fallDyingData.VectorTest.Z = VectorTest.Z;
			fallDyingData.RotatorTest = new GurGsStruct.FRotator();
			fallDyingData.RotatorTest.Pitch = RotatorTest.Pitch;
			fallDyingData.RotatorTest.Yaw = RotatorTest.Yaw;
			fallDyingData.RotatorTest.Roll = RotatorTest.Roll;
			if (GSListTest == null)
			{
				fallDyingData.GSListTest.Add(new ListDeltaMsgFloat
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				GSListTest.DumpFull(fallDyingData.GSListTest);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					FallDyingData other = _RepData[i % 64];
					fallDyingData.MergeFrom(other);
				}
			}
		}
		return fallDyingData;
	}

	private void OnFallDyingTimeChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().FallDyingTime = NewValue;
			}
			this.OnFallDyingTimeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnSaveSelfWaitTimeChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().SaveSelfWaitTime = NewValue;
			}
			this.OnSaveSelfWaitTimeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnUnitFallDyingStateChg_Invoke(EFallDyingState OldValue, EFallDyingState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().UnitFallDyingState = (int)NewValue;
			}
			this.OnUnitFallDyingStateChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnInteractStateValueChg_Invoke(EInteractUIState OldValue, EInteractUIState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnInteractStateValueChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnVectorTestChg_Invoke(UnrealEngine.Runtime.FVector OldValue, UnrealEngine.Runtime.FVector NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				FallDyingData orAllocRepData = GetOrAllocRepData();
				orAllocRepData.VectorTest = new GurGsStruct.FVector();
				orAllocRepData.VectorTest.X = NewValue.X;
				orAllocRepData.VectorTest.Y = NewValue.Y;
				orAllocRepData.VectorTest.Z = NewValue.Z;
			}
			this.OnVectorTestChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnRotatorTestChg_Invoke(UnrealEngine.Runtime.FRotator OldValue, UnrealEngine.Runtime.FRotator NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				FallDyingData orAllocRepData = GetOrAllocRepData();
				orAllocRepData.RotatorTest = new GurGsStruct.FRotator();
				orAllocRepData.RotatorTest.Pitch = NewValue.Pitch;
				orAllocRepData.RotatorTest.Yaw = NewValue.Yaw;
				orAllocRepData.RotatorTest.Roll = NewValue.Roll;
			}
			this.OnRotatorTestChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnGSListTestChg_Invoke(BindListFloat OldValue, BindListFloat NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			FallDyingData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.GSListTest.Clear();
			if (NewValue == null)
			{
				orAllocRepData.GSListTest.Add(new ListDeltaMsgFloat
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.GSListTest);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForGSListTest);
		this.OnGSListTestChg?.Invoke(OldValue, NewValue);
	}

	public BUC_FallDyingData()
	{
		FallDyingTime = 0f;
		SaveSelfWaitTime = 0f;
		SavingSelfTime = 0f;
		UnitFallDyingState = EFallDyingState.Alive;
		InteractStateValue = EInteractUIState.Invisiable;
		GSListTest = new BindListFloat();
	}

	public void ReSetFallDyingState()
	{
		FallDyingTime = 0f;
		SaveSelfWaitTime = 0f;
		SavingSelfTime = 0f;
		GSListTest = new BindListFloat();
	}

	public float GetFallDyingTime()
	{
		return FallDyingTime;
	}

	public float GetSaveSelfWaitTime()
	{
		return SaveSelfWaitTime;
	}

	public bool GetCanSaveSelf()
	{
		if (UnitFallDyingState != EFallDyingState.FallDyingSelfSaving)
		{
			return UnitFallDyingState == EFallDyingState.FallDyingWaitSelfSave;
		}
		return true;
	}

	public bool GetCanBeSaveByTarget()
	{
		if (UnitFallDyingState != EFallDyingState.FallDyingSelfSaving && UnitFallDyingState != EFallDyingState.FallDyingWaitSelfSave)
		{
			return UnitFallDyingState == EFallDyingState.FallDyingWaiting;
		}
		return true;
	}

	public EFallDyingState GetFallDyingState()
	{
		return UnitFallDyingState;
	}
}
