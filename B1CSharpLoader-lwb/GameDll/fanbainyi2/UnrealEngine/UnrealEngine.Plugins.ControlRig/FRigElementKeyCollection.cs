using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigElementKeyCollection", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigElementKeyCollection
{
	private static bool Keys_IsValid;

	private static FFieldAddress Keys_PropertyAddress;

	private static int Keys_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ControlRig.RigElementKeyCollection:Keys")]
	public List<FRigElementKey> Keys;

	private static bool FRigElementKeyCollection_IsValid;

	private static int FRigElementKeyCollection_StructSize;

	public FRigElementKeyCollection Copy()
	{
		FRigElementKeyCollection result = this;
		if (Keys != null)
		{
			result.Keys = new List<FRigElementKey>(Keys);
		}
		return result;
	}

	public static FRigElementKeyCollection FromNative(IntPtr nativeBuffer)
	{
		return new FRigElementKeyCollection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigElementKeyCollection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigElementKeyCollection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigElementKeyCollection(nativeBuffer + arrayIndex * FRigElementKeyCollection_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigElementKeyCollection value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigElementKeyCollection_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigElementKeyCollection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigElementKeyCollection");
		}
		else
		{
			new TArrayCopyMarshaler<FRigElementKey>(1, Keys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(nativeStruct, Keys_Offset), Keys);
		}
	}

	public FRigElementKeyCollection(IntPtr nativeStruct)
	{
		if (!FRigElementKeyCollection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigElementKeyCollection");
			Keys = null;
		}
		else
		{
			Keys = new TArrayCopyMarshaler<FRigElementKey>(1, Keys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(nativeStruct, Keys_Offset));
		}
	}

	static FRigElementKeyCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigElementKeyCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigElementKeyCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigElementKeyCollection");
		FRigElementKeyCollection_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Keys_PropertyAddress, intPtr, "Keys");
		Keys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Keys");
		Keys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Keys", Classes.FArrayProperty);
		FRigElementKeyCollection_IsValid = intPtr != IntPtr.Zero && Keys_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigElementKeyCollection", FRigElementKeyCollection_IsValid);
	}
}
