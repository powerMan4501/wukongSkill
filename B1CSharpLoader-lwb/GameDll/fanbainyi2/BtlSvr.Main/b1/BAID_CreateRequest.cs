using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CreateRequest")]
internal class BAID_CreateRequest : BAID_Base
{
	private static bool RequiredFeatureList_IsValid;

	private static int RequiredFeatureList_Offset;

	private static FFieldAddress RequiredFeatureList_PropertyAddress;

	private TArrayReadWriteMarshaler<EAIAttentionFeatureType> RequiredFeatureList_Marshaler;

	private static bool InverseList_IsValid;

	private static int InverseList_Offset;

	private static FFieldAddress InverseList_PropertyAddress;

	private TArrayReadWriteMarshaler<bool> InverseList_Marshaler;

	private static bool AIRequestType_IsValid;

	private static int AIRequestType_Offset;

	private static FFieldAddress AIRequestType_PropertyAddress;

	private static bool FeatureTestList_IsValid;

	private static int FeatureTestList_Offset;

	private static FFieldAddress FeatureTestList_PropertyAddress;

	private TArrayReadWriteMarshaler<EPointTestType> FeatureTestList_Marshaler;

	private static bool FeatureCheckAngleTestList_IsValid;

	private static int FeatureCheckAngleTestList_Offset;

	private static FFieldAddress FeatureCheckAngleTestList_PropertyAddress;

	private TArrayReadWriteMarshaler<FCheckAngleTest> FeatureCheckAngleTestList_Marshaler;

	private static bool FeatureDistanceTest_IsValid;

	private static int FeatureDistanceTest_Offset;

	private static bool RingPointGenerate_IsValid;

	private static int RingPointGenerate_Offset;

	private static bool IsRandomPoint_IsValid;

	private static int IsRandomPoint_Offset;

	private static FFieldAddress IsRandomPoint_PropertyAddress;

	private static bool PointGenBaseType_IsValid;

	private static int PointGenBaseType_Offset;

	private static FFieldAddress PointGenBaseType_PropertyAddress;

	private static bool PointTestList_IsValid;

	private static int PointTestList_Offset;

	private static FFieldAddress PointTestList_PropertyAddress;

	private TArrayReadWriteMarshaler<EPointTestType> PointTestList_Marshaler;

	private static bool CheckAngleTestList_IsValid;

	private static int CheckAngleTestList_Offset;

	private static FFieldAddress CheckAngleTestList_PropertyAddress;

	private TArrayReadWriteMarshaler<FCheckAngleTest> CheckAngleTestList_Marshaler;

	private static bool DistanceTest_IsValid;

