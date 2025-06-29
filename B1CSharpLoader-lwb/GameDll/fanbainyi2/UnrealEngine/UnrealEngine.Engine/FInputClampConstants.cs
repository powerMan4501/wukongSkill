using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputClampConstants", "Engine", UnrealModuleType.Engine)]
public struct FInputClampConstants
{
	private static bool ClampResult_IsValid;

	private static FFieldAddress ClampResult_PropertyAddress;

	private static int ClampResult_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputClampConstants:bClampResult")]
	public bool ClampResult;

	private static bool InterpResult_IsValid;

	private static FFieldAddress InterpResult_PropertyAddress;

	private static int InterpResult_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputClampConstants:bInterpResult")]
	public bool InterpResult;

	private static bool ClampMin_IsValid;

	private static int ClampMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputClampConstants:ClampMin")]
	public float ClampMin;

	private static bool ClampMax_IsValid;

	private static int ClampMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputClampConstants:ClampMax")]
	public float ClampMax;

	private static bool InterpSpeedIncreasing_IsValid;

	private static int InterpSpeedIncreasing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputClampConstants:InterpSpeedIncreasing")]
	public float InterpSpeedIncreasing;

	private static bool InterpSpeedDecreasing_IsValid;

	private static int InterpSpeedDecreasing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputClampConstants:InterpSpeedDecreasing")]
	public float InterpSpeedDecreasing;

	private static bool FInputClampConstants_IsValid;

	private static int FInputClampConstants_StructSize;

	public FInputClampConstants Copy()
	{
		return this;
	}

	public static FInputClampConstants FromNative(IntPtr nativeBuffer)
	{
		return new FInputClampConstants(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputClampConstants value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputClampConstants FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputClampConstants(nativeBuffer + arrayIndex * FInputClampConstants_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputClampConstants value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputClampConstants_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputClampConstants_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputClampConstants");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ClampResult_Offset), 0, ClampResult_PropertyAddress.Address, ClampResult);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InterpResult_Offset), 0, InterpResult_PropertyAddress.Address, InterpResult);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ClampMin_Offset), ClampMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ClampMax_Offset), ClampMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InterpSpeedIncreasing_Offset), InterpSpeedIncreasing);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InterpSpeedDecreasing_Offset), InterpSpeedDecreasing);
	}

	public FInputClampConstants(IntPtr nativeStruct)
	{
		if (!FInputClampConstants_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputClampConstants");
			ClampResult = false;
			InterpResult = false;
			ClampMin = 0f;
			ClampMax = 0f;
			InterpSpeedIncreasing = 0f;
			InterpSpeedDecreasing = 0f;
		}
		else
		{
			ClampResult = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ClampResult_Offset), 0, ClampResult_PropertyAddress.Address);
			InterpResult = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InterpResult_Offset), 0, InterpResult_PropertyAddress.Address);
			ClampMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ClampMin_Offset));
			ClampMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ClampMax_Offset));
			InterpSpeedIncreasing = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InterpSpeedIncreasing_Offset));
			InterpSpeedDecreasing = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InterpSpeedDecreasing_Offset));
		}
	}

	static FInputClampConstants()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputClampConstants)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputClampConstants));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputClampConstants");
		FInputClampConstants_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ClampResult_PropertyAddress, intPtr, "bClampResult");
		ClampResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClampResult");
		ClampResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClampResult", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpResult_PropertyAddress, intPtr, "bInterpResult");
		InterpResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInterpResult");
		InterpResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInterpResult", Classes.FBoolProperty);
		ClampMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClampMin");
		ClampMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClampMin", Classes.FFloatProperty);
		ClampMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClampMax");
		ClampMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClampMax", Classes.FFloatProperty);
		InterpSpeedIncreasing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpSpeedIncreasing");
		InterpSpeedIncreasing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpSpeedIncreasing", Classes.FFloatProperty);
		InterpSpeedDecreasing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpSpeedDecreasing");
		InterpSpeedDecreasing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpSpeedDecreasing", Classes.FFloatProperty);
		FInputClampConstants_IsValid = intPtr != IntPtr.Zero && ClampResult_IsValid && InterpResult_IsValid && ClampMin_IsValid && ClampMax_IsValid && InterpSpeedIncreasing_IsValid && InterpSpeedDecreasing_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.InputClampConstants", FInputClampConstants_IsValid);
	}
}
