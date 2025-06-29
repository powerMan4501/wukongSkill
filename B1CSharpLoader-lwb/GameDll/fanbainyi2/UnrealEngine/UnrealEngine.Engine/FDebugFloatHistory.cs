using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.DebugFloatHistory", "Engine", UnrealModuleType.Engine)]
public struct FDebugFloatHistory
{
	private static bool MaxSamples_IsValid;

	private static int MaxSamples_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DebugFloatHistory:MaxSamples")]
	public int MaxSamples;

	private static bool MinValue_IsValid;

	private static int MinValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DebugFloatHistory:MinValue")]
	public float MinValue;

	private static bool MaxValue_IsValid;

	private static int MaxValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DebugFloatHistory:MaxValue")]
	public float MaxValue;

	private static bool AutoAdjustMinMax_IsValid;

	private static FFieldAddress AutoAdjustMinMax_PropertyAddress;

	private static int AutoAdjustMinMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DebugFloatHistory:bAutoAdjustMinMax")]
	public bool AutoAdjustMinMax;

	private static bool FDebugFloatHistory_IsValid;

	private static int FDebugFloatHistory_StructSize;

	public FDebugFloatHistory Copy()
	{
		return this;
	}

	public static FDebugFloatHistory FromNative(IntPtr nativeBuffer)
	{
		return new FDebugFloatHistory(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDebugFloatHistory value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDebugFloatHistory FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDebugFloatHistory(nativeBuffer + arrayIndex * FDebugFloatHistory_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDebugFloatHistory value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDebugFloatHistory_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDebugFloatHistory_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DebugFloatHistory");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxSamples_Offset), MaxSamples);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinValue_Offset), MinValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxValue_Offset), MaxValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoAdjustMinMax_Offset), 0, AutoAdjustMinMax_PropertyAddress.Address, AutoAdjustMinMax);
	}

	public FDebugFloatHistory(IntPtr nativeStruct)
	{
		if (!FDebugFloatHistory_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DebugFloatHistory");
			MaxSamples = 0;
			MinValue = 0f;
			MaxValue = 0f;
			AutoAdjustMinMax = false;
		}
		else
		{
			MaxSamples = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxSamples_Offset));
			MinValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinValue_Offset));
			MaxValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxValue_Offset));
			AutoAdjustMinMax = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoAdjustMinMax_Offset), 0, AutoAdjustMinMax_PropertyAddress.Address);
		}
	}

	static FDebugFloatHistory()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDebugFloatHistory)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDebugFloatHistory));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.DebugFloatHistory");
		FDebugFloatHistory_StructSize = NativeReflection.GetStructSize(intPtr);
		MaxSamples_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSamples");
		MaxSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSamples", Classes.FIntProperty);
		MinValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinValue");
		MinValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinValue", Classes.FFloatProperty);
		MaxValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxValue");
		MaxValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAdjustMinMax_PropertyAddress, intPtr, "bAutoAdjustMinMax");
		AutoAdjustMinMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoAdjustMinMax");
		AutoAdjustMinMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoAdjustMinMax", Classes.FBoolProperty);
		FDebugFloatHistory_IsValid = intPtr != IntPtr.Zero && MaxSamples_IsValid && MinValue_IsValid && MaxValue_IsValid && AutoAdjustMinMax_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.DebugFloatHistory", FDebugFloatHistory_IsValid);
	}
}
