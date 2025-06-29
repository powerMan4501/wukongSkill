using System;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundModulationDestinationSettings", "Engine", UnrealModuleType.Engine)]
public struct FSoundModulationDestinationSettings
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundModulationDestinationSettings:Value")]
	public float Value;

	private static bool Modulator_IsValid;

	private static int Modulator_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SoundModulationDestinationSettings:Modulator")]
	public USoundModulatorBase Modulator;

	private static bool FSoundModulationDestinationSettings_IsValid;

	private static int FSoundModulationDestinationSettings_StructSize;

	public FSoundModulationDestinationSettings Copy()
	{
		return this;
	}

	public static FSoundModulationDestinationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSoundModulationDestinationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundModulationDestinationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundModulationDestinationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundModulationDestinationSettings(nativeBuffer + arrayIndex * FSoundModulationDestinationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundModulationDestinationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundModulationDestinationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundModulationDestinationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundModulationDestinationSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		UObjectMarshaler<USoundModulatorBase>.ToNative(IntPtr.Add(nativeStruct, Modulator_Offset), Modulator);
	}

	public FSoundModulationDestinationSettings(IntPtr nativeStruct)
	{
		if (!FSoundModulationDestinationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundModulationDestinationSettings");
			Value = 0f;
			Modulator = null;
		}
		else
		{
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Modulator = UObjectMarshaler<USoundModulatorBase>.FromNative(IntPtr.Add(nativeStruct, Modulator_Offset));
		}
	}

	static FSoundModulationDestinationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundModulationDestinationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundModulationDestinationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundModulationDestinationSettings");
		FSoundModulationDestinationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		Modulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Modulator");
		Modulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Modulator", Classes.FObjectProperty);
		FSoundModulationDestinationSettings_IsValid = intPtr != IntPtr.Zero && Value_IsValid && Modulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundModulationDestinationSettings", FSoundModulationDestinationSettings_IsValid);
	}
}
