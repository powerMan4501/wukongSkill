using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_CompareGamePlusCount")]
public struct FDetectCondition_CompareGamePlusCount
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("比较方式")]
	[USharpPath("/Script/b1-Managed.DetectCondition_CompareGamePlusCount:OperationType")]
	public EValueCompareOperationType OperationType;

	[DisplayName("比较值")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_CompareGamePlusCount:GamePlusCount")]
	public int GamePlusCount;

	private static int DetectCondition_CompareGamePlusCount_StructSize;

	private static int DetectCondition_CompareGamePlusCount_IsValid;

	private static bool OperationType_IsValid;

	private static int OperationType_Offset;

	private static FFieldAddress OperationType_PropertyAddress;

	private static bool GamePlusCount_IsValid;

	private static int GamePlusCount_Offset;

	public FDetectCondition_CompareGamePlusCount Copy()
	{
		return this;
	}

	public static FDetectCondition_CompareGamePlusCount FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_CompareGamePlusCount(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_CompareGamePlusCount value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_CompareGamePlusCount FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_CompareGamePlusCount(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_CompareGamePlusCount_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_CompareGamePlusCount value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_CompareGamePlusCount_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_CompareGamePlusCount_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_CompareGamePlusCount");
			return;
		}
		EnumMarshaler<EValueCompareOperationType>.ToNative(IntPtr.Add(nativeStruct, OperationType_Offset), 0, OperationType_PropertyAddress.Address, OperationType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GamePlusCount_Offset), GamePlusCount);
	}

	public FDetectCondition_CompareGamePlusCount(IntPtr nativeStruct)
	{
		if (DetectCondition_CompareGamePlusCount_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_CompareGamePlusCount");
			OperationType = EValueCompareOperationType.EqualTo;
			GamePlusCount = 0;
		}
		else
		{
			OperationType = EnumMarshaler<EValueCompareOperationType>.FromNative(IntPtr.Add(nativeStruct, OperationType_Offset), 0, OperationType_PropertyAddress.Address);
			GamePlusCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GamePlusCount_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_CompareGamePlusCount");
		DetectCondition_CompareGamePlusCount_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref OperationType_PropertyAddress, intPtr, "OperationType");
		OperationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "OperationType");
		OperationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OperationType", Classes.FEnumProperty);
		GamePlusCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "GamePlusCount");
		GamePlusCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GamePlusCount", Classes.FIntProperty);
		DetectCondition_CompareGamePlusCount_IsValid = ((intPtr != IntPtr.Zero && OperationType_IsValid && GamePlusCount_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_CompareGamePlusCount", (byte)DetectCondition_CompareGamePlusCount_IsValid != 0);
	}

	static FDetectCondition_CompareGamePlusCount()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_CompareGamePlusCount)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_CompareGamePlusCount));
	}
}
