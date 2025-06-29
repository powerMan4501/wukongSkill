using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_LastBeAttackedStiffLevel")]
public struct FDetectCondition_LastBeAttackedStiffLevel
{
	[UProperty]
	[DisplayName("属性比较方式")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_LastBeAttackedStiffLevel:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[EditAnywhere]
	[UProperty]
	[DisplayName("属性比较值")]
	[USharpPath("/Script/b1-Managed.DetectCondition_LastBeAttackedStiffLevel:CompareValueInt")]
	public int CompareValueInt;

	private static int DetectCondition_LastBeAttackedStiffLevel_StructSize;

	private static int DetectCondition_LastBeAttackedStiffLevel_IsValid;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValueInt_IsValid;

	private static int CompareValueInt_Offset;

	public FDetectCondition_LastBeAttackedStiffLevel Copy()
	{
		return this;
	}

	public static FDetectCondition_LastBeAttackedStiffLevel FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_LastBeAttackedStiffLevel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_LastBeAttackedStiffLevel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_LastBeAttackedStiffLevel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_LastBeAttackedStiffLevel(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_LastBeAttackedStiffLevel_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_LastBeAttackedStiffLevel value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_LastBeAttackedStiffLevel_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_LastBeAttackedStiffLevel_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_LastBeAttackedStiffLevel");
			return;
		}
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CompareValueInt_Offset), CompareValueInt);
	}

	public FDetectCondition_LastBeAttackedStiffLevel(IntPtr nativeStruct)
	{
		if (DetectCondition_LastBeAttackedStiffLevel_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_LastBeAttackedStiffLevel");
			CompareOperation = EValueCompareOperations.EqualTo;
			CompareValueInt = 0;
		}
		else
		{
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			CompareValueInt = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CompareValueInt_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_LastBeAttackedStiffLevel");
		DetectCondition_LastBeAttackedStiffLevel_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValueInt_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValueInt");
		CompareValueInt_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValueInt", Classes.FIntProperty);
		DetectCondition_LastBeAttackedStiffLevel_IsValid = ((intPtr != IntPtr.Zero && CompareOperation_IsValid && CompareValueInt_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_LastBeAttackedStiffLevel", (byte)DetectCondition_LastBeAttackedStiffLevel_IsValid != 0);
	}

	static FDetectCondition_LastBeAttackedStiffLevel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_LastBeAttackedStiffLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_LastBeAttackedStiffLevel));
	}
}
