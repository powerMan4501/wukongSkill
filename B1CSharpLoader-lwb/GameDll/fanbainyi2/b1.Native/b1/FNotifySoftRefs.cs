using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.NotifySoftRefs", "b1", UnrealModuleType.Game)]
public struct FNotifySoftRefs
{
	private static bool SoftPaths_IsValid;

	private static FFieldAddress SoftPaths_PropertyAddress;

	private static int SoftPaths_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/b1.NotifySoftRefs:SoftPaths")]
	public HashSet<FSoftObjectPath> SoftPaths;

	private static bool FNotifySoftRefs_IsValid;

	private static int FNotifySoftRefs_StructSize;

	public FNotifySoftRefs Copy()
	{
		FNotifySoftRefs result = this;
		if (SoftPaths != null)
		{
			result.SoftPaths = new HashSet<FSoftObjectPath>(SoftPaths);
		}
		return result;
	}

	public static FNotifySoftRefs FromNative(IntPtr nativeBuffer)
	{
		return new FNotifySoftRefs(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNotifySoftRefs value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNotifySoftRefs FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNotifySoftRefs(nativeBuffer + arrayIndex * FNotifySoftRefs_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNotifySoftRefs value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNotifySoftRefs_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNotifySoftRefs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.NotifySoftRefs");
		}
		else
		{
			new TSetCopyMarshaler<FSoftObjectPath>(1, SoftPaths_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).ToNative(IntPtr.Add(nativeStruct, SoftPaths_Offset), SoftPaths);
		}
	}

	public FNotifySoftRefs(IntPtr nativeStruct)
	{
		if (!FNotifySoftRefs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.NotifySoftRefs");
			SoftPaths = null;
		}
		else
		{
			SoftPaths = new TSetCopyMarshaler<FSoftObjectPath>(1, SoftPaths_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).FromNative(IntPtr.Add(nativeStruct, SoftPaths_Offset));
		}
	}

	static FNotifySoftRefs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNotifySoftRefs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNotifySoftRefs));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.NotifySoftRefs");
		FNotifySoftRefs_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SoftPaths_PropertyAddress, intPtr, "SoftPaths");
		SoftPaths_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoftPaths");
		SoftPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoftPaths", Classes.FSetProperty);
		FNotifySoftRefs_IsValid = intPtr != IntPtr.Zero && SoftPaths_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.NotifySoftRefs", FNotifySoftRefs_IsValid);
	}
}
