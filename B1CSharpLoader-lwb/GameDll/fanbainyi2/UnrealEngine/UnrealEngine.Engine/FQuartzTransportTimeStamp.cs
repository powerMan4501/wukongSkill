using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.QuartzTransportTimeStamp", "Engine", UnrealModuleType.Engine)]
public struct FQuartzTransportTimeStamp
{
	private static bool Bars_IsValid;

	private static int Bars_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.QuartzTransportTimeStamp:Bars")]
	public int Bars;

	private static bool Beat_IsValid;

	private static int Beat_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.QuartzTransportTimeStamp:Beat")]
	public int Beat;

	private static bool BeatFraction_IsValid;

	private static int BeatFraction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.QuartzTransportTimeStamp:BeatFraction")]
	public float BeatFraction;

	private static bool Seconds_IsValid;

	private static int Seconds_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.QuartzTransportTimeStamp:Seconds")]
	public float Seconds;

	private static bool FQuartzTransportTimeStamp_IsValid;

	private static int FQuartzTransportTimeStamp_StructSize;

	public FQuartzTransportTimeStamp Copy()
	{
		return this;
	}

	public static FQuartzTransportTimeStamp FromNative(IntPtr nativeBuffer)
	{
		return new FQuartzTransportTimeStamp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FQuartzTransportTimeStamp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FQuartzTransportTimeStamp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FQuartzTransportTimeStamp(nativeBuffer + arrayIndex * FQuartzTransportTimeStamp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FQuartzTransportTimeStamp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FQuartzTransportTimeStamp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FQuartzTransportTimeStamp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzTransportTimeStamp");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Bars_Offset), Bars);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Beat_Offset), Beat);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeatFraction_Offset), BeatFraction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Seconds_Offset), Seconds);
	}

	public FQuartzTransportTimeStamp(IntPtr nativeStruct)
	{
		if (!FQuartzTransportTimeStamp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzTransportTimeStamp");
			Bars = 0;
			Beat = 0;
			BeatFraction = 0f;
			Seconds = 0f;
		}
		else
		{
			Bars = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Bars_Offset));
			Beat = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Beat_Offset));
			BeatFraction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeatFraction_Offset));
			Seconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Seconds_Offset));
		}
	}

	static FQuartzTransportTimeStamp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FQuartzTransportTimeStamp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FQuartzTransportTimeStamp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.QuartzTransportTimeStamp");
		FQuartzTransportTimeStamp_StructSize = NativeReflection.GetStructSize(intPtr);
		Bars_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bars");
		Bars_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bars", Classes.FIntProperty);
		Beat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Beat");
		Beat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Beat", Classes.FIntProperty);
		BeatFraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BeatFraction");
		BeatFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BeatFraction", Classes.FFloatProperty);
		Seconds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Seconds");
		Seconds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Seconds", Classes.FFloatProperty);
		FQuartzTransportTimeStamp_IsValid = intPtr != IntPtr.Zero && Bars_IsValid && Beat_IsValid && BeatFraction_IsValid && Seconds_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.QuartzTransportTimeStamp", FQuartzTransportTimeStamp_IsValid);
	}
}
