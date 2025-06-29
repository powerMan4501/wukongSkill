using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigControlElementCustomization", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigControlElementCustomization
{
	private static bool AvailableSpaces_IsValid;

	private static FFieldAddress AvailableSpaces_PropertyAddress;

	private static int AvailableSpaces_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/ControlRig.RigControlElementCustomization:AvailableSpaces")]
	public List<FRigElementKey> AvailableSpaces;

	private static bool RemovedSpaces_IsValid;

	private static FFieldAddress RemovedSpaces_PropertyAddress;

	private static int RemovedSpaces_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/ControlRig.RigControlElementCustomization:RemovedSpaces")]
	public List<FRigElementKey> RemovedSpaces;

	private static bool FRigControlElementCustomization_IsValid;

	private static int FRigControlElementCustomization_StructSize;

	public FRigControlElementCustomization Copy()
	{
		FRigControlElementCustomization result = this;
		if (AvailableSpaces != null)
		{
			result.AvailableSpaces = new List<FRigElementKey>(AvailableSpaces);
		}
		if (RemovedSpaces != null)
		{
			result.RemovedSpaces = new List<FRigElementKey>(RemovedSpaces);
		}
		return result;
	}

	public static FRigControlElementCustomization FromNative(IntPtr nativeBuffer)
	{
		return new FRigControlElementCustomization(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigControlElementCustomization value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigControlElementCustomization FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigControlElementCustomization(nativeBuffer + arrayIndex * FRigControlElementCustomization_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigControlElementCustomization value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigControlElementCustomization_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigControlElementCustomization_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlElementCustomization");
			return;
		}
		new TArrayCopyMarshaler<FRigElementKey>(1, AvailableSpaces_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(nativeStruct, AvailableSpaces_Offset), AvailableSpaces);
		new TArrayCopyMarshaler<FRigElementKey>(1, RemovedSpaces_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(nativeStruct, RemovedSpaces_Offset), RemovedSpaces);
	}

	public FRigControlElementCustomization(IntPtr nativeStruct)
	{
		if (!FRigControlElementCustomization_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlElementCustomization");
			AvailableSpaces = null;
			RemovedSpaces = null;
		}
		else
		{
			AvailableSpaces = new TArrayCopyMarshaler<FRigElementKey>(1, AvailableSpaces_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(nativeStruct, AvailableSpaces_Offset));
			RemovedSpaces = new TArrayCopyMarshaler<FRigElementKey>(1, RemovedSpaces_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(nativeStruct, RemovedSpaces_Offset));
		}
	}

	static FRigControlElementCustomization()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigControlElementCustomization)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigControlElementCustomization));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigControlElementCustomization");
		FRigControlElementCustomization_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AvailableSpaces_PropertyAddress, intPtr, "AvailableSpaces");
		AvailableSpaces_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AvailableSpaces");
		AvailableSpaces_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AvailableSpaces", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RemovedSpaces_PropertyAddress, intPtr, "RemovedSpaces");
		RemovedSpaces_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RemovedSpaces");
		RemovedSpaces_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RemovedSpaces", Classes.FArrayProperty);
		FRigControlElementCustomization_IsValid = intPtr != IntPtr.Zero && AvailableSpaces_IsValid && RemovedSpaces_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigControlElementCustomization", FRigControlElementCustomization_IsValid);
	}
}
