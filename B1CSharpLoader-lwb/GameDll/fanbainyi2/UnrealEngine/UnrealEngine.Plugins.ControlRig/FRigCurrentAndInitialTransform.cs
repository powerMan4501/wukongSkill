using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigCurrentAndInitialTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigCurrentAndInitialTransform
{
	private static bool Current_IsValid;

	private static int Current_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/ControlRig.RigCurrentAndInitialTransform:Current")]
	public FRigLocalAndGlobalTransform Current;

	private static bool Initial_IsValid;

	private static int Initial_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/ControlRig.RigCurrentAndInitialTransform:Initial")]
	public FRigLocalAndGlobalTransform Initial;

	private static bool FRigCurrentAndInitialTransform_IsValid;

	private static int FRigCurrentAndInitialTransform_StructSize;

	public FRigCurrentAndInitialTransform Copy()
	{
		return this;
	}

	public static FRigCurrentAndInitialTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigCurrentAndInitialTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigCurrentAndInitialTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigCurrentAndInitialTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigCurrentAndInitialTransform(nativeBuffer + arrayIndex * FRigCurrentAndInitialTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigCurrentAndInitialTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigCurrentAndInitialTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigCurrentAndInitialTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigCurrentAndInitialTransform");
			return;
		}
		FRigLocalAndGlobalTransform.ToNative(IntPtr.Add(nativeStruct, Current_Offset), Current);
		FRigLocalAndGlobalTransform.ToNative(IntPtr.Add(nativeStruct, Initial_Offset), Initial);
	}

	public FRigCurrentAndInitialTransform(IntPtr nativeStruct)
	{
		if (!FRigCurrentAndInitialTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigCurrentAndInitialTransform");
			Current = default(FRigLocalAndGlobalTransform);
			Initial = default(FRigLocalAndGlobalTransform);
		}
		else
		{
			Current = FRigLocalAndGlobalTransform.FromNative(IntPtr.Add(nativeStruct, Current_Offset));
			Initial = FRigLocalAndGlobalTransform.FromNative(IntPtr.Add(nativeStruct, Initial_Offset));
		}
	}

	static FRigCurrentAndInitialTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigCurrentAndInitialTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigCurrentAndInitialTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigCurrentAndInitialTransform");
		FRigCurrentAndInitialTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		Current_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Current");
		Current_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Current", Classes.FStructProperty);
		Initial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Initial");
		Initial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Initial", Classes.FStructProperty);
		FRigCurrentAndInitialTransform_IsValid = intPtr != IntPtr.Zero && Current_IsValid && Initial_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigCurrentAndInitialTransform", FRigCurrentAndInitialTransform_IsValid);
	}
}
