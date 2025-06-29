using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundModulationDefaultSettings", "Engine", UnrealModuleType.Engine)]
public struct FSoundModulationDefaultSettings
{
	private static bool VolumeModulationDestination_IsValid;

	private static int VolumeModulationDestination_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.SoundModulationDefaultSettings:VolumeModulationDestination")]
	public FSoundModulationDestinationSettings VolumeModulationDestination;

	private static bool PitchModulationDestination_IsValid;

	private static int PitchModulationDestination_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.SoundModulationDefaultSettings:PitchModulationDestination")]
	public FSoundModulationDestinationSettings PitchModulationDestination;

	private static bool HighpassModulationDestination_IsValid;

	private static int HighpassModulationDestination_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.SoundModulationDefaultSettings:HighpassModulationDestination")]
	public FSoundModulationDestinationSettings HighpassModulationDestination;

	private static bool LowpassModulationDestination_IsValid;

	private static int LowpassModulationDestination_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.SoundModulationDefaultSettings:LowpassModulationDestination")]
	public FSoundModulationDestinationSettings LowpassModulationDestination;

	private static bool FSoundModulationDefaultSettings_IsValid;

	private static int FSoundModulationDefaultSettings_StructSize;

	public FSoundModulationDefaultSettings Copy()
	{
		return this;
	}

	public static FSoundModulationDefaultSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSoundModulationDefaultSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundModulationDefaultSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundModulationDefaultSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundModulationDefaultSettings(nativeBuffer + arrayIndex * FSoundModulationDefaultSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundModulationDefaultSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundModulationDefaultSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundModulationDefaultSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundModulationDefaultSettings");
			return;
		}
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, VolumeModulationDestination_Offset), VolumeModulationDestination);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, PitchModulationDestination_Offset), PitchModulationDestination);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, HighpassModulationDestination_Offset), HighpassModulationDestination);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, LowpassModulationDestination_Offset), LowpassModulationDestination);
	}

	public FSoundModulationDefaultSettings(IntPtr nativeStruct)
	{
		if (!FSoundModulationDefaultSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundModulationDefaultSettings");
			VolumeModulationDestination = default(FSoundModulationDestinationSettings);
			PitchModulationDestination = default(FSoundModulationDestinationSettings);
			HighpassModulationDestination = default(FSoundModulationDestinationSettings);
			LowpassModulationDestination = default(FSoundModulationDestinationSettings);
		}
		else
		{
			VolumeModulationDestination = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, VolumeModulationDestination_Offset));
			PitchModulationDestination = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, PitchModulationDestination_Offset));
			HighpassModulationDestination = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, HighpassModulationDestination_Offset));
			LowpassModulationDestination = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, LowpassModulationDestination_Offset));
		}
	}

	static FSoundModulationDefaultSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundModulationDefaultSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundModulationDefaultSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundModulationDefaultSettings");
		FSoundModulationDefaultSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		VolumeModulationDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeModulationDestination");
		VolumeModulationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeModulationDestination", Classes.FStructProperty);
		PitchModulationDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PitchModulationDestination");
		PitchModulationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PitchModulationDestination", Classes.FStructProperty);
		HighpassModulationDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighpassModulationDestination");
		HighpassModulationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighpassModulationDestination", Classes.FStructProperty);
		LowpassModulationDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowpassModulationDestination");
		LowpassModulationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowpassModulationDestination", Classes.FStructProperty);
		FSoundModulationDefaultSettings_IsValid = intPtr != IntPtr.Zero && VolumeModulationDestination_IsValid && PitchModulationDestination_IsValid && HighpassModulationDestination_IsValid && LowpassModulationDestination_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundModulationDefaultSettings", FSoundModulationDefaultSettings_IsValid);
	}
}
