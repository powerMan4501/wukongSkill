using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputScaleBiasClampConstants", "Engine", UnrealModuleType.Engine)]
public struct FInputScaleBiasClampConstants
{
	private static bool MapRange_IsValid;

	private static FFieldAddress MapRange_PropertyAddress;

	private static int MapRange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:bMapRange")]
	public bool MapRange;

	private static bool ClampResult_IsValid;

	private static FFieldAddress ClampResult_PropertyAddress;

	private static int ClampResult_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:bClampResult")]
	public bool ClampResult;

	private static bool InterpResult_IsValid;

	private static FFieldAddress InterpResult_PropertyAddress;

	private static int InterpResult_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:bInterpResult")]
	public bool InterpResult;

	private static bool InRange_IsValid;

	private static int InRange_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:InRange")]
	public FInputRange InRange;

	private static bool OutRange_IsValid;

	private static int OutRange_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:OutRange")]
	public FInputRange OutRange;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:Scale")]
	public float Scale;

	private static bool Bias_IsValid;

	private static int Bias_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:Bias")]
	public float Bias;

	private static bool ClampMin_IsValid;

	private static int ClampMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:ClampMin")]
	public float ClampMin;

	private static bool ClampMax_IsValid;

	private static int ClampMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:ClampMax")]
	public float ClampMax;

	private static bool InterpSpeedIncreasing_IsValid;

	private static int InterpSpeedIncreasing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:InterpSpeedIncreasing")]
	public float InterpSpeedIncreasing;

	private static bool InterpSpeedDecreasing_IsValid;

	private static int InterpSpeedDecreasing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBiasClampConstants:InterpSpeedDecreasing")]
	public float InterpSpeedDecreasing;

	private static bool FInputScaleBiasClampConstants_IsValid;

	private static int FInputScaleBiasClampConstants_StructSize;

	public FInputScaleBiasClampConstants Copy()
	{
		return this;
	}

	public static FInputScaleBiasClampConstants FromNative(IntPtr nativeBuffer)
	{
		return new FInputScaleBiasClampConstants(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputScaleBiasClampConstants value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputScaleBiasClampConstants FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputScaleBiasClampConstants(nativeBuffer + arrayIndex * FInputScaleBiasClampConstants_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputScaleBiasClampConstants value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputScaleBiasClampConstants_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputScaleBiasClampConstants_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputScaleBiasClampConstants");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MapRange_Offset), 0, MapRange_PropertyAddress.Address, MapRange);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ClampResult_Offset), 0, ClampResult_PropertyAddress.Address, ClampResult);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InterpResult_Offset), 0, InterpResult_PropertyAddress.Address, InterpResult);
		FInputRange.ToNative(IntPtr.Add(nativeStruct, InRange_Offset), InRange);
		FInputRange.ToNative(IntPtr.Add(nativeStruct, OutRange_Offset), OutRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Bias_Offset), Bias);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ClampMin_Offset), ClampMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ClampMax_Offset), ClampMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InterpSpeedIncreasing_Offset), InterpSpeedIncreasing);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InterpSpeedDecreasing_Offset), InterpSpeedDecreasing);
	}

	public FInputScaleBiasClampConstants(IntPtr nativeStruct)
	{
		if (!FInputScaleBiasClampConstants_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputScaleBiasClampConstants");
			MapRange = false;
			ClampResult = false;
			InterpResult = false;
			InRange = default(FInputRange);
			OutRange = default(FInputRange);
			Scale = 0f;
			Bias = 0f;
			ClampMin = 0f;
			ClampMax = 0f;
			InterpSpeedIncreasing = 0f;
			InterpSpeedDecreasing = 0f;
		}
		else
		{
			MapRange = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MapRange_Offset), 0, MapRange_PropertyAddress.Address);
			ClampResult = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ClampResult_Offset), 0, ClampResult_PropertyAddress.Address);
			InterpResult = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InterpResult_Offset), 0, InterpResult_PropertyAddress.Address);
			InRange = FInputRange.FromNative(IntPtr.Add(nativeStruct, InRange_Offset));
			OutRange = FInputRange.FromNative(IntPtr.Add(nativeStruct, OutRange_Offset));
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Bias = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Bias_Offset));
			ClampMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ClampMin_Offset));
			ClampMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ClampMax_Offset));
			InterpSpeedIncreasing = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InterpSpeedIncreasing_Offset));
			InterpSpeedDecreasing = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InterpSpeedDecreasing_Offset));
		}
	}

	static FInputScaleBiasClampConstants()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputScaleBiasClampConstants)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputScaleBiasClampConstants));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputScaleBiasClampConstants");
		FInputScaleBiasClampConstants_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MapRange_PropertyAddress, intPtr, "bMapRange");
		MapRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMapRange");
		MapRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMapRange", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClampResult_PropertyAddress, intPtr, "bClampResult");
		ClampResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClampResult");
		ClampResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClampResult", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpResult_PropertyAddress, intPtr, "bInterpResult");
		InterpResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInterpResult");
		InterpResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInterpResult", Classes.FBoolProperty);
		InRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InRange");
		InRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InRange", Classes.FStructProperty);
		OutRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutRange");
		OutRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutRange", Classes.FStructProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		Bias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bias");
		Bias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bias", Classes.FFloatProperty);
		ClampMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClampMin");
		ClampMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClampMin", Classes.FFloatProperty);
		ClampMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClampMax");
		ClampMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClampMax", Classes.FFloatProperty);
		InterpSpeedIncreasing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpSpeedIncreasing");
		InterpSpeedIncreasing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpSpeedIncreasing", Classes.FFloatProperty);
		InterpSpeedDecreasing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpSpeedDecreasing");
		InterpSpeedDecreasing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpSpeedDecreasing", Classes.FFloatProperty);
		FInputScaleBiasClampConstants_IsValid = intPtr != IntPtr.Zero && MapRange_IsValid && ClampResult_IsValid && InterpResult_IsValid && InRange_IsValid && OutRange_IsValid && Scale_IsValid && Bias_IsValid && ClampMin_IsValid && ClampMax_IsValid && InterpSpeedIncreasing_IsValid && InterpSpeedDecreasing_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.InputScaleBiasClampConstants", FInputScaleBiasClampConstants_IsValid);
	}
}
