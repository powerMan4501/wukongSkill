using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigComputedTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigComputedTransform
{
	private static bool Transform_IsValid;

	private static int Transform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589077uL)]
	[UMetaPath("/Script/ControlRig.RigComputedTransform:Transform")]
	public FTransform Transform;

	private static bool FRigComputedTransform_IsValid;

	private static int FRigComputedTransform_StructSize;

	public FRigComputedTransform Copy()
	{
		return this;
	}

	public static FRigComputedTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigComputedTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigComputedTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigComputedTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigComputedTransform(nativeBuffer + arrayIndex * FRigComputedTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigComputedTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigComputedTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigComputedTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigComputedTransform");
		}
		else
		{
			BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, Transform_Offset), Transform);
		}
	}

	public FRigComputedTransform(IntPtr nativeStruct)
	{
		if (!FRigComputedTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigComputedTransform");
			Transform = default(FTransform);
		}
		else
		{
			Transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, Transform_Offset));
		}
	}

	static FRigComputedTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigComputedTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigComputedTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigComputedTransform");
		FRigComputedTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		FRigComputedTransform_IsValid = intPtr != IntPtr.Zero && Transform_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigComputedTransform", FRigComputedTransform_IsValid);
	}
}
