using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_DistanceFromMaster")]
public struct FDetectCondition_DistanceFromMaster
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("距离比较方式")]
	[USharpPath("/Script/b1-Managed.DetectCondition_DistanceFromMaster:DistanceCompareOperations")]
	public EValueCompareOperations DistanceCompareOperations;

	[UProperty]
	[EditAnywhere]
	[DisplayName("距离比较值")]
	[USharpPath("/Script/b1-Managed.DetectCondition_DistanceFromMaster:DistanceCompareValue")]
	public float DistanceCompareValue;

	private static int DetectCondition_DistanceFromMaster_StructSize;

	private static int DetectCondition_DistanceFromMaster_IsValid;

	private static bool DistanceCompareOperations_IsValid;

	private static int DistanceCompareOperations_Offset;

	private static FFieldAddress DistanceCompareOperations_PropertyAddress;

	private static bool DistanceCompareValue_IsValid;

	private static int DistanceCompareValue_Offset;

	public FDetectCondition_DistanceFromMaster Copy()
	{
		return this;
	}

	public static FDetectCondition_DistanceFromMaster FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_DistanceFromMaster(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_DistanceFromMaster value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_DistanceFromMaster FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_DistanceFromMaster(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_DistanceFromMaster_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_DistanceFromMaster value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_DistanceFromMaster_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_DistanceFromMaster_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_DistanceFromMaster");
			return;
		}
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, DistanceCompareOperations_Offset), 0, DistanceCompareOperations_PropertyAddress.Address, DistanceCompareOperations);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceCompareValue_Offset), DistanceCompareValue);
	}

	public FDetectCondition_DistanceFromMaster(IntPtr nativeStruct)
	{
		if (DetectCondition_DistanceFromMaster_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_DistanceFromMaster");
			DistanceCompareOperations = EValueCompareOperations.EqualTo;
			DistanceCompareValue = 0f;
		}
		else
		{
			DistanceCompareOperations = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, DistanceCompareOperations_Offset), 0, DistanceCompareOperations_PropertyAddress.Address);
			DistanceCompareValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceCompareValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_DistanceFromMaster");
		DetectCondition_DistanceFromMaster_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref DistanceCompareOperations_PropertyAddress, intPtr, "DistanceCompareOperations");
		DistanceCompareOperations_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceCompareOperations");
		DistanceCompareOperations_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceCompareOperations", Classes.FEnumProperty);
		DistanceCompareValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceCompareValue");
		DistanceCompareValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceCompareValue", Classes.FFloatProperty);
		DetectCondition_DistanceFromMaster_IsValid = ((intPtr != IntPtr.Zero && DistanceCompareOperations_IsValid && DistanceCompareValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_DistanceFromMaster", (byte)DetectCondition_DistanceFromMaster_IsValid != 0);
	}

	static FDetectCondition_DistanceFromMaster()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_DistanceFromMaster)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_DistanceFromMaster));
	}
}
