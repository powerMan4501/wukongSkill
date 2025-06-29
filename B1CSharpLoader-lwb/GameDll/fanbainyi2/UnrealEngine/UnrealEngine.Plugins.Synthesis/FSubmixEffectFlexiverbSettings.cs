using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectFlexiverbSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSubmixEffectFlexiverbSettings
{
	private static bool PreDelay_IsValid;

	private static int PreDelay_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFlexiverbSettings:PreDelay")]
	public float PreDelay;

	private static bool DecayTime_IsValid;

	private static int DecayTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFlexiverbSettings:DecayTime")]
	public float DecayTime;

	private static bool RoomDampening_IsValid;

	private static int RoomDampening_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFlexiverbSettings:RoomDampening")]
	public float RoomDampening;

	private static bool Complexity_IsValid;

	private static int Complexity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFlexiverbSettings:Complexity")]
	public int Complexity;

	private static bool FSubmixEffectFlexiverbSettings_IsValid;

	private static int FSubmixEffectFlexiverbSettings_StructSize;

	public FSubmixEffectFlexiverbSettings Copy()
	{
		return this;
	}

	public static FSubmixEffectFlexiverbSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectFlexiverbSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectFlexiverbSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectFlexiverbSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectFlexiverbSettings(nativeBuffer + arrayIndex * FSubmixEffectFlexiverbSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectFlexiverbSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectFlexiverbSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectFlexiverbSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectFlexiverbSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PreDelay_Offset), PreDelay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DecayTime_Offset), DecayTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RoomDampening_Offset), RoomDampening);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Complexity_Offset), Complexity);
	}

	public FSubmixEffectFlexiverbSettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectFlexiverbSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectFlexiverbSettings");
			PreDelay = 0f;
			DecayTime = 0f;
			RoomDampening = 0f;
			Complexity = 0;
		}
		else
		{
			PreDelay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PreDelay_Offset));
			DecayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DecayTime_Offset));
			RoomDampening = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RoomDampening_Offset));
			Complexity = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Complexity_Offset));
		}
	}

	static FSubmixEffectFlexiverbSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectFlexiverbSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectFlexiverbSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SubmixEffectFlexiverbSettings");
		FSubmixEffectFlexiverbSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		PreDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreDelay");
		PreDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreDelay", Classes.FFloatProperty);
		DecayTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DecayTime");
		DecayTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DecayTime", Classes.FFloatProperty);
		RoomDampening_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoomDampening");
		RoomDampening_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoomDampening", Classes.FFloatProperty);
		Complexity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Complexity");
		Complexity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Complexity", Classes.FIntProperty);
		FSubmixEffectFlexiverbSettings_IsValid = intPtr != IntPtr.Zero && PreDelay_IsValid && DecayTime_IsValid && RoomDampening_IsValid && Complexity_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SubmixEffectFlexiverbSettings", FSubmixEffectFlexiverbSettings_IsValid);
	}
}
