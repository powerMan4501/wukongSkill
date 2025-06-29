using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/LevelSequence.LevelSequenceCameraSettings", "LevelSequence", UnrealModuleType.Engine)]
public struct FLevelSequenceCameraSettings
{
	private static bool OverrideAspectRatioAxisConstraint_IsValid;

	private static FFieldAddress OverrideAspectRatioAxisConstraint_PropertyAddress;

	private static int OverrideAspectRatioAxisConstraint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceCameraSettings:bOverrideAspectRatioAxisConstraint")]
	public bool OverrideAspectRatioAxisConstraint;

	private static bool AspectRatioAxisConstraint_IsValid;

	private static FFieldAddress AspectRatioAxisConstraint_PropertyAddress;

	private static int AspectRatioAxisConstraint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceCameraSettings:AspectRatioAxisConstraint")]
	public EAspectRatioAxisConstraint AspectRatioAxisConstraint;

	private static bool FLevelSequenceCameraSettings_IsValid;

	private static int FLevelSequenceCameraSettings_StructSize;

	public FLevelSequenceCameraSettings Copy()
	{
		return this;
	}

	public static FLevelSequenceCameraSettings FromNative(IntPtr nativeBuffer)
	{
		return new FLevelSequenceCameraSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLevelSequenceCameraSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLevelSequenceCameraSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLevelSequenceCameraSettings(nativeBuffer + arrayIndex * FLevelSequenceCameraSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLevelSequenceCameraSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLevelSequenceCameraSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLevelSequenceCameraSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LevelSequence.LevelSequenceCameraSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OverrideAspectRatioAxisConstraint_Offset), 0, OverrideAspectRatioAxisConstraint_PropertyAddress.Address, OverrideAspectRatioAxisConstraint);
		EnumMarshaler<EAspectRatioAxisConstraint>.ToNative(IntPtr.Add(nativeStruct, AspectRatioAxisConstraint_Offset), 0, AspectRatioAxisConstraint_PropertyAddress.Address, AspectRatioAxisConstraint);
	}

	public FLevelSequenceCameraSettings(IntPtr nativeStruct)
	{
		if (!FLevelSequenceCameraSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LevelSequence.LevelSequenceCameraSettings");
			OverrideAspectRatioAxisConstraint = false;
			AspectRatioAxisConstraint = EAspectRatioAxisConstraint.AspectRatio_MaintainYFOV;
		}
		else
		{
			OverrideAspectRatioAxisConstraint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OverrideAspectRatioAxisConstraint_Offset), 0, OverrideAspectRatioAxisConstraint_PropertyAddress.Address);
			AspectRatioAxisConstraint = EnumMarshaler<EAspectRatioAxisConstraint>.FromNative(IntPtr.Add(nativeStruct, AspectRatioAxisConstraint_Offset), 0, AspectRatioAxisConstraint_PropertyAddress.Address);
		}
	}

	static FLevelSequenceCameraSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLevelSequenceCameraSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLevelSequenceCameraSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LevelSequence.LevelSequenceCameraSettings");
		FLevelSequenceCameraSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref OverrideAspectRatioAxisConstraint_PropertyAddress, intPtr, "bOverrideAspectRatioAxisConstraint");
		OverrideAspectRatioAxisConstraint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideAspectRatioAxisConstraint");
		OverrideAspectRatioAxisConstraint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideAspectRatioAxisConstraint", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AspectRatioAxisConstraint_PropertyAddress, intPtr, "AspectRatioAxisConstraint");
		AspectRatioAxisConstraint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AspectRatioAxisConstraint");
		AspectRatioAxisConstraint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AspectRatioAxisConstraint", Classes.FByteProperty);
		FLevelSequenceCameraSettings_IsValid = intPtr != IntPtr.Zero && OverrideAspectRatioAxisConstraint_IsValid && AspectRatioAxisConstraint_IsValid;
		NativeReflection.LogStructIsValid("/Script/LevelSequence.LevelSequenceCameraSettings", FLevelSequenceCameraSettings_IsValid);
	}
}
