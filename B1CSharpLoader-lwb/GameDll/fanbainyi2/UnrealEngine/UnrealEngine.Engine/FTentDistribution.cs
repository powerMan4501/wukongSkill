using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.TentDistribution", "Engine", UnrealModuleType.Engine)]
public struct FTentDistribution
{
	private static bool TipAltitude_IsValid;

	private static int TipAltitude_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.TentDistribution:TipAltitude")]
	public float TipAltitude;

	private static bool TipValue_IsValid;

	private static int TipValue_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.TentDistribution:TipValue")]
	public float TipValue;

	private static bool Width_IsValid;

	private static int Width_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.TentDistribution:Width")]
	public float Width;

	private static bool FTentDistribution_IsValid;

	private static int FTentDistribution_StructSize;

	public FTentDistribution Copy()
	{
		return this;
	}

	public static FTentDistribution FromNative(IntPtr nativeBuffer)
	{
		return new FTentDistribution(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTentDistribution value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTentDistribution FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTentDistribution(nativeBuffer + arrayIndex * FTentDistribution_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTentDistribution value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTentDistribution_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTentDistribution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TentDistribution");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TipAltitude_Offset), TipAltitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TipValue_Offset), TipValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Width_Offset), Width);
	}

	public FTentDistribution(IntPtr nativeStruct)
	{
		if (!FTentDistribution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TentDistribution");
			TipAltitude = 0f;
			TipValue = 0f;
			Width = 0f;
		}
		else
		{
			TipAltitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TipAltitude_Offset));
			TipValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TipValue_Offset));
			Width = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Width_Offset));
		}
	}

	static FTentDistribution()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTentDistribution)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTentDistribution));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TentDistribution");
		FTentDistribution_StructSize = NativeReflection.GetStructSize(intPtr);
		TipAltitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TipAltitude");
		TipAltitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TipAltitude", Classes.FFloatProperty);
		TipValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TipValue");
		TipValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TipValue", Classes.FFloatProperty);
		Width_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Width");
		Width_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Width", Classes.FFloatProperty);
		FTentDistribution_IsValid = intPtr != IntPtr.Zero && TipAltitude_IsValid && TipValue_IsValid && Width_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.TentDistribution", FTentDistribution_IsValid);
	}
}
