using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_DistanceFromNearestPlayer")]
public struct FDetectCondition_DistanceFromNearestPlayer
{
	[DisplayName("属性比较方式")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_DistanceFromNearestPlayer:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[DisplayName("属性比较值")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_DistanceFromNearestPlayer:CompareValueInt")]
	public int CompareValueInt;

	private static int DetectCondition_DistanceFromNearestPlayer_StructSize;

	private static int DetectCondition_DistanceFromNearestPlayer_IsValid;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValueInt_IsValid;

	private static int CompareValueInt_Offset;

	public FDetectCondition_DistanceFromNearestPlayer Copy()
	{
		return this;
	}

	public static FDetectCondition_DistanceFromNearestPlayer FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_DistanceFromNearestPlayer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_DistanceFromNearestPlayer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_DistanceFromNearestPlayer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_DistanceFromNearestPlayer(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_DistanceFromNearestPlayer_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_DistanceFromNearestPlayer value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_DistanceFromNearestPlayer_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_DistanceFromNearestPlayer_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_DistanceFromNearestPlayer");
			return;
		}
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CompareValueInt_Offset), CompareValueInt);
	}

	public FDetectCondition_DistanceFromNearestPlayer(IntPtr nativeStruct)
	{
		if (DetectCondition_DistanceFromNearestPlayer_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_DistanceFromNearestPlayer");
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
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_DistanceFromNearestPlayer");
		DetectCondition_DistanceFromNearestPlayer_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValueInt_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValueInt");
		CompareValueInt_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValueInt", Classes.FIntProperty);
		DetectCondition_DistanceFromNearestPlayer_IsValid = ((intPtr != IntPtr.Zero && CompareOperation_IsValid && CompareValueInt_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_DistanceFromNearestPlayer", (byte)DetectCondition_DistanceFromNearestPlayer_IsValid != 0);
	}

	static FDetectCondition_DistanceFromNearestPlayer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_DistanceFromNearestPlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_DistanceFromNearestPlayer));
	}
}
