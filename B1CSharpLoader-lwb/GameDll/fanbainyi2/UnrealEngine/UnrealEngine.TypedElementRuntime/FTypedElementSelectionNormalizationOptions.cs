using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementRuntime;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions", "TypedElementRuntime", UnrealModuleType.Engine)]
public struct FTypedElementSelectionNormalizationOptions
{
	private static bool ExpandGroups_IsValid;

	private static FFieldAddress ExpandGroups_PropertyAddress;

	private static int ExpandGroups_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions:bExpandGroups")]
	public bool ExpandGroups;

	private static bool FollowAttachment_IsValid;

	private static FFieldAddress FollowAttachment_PropertyAddress;

	private static int FollowAttachment_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions:bFollowAttachment")]
	public bool FollowAttachment;

	private static bool FTypedElementSelectionNormalizationOptions_IsValid;

	private static int FTypedElementSelectionNormalizationOptions_StructSize;

	public FTypedElementSelectionNormalizationOptions Copy()
	{
		return this;
	}

	public static FTypedElementSelectionNormalizationOptions FromNative(IntPtr nativeBuffer)
	{
		return new FTypedElementSelectionNormalizationOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTypedElementSelectionNormalizationOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTypedElementSelectionNormalizationOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTypedElementSelectionNormalizationOptions(nativeBuffer + arrayIndex * FTypedElementSelectionNormalizationOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTypedElementSelectionNormalizationOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTypedElementSelectionNormalizationOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTypedElementSelectionNormalizationOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ExpandGroups_Offset), 0, ExpandGroups_PropertyAddress.Address, ExpandGroups);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FollowAttachment_Offset), 0, FollowAttachment_PropertyAddress.Address, FollowAttachment);
	}

	public FTypedElementSelectionNormalizationOptions(IntPtr nativeStruct)
	{
		if (!FTypedElementSelectionNormalizationOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions");
			ExpandGroups = false;
			FollowAttachment = false;
		}
		else
		{
			ExpandGroups = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ExpandGroups_Offset), 0, ExpandGroups_PropertyAddress.Address);
			FollowAttachment = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FollowAttachment_Offset), 0, FollowAttachment_PropertyAddress.Address);
		}
	}

	static FTypedElementSelectionNormalizationOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTypedElementSelectionNormalizationOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTypedElementSelectionNormalizationOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions");
		FTypedElementSelectionNormalizationOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ExpandGroups_PropertyAddress, intPtr, "bExpandGroups");
		ExpandGroups_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExpandGroups");
		ExpandGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExpandGroups", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FollowAttachment_PropertyAddress, intPtr, "bFollowAttachment");
		FollowAttachment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFollowAttachment");
		FollowAttachment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFollowAttachment", Classes.FBoolProperty);
		FTypedElementSelectionNormalizationOptions_IsValid = intPtr != IntPtr.Zero && ExpandGroups_IsValid && FollowAttachment_IsValid;
		NativeReflection.LogStructIsValid("/Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions", FTypedElementSelectionNormalizationOptions_IsValid);
	}
}
