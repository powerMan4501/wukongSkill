using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AIPointTestInfo")]
public class AIPointTestInfo : UObject
{
	public bool IsRandom;

	private static bool RingPointGenerate_IsValid;

	private static int RingPointGenerate_Offset;

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

	private static bool PointGenBaseType_IsValid;

	private static int PointGenBaseType_Offset;

	private static FFieldAddress PointGenBaseType_PropertyAddress;

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIPointTestInfo:RingPointGenerate")]
	public FRingPointGenerate RingPointGenerate
	{
		get
		{
			CheckDestroyed();
			if (!RingPointGenerate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIPointTestInfo:RingPointGenerate");
				return default(FRingPointGenerate);
			}
			return BlittableTypeMarshaler<FRingPointGenerate>.FromNative(IntPtr.Add(base.Address, RingPointGenerate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RingPointGenerate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIPointTestInfo:RingPointGenerate");
			}
			else
			{
				BlittableTypeMarshaler<FRingPointGenerate>.ToNative(IntPtr.Add(base.Address, RingPointGenerate_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIPointTestInfo:PointTestList")]
	public TArrayReadWrite<EPointTestType> PointTestList
	{
		get
		{
			CheckDestroyed();
			if (!PointTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIPointTestInfo:PointTestList");
				return null;
			}
			if (PointTestList_Marshaler == null)
			{
				PointTestList_Marshaler = new TArrayReadWriteMarshaler<EPointTestType>(1, PointTestList_PropertyAddress, CachedMarshalingDelegates<EPointTestType, EnumMarshaler<EPointTestType>>.FromNative, CachedMarshalingDelegates<EPointTestType, EnumMarshaler<EPointTestType>>.ToNative);
			}
			return PointTestList_Marshaler.FromNative(IntPtr.Add(base.Address, PointTestList_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIPointTestInfo:CheckAngleTestList")]
	public TArrayReadWrite<FCheckAngleTest> CheckAngleTestList
	{
		get
		{
			CheckDestroyed();
			if (!CheckAngleTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIPointTestInfo:CheckAngleTestList");
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
	[USharpPath("/Script/b1-Managed.AIPointTestInfo:DistanceTest")]
	public FDistanceTest DistanceTest
	{
		get
		{
			CheckDestroyed();
			if (!DistanceTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIPointTestInfo:DistanceTest");
				return default(FDistanceTest);
			}
			return FDistanceTest.FromNative(IntPtr.Add(base.Address, DistanceTest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIPointTestInfo:DistanceTest");
			}
			else
			{
				FDistanceTest.ToNative(IntPtr.Add(base.Address, DistanceTest_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIPointTestInfo:PointGenBaseType")]
	public EPointGenBaseType PointGenBaseType
	{
		get
		{
			CheckDestroyed();
			if (!PointGenBaseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIPointTestInfo:PointGenBaseType");
				return EPointGenBaseType.OwnCharacter;
			}
			return EnumMarshaler<EPointGenBaseType>.FromNative(IntPtr.Add(base.Address, PointGenBaseType_Offset), 0, PointGenBaseType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PointGenBaseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIPointTestInfo:PointGenBaseType");
			}
			else
			{
				EnumMarshaler<EPointGenBaseType>.ToNative(IntPtr.Add(base.Address, PointGenBaseType_Offset), 0, PointGenBaseType_PropertyAddress.Address, value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AIPointTestInfo");
		RingPointGenerate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RingPointGenerate");
		RingPointGenerate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RingPointGenerate", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref PointTestList_PropertyAddress, unrealStruct, "PointTestList");
		PointTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointTestList");
		PointTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointTestList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CheckAngleTestList_PropertyAddress, unrealStruct, "CheckAngleTestList");
		CheckAngleTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckAngleTestList");
		CheckAngleTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckAngleTestList", Classes.FArrayProperty);
		DistanceTest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistanceTest");
		DistanceTest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistanceTest", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref PointGenBaseType_PropertyAddress, unrealStruct, "PointGenBaseType");
		PointGenBaseType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointGenBaseType");
		PointGenBaseType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointGenBaseType", Classes.FEnumProperty);
	}

	static AIPointTestInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AIPointTestInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AIPointTestInfo));
	}
}
