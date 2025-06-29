using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectChorusBaseSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectChorusBaseSettings
{
	private static bool Depth_IsValid;

	private static int Depth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusBaseSettings:Depth")]
	public float Depth;

	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusBaseSettings:Frequency")]
	public float Frequency;

	private static bool Feedback_IsValid;

	private static int Feedback_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusBaseSettings:Feedback")]
	public float Feedback;

	private static bool WetLevel_IsValid;

	private static int WetLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusBaseSettings:WetLevel")]
	public float WetLevel;

	private static bool DryLevel_IsValid;

	private static int DryLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusBaseSettings:DryLevel")]
	public float DryLevel;

	private static bool Spread_IsValid;

	private static int Spread_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusBaseSettings:Spread")]
	public float Spread;

	private static bool FSourceEffectChorusBaseSettings_IsValid;

	private static int FSourceEffectChorusBaseSettings_StructSize;

	public FSourceEffectChorusBaseSettings Copy()
	{
		return this;
	}

	public static FSourceEffectChorusBaseSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectChorusBaseSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectChorusBaseSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectChorusBaseSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectChorusBaseSettings(nativeBuffer + arrayIndex * FSourceEffectChorusBaseSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectChorusBaseSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectChorusBaseSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectChorusBaseSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectChorusBaseSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Depth_Offset), Depth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Feedback_Offset), Feedback);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WetLevel_Offset), WetLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DryLevel_Offset), DryLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Spread_Offset), Spread);
	}

	public FSourceEffectChorusBaseSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectChorusBaseSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectChorusBaseSettings");
			Depth = 0f;
			Frequency = 0f;
			Feedback = 0f;
			WetLevel = 0f;
			DryLevel = 0f;
			Spread = 0f;
		}
		else
		{
			Depth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Depth_Offset));
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			Feedback = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Feedback_Offset));
			WetLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WetLevel_Offset));
			DryLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DryLevel_Offset));
			Spread = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Spread_Offset));
		}
	}

	static FSourceEffectChorusBaseSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectChorusBaseSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectChorusBaseSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectChorusBaseSettings");
		FSourceEffectChorusBaseSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Depth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Depth");
		Depth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Depth", Classes.FFloatProperty);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		Feedback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Feedback");
		Feedback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Feedback", Classes.FFloatProperty);
		WetLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WetLevel");
		WetLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WetLevel", Classes.FFloatProperty);
		DryLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DryLevel");
		DryLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DryLevel", Classes.FFloatProperty);
		Spread_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Spread");
		Spread_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Spread", Classes.FFloatProperty);
		FSourceEffectChorusBaseSettings_IsValid = intPtr != IntPtr.Zero && Depth_IsValid && Frequency_IsValid && Feedback_IsValid && WetLevel_IsValid && DryLevel_IsValid && Spread_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectChorusBaseSettings", FSourceEffectChorusBaseSettings_IsValid);
	}
}
