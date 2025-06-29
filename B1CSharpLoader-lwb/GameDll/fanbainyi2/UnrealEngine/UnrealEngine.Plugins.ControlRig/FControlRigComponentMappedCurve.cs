using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ControlRigComponentMappedCurve", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FControlRigComponentMappedCurve
{
	private static bool Source_IsValid;

	private static int Source_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedCurve:Source")]
	public FName Source;

	private static bool Target_IsValid;

	private static int Target_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedCurve:Target")]
	public FName Target;

	private static bool FControlRigComponentMappedCurve_IsValid;

	private static int FControlRigComponentMappedCurve_StructSize;

	public FControlRigComponentMappedCurve Copy()
	{
		return this;
	}

	public static FControlRigComponentMappedCurve FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigComponentMappedCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigComponentMappedCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigComponentMappedCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigComponentMappedCurve(nativeBuffer + arrayIndex * FControlRigComponentMappedCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigComponentMappedCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigComponentMappedCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigComponentMappedCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigComponentMappedCurve");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Source_Offset), Source);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Target_Offset), Target);
	}

	public FControlRigComponentMappedCurve(IntPtr nativeStruct)
	{
		if (!FControlRigComponentMappedCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigComponentMappedCurve");
			Source = default(FName);
			Target = default(FName);
		}
		else
		{
			Source = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Source_Offset));
			Target = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Target_Offset));
		}
	}

	static FControlRigComponentMappedCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigComponentMappedCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigComponentMappedCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.ControlRigComponentMappedCurve");
		FControlRigComponentMappedCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		Source_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Source");
		Source_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Source", Classes.FNameProperty);
		Target_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Target");
		Target_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Target", Classes.FNameProperty);
		FControlRigComponentMappedCurve_IsValid = intPtr != IntPtr.Zero && Source_IsValid && Target_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.ControlRigComponentMappedCurve", FControlRigComponentMappedCurve_IsValid);
	}
}
