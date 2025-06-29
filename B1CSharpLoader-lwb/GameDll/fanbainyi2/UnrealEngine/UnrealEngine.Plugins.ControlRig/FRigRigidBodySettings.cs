using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigRigidBodySettings", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigRigidBodySettings
{
	private static bool Mass_IsValid;

	private static int Mass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigRigidBodySettings:Mass")]
	public float Mass;

	private static bool FRigRigidBodySettings_IsValid;

	private static int FRigRigidBodySettings_StructSize;

	public FRigRigidBodySettings Copy()
	{
		return this;
	}

	public static FRigRigidBodySettings FromNative(IntPtr nativeBuffer)
	{
		return new FRigRigidBodySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigRigidBodySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigRigidBodySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigRigidBodySettings(nativeBuffer + arrayIndex * FRigRigidBodySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigRigidBodySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigRigidBodySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigRigidBodySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigRigidBodySettings");
		}
		else
		{
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Mass_Offset), Mass);
		}
	}

	public FRigRigidBodySettings(IntPtr nativeStruct)
	{
		if (!FRigRigidBodySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigRigidBodySettings");
			Mass = 0f;
		}
		else
		{
			Mass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Mass_Offset));
		}
	}

	static FRigRigidBodySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigRigidBodySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigRigidBodySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigRigidBodySettings");
		FRigRigidBodySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Mass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass");
		Mass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass", Classes.FFloatProperty);
		FRigRigidBodySettings_IsValid = intPtr != IntPtr.Zero && Mass_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigRigidBodySettings", FRigRigidBodySettings_IsValid);
	}
}
