using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundModulationDefaultRoutingSettings", "Engine", UnrealModuleType.Engine)]
public struct FSoundModulationDefaultRoutingSettings
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

	private static bool VolumeRouting_IsValid;

	private static FFieldAddress VolumeRouting_PropertyAddress;

	private static int VolumeRouting_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundModulationDefaultRoutingSettings:VolumeRouting")]
	public EModulationRouting VolumeRouting;

	private static bool PitchRouting_IsValid;

	private static FFieldAddress PitchRouting_PropertyAddress;

	private static int PitchRouting_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundModulationDefaultRoutingSettings:PitchRouting")]
	public EModulationRouting PitchRouting;

	private static bool HighpassRouting_IsValid;

	private static FFieldAddress HighpassRouting_PropertyAddress;

	private static int HighpassRouting_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundModulationDefaultRoutingSettings:HighpassRouting")]
	public EModulationRouting HighpassRouting;

	private static bool LowpassRouting_IsValid;

	private static FFieldAddress LowpassRouting_PropertyAddress;

	private static int LowpassRouting_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundModulationDefaultRoutingSettings:LowpassRouting")]
	public EModulationRouting LowpassRouting;

	private static bool FSoundModulationDefaultRoutingSettings_IsValid;

	private static int FSoundModulationDefaultRoutingSettings_StructSize;

	public FSoundModulationDefaultRoutingSettings Copy()
	{
		return this;
	}

	public static FSoundModulationDefaultRoutingSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSoundModulationDefaultRoutingSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundModulationDefaultRoutingSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundModulationDefaultRoutingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundModulationDefaultRoutingSettings(nativeBuffer + arrayIndex * FSoundModulationDefaultRoutingSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundModulationDefaultRoutingSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundModulationDefaultRoutingSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundModulationDefaultRoutingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundModulationDefaultRoutingSettings");
			return;
		}
		EnumMarshaler<EModulationRouting>.ToNative(IntPtr.Add(nativeStruct, VolumeRouting_Offset), 0, VolumeRouting_PropertyAddress.Address, VolumeRouting);
		EnumMarshaler<EModulationRouting>.ToNative(IntPtr.Add(nativeStruct, PitchRouting_Offset), 0, PitchRouting_PropertyAddress.Address, PitchRouting);
		EnumMarshaler<EModulationRouting>.ToNative(IntPtr.Add(nativeStruct, HighpassRouting_Offset), 0, HighpassRouting_PropertyAddress.Address, HighpassRouting);
		EnumMarshaler<EModulationRouting>.ToNative(IntPtr.Add(nativeStruct, LowpassRouting_Offset), 0, LowpassRouting_PropertyAddress.Address, LowpassRouting);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, VolumeModulationDestination_Offset), VolumeModulationDestination);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, PitchModulationDestination_Offset), PitchModulationDestination);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, HighpassModulationDestination_Offset), HighpassModulationDestination);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, LowpassModulationDestination_Offset), LowpassModulationDestination);
	}

	public FSoundModulationDefaultRoutingSettings(IntPtr nativeStruct)
	{
		if (!FSoundModulationDefaultRoutingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundModulationDefaultRoutingSettings");
			VolumeRouting = EModulationRouting.Disable;
			PitchRouting = EModulationRouting.Disable;
			HighpassRouting = EModulationRouting.Disable;
			LowpassRouting = EModulationRouting.Disable;
			VolumeModulationDestination = default(FSoundModulationDestinationSettings);
			PitchModulationDestination = default(FSoundModulationDestinationSettings);
			HighpassModulationDestination = default(FSoundModulationDestinationSettings);
			LowpassModulationDestination = default(FSoundModulationDestinationSettings);
		}
		else
		{
			VolumeRouting = EnumMarshaler<EModulationRouting>.FromNative(IntPtr.Add(nativeStruct, VolumeRouting_Offset), 0, VolumeRouting_PropertyAddress.Address);
			PitchRouting = EnumMarshaler<EModulationRouting>.FromNative(IntPtr.Add(nativeStruct, PitchRouting_Offset), 0, PitchRouting_PropertyAddress.Address);
			HighpassRouting = EnumMarshaler<EModulationRouting>.FromNative(IntPtr.Add(nativeStruct, HighpassRouting_Offset), 0, HighpassRouting_PropertyAddress.Address);
			LowpassRouting = EnumMarshaler<EModulationRouting>.FromNative(IntPtr.Add(nativeStruct, LowpassRouting_Offset), 0, LowpassRouting_PropertyAddress.Address);
			VolumeModulationDestination = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, VolumeModulationDestination_Offset));
			PitchModulationDestination = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, PitchModulationDestination_Offset));
			HighpassModulationDestination = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, HighpassModulationDestination_Offset));
			LowpassModulationDestination = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, LowpassModulationDestination_Offset));
		}
	}

	static FSoundModulationDefaultRoutingSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundModulationDefaultRoutingSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundModulationDefaultRoutingSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundModulationDefaultRoutingSettings");
		FSoundModulationDefaultRoutingSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		VolumeModulationDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeModulationDestination");
		VolumeModulationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeModulationDestination", Classes.FStructProperty);
		PitchModulationDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PitchModulationDestination");
		PitchModulationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PitchModulationDestination", Classes.FStructProperty);
		HighpassModulationDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighpassModulationDestination");
		HighpassModulationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighpassModulationDestination", Classes.FStructProperty);
		LowpassModulationDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowpassModulationDestination");
		LowpassModulationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowpassModulationDestination", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VolumeRouting_PropertyAddress, intPtr, "VolumeRouting");
		VolumeRouting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeRouting");
		VolumeRouting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeRouting", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PitchRouting_PropertyAddress, intPtr, "PitchRouting");
		PitchRouting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PitchRouting");
		PitchRouting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PitchRouting", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref HighpassRouting_PropertyAddress, intPtr, "HighpassRouting");
		HighpassRouting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighpassRouting");
		HighpassRouting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighpassRouting", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LowpassRouting_PropertyAddress, intPtr, "LowpassRouting");
		LowpassRouting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowpassRouting");
		LowpassRouting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowpassRouting", Classes.FEnumProperty);
		FSoundModulationDefaultRoutingSettings_IsValid = intPtr != IntPtr.Zero && VolumeRouting_IsValid && PitchRouting_IsValid && HighpassRouting_IsValid && LowpassRouting_IsValid && VolumeModulationDestination_IsValid && PitchModulationDestination_IsValid && HighpassModulationDestination_IsValid && LowpassModulationDestination_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundModulationDefaultRoutingSettings", FSoundModulationDefaultRoutingSettings_IsValid);
	}
}
