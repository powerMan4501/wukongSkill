using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AIFeatureTestInfo")]
public class AIFeatureTestInfo : UObject
{
	private static bool RequiredFeatureList_IsValid;

	private static int RequiredFeatureList_Offset;

	private static FFieldAddress RequiredFeatureList_PropertyAddress;

	private TArrayReadWriteMarshaler<EAIAttentionFeatureType> RequiredFeatureList_Marshaler;

	private static bool InverseList_IsValid;

	private static int InverseList_Offset;

	private static FFieldAddress InverseList_PropertyAddress;

	private TArrayReadWriteMarshaler<bool> InverseList_Marshaler;

	private static bool FeatureTestList_IsValid;

	private static int FeatureTestList_Offset;

	private static FFieldAddress FeatureTestList_PropertyAddress;

	private TArrayReadWriteMarshaler<EPointTestType> FeatureTestList_Marshaler;

	private static bool CheckAngleTestList_IsValid;

	private static int CheckAngleTestList_Offset;

	private static FFieldAddress CheckAngleTestList_PropertyAddress;

	private TArrayReadWriteMarshaler<FCheckAngleTest> CheckAngleTestList_Marshaler;

	private static bool DistanceTest_IsValid;

	private static int DistanceTest_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIFeatureTestInfo:RequiredFeatureList")]
	public TArrayReadWrite<EAIAttentionFeatureType> RequiredFeatureList
	{
		get
		{
			CheckDestroyed();
			if (!RequiredFeatureList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIFeatureTestInfo:RequiredFeatureList");
				return null;
			}
			if (RequiredFeatureList_Marshaler == null)
			{
				RequiredFeatureList_Marshaler = new TArrayReadWriteMarshaler<EAIAttentionFeatureType>(1, RequiredFeatureList_PropertyAddress, CachedMarshalingDelegates<EAIAttentionFeatureType, EnumMarshaler<EAIAttentionFeatureType>>.FromNative, CachedMarshalingDelegates<EAIAttentionFeatureType, EnumMarshaler<EAIAttentionFeatureType>>.ToNative);
			}
			return RequiredFeatureList_Marshaler.FromNative(IntPtr.Add(base.Address, RequiredFeatureList_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIFeatureTestInfo:InverseList")]
	public TArrayReadWrite<bool> InverseList
	{
		get
		{
			CheckDestroyed();
			if (!InverseList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIFeatureTestInfo:InverseList");
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
	[USharpPath("/Script/b1-Managed.AIFeatureTestInfo:FeatureTestList")]
	public TArrayReadWrite<EPointTestType> FeatureTestList
	{
		get
		{
			CheckDestroyed();
			if (!FeatureTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIFeatureTestInfo:FeatureTestList");
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
	[USharpPath("/Script/b1-Managed.AIFeatureTestInfo:CheckAngleTestList")]
	public TArrayReadWrite<FCheckAngleTest> CheckAngleTestList
	{
		get
		{
			CheckDestroyed();
			if (!CheckAngleTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIFeatureTestInfo:CheckAngleTestList");
				return null;
			}
			if (CheckAngleTestList_Marshaler == null)
			{
				CheckAngleTestList_Marshaler = new TArrayReadWriteMarshaler<FCheckAngleTest>(1, CheckAngleTestList_PropertyAddress, CachedMarshalingDelegates<FCheckAngleTest, FCheckAngleTest>.FromNative, CachedMarshalingDelegates<FCheckAngleTest, FCheckAngleTest>.ToNative);
			}
			return CheckAngleTestList_Marshaler.FromNative(IntPtr.Add(base.Address, CheckAngleTestList_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIFeatureTestInfo:DistanceTest")]
	public FDistanceTest DistanceTest
	{
		get
		{
			CheckDestroyed();
			if (!DistanceTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIFeatureTestInfo:DistanceTest");
				return default(FDistanceTest);
			}
			return FDistanceTest.FromNative(IntPtr.Add(base.Address, DistanceTest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIFeatureTestInfo:DistanceTest");
			}
			else
			{
				FDistanceTest.ToNative(IntPtr.Add(base.Address, DistanceTest_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AIFeatureTestInfo");
		NativeReflection.GetPropertyRef(ref RequiredFeatureList_PropertyAddress, unrealStruct, "RequiredFeatureList");
		RequiredFeatureList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RequiredFeatureList");
		RequiredFeatureList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RequiredFeatureList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InverseList_PropertyAddress, unrealStruct, "InverseList");
		InverseList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InverseList");
		InverseList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InverseList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FeatureTestList_PropertyAddress, unrealStruct, "FeatureTestList");
		FeatureTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FeatureTestList");
		FeatureTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FeatureTestList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CheckAngleTestList_PropertyAddress, unrealStruct, "CheckAngleTestList");
		CheckAngleTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckAngleTestList");
		CheckAngleTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckAngleTestList", Classes.FArrayProperty);
		DistanceTest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistanceTest");
		DistanceTest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistanceTest", Classes.FStructProperty);
	}

	static AIFeatureTestInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AIFeatureTestInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AIFeatureTestInfo));
	}
}
