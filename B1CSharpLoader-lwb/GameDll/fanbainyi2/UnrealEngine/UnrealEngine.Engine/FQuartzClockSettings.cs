using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.QuartzClockSettings", "Engine", UnrealModuleType.Engine)]
public struct FQuartzClockSettings
{
	private static bool TimeSignature_IsValid;

	private static int TimeSignature_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.QuartzClockSettings:TimeSignature")]
	public FQuartzTimeSignature TimeSignature;

	private static bool IgnoreLevelChange_IsValid;

	private static FFieldAddress IgnoreLevelChange_PropertyAddress;

	private static int IgnoreLevelChange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.QuartzClockSettings:bIgnoreLevelChange")]
	public bool IgnoreLevelChange;

	private static bool FQuartzClockSettings_IsValid;

	private static int FQuartzClockSettings_StructSize;

	public FQuartzClockSettings Copy()
	{
		return this;
	}

	public static FQuartzClockSettings FromNative(IntPtr nativeBuffer)
	{
		return new FQuartzClockSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FQuartzClockSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FQuartzClockSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FQuartzClockSettings(nativeBuffer + arrayIndex * FQuartzClockSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FQuartzClockSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FQuartzClockSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FQuartzClockSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzClockSettings");
			return;
		}
		FQuartzTimeSignature.ToNative(IntPtr.Add(nativeStruct, TimeSignature_Offset), TimeSignature);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreLevelChange_Offset), 0, IgnoreLevelChange_PropertyAddress.Address, IgnoreLevelChange);
	}

	public FQuartzClockSettings(IntPtr nativeStruct)
	{
		if (!FQuartzClockSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzClockSettings");
			TimeSignature = default(FQuartzTimeSignature);
			IgnoreLevelChange = false;
		}
		else
		{
			TimeSignature = FQuartzTimeSignature.FromNative(IntPtr.Add(nativeStruct, TimeSignature_Offset));
			IgnoreLevelChange = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreLevelChange_Offset), 0, IgnoreLevelChange_PropertyAddress.Address);
		}
	}

	static FQuartzClockSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FQuartzClockSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FQuartzClockSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.QuartzClockSettings");
		FQuartzClockSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		TimeSignature_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeSignature");
		TimeSignature_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeSignature", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreLevelChange_PropertyAddress, intPtr, "bIgnoreLevelChange");
		IgnoreLevelChange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreLevelChange");
		IgnoreLevelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreLevelChange", Classes.FBoolProperty);
		FQuartzClockSettings_IsValid = intPtr != IntPtr.Zero && TimeSignature_IsValid && IgnoreLevelChange_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.QuartzClockSettings", FQuartzClockSettings_IsValid);
	}
}
