using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Chaos.SolverCollisionFilterSettings", "Chaos", UnrealModuleType.Engine)]
public struct FSolverCollisionFilterSettings
{
	private static bool FilterEnabled_IsValid;

	private static FFieldAddress FilterEnabled_PropertyAddress;

	private static int FilterEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverCollisionFilterSettings:FilterEnabled")]
	public bool FilterEnabled;

	private static bool MinMass_IsValid;

	private static int MinMass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverCollisionFilterSettings:MinMass")]
	public float MinMass;

	private static bool MinSpeed_IsValid;

	private static int MinSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverCollisionFilterSettings:MinSpeed")]
	public float MinSpeed;

	private static bool MinImpulse_IsValid;

	private static int MinImpulse_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Chaos.SolverCollisionFilterSettings:MinImpulse")]
	public float MinImpulse;

	private static bool FSolverCollisionFilterSettings_IsValid;

	private static int FSolverCollisionFilterSettings_StructSize;

	public FSolverCollisionFilterSettings Copy()
	{
		return this;
	}

	public static FSolverCollisionFilterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSolverCollisionFilterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSolverCollisionFilterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSolverCollisionFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSolverCollisionFilterSettings(nativeBuffer + arrayIndex * FSolverCollisionFilterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSolverCollisionFilterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSolverCollisionFilterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSolverCollisionFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Chaos.SolverCollisionFilterSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FilterEnabled_Offset), 0, FilterEnabled_PropertyAddress.Address, FilterEnabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinMass_Offset), MinMass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSpeed_Offset), MinSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinImpulse_Offset), MinImpulse);
	}

	public FSolverCollisionFilterSettings(IntPtr nativeStruct)
	{
		if (!FSolverCollisionFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Chaos.SolverCollisionFilterSettings");
			FilterEnabled = false;
			MinMass = 0f;
			MinSpeed = 0f;
			MinImpulse = 0f;
		}
		else
		{
			FilterEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FilterEnabled_Offset), 0, FilterEnabled_PropertyAddress.Address);
			MinMass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinMass_Offset));
			MinSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSpeed_Offset));
			MinImpulse = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinImpulse_Offset));
		}
	}

	static FSolverCollisionFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSolverCollisionFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSolverCollisionFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Chaos.SolverCollisionFilterSettings");
		FSolverCollisionFilterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FilterEnabled_PropertyAddress, intPtr, "FilterEnabled");
		FilterEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterEnabled");
		FilterEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterEnabled", Classes.FBoolProperty);
		MinMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinMass");
		MinMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinMass", Classes.FFloatProperty);
		MinSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSpeed");
		MinSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSpeed", Classes.FFloatProperty);
		MinImpulse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinImpulse");
		MinImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinImpulse", Classes.FFloatProperty);
		FSolverCollisionFilterSettings_IsValid = intPtr != IntPtr.Zero && FilterEnabled_IsValid && MinMass_IsValid && MinSpeed_IsValid && MinImpulse_IsValid;
		NativeReflection.LogStructIsValid("/Script/Chaos.SolverCollisionFilterSettings", FSolverCollisionFilterSettings_IsValid);
	}
}
