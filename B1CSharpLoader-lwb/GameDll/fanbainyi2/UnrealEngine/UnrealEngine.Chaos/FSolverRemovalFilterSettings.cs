using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Chaos.SolverRemovalFilterSettings", "Chaos", UnrealModuleType.Engine)]
public struct FSolverRemovalFilterSettings
{
	private static bool FilterEnabled_IsValid;

	private static FFieldAddress FilterEnabled_PropertyAddress;

	private static int FilterEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverRemovalFilterSettings:FilterEnabled")]
	public bool FilterEnabled;

	private static bool MinMass_IsValid;

	private static int MinMass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverRemovalFilterSettings:MinMass")]
	public float MinMass;

	private static bool MinVolume_IsValid;

	private static int MinVolume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverRemovalFilterSettings:MinVolume")]
	public float MinVolume;

	private static bool FSolverRemovalFilterSettings_IsValid;

	private static int FSolverRemovalFilterSettings_StructSize;

	public FSolverRemovalFilterSettings Copy()
	{
		return this;
	}

	public static FSolverRemovalFilterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSolverRemovalFilterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSolverRemovalFilterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSolverRemovalFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSolverRemovalFilterSettings(nativeBuffer + arrayIndex * FSolverRemovalFilterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSolverRemovalFilterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSolverRemovalFilterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSolverRemovalFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Chaos.SolverRemovalFilterSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FilterEnabled_Offset), 0, FilterEnabled_PropertyAddress.Address, FilterEnabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinMass_Offset), MinMass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinVolume_Offset), MinVolume);
	}

	public FSolverRemovalFilterSettings(IntPtr nativeStruct)
	{
		if (!FSolverRemovalFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Chaos.SolverRemovalFilterSettings");
			FilterEnabled = false;
			MinMass = 0f;
			MinVolume = 0f;
		}
		else
		{
			FilterEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FilterEnabled_Offset), 0, FilterEnabled_PropertyAddress.Address);
			MinMass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinMass_Offset));
			MinVolume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinVolume_Offset));
		}
	}

	static FSolverRemovalFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSolverRemovalFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSolverRemovalFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Chaos.SolverRemovalFilterSettings");
		FSolverRemovalFilterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FilterEnabled_PropertyAddress, intPtr, "FilterEnabled");
		FilterEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterEnabled");
		FilterEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterEnabled", Classes.FBoolProperty);
		MinMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinMass");
		MinMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinMass", Classes.FFloatProperty);
		MinVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinVolume");
		MinVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinVolume", Classes.FFloatProperty);
		FSolverRemovalFilterSettings_IsValid = intPtr != IntPtr.Zero && FilterEnabled_IsValid && MinMass_IsValid && MinVolume_IsValid;
		NativeReflection.LogStructIsValid("/Script/Chaos.SolverRemovalFilterSettings", FSolverRemovalFilterSettings_IsValid);
	}
}
