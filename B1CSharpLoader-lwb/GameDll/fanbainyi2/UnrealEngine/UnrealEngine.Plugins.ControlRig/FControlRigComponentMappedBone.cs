using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ControlRigComponentMappedBone", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FControlRigComponentMappedBone
{
	private static bool Source_IsValid;

	private static int Source_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedBone:Source")]
	public FName Source;

	private static bool Target_IsValid;

	private static int Target_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedBone:Target")]
	public FName Target;

	private static bool FControlRigComponentMappedBone_IsValid;

	private static int FControlRigComponentMappedBone_StructSize;

	public FControlRigComponentMappedBone Copy()
	{
		return this;
	}

	public static FControlRigComponentMappedBone FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigComponentMappedBone(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigComponentMappedBone value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigComponentMappedBone FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigComponentMappedBone(nativeBuffer + arrayIndex * FControlRigComponentMappedBone_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigComponentMappedBone value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigComponentMappedBone_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigComponentMappedBone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigComponentMappedBone");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Source_Offset), Source);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Target_Offset), Target);
	}

	public FControlRigComponentMappedBone(IntPtr nativeStruct)
	{
		if (!FControlRigComponentMappedBone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigComponentMappedBone");
			Source = default(FName);
			Target = default(FName);
		}
		else
		{
			Source = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Source_Offset));
			Target = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Target_Offset));
		}
	}

	static FControlRigComponentMappedBone()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigComponentMappedBone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigComponentMappedBone));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.ControlRigComponentMappedBone");
		FControlRigComponentMappedBone_StructSize = NativeReflection.GetStructSize(intPtr);
		Source_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Source");
		Source_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Source", Classes.FNameProperty);
		Target_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Target");
		Target_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Target", Classes.FNameProperty);
		FControlRigComponentMappedBone_IsValid = intPtr != IntPtr.Zero && Source_IsValid && Target_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.ControlRigComponentMappedBone", FControlRigComponentMappedBone_IsValid);
	}
}
