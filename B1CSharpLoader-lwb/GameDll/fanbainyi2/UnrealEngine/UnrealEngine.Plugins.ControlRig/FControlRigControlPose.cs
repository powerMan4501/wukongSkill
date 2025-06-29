using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ControlRigControlPose", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FControlRigControlPose
{
	private static bool CopyOfControls_IsValid;

	private static FFieldAddress CopyOfControls_PropertyAddress;

	private static int CopyOfControls_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ControlRig.ControlRigControlPose:CopyOfControls")]
	public List<FRigControlCopy> CopyOfControls;

	private static bool FControlRigControlPose_IsValid;

	private static int FControlRigControlPose_StructSize;

	public FControlRigControlPose Copy()
	{
		FControlRigControlPose result = this;
		if (CopyOfControls != null)
		{
			result.CopyOfControls = new List<FRigControlCopy>(CopyOfControls);
		}
		return result;
	}

	public static FControlRigControlPose FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigControlPose(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigControlPose value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigControlPose FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigControlPose(nativeBuffer + arrayIndex * FControlRigControlPose_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigControlPose value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigControlPose_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigControlPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigControlPose");
		}
		else
		{
			new TArrayCopyMarshaler<FRigControlCopy>(1, CopyOfControls_PropertyAddress, CachedMarshalingDelegates<FRigControlCopy, FRigControlCopy>.FromNative, CachedMarshalingDelegates<FRigControlCopy, FRigControlCopy>.ToNative).ToNative(IntPtr.Add(nativeStruct, CopyOfControls_Offset), CopyOfControls);
		}
	}

	public FControlRigControlPose(IntPtr nativeStruct)
	{
		if (!FControlRigControlPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigControlPose");
			CopyOfControls = null;
		}
		else
		{
			CopyOfControls = new TArrayCopyMarshaler<FRigControlCopy>(1, CopyOfControls_PropertyAddress, CachedMarshalingDelegates<FRigControlCopy, FRigControlCopy>.FromNative, CachedMarshalingDelegates<FRigControlCopy, FRigControlCopy>.ToNative).FromNative(IntPtr.Add(nativeStruct, CopyOfControls_Offset));
		}
	}

	static FControlRigControlPose()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigControlPose)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigControlPose));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.ControlRigControlPose");
		FControlRigControlPose_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CopyOfControls_PropertyAddress, intPtr, "CopyOfControls");
		CopyOfControls_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CopyOfControls");
		CopyOfControls_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CopyOfControls", Classes.FArrayProperty);
		FControlRigControlPose_IsValid = intPtr != IntPtr.Zero && CopyOfControls_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.ControlRigControlPose", FControlRigControlPose_IsValid);
	}
}
