using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Chaos.SolverBreakingFilterSettings", "Chaos", UnrealModuleType.Engine)]
public struct FSolverBreakingFilterSettings
{
	private static bool FilterEnabled_IsValid;

	private static FFieldAddress FilterEnabled_PropertyAddress;

	private static int FilterEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverBreakingFilterSettings:FilterEnabled")]
	public bool FilterEnabled;

	private static bool MinMass_IsValid;

	private static int MinMass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverBreakingFilterSettings:MinMass")]
	public float MinMass;

	private static bool MinSpeed_IsValid;

	private static int MinSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverBreakingFilterSettings:MinSpeed")]
	public float MinSpeed;

	private static bool MinVolume_IsValid;

	private static int MinVolume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverBreakingFilterSettings:MinVolume")]
	public float MinVolume;

	private static bool FSolverBreakingFilterSettings_IsValid;

	private static int FSolverBreakingFilterSettings_StructSize;

	public FSolverBreakingFilterSettings Copy()
	{
		return this;
	}

	public static FSolverBreakingFilterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSolverBreakingFilterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSolverBreakingFilterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSolverBreakingFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSolverBreakingFilterSettings(nativeBuffer + arrayIndex * FSolverBreakingFilterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSolverBreakingFilterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSolverBreakingFilterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSolverBreakingFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Chaos.SolverBreakingFilterSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FilterEnabled_Offset), 0, FilterEnabled_PropertyAddress.Address, FilterEnabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinMass_Offset), MinMass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSpeed_Offset), MinSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinVolume_Offset), MinVolume);
	}

	public FSolverBreakingFilterSettings(IntPtr nativeStruct)
	{
		if (!FSolverBreakingFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Chaos.SolverBreakingFilterSettings");
			FilterEnabled = false;
			MinMass = 0f;
			MinSpeed = 0f;
			MinVolume = 0f;
		}
		else
		{
			FilterEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FilterEnabled_Offset), 0, FilterEnabled_PropertyAddress.Address);
			MinMass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinMass_Offset));
			MinSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSpeed_Offset));
			MinVolume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinVolume_Offset));
		}
	}

	static FSolverBreakingFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSolverBreakingFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSolverBreakingFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Chaos.SolverBreakingFilterSettings");
		FSolverBreakingFilterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FilterEnabled_PropertyAddress, intPtr, "FilterEnabled");
		FilterEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterEnabled");
		FilterEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterEnabled", Classes.FBoolProperty);
		MinMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinMass");
		MinMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinMass", Classes.FFloatProperty);
		MinSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSpeed");
		MinSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSpeed", Classes.FFloatProperty);
		MinVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinVolume");
		MinVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinVolume", Classes.FFloatProperty);
		FSolverBreakingFilterSettings_IsValid = intPtr != IntPtr.Zero && FilterEnabled_IsValid && MinMass_IsValid && MinSpeed_IsValid && MinVolume_IsValid;
		NativeReflection.LogStructIsValid("/Script/Chaos.SolverBreakingFilterSettings", FSolverBreakingFilterSettings_IsValid);
	}
}
