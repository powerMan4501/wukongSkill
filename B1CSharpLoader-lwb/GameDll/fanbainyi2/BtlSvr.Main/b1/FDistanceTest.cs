using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.DistanceTest")]
public struct FDistanceTest
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DistanceTest")]
	[USharpPath("/Script/b1-Managed.DistanceTest:DisTestType")]
	public EDisTestFilterType DisTestType;

	[Category("DistanceTest")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DistanceTest:DisBaseType")]
	public EDisTestBaseType DisBaseType;

	private static int DistanceTest_StructSize;

	private static int DistanceTest_IsValid;

	private static bool DisTestType_IsValid;

	private static int DisTestType_Offset;

	private static FFieldAddress DisTestType_PropertyAddress;

	private static bool DisBaseType_IsValid;

	private static int DisBaseType_Offset;

	private static FFieldAddress DisBaseType_PropertyAddress;

	public FDistanceTest Copy()
	{
		return this;
	}

	public static FDistanceTest FromNative(IntPtr nativeBuffer)
	{
		return new FDistanceTest(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDistanceTest value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDistanceTest FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDistanceTest(IntPtr.Add(nativeBuffer, arrayIndex * DistanceTest_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDistanceTest value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DistanceTest_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DistanceTest_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DistanceTest");
			return;
		}
		EnumMarshaler<EDisTestFilterType>.ToNative(IntPtr.Add(nativeStruct, DisTestType_Offset), 0, DisTestType_PropertyAddress.Address, DisTestType);
		EnumMarshaler<EDisTestBaseType>.ToNative(IntPtr.Add(nativeStruct, DisBaseType_Offset), 0, DisBaseType_PropertyAddress.Address, DisBaseType);
	}

	public FDistanceTest(IntPtr nativeStruct)
	{
		if (DistanceTest_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DistanceTest");
			DisTestType = EDisTestFilterType.DTF_Min;
			DisBaseType = EDisTestBaseType.OwnCharacter;
		}
		else
		{
			DisTestType = EnumMarshaler<EDisTestFilterType>.FromNative(IntPtr.Add(nativeStruct, DisTestType_Offset), 0, DisTestType_PropertyAddress.Address);
			DisBaseType = EnumMarshaler<EDisTestBaseType>.FromNative(IntPtr.Add(nativeStruct, DisBaseType_Offset), 0, DisBaseType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DistanceTest");
		DistanceTest_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref DisTestType_PropertyAddress, intPtr, "DisTestType");
		DisTestType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisTestType");
		DisTestType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisTestType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DisBaseType_PropertyAddress, intPtr, "DisBaseType");
		DisBaseType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisBaseType");
		DisBaseType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisBaseType", Classes.FEnumProperty);
		DistanceTest_IsValid = ((intPtr != IntPtr.Zero && DisTestType_IsValid && DisBaseType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DistanceTest", (byte)DistanceTest_IsValid != 0);
	}

	static FDistanceTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDistanceTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDistanceTest));
	}
}
