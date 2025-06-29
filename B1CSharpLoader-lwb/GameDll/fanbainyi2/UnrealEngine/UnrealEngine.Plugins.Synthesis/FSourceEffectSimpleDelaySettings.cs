using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectSimpleDelaySettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectSimpleDelaySettings
{
	private static bool SpeedOfSound_IsValid;

	private static int SpeedOfSound_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectSimpleDelaySettings:SpeedOfSound")]
	public float SpeedOfSound;

	private static bool DelayAmount_IsValid;

	private static int DelayAmount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectSimpleDelaySettings:DelayAmount")]
	public float DelayAmount;

	private static bool DryAmount_IsValid;

	private static int DryAmount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectSimpleDelaySettings:DryAmount")]
	public float DryAmount;

	private static bool WetAmount_IsValid;

	private static int WetAmount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectSimpleDelaySettings:WetAmount")]
	public float WetAmount;

	private static bool Feedback_IsValid;

	private static int Feedback_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectSimpleDelaySettings:Feedback")]
	public float Feedback;

	private static bool DelayBasedOnDistance_IsValid;

	private static FFieldAddress DelayBasedOnDistance_PropertyAddress;

	private static int DelayBasedOnDistance_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectSimpleDelaySettings:bDelayBasedOnDistance")]
	public bool DelayBasedOnDistance;

	private static bool FSourceEffectSimpleDelaySettings_IsValid;

	private static int FSourceEffectSimpleDelaySettings_StructSize;

	public FSourceEffectSimpleDelaySettings Copy()
	{
		return this;
	}

	public static FSourceEffectSimpleDelaySettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectSimpleDelaySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectSimpleDelaySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectSimpleDelaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectSimpleDelaySettings(nativeBuffer + arrayIndex * FSourceEffectSimpleDelaySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectSimpleDelaySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectSimpleDelaySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectSimpleDelaySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectSimpleDelaySettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpeedOfSound_Offset), SpeedOfSound);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayAmount_Offset), DelayAmount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DryAmount_Offset), DryAmount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WetAmount_Offset), WetAmount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Feedback_Offset), Feedback);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DelayBasedOnDistance_Offset), 0, DelayBasedOnDistance_PropertyAddress.Address, DelayBasedOnDistance);
	}

	public FSourceEffectSimpleDelaySettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectSimpleDelaySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectSimpleDelaySettings");
			SpeedOfSound = 0f;
			DelayAmount = 0f;
			DryAmount = 0f;
			WetAmount = 0f;
			Feedback = 0f;
			DelayBasedOnDistance = false;
		}
		else
		{
			SpeedOfSound = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpeedOfSound_Offset));
			DelayAmount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayAmount_Offset));
			DryAmount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DryAmount_Offset));
			WetAmount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WetAmount_Offset));
			Feedback = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Feedback_Offset));
			DelayBasedOnDistance = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DelayBasedOnDistance_Offset), 0, DelayBasedOnDistance_PropertyAddress.Address);
		}
	}

	static FSourceEffectSimpleDelaySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectSimpleDelaySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectSimpleDelaySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectSimpleDelaySettings");
		FSourceEffectSimpleDelaySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		SpeedOfSound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedOfSound");
		SpeedOfSound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedOfSound", Classes.FFloatProperty);
		DelayAmount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DelayAmount");
		DelayAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DelayAmount", Classes.FFloatProperty);
		DryAmount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DryAmount");
		DryAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DryAmount", Classes.FFloatProperty);
		WetAmount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WetAmount");
		WetAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WetAmount", Classes.FFloatProperty);
		Feedback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Feedback");
		Feedback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Feedback", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DelayBasedOnDistance_PropertyAddress, intPtr, "bDelayBasedOnDistance");
		DelayBasedOnDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDelayBasedOnDistance");
		DelayBasedOnDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDelayBasedOnDistance", Classes.FBoolProperty);
		FSourceEffectSimpleDelaySettings_IsValid = intPtr != IntPtr.Zero && SpeedOfSound_IsValid && DelayAmount_IsValid && DryAmount_IsValid && WetAmount_IsValid && Feedback_IsValid && DelayBasedOnDistance_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectSimpleDelaySettings", FSourceEffectSimpleDelaySettings_IsValid);
	}
}