	private static int DistanceTest_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:RequiredFeatureList")]
	public TArrayReadWrite<EAIAttentionFeatureType> RequiredFeatureList
	{
		get
		{
			CheckDestroyed();
			if (!RequiredFeatureList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:RequiredFeatureList");
				return null;
			}
			if (RequiredFeatureList_Marshaler == null)
			{
				RequiredFeatureList_Marshaler = new TArrayReadWriteMarshaler<EAIAttentionFeatureType>(1, RequiredFeatureList_PropertyAddress, CachedMarshalingDelegates<EAIAttentionFeatureType, EnumMarshaler<EAIAttentionFeatureType>>.FromNative, CachedMarshalingDelegates<EAIAttentionFeatureType, EnumMarshaler<EAIAttentionFeatureType>>.ToNative);
			}
			return RequiredFeatureList_Marshaler.FromNative(IntPtr.Add(base.Address, RequiredFeatureList_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:InverseList")]
	public TArrayReadWrite<bool> InverseList
	{
		get
		{
			CheckDestroyed();
			if (!InverseList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:InverseList");
				return null;
			}
			if (InverseList_Marshaler == null)
			{
				InverseList_Marshaler = new TArrayReadWriteMarshaler<bool>(1, InverseList_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
			}
			return InverseList_Marshaler.FromNative(IntPtr.Add(base.Address, InverseList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:AIRequestType")]
	public EAIRequestType AIRequestType
	{
		get
		{
			CheckDestroyed();
			if (!AIRequestType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:AIRequestType");
				return EAIRequestType.MoveToLoc;
			}
			return EnumMarshaler<EAIRequestType>.FromNative(IntPtr.Add(base.Address, AIRequestType_Offset), 0, AIRequestType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AIRequestType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:AIRequestType");
			}
			else
			{
				EnumMarshaler<EAIRequestType>.ToNative(IntPtr.Add(base.Address, AIRequestType_Offset), 0, AIRequestType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Feature筛选")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:FeatureTestList")]
	public TArrayReadWrite<EPointTestType> FeatureTestList
	{
		get
		{
			CheckDestroyed();
			if (!FeatureTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:FeatureTestList");
				return null;
			}
			if (FeatureTestList_Marshaler == null)
			{
				FeatureTestList_Marshaler = new TArrayReadWriteMarshaler<EPointTestType>(1, FeatureTestList_PropertyAddress, CachedMarshalingDelegates<EPointTestType, EnumMarshaler<EPointTestType>>.FromNative, CachedMarshalingDelegates<EPointTestType, EnumMarshaler<EPointTestType>>.ToNative);
			}
			return FeatureTestList_Marshaler.FromNative(IntPtr.Add(base.Address, FeatureTestList_Offset));
		}
	}

	[UProperty]
	[Category("Feature筛选")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:FeatureCheckAngleTestList")]
	public TArrayReadWrite<FCheckAngleTest> FeatureCheckAngleTestList
	{
		get
		{
			CheckDestroyed();
			if (!FeatureCheckAngleTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:FeatureCheckAngleTestList");
				return null;
			}
			if (FeatureCheckAngleTestList_Marshaler == null)
			{
				FeatureCheckAngleTestList_Marshaler = new TArrayReadWriteMarshaler<FCheckAngleTest>(1, FeatureCheckAngleTestList_PropertyAddress, CachedMarshalingDelegates<FCheckAngleTest, FCheckAngleTest>.FromNative, CachedMarshalingDelegates<FCheckAngleTest, FCheckAngleTest>.ToNative);
			}
			return FeatureCheckAngleTestList_Marshaler.FromNative(IntPtr.Add(base.Address, FeatureCheckAngleTestList_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Feature筛选")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:FeatureDistanceTest")]
	public FDistanceTest FeatureDistanceTest
	{
		get
		{
			CheckDestroyed();
			if (!FeatureDistanceTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:FeatureDistanceTest");
				return default(FDistanceTest);
			}
			return FDistanceTest.FromNative(IntPtr.Add(base.Address, FeatureDistanceTest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FeatureDistanceTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:FeatureDistanceTest");
			}
			else
			{
				FDistanceTest.ToNative(IntPtr.Add(base.Address, FeatureDistanceTest_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("点筛选")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:RingPointGenerate")]
	public FRingPointGenerate RingPointGenerate
	{
		get
		{
			CheckDestroyed();
			if (!RingPointGenerate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:RingPointGenerate");
				return default(FRingPointGenerate);
			}
			return BlittableTypeMarshaler<FRingPointGenerate>.FromNative(IntPtr.Add(base.Address, RingPointGenerate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RingPointGenerate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:RingPointGenerate");
			}
			else
			{
				BlittableTypeMarshaler<FRingPointGenerate>.ToNative(IntPtr.Add(base.Address, RingPointGenerate_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("点筛选")]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:IsRandomPoint")]
	public bool IsRandomPoint
	{
		get
		{
			CheckDestroyed();
			if (!IsRandomPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:IsRandomPoint");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRandomPoint_Offset), 0, IsRandomPoint_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRandomPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:IsRandomPoint");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRandomPoint_Offset), 0, IsRandomPoint_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("点筛选")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:PointGenBaseType")]
	public EPointGenBaseType PointGenBaseType
	{
		get
		{
			CheckDestroyed();
			if (!PointGenBaseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:PointGenBaseType");
				return EPointGenBaseType.OwnCharacter;
			}
			return EnumMarshaler<EPointGenBaseType>.FromNative(IntPtr.Add(base.Address, PointGenBaseType_Offset), 0, PointGenBaseType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PointGenBaseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:PointGenBaseType");
			}
			else
			{
				EnumMarshaler<EPointGenBaseType>.ToNative(IntPtr.Add(base.Address, PointGenBaseType_Offset), 0, PointGenBaseType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("点筛选")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:PointTestList")]
	public TArrayReadWrite<EPointTestType> PointTestList
	{
		get
		{
			CheckDestroyed();
			if (!PointTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:PointTestList");
				return null;
			}
			if (PointTestList_Marshaler == null)
			{
				PointTestList_Marshaler = new TArrayReadWriteMarshaler<EPointTestType>(1, PointTestList_PropertyAddress, CachedMarshalingDelegates<EPointTestType, EnumMarshaler<EPointTestType>>.FromNative, CachedMarshalingDelegates<EPointTestType, EnumMarshaler<EPointTestType>>.ToNative);
			}
			return PointTestList_Marshaler.FromNative(IntPtr.Add(base.Address, PointTestList_Offset));
		}
	}

	[Category("点筛选")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:CheckAngleTestList")]
	public TArrayReadWrite<FCheckAngleTest> CheckAngleTestList
	{
		get
		{
			CheckDestroyed();
			if (!CheckAngleTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:CheckAngleTestList");
				return null;
			}
			if (CheckAngleTestList_Marshaler == null)
			{
				CheckAngleTestList_Marshaler = new TArrayReadWriteMarshaler<FCheckAngleTest>(1, CheckAngleTestList_PropertyAddress, CachedMarshalingDelegates<FCheckAngleTest, FCheckAngleTest>.FromNative, CachedMarshalingDelegates<FCheckAngleTest, FCheckAngleTest>.ToNative);
			}
			return CheckAngleTestList_Marshaler.FromNative(IntPtr.Add(base.Address, CheckAngleTestList_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("点筛选")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CreateRequest:DistanceTest")]
	public FDistanceTest DistanceTest
	{
		get
		{
			CheckDestroyed();
			if (!DistanceTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:DistanceTest");
				return default(FDistanceTest);
			}
			return FDistanceTest.FromNative(IntPtr.Add(base.Address, DistanceTest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CreateRequest:DistanceTest");
			}
			else
			{
				FDistanceTest.ToNative(IntPtr.Add(base.Address, DistanceTest_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		FCurThinkInfo curThinkInfo = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIAttentionData, BUC_AIAttentionData>(OwnerActor).GetCurThinkInfo();
		if (curThinkInfo.ActiveThinkName == curThinkInfo.CurThinkName)
		{
			return true;
		}
		AIRequestBase aIRequestBase = null;
		switch (AIRequestType)
		{
		case EAIRequestType.MoveToLoc:
			aIRequestBase = UObject.NewObject<AIReqMoveToLoc>();
			break;
		case EAIRequestType.DirDamage:
			aIRequestBase = UObject.NewObject<AIReqDirDamage>();
			break;
		case EAIRequestType.MoveToActor:
			aIRequestBase = UObject.NewObject<AIReqMoveToActor>();
			break;
		case EAIRequestType.MoveSkill:
			aIRequestBase = UObject.NewObject<AIReqMoveSkill>();
			break;
		}
		AIPointTestInfo pointTestInfo = UObject.NewObject<AIPointTestInfo>();
		AIFeatureTestInfo featureTestInfo = UObject.NewObject<AIFeatureTestInfo>();
		aIRequestBase.InitTestInfo(pointTestInfo, featureTestInfo);
		CopyLocalFeatureTestInfo(featureTestInfo);
		AActor SelectedActor;
		switch (AIFuncLibForCS.RequestFeatureTest(aIRequestBase, OwnerActor, out SelectedActor))
		{
		case ERequestTestResult.FeatureNotFound:
		case ERequestTestResult.SelectFaild:
			CreateRequestFailed(OwnerActor);
			return false;
		case ERequestTestResult.SelectSuccess:
			aIRequestBase.FeatureActor = SelectedActor;
			break;
		}
		_ = 1;
		CopyLocalPointTestInfo(pointTestInfo, SelectedActor);
		FVector SelectedPoint;
		ERequestTestResult eRequestTestResult = AIFuncLibForCS.RequestPointTest(aIRequestBase, OwnerActor, out SelectedPoint);
		_ = 1;
		switch (eRequestTestResult)
		{
		case ERequestTestResult.SelectFaild:
			CreateRequestFailed(OwnerActor);
			return false;
		case ERequestTestResult.SelectSuccess:
			aIRequestBase.SelectedPoint = SelectedPoint;
			break;
		}
		BUS_EventCollectionCS.Get(OwnerActor).Evt_OnCreateRequest.Invoke(aIRequestBase);
		return true;
	}

	private void CreateRequestFailed(AActor Own)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Own);
		IBUC_AIAttentionData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIAttentionData, BUC_AIAttentionData>(Own);
		bUS_GSEventCollection.Evt_OnExitThink.Invoke();
		if (unPersistentReadOnlyData.GetCurThinkInfo().ActiveThinkName == unPersistentReadOnlyData.GetCurThinkInfo().CurThinkName)
		{
			bUS_GSEventCollection.Evt_OnExitActiveThink.Invoke();
		}
	}

	private void CopyLocalFeatureTestInfo(AIFeatureTestInfo FeatureTestInfo)
	{
		CopyTArray(FeatureTestList, FeatureTestInfo.FeatureTestList);
		CopyTArray(FeatureCheckAngleTestList, FeatureTestInfo.CheckAngleTestList);
		CopyTArray(RequiredFeatureList, FeatureTestInfo.RequiredFeatureList);
		CopyTArray(InverseList, FeatureTestInfo.InverseList);
		FeatureTestInfo.DistanceTest = FeatureDistanceTest;
	}

	private void CopyLocalPointTestInfo(AIPointTestInfo PointTestInfo, AActor FeatureActor)
	{
		CopyTArray(PointTestList, PointTestInfo.PointTestList);
		CopyTArray(CheckAngleTestList, PointTestInfo.CheckAngleTestList);
		PointTestInfo.DistanceTest = DistanceTest;
		PointTestInfo.IsRandom = IsRandomPoint;
		PointTestInfo.PointGenBaseType = PointGenBaseType;
		PointTestInfo.RingPointGenerate = RingPointGenerate;
	}

	private void CopyTArray<Type>(TArrayReadWrite<Type> Src, TArrayReadWrite<Type> Dst)
	{
		Dst.Clear();
		foreach (Type item in Src)
		{
			Dst.Add(item);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CreateRequest");
		NativeReflection.GetPropertyRef(ref RequiredFeatureList_PropertyAddress, unrealStruct, "RequiredFeatureList");
		RequiredFeatureList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RequiredFeatureList");
		RequiredFeatureList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RequiredFeatureList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InverseList_PropertyAddress, unrealStruct, "InverseList");
		InverseList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InverseList");
		InverseList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InverseList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AIRequestType_PropertyAddress, unrealStruct, "AIRequestType");
		AIRequestType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AIRequestType");
		AIRequestType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AIRequestType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref FeatureTestList_PropertyAddress, unrealStruct, "FeatureTestList");
		FeatureTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FeatureTestList");
		FeatureTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FeatureTestList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FeatureCheckAngleTestList_PropertyAddress, unrealStruct, "FeatureCheckAngleTestList");
		FeatureCheckAngleTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FeatureCheckAngleTestList");
		FeatureCheckAngleTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FeatureCheckAngleTestList", Classes.FArrayProperty);
		FeatureDistanceTest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FeatureDistanceTest");
		FeatureDistanceTest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FeatureDistanceTest", Classes.FStructProperty);
		RingPointGenerate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RingPointGenerate");
		RingPointGenerate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RingPointGenerate", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IsRandomPoint_PropertyAddress, unrealStruct, "IsRandomPoint");
		IsRandomPoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsRandomPoint");
		IsRandomPoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsRandomPoint", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PointGenBaseType_PropertyAddress, unrealStruct, "PointGenBaseType");
		PointGenBaseType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointGenBaseType");
		PointGenBaseType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointGenBaseType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PointTestList_PropertyAddress, unrealStruct, "PointTestList");
		PointTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointTestList");
		PointTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointTestList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CheckAngleTestList_PropertyAddress, unrealStruct, "CheckAngleTestList");
		CheckAngleTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckAngleTestList");
		CheckAngleTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckAngleTestList", Classes.FArrayProperty);
		DistanceTest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistanceTest");
		DistanceTest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistanceTest", Classes.FStructProperty);
	}

	static BAID_CreateRequest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CreateRequest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CreateRequest));
	}
}
