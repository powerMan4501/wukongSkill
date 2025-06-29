using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Chaos.SolverTrailingFilterSettings", "Chaos", UnrealModuleType.Engine)]
public struct FSolverTrailingFilterSettings
{
	private static bool FilterEnabled_IsValid;

	private static FFieldAddress FilterEnabled_PropertyAddress;

	private static int FilterEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverTrailingFilterSettings:FilterEnabled")]
	public bool FilterEnabled;

	private static bool MinMass_IsValid;

	private static int MinMass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverTrailingFilterSettings:MinMass")]
	public float MinMass;

	private static bool MinSpeed_IsValid;

	private static int MinSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverTrailingFilterSettings:MinSpeed")]
	public float MinSpeed;

	private static bool MinVolume_IsValid;

	private static int MinVolume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverTrailingFilterSettings:MinVolume")]
	public float MinVolume;

	private static bool FSolverTrailingFilterSettings_IsValid;

	private static int FSolverTrailingFilterSettings_StructSize;

	public FSolverTrailingFilterSettings Copy()
	{
		return this;
	}

	public static FSolverTrailingFilterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSolverTrailingFilterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSolverTrailingFilterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSolverTrailingFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSolverTrailingFilterSettings(nativeBuffer + arrayIndex * FSolverTrailingFilterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSolverTrailingFilterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSolverTrailingFilterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSolverTrailingFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Chaos.SolverTrailingFilterSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FilterEnabled_Offset), 0, FilterEnabled_PropertyAddress.Address, FilterEnabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinMass_Offset), MinMass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSpeed_Offset), MinSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinVolume_Offset), MinVolume);
	}

	public FSolverTrailingFilterSettings(IntPtr nativeStruct)
	{
		if (!FSolverTrailingFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Chaos.SolverTrailingFilterSettings");
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

	static FSolverTrailingFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSolverTrailingFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSolverTrailingFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Chaos.SolverTrailingFilterSettings");
		FSolverTrailingFilterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FilterEnabled_PropertyAddress, intPtr, "FilterEnabled");
		FilterEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterEnabled");
		FilterEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterEnabled", Classes.FBoolProperty);
		MinMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinMass");
		MinMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinMass", Classes.FFloatProperty);
		MinSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSpeed");
		MinSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSpeed", Classes.FFloatProperty);
		MinVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinVolume");
		MinVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinVolume", Classes.FFloatProperty);
		FSolverTrailingFilterSettings_IsValid = intPtr != IntPtr.Zero && FilterEnabled_IsValid && MinMass_IsValid && MinSpeed_IsValid && MinVolume_IsValid;
		NativeReflection.LogStructIsValid("/Script/Chaos.SolverTrailingFilterSettings", FSolverTrailingFilterSettings_IsValid);
	}
}
