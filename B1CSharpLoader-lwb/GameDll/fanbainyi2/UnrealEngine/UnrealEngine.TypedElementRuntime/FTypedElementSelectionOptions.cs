using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementRuntime;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionOptions", "TypedElementRuntime", UnrealModuleType.Engine)]
public struct FTypedElementSelectionOptions
{
	private static bool AllowHidden_IsValid;

	private static FFieldAddress AllowHidden_PropertyAddress;

	private static int AllowHidden_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionOptions:bAllowHidden")]
	public bool AllowHidden;

	private static bool AllowGroups_IsValid;

	private static FFieldAddress AllowGroups_PropertyAddress;

	private static int AllowGroups_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionOptions:bAllowGroups")]
	public bool AllowGroups;

	private static bool AllowLegacyNotifications_IsValid;

	private static FFieldAddress AllowLegacyNotifications_PropertyAddress;

	private static int AllowLegacyNotifications_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionOptions:bAllowLegacyNotifications")]
	public bool AllowLegacyNotifications;

	private static bool WarnIfLocked_IsValid;

	private static FFieldAddress WarnIfLocked_PropertyAddress;

	private static int WarnIfLocked_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionOptions:bWarnIfLocked")]
	public bool WarnIfLocked;

	private static bool ChildElementInclusionMethod_IsValid;

	private static FFieldAddress ChildElementInclusionMethod_PropertyAddress;

	private static int ChildElementInclusionMethod_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionOptions:ChildElementInclusionMethod")]
	public ETypedElementChildInclusionMethod ChildElementInclusionMethod;

	private static bool FTypedElementSelectionOptions_IsValid;

	private static int FTypedElementSelectionOptions_StructSize;

	public FTypedElementSelectionOptions Copy()
	{
		return this;
	}

	public static FTypedElementSelectionOptions FromNative(IntPtr nativeBuffer)
	{
		return new FTypedElementSelectionOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTypedElementSelectionOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTypedElementSelectionOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTypedElementSelectionOptions(nativeBuffer + arrayIndex * FTypedElementSelectionOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTypedElementSelectionOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTypedElementSelectionOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTypedElementSelectionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementRuntime.TypedElementSelectionOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowHidden_Offset), 0, AllowHidden_PropertyAddress.Address, AllowHidden);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowGroups_Offset), 0, AllowGroups_PropertyAddress.Address, AllowGroups);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowLegacyNotifications_Offset), 0, AllowLegacyNotifications_PropertyAddress.Address, AllowLegacyNotifications);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WarnIfLocked_Offset), 0, WarnIfLocked_PropertyAddress.Address, WarnIfLocked);
		EnumMarshaler<ETypedElementChildInclusionMethod>.ToNative(IntPtr.Add(nativeStruct, ChildElementInclusionMethod_Offset), 0, ChildElementInclusionMethod_PropertyAddress.Address, ChildElementInclusionMethod);
	}

	public FTypedElementSelectionOptions(IntPtr nativeStruct)
	{
		if (!FTypedElementSelectionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementRuntime.TypedElementSelectionOptions");
			AllowHidden = false;
			AllowGroups = false;
			AllowLegacyNotifications = false;
			WarnIfLocked = false;
			ChildElementInclusionMethod = ETypedElementChildInclusionMethod.None;
		}
		else
		{
			AllowHidden = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowHidden_Offset), 0, AllowHidden_PropertyAddress.Address);
			AllowGroups = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowGroups_Offset), 0, AllowGroups_PropertyAddress.Address);
			AllowLegacyNotifications = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowLegacyNotifications_Offset), 0, AllowLegacyNotifications_PropertyAddress.Address);
			WarnIfLocked = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WarnIfLocked_Offset), 0, WarnIfLocked_PropertyAddress.Address);
			ChildElementInclusionMethod = EnumMarshaler<ETypedElementChildInclusionMethod>.FromNative(IntPtr.Add(nativeStruct, ChildElementInclusionMethod_Offset), 0, ChildElementInclusionMethod_PropertyAddress.Address);
		}
	}

	static FTypedElementSelectionOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTypedElementSelectionOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTypedElementSelectionOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TypedElementRuntime.TypedElementSelectionOptions");
		FTypedElementSelectionOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AllowHidden_PropertyAddress, intPtr, "bAllowHidden");
		AllowHidden_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowHidden");
		AllowHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowHidden", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowGroups_PropertyAddress, intPtr, "bAllowGroups");
		AllowGroups_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowGroups");
		AllowGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowGroups", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowLegacyNotifications_PropertyAddress, intPtr, "bAllowLegacyNotifications");
		AllowLegacyNotifications_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowLegacyNotifications");
		AllowLegacyNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowLegacyNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WarnIfLocked_PropertyAddress, intPtr, "bWarnIfLocked");
		WarnIfLocked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWarnIfLocked");
		WarnIfLocked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWarnIfLocked", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ChildElementInclusionMethod_PropertyAddress, intPtr, "ChildElementInclusionMethod");
		ChildElementInclusionMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChildElementInclusionMethod");
		ChildElementInclusionMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChildElementInclusionMethod", Classes.FEnumProperty);
		FTypedElementSelectionOptions_IsValid = intPtr != IntPtr.Zero && AllowHidden_IsValid && AllowGroups_IsValid && AllowLegacyNotifications_IsValid && WarnIfLocked_IsValid && ChildElementInclusionMethod_IsValid;
		NativeReflection.LogStructIsValid("/Script/TypedElementRuntime.TypedElementSelectionOptions", FTypedElementSelectionOptions_IsValid);
	}
}
