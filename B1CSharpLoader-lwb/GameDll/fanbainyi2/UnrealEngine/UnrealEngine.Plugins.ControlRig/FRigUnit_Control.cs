using System;
using UnrealEngine.AnimationCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Control", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Control
{
	private static bool Transform_IsValid;

	private static int Transform_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/ControlRig.RigUnit_Control:Transform")]
	public FEulerTransform Transform;

	private static bool FRigUnit_Control_IsValid;

	private static int FRigUnit_Control_StructSize;

	public FRigUnit_Control Copy()
	{
		return this;
	}

	public static FRigUnit_Control FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Control(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Control value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Control FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Control(nativeBuffer + arrayIndex * FRigUnit_Control_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Control value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Control_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Control_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Control");
		}
		else
		{
			FEulerTransform.ToNative(IntPtr.Add(nativeStruct, Transform_Offset), Transform);
		}
	}

	public FRigUnit_Control(IntPtr nativeStruct)
	{
		if (!FRigUnit_Control_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Control");
			Transform = default(FEulerTransform);
		}
		else
		{
			Transform = FEulerTransform.FromNative(IntPtr.Add(nativeStruct, Transform_Offset));
		}
	}

	static FRigUnit_Control()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Control)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Control));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Control");
		FRigUnit_Control_StructSize = NativeReflection.GetStructSize(intPtr);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		FRigUnit_Control_IsValid = intPtr != IntPtr.Zero && Transform_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Control", FRigUnit_Control_IsValid);
	}
}
