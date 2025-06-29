using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SourceEffectChainEntry", "Engine", UnrealModuleType.Engine)]
public struct FSourceEffectChainEntry
{
	private static bool Preset_IsValid;

	private static int Preset_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SourceEffectChainEntry:Preset")]
	public USoundEffectSourcePreset Preset;

	private static bool Bypass_IsValid;

	private static FFieldAddress Bypass_PropertyAddress;

	private static int Bypass_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SourceEffectChainEntry:bBypass")]
	public bool Bypass;

	private static bool FSourceEffectChainEntry_IsValid;

	private static int FSourceEffectChainEntry_StructSize;

	public FSourceEffectChainEntry Copy()
	{
		return this;
	}

	public static FSourceEffectChainEntry FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectChainEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectChainEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectChainEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectChainEntry(nativeBuffer + arrayIndex * FSourceEffectChainEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectChainEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectChainEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectChainEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SourceEffectChainEntry");
			return;
		}
		UObjectMarshaler<USoundEffectSourcePreset>.ToNative(IntPtr.Add(nativeStruct, Preset_Offset), Preset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address, Bypass);
	}

	public FSourceEffectChainEntry(IntPtr nativeStruct)
	{
		if (!FSourceEffectChainEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SourceEffectChainEntry");
			Preset = null;
			Bypass = false;
		}
		else
		{
			Preset = UObjectMarshaler<USoundEffectSourcePreset>.FromNative(IntPtr.Add(nativeStruct, Preset_Offset));
			Bypass = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address);
		}
	}

	static FSourceEffectChainEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectChainEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectChainEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SourceEffectChainEntry");
		FSourceEffectChainEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		Preset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Preset");
		Preset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Preset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Bypass_PropertyAddress, intPtr, "bBypass");
		Bypass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBypass");
		Bypass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBypass", Classes.FBoolProperty);
		FSourceEffectChainEntry_IsValid = intPtr != IntPtr.Zero && Preset_IsValid && Bypass_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SourceEffectChainEntry", FSourceEffectChainEntry_IsValid);
	}
}
